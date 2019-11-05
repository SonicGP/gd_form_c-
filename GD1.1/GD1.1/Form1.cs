using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GD1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Excuse currentExcuse = new Excuse();
        private string selectedFolder = "";
        private bool formChanged = false;
        Random random = new Random();

        private void UpdateForm(bool Changed)
        {
            if (!Changed)
            {
                this.textBoxDesc.Text = currentExcuse.Description;
                this.textBoxResut.Text = currentExcuse.Results;
                this.dateTimePicker1.Value = currentExcuse.LastUsed;
                if (!string.IsNullOrEmpty(currentExcuse.ExcusePath))
                    labelDatFile.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Genrenciador de Desculpas 1.1";
            }
            else
                this.Text = "Genrenciador de Desculpas 1.1*";
            this.formChanged = Changed;
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                buttonSave.Enabled = true;
                buttonOpen.Enabled = true;
                buttonRandomDesc.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxDesc.Text) || string.IsNullOrEmpty(textBoxResut.Text))
            {
                MessageBox.Show("Por favor, especifique a desculpa ou resultado", "Impossivel salvar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.FileName = textBoxDesc.Text + ".txt";
            DialogResult result = saveFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Desculpa Salva");                
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
                openFileDialog1.FileName = textBoxDesc.Text + ".txt";
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentExcuse.OpenFile(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void buttonRandomDesc_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show("A desculpa atual não foi salva. Deseja Continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
            }
            return true;
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = textBoxDesc.Text;
            UpdateForm(true);
        }

        private void textBoxResut_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = textBoxDesc.Text;
            UpdateForm(true);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = dateTimePicker1.Value;
            UpdateForm(true);
        }
    }
}
