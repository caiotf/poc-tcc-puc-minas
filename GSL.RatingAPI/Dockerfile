#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["GSL.RatingAPI/GSL.RatingAPI.csproj", "GSL.RatingAPI/"]
RUN dotnet restore "GSL.RatingAPI/GSL.RatingAPI.csproj"
COPY . .
WORKDIR "/src/GSL.RatingAPI"
RUN dotnet build "GSL.RatingAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GSL.RatingAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GSL.RatingAPI.dll"]
