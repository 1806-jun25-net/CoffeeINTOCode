FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY HappyPets.WebApp/*.csproj ./HappyPets.WebApp/
COPY HappyPets.Data/*.csproj   ./HappyPets.Data/
COPY HappyPets.Test/*.csproj   ./HappyPets.Test/
RUN dotnet restore

# copy everything else and build app
COPY . ./
WORKDIR /app/HappyPets.WebApp
RUN dotnet publish -c Release -o out


FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/HappyPets.WebApp/out ./
ENTRYPOINT ["dotnet", "HappyPets.WebApp.dll"]
