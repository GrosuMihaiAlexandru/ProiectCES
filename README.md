Simian is a program which identifies duplication in code written in multiple programming languages as well as in plain text files. 
Simian DX Plugin uses the output Simian gives and generates a property file for DXPlatform, which can be used to display files which contain code duplication.

## Running with Docker
We recommend running the following docker image: [raulbrumar/simiandx.](https://hub.docker.com/r/raulbrumar/simiandx)
To run the docker image, simply run the following command:
```docker
 docker run -v [LOCALPATH]:/simianDX/SimianDXData raulbrumar/simiandx "**/*.[EXTENSION]"
```
   - `[LOCALPATH]` is the path where the project's folder you want to analyze is located
   
  -  `[EXTENSION]` is the desired extension of the files you want to analyze.

## Running without Docker
Alternatively you can download the latest release and run it following the instructions.
### Requirements
Java JRE and Microsoft dotnet SDK 3.1 are required in order to run the plugin.
### Installation
Download the latest release of SimianPlugin.
You will also need [Simian](https://www.harukizaemon.com/simian/index.html) in the same folder as the plugin.

### Usage
Run Simian first with the following command:
```
java -jar simian.jar [files]
```
You can also run the .NET version using:
```
simian.exe [files]
```
  ```[files]``` is the matching pattern for Simian.
 
For example, to find all java files in all sub-directories of the current directory use ```"**/*.java"```. 
Replace `.java` with your desired file extension. 

More information about Simian matching patterns can be found [here](https://www.harukizaemon.com/simian/installation.html).


Now simply run `SimianPlugin.exe` and your `property.json` file will be generated inside the same folder.

## License
MIT
