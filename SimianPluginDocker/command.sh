echo "Running simian. Please wait."

java -jar simian-2.5.10.jar -formatter=xml $1 | grep "<" > results.xml

echo "Running SimianPlugin"

dotnet SimianPlugin.dll
mv property.json $PWD/SimianDXData