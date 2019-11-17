FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /app

COPY *.sln .
COPY Client.DataObject/*.csproj ./Client.DataObject/
COPY Client.Domain/*.csproj ./Client.Domain/
COPY Client.Infrastructure/*.csproj ./Client.Infrastructure/
COPY Client.Service.Business/*.csproj ./Client.Service.Business/
COPY Client.Service.Proxy/*.csproj ./Client.Service.Proxy/
RUN dotnet restore

COPY Client.DataObject/. ./Client.DataObject/
COPY Client.Domain/. ./Client.Domain/
COPY Client.Infrastructure/. ./Client.Infrastructure/
COPY Client.Service.Business/. ./Client.Service.Business/
COPY Client.Service.Proxy/. ./Client.Service.Proxy/
WORKDIR /app/Client.Service.Proxy
RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:2.2-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/Client.Service.Proxy/out ./
ENTRYPOINT ["dotnet", "Client.Service.Proxy.dll"]