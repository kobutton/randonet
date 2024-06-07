FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 as build

WORKDIR /app

COPY ./ ./

RUN nuget restore
RUN msbuild /p:Configuration=release -r:False


FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8 as runtime
WORKDIR /inetpub/wwwroot
COPY --from=build /app/. ./

