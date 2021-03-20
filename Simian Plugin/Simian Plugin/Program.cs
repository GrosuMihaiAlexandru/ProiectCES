using System;
using System.Collections;
using System.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.InteropServices;

namespace Simian_Plugin
{
    class Program
    {
        static string projectFilePath;

        const string inputFile = "results.xml";
        const string outputFile = "property.json";

        const string propertyName = "duplicated_lines";
        const string propertyCategory = "duplication";

        static int Main(string[] args)
        {
            projectFilePath = Directory.GetCurrentDirectory();
            Console.WriteLine(projectFilePath);
            Run();

            return 0;
        }

        private static void Run()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Simian));
            FileStream fs = new FileStream(inputFile, FileMode.Open);

            Simian simianObj;
            simianObj = (Simian)serializer.Deserialize(fs);
            simianObj.PrintCheck();

            fs.Close();

            DxProperties outputObj = CreateProperties(simianObj);
            outputObj.PrintProperties();

            string JsonExport = JsonConvert.SerializeObject(outputObj.properties, Formatting.Indented);

            Console.WriteLine(JsonExport);
            File.WriteAllText(outputFile, JsonExport);
        }

        private static DxProperties CreateProperties(Simian serializedXMml)
        {
            DxProperties dxObject = new DxProperties();

            Console.WriteLine("Creating new Object\n\n\n\n");
            // Parcurgem tot obiectu serializat si construim obiectul pentru export
            foreach (var set in serializedXMml.check.sets)
            {
                foreach (var block in set.blocks)
                {
                    // Proprietatea exista
                    if (dxObject.properties.Exists(t => t.file == block.sourceFile))
                    {
                        dxObject.properties.Find(t => t.file == block.sourceFile).value += set.lineCount;
                    }
                    // Adaugam o proprietate noua pentru fisierul respectiv
                    else
                    {
                        dxObject.properties.Add(new Property(block.sourceFile, propertyName, propertyCategory, set.lineCount));
                    }
                }
            }

            // Replace file path with local one
            foreach (var property in dxObject.properties)
            {
                string filePath = property.file.Replace(projectFilePath, "");
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    filePath = filePath.Substring(filePath.IndexOf('\\') + 1);
                    filePath = filePath.Substring(filePath.IndexOf('\\') + 1);

                    filePath = filePath.Replace("\\", "/");
                }
                else
                {
                    filePath = filePath.Substring(filePath.IndexOf('/') + 1);
                    filePath = filePath.Substring(filePath.IndexOf('/') + 1);
                }

                property.file = filePath;
            }

            dxObject.PrintProperties();

            return dxObject;
        }
    }
}
