#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Docke$

FROM mcr.microsoft.com/dotnet/core/sdk:3.1.102-buster AS build
WORKDIR /app
EXPOSE 80
EXPOSE 443

WORKDIR /src
COPY ["Server/KPSL.Collacteral.Server.csproj", "Collacteral/Server/"]
COPY ["Client/KPSL.Collacteral.Client.csproj", "Collacteral/Client/"]
COPY ["Shared/KPSL.Collacteral.Shared.csproj", "Collacteral/Shared/"]
RUN dotnet restore "Collacteral/Server/KPSL.Collacteral.Server.csproj"
COPY . ./
WORKDIR "/src/Collacteral/Server"
RUN dotnet build "KPSL.Collacteral.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "KPSL.Collacteral.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KPSL.Collacteral.Server.dll"]
