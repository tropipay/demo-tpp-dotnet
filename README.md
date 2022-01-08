# Demo TropiPay DotNet Framework 6.0
Simple demo web API with client credential authentication for TropiPay based on DotNet Framework 6.0. This is an example that shows an example of obtaining the user profile data from the authentication with an apikey.

**Note:** the credentials are specified in the ```appsettings.Development.json``` or ```appsettings.json``` file, using the key named *ClientId* and *ClientSecret*.

## Develop steps 
- dotnet new webapi --name demo-tpp-dotnet
- cd demo-tpp-dotnet

- dotnet dev-certs https --clean
- dotnet dev-certs https -t
- dotnet dev-certs https --check
- dotnet dev-certs https --trust

## Run steps 
- git clone https://github.com/ameksike/demo-tpp-dotnet.git
- cd demo-tpp-dotnet
- dotnet run 
- https://localhost:7089/profile
- https://localhost:7089/swagger/index.html

## Docs
- For more information about ASP Net, see the [link below](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio-code).

- For more information about TropiPay API, see the [link below](https://tpp.stoplight.io/docs/tropipay-api-doc/ZG9jOjEwMDY4ODg3-getting-started).

