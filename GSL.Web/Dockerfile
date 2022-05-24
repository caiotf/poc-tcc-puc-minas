#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
ENV LANG pt_BR.UTF-8
ENV LC_ALL pt_BR.UTF-8
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["GSL.Web/GSL.Web.csproj", "GSL.Web/"]
RUN dotnet restore "GSL.Web/GSL.Web.csproj"
COPY . .
WORKDIR "/src/GSL.Web"
RUN dotnet build "GSL.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GSL.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GSL.Web.dll"]
