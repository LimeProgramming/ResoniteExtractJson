namespace JsonExtractingTestingProc
{
    partial class ExtractToJson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtractToJson));
            this.FilePath = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.outputbox = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtMSGBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FilePath
            // 
            this.FilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePath.Location = new System.Drawing.Point(12, 207);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(804, 26);
            this.FilePath.TabIndex = 0;
            this.FilePath.TabStop = false;
            this.FilePath.TextChanged += new System.EventHandler(this.FilePath_TextChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Enabled = false;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.Location = new System.Drawing.Point(250, 266);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(150, 50);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Decode";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(822, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // outputbox
            // 
            this.outputbox.AcceptsReturn = true;
            this.outputbox.AcceptsTab = true;
            this.outputbox.Enabled = false;
            this.outputbox.Location = new System.Drawing.Point(12, 322);
            this.outputbox.Multiline = true;
            this.outputbox.Name = "outputbox";
            this.outputbox.ReadOnly = true;
            this.outputbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputbox.Size = new System.Drawing.Size(960, 566);
            this.outputbox.TabIndex = 0;
            this.outputbox.TabStop = false;
            this.outputbox.TextChanged += new System.EventHandler(this.outputbox_TextChanged);
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(600, 266);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(150, 50);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export as Json";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 11);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(960, 178);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // txtMSGBox
            // 
            this.txtMSGBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtMSGBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMSGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSGBox.ForeColor = System.Drawing.Color.Red;
            this.txtMSGBox.Location = new System.Drawing.Point(12, 241);
            this.txtMSGBox.Name = "txtMSGBox";
            this.txtMSGBox.ReadOnly = true;
            this.txtMSGBox.Size = new System.Drawing.Size(960, 19);
            this.txtMSGBox.TabIndex = 0;
            this.txtMSGBox.TabStop = false;
            // 
            // ExtractToJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 900);
            this.Controls.Add(this.txtMSGBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.outputbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.FilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 939);
            this.MinimumSize = new System.Drawing.Size(1000, 939);
            this.Name = "ExtractToJson";
            this.Text = "ExtractJson";
            this.Load += new System.EventHandler(this.ExtractToJson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox outputbox;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtMSGBox;
    }
}

