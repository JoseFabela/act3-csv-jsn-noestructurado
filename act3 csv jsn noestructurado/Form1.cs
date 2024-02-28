using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace act3_csv_jsn_noestructurado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProcesarCSV_Click(object sender, EventArgs e)
        {
            // Lógica para el procesamiento de archivos CSV
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<string[]> csvData = ReadCSV(filePath);

                // Puedes realizar acciones con los datos del archivo CSV aquí
                // Por ejemplo, mostrarlos en un DataGridView:
                DataGridView dgv = new DataGridView();
                dgv.Dock = DockStyle.Fill;
                dgv.RowHeadersVisible = false;
                dgv.ColumnHeadersVisible = true;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                foreach (string header in csvData[0])
                {
                    dgv.Columns.Add(header, header);
                }

                for (int i = 1; i < csvData.Count; i++)
                {
                    dgv.Rows.Add(csvData[i]);
                }

                Form csvForm = new Form();
                csvForm.Text = "Datos CSV";
                csvForm.Size = new System.Drawing.Size(600, 400);
                csvForm.Controls.Add(dgv);
                csvForm.ShowDialog();
            }
        }

        private List<string[]> ReadCSV(string filePath)
        {
            List<string[]> data = new List<string[]>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');
                        data.Add(values);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo CSV: {ex.Message}");
            }

            return data;
        }

        private void btnProcesarXMLJSON_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos XML (*.xml)|*.xml|Archivos JSON (*.json)|*.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (filePath.EndsWith(".xml", StringComparison.OrdinalIgnoreCase))
                {
                    // Lógica para el procesamiento de archivos XML
                    ProcessXML(filePath);
                }
                else if (filePath.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                {
                    // Lógica para el procesamiento de archivos JSON
                    ProcessJSON(filePath);
                }
            }
        }

        private void ProcessXML(string filePath)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                // Puedes realizar acciones con el documento XML aquí
                // Por ejemplo, mostrar el contenido en un TextBox:
                TextBox txtResult = new TextBox();
                txtResult.Multiline = true;
                txtResult.Dock = DockStyle.Fill;
                txtResult.Text = xmlDoc.OuterXml;

                Form xmlForm = new Form();
                xmlForm.Text = "Contenido XML";
                xmlForm.Size = new System.Drawing.Size(600, 400);
                xmlForm.Controls.Add(txtResult);
                xmlForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el archivo XML: {ex.Message}");
            }
        }

        private void ProcessJSON(string filePath)
        {
            try
            {
                string jsonContent = File.ReadAllText(filePath);

                // Puedes realizar acciones con el contenido JSON aquí
                // Por ejemplo, mostrar el contenido en un TextBox:
                TextBox txtResult = new TextBox();
                txtResult.Multiline = true;
                txtResult.Dock = DockStyle.Fill;
                txtResult.Text = JToken.Parse(jsonContent).ToString();

                Form jsonForm = new Form();
                jsonForm.Text = "Contenido JSON";
                jsonForm.Size = new System.Drawing.Size(600, 400);
                jsonForm.Controls.Add(txtResult);
                jsonForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el archivo JSON: {ex.Message}");
            }
        }

        private void btnProcesarNoEstructurados_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Lógica para el procesamiento de archivos no estructurados
                ProcessUnstructuredFile(filePath);
            }
        }
        private void ProcessUnstructuredFile(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);

                // Puedes realizar acciones con el contenido del archivo no estructurado aquí
                // Por ejemplo, mostrar el contenido en un TextBox:
                TextBox txtResult = new TextBox();
                txtResult.Multiline = true;
                txtResult.Dock = DockStyle.Fill;
                txtResult.Text = content;

                Form unstructuredForm = new Form();
                unstructuredForm.Text = "Contenido No Estructurado";
                unstructuredForm.Size = new System.Drawing.Size(600, 400);
                unstructuredForm.Controls.Add(txtResult);
                unstructuredForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el archivo no estructurado: {ex.Message}");
            }
        }
    }

}
