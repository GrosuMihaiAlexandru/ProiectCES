FROM mcr.microsoft.com/dotnet/sdk:3.1

RUN apt-get update
RUN apt-get install -y default-jre

WORKDIR /simianDX

COPY simian-2.5.10.jar ./simian-2.5.10.jar

COPY SimianPlugin.dll ./SimianPlugin.dll
COPY SimianPlugin.runtimeconfig.json ./SimianPlugin.runtimeconfig.json
COPY Newtonsoft.Json.dll ./Newtonsoft.Json.dll

COPY command.sh ./command.sh

ENTRYPOINT [ "bash", "command.sh" ]