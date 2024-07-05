﻿/*
 * Copyright © Federation of State Medical Boards
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
 * documentation files (the “Software”), to deal in the Software without restriction, including without limitation the
 * rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit
 * persons to whom the Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
 * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

using Fsmb.Api.Unified.Client.Authentication;
using Fsmb.Api.Unified.Client.Models;

namespace Fsmb.Api.Unified.Client
{
    /// <summary>Provides an HTTP client for working with the FSMB Unified API.</summary>
    public class UnifiedClient
    {
        #region Construction

        /// <summary>Initializes an instance of the <see cref="UnifiedClient"/> class.</summary>
        protected UnifiedClient ()
        { }

        /// <summary>Initializes an instance of the <see cref="UnifiedClient"/> class.</summary>
        /// <param name="client">HTTP client to use.</param>
        /// <remarks>
        /// Credentials must be configured on the HTTP client when using this overload.
        /// </remarks>
        public UnifiedClient ( HttpClient client ) : this(client, null)
        {
        }

        /// <summary>Initializes an instance of the <see cref="UnifiedClient"/> class.</summary>
        /// <param name="client">HTTP client to use.</param>
        public UnifiedClient ( HttpClient client, UnifiedClientCredentials credentials )
        {         
            Client = client;

            _baseUrl = $"v1/{credentials.Board}";

            if (credentials != null)
            {
                _credentials = new OAuthClientCredentials() {
                    TokenUrl = "connect/token",
                    ClientId = credentials.ClientId,
                    ClientSecret = credentials.ClientSecret,
                    Scopes = new[] { "fcvs.read" }
                };
            };
        }
        #endregion

        /// <summary>Get Applicant By FID</summary>
        /// <param name="fid">FID of the applicant.</param>        
        /// <returns>Applicant, if any</returns>
        public virtual Applicant GetApplicantByFid ( string fid )
                    => GetApplicantByFidAsync(fid, CancellationToken.None).GetAwaiter().GetResult();

        /// <summary>Get Applicant By FID</summary>
        /// <param name="fid">FID of the applicant.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>Applicant, if any</returns>
        public virtual async Task<Applicant> GetApplicantByFidAsync ( string fid, CancellationToken cancellationToken = default )
        {            
            var url = GetResourceUrl(String.Join("/", "applicants", fid));

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            await PrepareRequestAsync(request, cancellationToken).ConfigureAwait(false);

            using (var response = await Client.SendAsync(request, cancellationToken).ConfigureAwait(false)) 
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound || response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    return null;

                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<Applicant>(cancellationToken).ConfigureAwait(false);
            };
        }
        #region Protected Members

        /// <summary>Gets the underlying HTTP client.</summary>
        protected HttpClient Client { get; }

        protected async Task<OAuthAccessToken> GetAccessTokenAsync ( CancellationToken cancellationToken )
        {
            //If the access token is still valid then use it
            if ((_accessToken?.ExpirationDate ?? DateTime.MinValue).AddMinutes(5) > DateTime.Now)
                return _accessToken;

            _accessToken = await Client.AuthenticateAsync(_credentials, cancellationToken).ConfigureAwait(false);
            
            return _accessToken;
        }

        protected string GetResourceUrl ( string resource ) => String.Join("/", _baseUrl, resource);

        protected virtual async Task PrepareRequestAsync ( HttpRequestMessage request, CancellationToken cancellationToken )
        {
            if (_credentials != null)
            {
                var token = await GetAccessTokenAsync(cancellationToken).ConfigureAwait(false);

                request.WithBearerToken(token.AccessToken);
            };
        }

        #endregion

        #region Private Members

        private readonly OAuthClientCredentials _credentials;
        private readonly string _baseUrl;

        private OAuthAccessToken _accessToken;
        #endregion
    }
}
