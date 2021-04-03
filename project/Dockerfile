FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /source

#COPY *.sln .
COPY ./*.csproj ./project/
RUN dotnet restore ./project

COPY . ./project/
WORKDIR /source/project
RUN dotnet publish -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "project.dll"]