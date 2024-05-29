using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static Elements.Core.FileUtil;


namespace JsonExtractingTestingProc
{
    public partial class ExtractToJson : Form
    {
        public ExtractToJson()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;

                FilePath.Text =  file;
            }
        }


        private void FilePath_TextChanged(object sender, EventArgs e)
        {
            outputbox.Text = "";
            txtMSGBox.Text = "";
            btnExecute.Enabled = false;
            btnExport.Enabled = false;
            btnExecute.Enabled = File.Exists(FilePath.Text);
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            outputbox.Text = "";
            txtMSGBox.Text = "";
            txtMSGBox.Text = "Working......";
            outputbox.Enabled = false;
            btnExport.Enabled = false;

            try
            {
                txtMSGBox.Text = "Working......";
                outputbox.Text = Program.ExtractJson(FilePath.Text);
                txtMSGBox.Text = "";
            }
            catch ( NotSupportedException ) 
            {
                txtMSGBox.Text = "Unsupported File Type";
                MessageBox.Show("-Unsupported File Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception excpt)
            {
                txtMSGBox.Text = excpt.Message;
                MessageBox.Show(excpt.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(excpt.Message);
            }

            return;
        }

        private void outputbox_TextChanged(object sender, EventArgs e)
        {
            if ( outputbox.Text.Length > 0 ) {outputbox.Enabled = true; btnExport.Enabled = true; }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (outputbox.Text.Length == 0)
            {
                return;
            }


            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = Path.GetDirectoryName(FilePath.Text);
            saveFileDialog1.Title = "Export to Json";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.FileName = Path.GetFileName(Path.GetFileNameWithoutExtension(FilePath.Text).Trim() + ".json");
            saveFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog1.DefaultExt = "json";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    var writer = new StreamWriter(myStream);
                    writer.Write(outputbox.Text);
                    writer.Flush();
                    myStream.Close();
                }
            }

        }


        // ==================== Has Assemblies ====================

        private static readonly HashSet<string> NEOS2_ASSEMBLY_NAMES_SET = new HashSet<string> { "LZ4", "Brotli.Core", "BrotliSharpLib", "Elements.Core", "Newtonsoft.Json", "Newtonsoft.Json.Bson", "MimeDetective", "LZMA", "SevenZip" };


        private static DirectoryInfo GetExecutingPath()
        {
            var location = Assembly.GetExecutingAssembly().Location;
            return string.IsNullOrEmpty(location) ? new DirectoryInfo(".") : new FileInfo(location).Directory;
        }

        private void ExtractToJson_Load(object sender, EventArgs e)
        {
            var executingPath = GetExecutingPath();

            foreach (var assemblyName in NEOS2_ASSEMBLY_NAMES_SET)
            {
                if (!File.Exists($"{executingPath}\\{assemblyName}.dll")) 
                {
                    MessageBox.Show($"Missing {assemblyName}.dll file.\nPlease add the file to the same folder as ExtractResoniteJson.exe.\nYou can find {assemblyName}.dll under Resonite/Managed", "External Lib Missing", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      
                    System.Environment.Exit(0);
                }
            }

        }
    }
}
