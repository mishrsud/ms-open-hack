FROM microsoft/dotnet:2.0-sdk
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy and build everything else
COPY . ./
RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "out/MinecraftMonotor.dll"]
#FROM microsoft/dotnet:2.0-runtime AS base
#WORKDIR /app
#
#FROM microsoft/dotnet:2.0-sdk AS build
#WORKDIR /src
#COPY MinecraftMonotor.csproj MinecraftMonotor/
#RUN dotnet restore MinecraftMonotor/MinecraftMonotor.csproj
#COPY . .
#WORKDIR /src/MinecraftMonotor
#RUN dotnet build MinecraftMonotor.csproj -c Release -o /app
#
#FROM build AS publish
#RUN dotnet publish MinecraftMonotor.csproj -c Release -o /app
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "MinecraftMonotor.dll"]
#