echo "Running simian"

java -jar simian-2.5.10.jar -formatter=xml $1 | grep "<" > results.xml

echo "Running SimianPlugin"

# mv project/results.xml $PWD
dotnet SimianPlugin.dll
mv property.json $PWD/project