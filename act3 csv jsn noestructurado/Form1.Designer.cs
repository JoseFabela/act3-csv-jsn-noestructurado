namespace act3_csv_jsn_noestructurado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProcesarCSV = new System.Windows.Forms.Button();
            this.btnProcesarNoEstructurados = new System.Windows.Forms.Button();
            this.btnProcesarXMLJSON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcesarCSV
            // 
            this.btnProcesarCSV.Location = new System.Drawing.Point(44, 43);
            this.btnProcesarCSV.Name = "btnProcesarCSV";
            this.btnProcesarCSV.Size = new System.Drawing.Size(75, 23);
            this.btnProcesarCSV.TabIndex = 0;
            this.btnProcesarCSV.Text = "CSV";
            this.btnProcesarCSV.UseVisualStyleBackColor = true;
            this.btnProcesarCSV.Click += new System.EventHandler(this.btnProcesarCSV_Click);
            // 
            // btnProcesarNoEstructurados
            // 
            this.btnProcesarNoEstructurados.Location = new System.Drawing.Point(44, 190);
            this.btnProcesarNoEstructurados.Name = "btnProcesarNoEstructurados";
            this.btnProcesarNoEstructurados.Size = new System.Drawing.Size(139, 49);
            this.btnProcesarNoEstructurados.TabIndex = 1;
            this.btnProcesarNoEstructurados.Text = "NO ESTRUCTURADOS";
            this.btnProcesarNoEstructurados.UseVisualStyleBackColor = true;
            this.btnProcesarNoEstructurados.Click += new System.EventHandler(this.btnProcesarNoEstructurados_Click);
            // 
            // btnProcesarXMLJSON
            // 
            this.btnProcesarXMLJSON.Location = new System.Drawing.Point(44, 115);
            this.btnProcesarXMLJSON.Name = "btnProcesarXMLJSON";
            this.btnProcesarXMLJSON.Size = new System.Drawing.Size(85, 23);
            this.btnProcesarXMLJSON.TabIndex = 2;
            this.btnProcesarXMLJSON.Text = "JSON/XML";
            this.btnProcesarXMLJSON.UseVisualStyleBackColor = true;
            this.btnProcesarXMLJSON.Click += new System.EventHandler(this.btnProcesarXMLJSON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcesarXMLJSON);
            this.Controls.Add(this.btnProcesarNoEstructurados);
            this.Controls.Add(this.btnProcesarCSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcesarCSV;
        private System.Windows.Forms.Button btnProcesarNoEstructurados;
        private System.Windows.Forms.Button btnProcesarXMLJSON;
    }
}

