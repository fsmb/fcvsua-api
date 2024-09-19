# FCVS UA Unified API Sample (C#)

[Run the Code](#run-the-code) \
[Using the Class Library](#using-the-class-library) \
[Change Log](#change-log)

This solution contains a simple test application for working with the API and a class library.

The console application demonstrates using the API to make calls. It demonstrates some of the more common requests.

*The code is an example of how you might use the API and has not been tested or hardened for production use.*

The class library contains auto-generated code to work with the API. The class library can be copied and used in your own project. The class library is multi-targeted for .NET 4.7.2 and .NET 8.0. If you are building .NET 4.7.2+ or .NET 6.0+ projects then the library should work out of the box.
If you are targeting a different version of .NET then you will need to adjust the project and code accordingly.

*Note: Visual Studio 2022 or later is required for .NET 8.0 support. If you are using an earlier version of Visual Studio you will need to adjust the project to target an older framework.*

## Run the Code

To run this sample do the following.

1. Download the entire solution directory to your local machine.
1. Open the solution (`.sln`) in Visual Studio.
1. Compile the solution.
1. Run the solution.

## Using the Class Library

To use the class library in your own code do the following.

1. Ensure either the project is part of your solution or build the project and reference the generated assembly in your solution.
1. In your application's startup code store the URL to the API (see the documentation), your client ID and client secret somewhere that your code has access to such as a configuration file or environment variable.
1. To call the API create an instance of the `FcvsUaClient` class and pass the configuration information stored earlier. See below for more information.     
1. Use the client to make calls to the API.
   ```
   //Assuming this code is called in an async function then use await to wait for the response
   Applicant applicant = await client.GetApplicantByFidAsync(fid).ConfigureAwait(false);
   ```

## Configuring the Client

For .NET Framework projects do the following.

```csharp
HttpClient httpClient = new HttpClient() {
    BaseAddress = new Uri("<url ending with slash>")
};
var credendentials = new FcvsUaApiClientCredentials() {
    ClientId = "clientId",
    ClientSecret = "clientSecret"
};
FcvsUaClient client = new FcvsUaApiClient(httpClient, credentials);
```

For .NET Core projects you should use dependency injection.

```csharp
//App startup code

//Configure the HTTP client
services.AddHttpClient("FcvsUa")
        .ConfigureHttpClient(client => {
            client.BaseAddress = new Uri("https://services-fcvsua-demo.fsmb.org/");
        });
       
//Configure the credentials to use
services.AddSingleton(new FcvsUaApiClientCredentials() {
    ClientId = "<client-id>",
    ClientSecret = "<client-secret>"
});

//Register the client
services.AddScoped<FcvsUaApiClient>(provider => {
    var options = provider.GetService<FcvsUaApiClientOptions>();
    var credentials = provider.GetRequiredService<FcvsUaApiClientCredentials>();

    var factory = provider.GetRequiredService<IHttpClientFactory>();
    var client = factory.CreateClient("FcvsUa");

    return new FcvsUaApiClient(client, options, credentials);
});

//Code that uses client through DI
class FsmbService
{
   public FsmbService ( FcvsUaApiClient client )
   {
      _client = client;
   }

   private readonly FcvsUaApiClient _client;
}
```

*Note: It is strongly recommended that you create a single instance of the client and reuse it instead of creating a new instance each time.*

## Change Log

- 2024-Jul-03
  - Initial version
