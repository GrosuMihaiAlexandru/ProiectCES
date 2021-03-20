using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Simian_Plugin
{
    [XmlRoot(ElementName = "simian")]
    public class Simian
    {
        [XmlElement("check")]
        public Check check;

        public void PrintCheck()
        {
            foreach (var set in check.sets)
            {
                Console.WriteLine(set.lineCount + " " + set.fingerprint + "\n");

                foreach (var block in set.blocks)
                    Console.WriteLine(block.sourceFile + " " + block.startLineNumber + " - " + block.endLineNumber);
            }
        }
    }

    public class Check
    {
        [XmlElement("set")]
        public Set[] sets;
    }

    public class Set
    {
        [XmlAttribute("lineCount")]
        public int lineCount;
        [XmlAttribute("fingerprint")]
        public string fingerprint;

        [XmlElement("block")]
        public Block[] blocks;
    }

    public class Block
    {
        [XmlAttribute("sourceFile")]
        public string sourceFile;
        [XmlAttribute("startLineNumber")]
        public int startLineNumber;
        [XmlAttribute("endLineNumber")]
        public int endLineNumber;
    }
}
