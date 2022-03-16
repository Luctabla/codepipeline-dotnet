FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR webapp


EXPOSE 80
EXPOSE 5000
EXPOSE 29831

COPY ./*.csproj ./
RUN dotnet add package Microsoft.AspNet.Mvc --version 5.2.7
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o out

#Build image
FROM mcr.microsoft.com/dotnet/sdk:5.0
WORKDIR /webapp
COPY --from=build /webapp/out .
ENTRYPOINT ["dotnet", "MyWebApp.dll"]