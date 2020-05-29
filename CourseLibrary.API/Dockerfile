FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
# These two lines were causing issues, the dependencies were not found 
#COPY ["CourseLibrary.API.csproj", "./"]
#RUN dotnet restore "./CourseLibrary.API.csproj"
COPY . .
RUN dotnet build "CourseLibrary.API.csproj" -c Release

FROM build AS publish
RUN dotnet publish "CourseLibrary.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .

ENTRYPOINT ["dotnet", "CourseLibrary.API.dll"]


# Below is from the microsoft documentation
#FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
#WORKDIR /app
#
## Copy csproj and restore as distinct layers
#COPY *.csproj ./
#RUN dotnet restore
#
## Copy everything else and build
#COPY . ./
#RUN dotnet publish -c Release -o out
#
## Build runtime image
#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
#WORKDIR /app
#COPY --from=build-env /app/out .
#ENTRYPOINT ["dotnet", "courselibrary.api.dll"]