#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-nanoserver-1903 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-nanoserver-1903 AS build
WORKDIR /src
COPY ["SIGAE.Padron/SIGAE.Padron.csproj", "SIGAE.Padron/"]
RUN dotnet restore "SIGAE.Padron/SIGAE.Padron.csproj"
COPY . .
WORKDIR "/src/SIGAE.Padron"
RUN dotnet build "SIGAE.Padron.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SIGAE.Padron.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SIGAE.Padron.dll"]