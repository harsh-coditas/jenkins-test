#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
# Use the .NET SDK image as the build environment
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# Copy the .sln file (optional, but can help with caching)
COPY *.sln ./

#EXPOSE 80
#EXPOSE 443

#FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
#WORKDIR /src
COPY ConnectAndSellSupport.API/*.csproj ./ConnectAndSellSupport.API/
COPY ConnectAndSellSupport.Services/*.csproj ./ConnectAndSellSupport.Services/
COPY ConnectAndSellSupport.Repository/*.csproj ./ConnectAndSellSupport.Repository/
COPY ConnectAndSellSupport.Domain/*.csproj ./ConnectAndSellSupport.Domain/
COPY ConnectAndSellSupport.Tests/*.csproj ./ConnectAndSellSupport.Tests/
RUN dotnet restore
COPY . ./
WORKDIR "/src/ConnectAndSellSupport.API"
RUN dotnet build -c Release -o /app/build

#COPY ["certs/", "/src/certs/"]

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .
#COPY --from=build /src/certs /app/certs/

#ENV ASPNETCORE_Kestrel__Certificates__Default__Password Coditas
#ENV ASPNETCORE_Kestrel__Certificates__Default__Path /app/certs/cert.pem
#ENV ASPNETCORE_Kestrel__Certificates__Default__KeyPath /app/certs/key.pem
#ENV ASPNETCORE_HTTPS_PORT 443

ENTRYPOINT ["dotnet", "watch", "run", "--urls", "https://*:5000"]
