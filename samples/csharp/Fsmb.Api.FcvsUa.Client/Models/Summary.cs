/*
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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fsmb.Api.FcvsUa.Client.Models
{
    /// <summary>Summary Details</summary>
    public class Summary
    {
        /// <summary>FID of applicant</summary>
        [Required(AllowEmptyStrings = false)]
        [MaxLength(9)]
        public string Fid { get; set; }

        /// <summary>Name</summary>
        [Required]
        public Name Name { get; set; }

        /// <summary>Is FCVS Available for applicant</summary>
        public bool isFcvsAvailable { get; set; }

        /// <summary>FCVS profile release date, if available</summary>
        public DateTime? fcvsReleaseDateUtc { get; set; }

        /// <summary>Is UA Available for applicant</summary>
        public bool isUaAvailable { get; set; }

        /// <summary>UA release date, if available</summary>
        public DateTime? uaReleaseDateUtc { get; set; }

        /// <summary>Newer release date between FCVS and UA, if available</summary>
        public DateTime? releaseDateUtc { get; set; }
    }
}
