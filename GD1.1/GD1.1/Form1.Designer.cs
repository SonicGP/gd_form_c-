namespace GD1._1
{
    partial class Form1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxResut = new System.Windows.Forms.TextBox();
            this.labelDesculpe = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelUltDat = new System.Windows.Forms.Label();
            this.labelDatFix = new System.Windows.Forms.Label();
            this.labelDatFile = new System.Windows.Forms.Label();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonRandomDesc = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(92, 12);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(324, 20);
            this.textBoxDesc.TabIndex = 1;
            this.textBoxDesc.TextChanged += new System.EventHandler(this.textBoxDesc_TextChanged);
            // 
            // textBoxResut
            // 
            this.textBoxResut.Location = new System.Drawing.Point(92, 38);
            this.textBoxResut.Name = "textBoxResut";
            this.textBoxResut.Size = new System.Drawing.Size(324, 20);
            this.textBoxResut.TabIndex = 2;
            this.textBoxResut.TextChanged += new System.EventHandler(this.textBoxResut_TextChanged);
            // 
            // labelDesculpe
            // 
            this.labelDesculpe.AutoSize = true;
            this.labelDesculpe.Location = new System.Drawing.Point(12, 19);
            this.labelDesculpe.Name = "labelDesculpe";
            this.labelDesculpe.Size = new System.Drawing.Size(52, 13);
            this.labelDesculpe.TabIndex = 3;
            this.labelDesculpe.Text = "Desculpa";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 41);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(55, 13);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Resultado";
            // 
            // labelUltDat
            // 
            this.labelUltDat.AutoSize = true;
            this.labelUltDat.Location = new System.Drawing.Point(12, 69);
            this.labelUltDat.Name = "labelUltDat";
            this.labelUltDat.Size = new System.Drawing.Size(130, 13);
            this.labelUltDat.TabIndex = 5;
            this.labelUltDat.Text = "Usado pela Última vez em";
            // 
            // labelDatFix
            // 
            this.labelDatFix.AutoSize = true;
            this.labelDatFix.Location = new System.Drawing.Point(12, 91);
            this.labelDatFix.Name = "labelDatFix";
            this.labelDatFix.Size = new System.Drawing.Size(84, 13);
            this.labelDatFix.TabIndex = 6;
            this.labelDatFix.Text = "Data do Arquivo";
            // 
            // labelDatFile
            // 
            this.labelDatFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDatFile.Location = new System.Drawing.Point(107, 91);
            this.labelDatFile.Name = "labelDatFile";
            this.labelDatFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDatFile.Size = new System.Drawing.Size(309, 23);
            this.labelDatFile.TabIndex = 7;
            // 
            // buttonFolder
            // 
            this.buttonFolder.Location = new System.Drawing.Point(12, 127);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonFolder.TabIndex = 8;
            this.buttonFolder.Text = "Pasta";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(93, 127);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Enabled = false;
            this.buttonOpen.Location = new System.Drawing.Point(174, 127);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 10;
            this.buttonOpen.Text = "Abrir";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonRandomDesc
            // 
            this.buttonRandomDesc.Enabled = false;
            this.buttonRandomDesc.Location = new System.Drawing.Point(255, 127);
            this.buttonRandomDesc.Name = "buttonRandomDesc";
            this.buttonRandomDesc.Size = new System.Drawing.Size(161, 23);
            this.buttonRandomDesc.TabIndex = 11;
            this.buttonRandomDesc.Text = "Desculpa Aleatória";
            this.buttonRandomDesc.UseVisualStyleBackColor = true;
            this.buttonRandomDesc.Click += new System.EventHandler(this.buttonRandomDesc_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 164);
            this.Controls.Add(this.buttonRandomDesc);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.labelDatFile);
            this.Controls.Add(this.labelDatFix);
            this.Controls.Add(this.labelUltDat);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelDesculpe);
            this.Controls.Add(this.textBoxResut);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.dateTimePicker1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Genrenciador de Desculpas 1.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxResut;
        private System.Windows.Forms.Label labelDesculpe;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelUltDat;
        private System.Windows.Forms.Label labelDatFix;
        private System.Windows.Forms.Label labelDatFile;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonRandomDesc;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

