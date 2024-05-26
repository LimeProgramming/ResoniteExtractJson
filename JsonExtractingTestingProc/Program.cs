using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Brotli;
using BrotliSharpLib;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using LZ4;
using System.Text;
using Newtonsoft.Json.Linq;
using System.IO.Pipes;
using Elements.Core;


namespace JsonExtractingTestingProc
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ExtractToJson());
        }


        public static string ExtractJson(string file)
        {
            // Attempt to open the file.
            DataTreeDictionary data;
            data = Elements.Core.DataTreeConverter.Load(file);


            // Convert the Resonite DataTree to Json
            string output = null;

            using (var sw = new StringWriter())
            {
                JsonTextWriter wr = new JsonTextWriter(sw);
                wr.Indentation = 2;
                wr.Formatting = Newtonsoft.Json.Formatting.Indented;

                Program.Write(data, wr);

                output = sw.ToString();
            }

            return output;
        }


        private static void Write(DataTreeNode node, JsonWriter jsWriter)
        {
            DataTreeValue dtvNode = node as DataTreeValue;
            if (dtvNode != null)
            {
                Program.WriteValue(dtvNode, jsWriter);
                return;
            }
            DataTreeList dataTreeList = node as DataTreeList;
            if (dataTreeList != null)
            {
                Program.WriteList(dataTreeList, jsWriter);
                return;
            }
            DataTreeDictionary dataTreeDictionary = node as DataTreeDictionary;
            if (dataTreeDictionary == null)
            {
                return;
            }

            Program.WriteDictionary(dataTreeDictionary, jsWriter);
        }

        private static void WriteValue(DataTreeValue value, JsonWriter jsWriter)
        {
            if (value.IsNull)
            {
                jsWriter.WriteNull();
                return;
            }
            IConvertible convertible = value.Value;
            if (convertible is ulong)
            {
                ulong num = (ulong)convertible;
                jsWriter.WriteValue((long)num);
                return;
            }
            convertible = value.Value;
            if (convertible is uint)
            {
                uint num2 = (uint)convertible;
                jsWriter.WriteValue((int)num2);
                return;
            }
            jsWriter.WriteValue(value.Value);
        }

        private static void WriteList(DataTreeList list, JsonWriter jsWriter)
        {
            jsWriter.WriteStartArray();

            foreach (DataTreeNode dataTreeNode in list.Children)
            {
                Program.Write(dataTreeNode, jsWriter);
            }
            jsWriter.WriteEndArray();
        }

        private static void WriteDictionary(DataTreeDictionary node, JsonWriter jsWriter)
        {
            jsWriter.WriteStartObject();

            foreach (KeyValuePair<string, DataTreeNode> keyValuePair in node.Children)
            {
                jsWriter.WritePropertyName(keyValuePair.Key.ToString());
                Program.Write(keyValuePair.Value, jsWriter);
            }
            jsWriter.WriteEndObject();
        }

    }
}
