using System;
using System.Collections.Generic;
using System.Text;

namespace Simian_Plugin
{
    public class DxProperties
    {
        public List<Property> properties = new List<Property>();

        public void PrintProperties()
        {
            foreach (var prop in properties)
            {
                Console.WriteLine(prop.file + " " + prop.value + "\n");
            }
        }
    }

    public class Property
    {
        public string file;
        public string name;
        public string category;
        public int value;

        public Property(string file, string name, string category, int value)
        {
            this.file = file;
            this.name = name;
            this.category = category;
            this.value = value;
        }
    }
}
