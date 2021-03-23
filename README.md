# Simian DxPlugin

Simian is a program which identifies duplication in code written in multiple programming languages as well as in plain text files. 
Simian DX Plugin uses the output Simian gives and generates a property file for DXPlatform, which can be used to display files which contain code duplication.

## Running with Docker
We recommend running the following docker image: [raulbrumar/simiandx.](https://hub.docker.com/r/raulbrumar/simiandx)
To run the docker image, simply run the following command:
```docker
   docker run -v [LOCALPATH]:/simianDX/SimianDXData raulbrumar/simiandx "**/*.extension"
   ```
   where ```[LOCALPATH]``` is the path where the project's folder you want to analyze is located.

## Running without Docker
Alternatively you can download the latest release and run it following the instructions.
### Requirements
Java JRE and Microsoft dotnet SDK 3.1 are required in order to run the plugin.
### Installation
Download the latest release of SimianPlugin.
You will also need [Simian](https://www.harukizaemon.com/simian/index.html) in the same folder as the plugin in order to run the plugin.

### Usage
Run Simian first with the following command:
```java -jar simian.jar [files]```, where ```[files]``` is the matching pattern for Simian.
For example, in order to analyze all files with a certain extension use ```"**/*.cs"```. Replace `.extension` with your desired extension.
  More information about Simian matching patterns can be found [here](https://www.harukizaemon.com/simian/installation.html).
Now run 

## License
MIT

