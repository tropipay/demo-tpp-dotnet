# Demo TropiPay DotNet Framework 6.0
Simple demo web API with client credential authentication for TropiPay based on DotNet Framework 6.0.

**Note:** the credentials are specified in the ```appsettings.Development.json``` or ```appsettings.json``` file, using the lcaves named *ClientId* and *ClientSecret*.

## Develop steps 
- dotnet new webapi --name deno-tpp-dotnet
- cd deno-tpp-dotnet
- dotnet dev-certs https --clean
- dotnet dev-certs https -t
- dotnet dev-certs https --check
- dotnet dev-certs https --trust

## Run steps 
- git clone 
- cd 
- dotnet run 
- https://localhost:7089/profile

For more information on ASP Net, see the [link below](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio-code).


