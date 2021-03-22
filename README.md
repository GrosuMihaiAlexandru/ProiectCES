# Simian DxPlugin

Simian is a program which identifies duplication in code written in multiple programming languages as well as in plain text files. 
Simian DX Plugin uses the output Simian gives and generates a property file for DXPlatform, which can be used to display files which contain code duplication.

## Requirements
Java JRE and Microsoft dotnet SDK 3.1 are required in order to run the plugin.
 ## Installation
In order to run we recommend running the following docker image: [raulbrumar/simiandx.](https://hub.docker.com/r/raulbrumar/simiandx)

Alternatively you can download the latest release and run it following the instructions.
You will also need [Simian](https://www.harukizaemon.com/simian/index.html) in the same folder as the plugin in order to run the plugin.

## Usage
The shellscript will run Simian first  and then it will  run the plugin. As input you need to specify the matching pattern for Simian.
 - For docker simply run the following command:
   ```docker
   docker run -v  raulbrumar/simiandx "**/*.extension"
   ```
 - Otherwise simply run SimianLinux.sh with the following command:
   ```sh
   ./SimianLinux.sh "**/*.extension"
    ```
  Replace `.extension` with your desired extension.
  More information about Simian matching patterns can be found [here](https://www.harukizaemon.com/simian/installation.html).   

## License
MIT
