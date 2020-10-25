using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huffman
{
    public partial class Huffman : Form
    {
        public Huffman()
        {
            InitializeComponent();
        }

        private void LoadFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog BtnBrowse = new OpenFileDialog();
            if (BtnBrowse.ShowDialog() == DialogResult.OK)
            {
                pathLabel.Text = BtnBrowse.FileName;
            }
        }

        private void EncodeFileBtn_Click(object sender, EventArgs e)
        {
            Codor codor = new Codor();
            if (pathLabel.Text != "")
            {
                codor.EncodeFromFile(pathLabel.Text);
                if (ShowCodesCB.Checked) 
                {
                    CodesBox.Items.Clear(); 
                    codor.AfisareInListBox(codor.listaFrunze[0], CodesBox); 
                }
                label2.Text = "Codare terminata";
                
            }
            else
            {
                //pathLabel.ForeColor = Color.Red;
                pathLabel.Text = "Please load a file to encode";
            }
        }

        private void LoadEncodedFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog BtnBrowse = new OpenFileDialog();
            if (BtnBrowse.ShowDialog() == DialogResult.OK)
            {
                pathLabel.Text = BtnBrowse.FileName;
            }
        }

        private void DecodeFileBtn_Click(object sender, EventArgs e)
        {
            Decodor decodor = new Decodor();
            if (pathLabel.Text != "")
            {
               decodor.Decodeaza(pathLabel.Text);
                if (ShowCodesCB.Checked) 
                {
                    CodesBox.Items.Clear();
                    decodor.AfisareInListBox(decodor.ListaDeNoduri[0], CodesBox); 
                }
                label2.Text = "Decodare terminata";

            }
            else
            {
                //pathLabel.ForeColor = Color.Red;
                pathLabel.Text = "Please load a file to decode";
            }
        }

        private void EncodeTextBtn_Click(object sender, EventArgs e)
        {
            Codor codor = new Codor();
            if (TextArea.Text != "")
            {
                codor.EncodeFromInputArea(TextArea.Text);
                if (ShowCodesCB.Checked)
                {
                    CodesBox.Items.Clear();
                    codor.AfisareInListBox(codor.listaFrunze[0], CodesBox); 
                }
                label3.Text = "Codare terminata";

            }
            else
            {
                //pathLabel.ForeColor = Color.Red;
                label3.Text = "Please write some text ";
            }
        }
    }
}
