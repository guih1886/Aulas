FROM mcr.microsoft.com/dotnet/sdk:8.0 as build
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
EXPOSE 8080
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet", "ItemService.dll" ]