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

namespace examFinalWF
{
    public partial class Form1 : Form
    {

        public string filename;
        public Form1()
        {
            InitializeComponent();
        }

        private void rbCar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCar.Checked == true)
            {
                ownerGrp.Enabled = false;
                carGroup.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbCar.Checked = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void makeCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            
            if (makeCar.SelectedItem.ToString().ToUpper() == "MAZDA")
            {
                comboBox2.Items.Add("Mazda3 GT");
                comboBox2.Items.Add("Mazda3 speed");
                comboBox2.Items.Add("Mazda2 2.2");
            }

            if (makeCar.SelectedItem.ToString().ToUpper() == "MERCEDEZ")
            {
                comboBox2.Items.Add("x3 2.3");
                comboBox2.Items.Add("x2 2.3");
                comboBox2.Items.Add("320 x 2.0");
            }
            if (makeCar.SelectedItem.ToString().ToUpper() == "AUDI")
            {
               
                comboBox2.Items.Add("Audi turbo");
                comboBox2.Items.Add("audi sport");
                comboBox2.Items.Add("Audi c2");
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            fName.Text = "";
            lName.Text = "";
            txtTelephone.Text = "";
            makeCar.Text="";
            comboBox2.Text = "";
            yearMenu.Text = "";
        }

        private void ownerRb_CheckedChanged(object sender, EventArgs e)
        {
            if (ownerRb.Checked == true)
            {
                ownerGrp.Enabled = true;
                carGroup.Enabled = false;
            }
        }

        private void writeToFile(String output)
        {
            using (StreamWriter sw = new StreamWriter("users.txt", true))
            {
                sw.WriteLine(output);
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)


        {

            if ((makeCar.Text.Trim() != "") && (comboBox2.Text.Trim() != "") && (yearMenu.Text.Trim() != "") && (lName.Text.Trim() != "") && (txtTelephone.Text.Trim() != ""))
            {
                savetoFile();
            }
            else
                MessageBox.Show("Please fill out all forms");



           
            
           
               
            
        }
        public void savetoFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.OverwritePrompt = false;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = saveFileDialog.FileName;
                    MessageBox.Show(filename);
                }
            }

            FileStream fileStream = new FileStream(filename, FileMode.Append, FileAccess.Write);

            using (StreamWriter streamWriter = new StreamWriter(fileStream))
            {

                streamWriter.WriteLine($"{makeCar.Text},{comboBox2.Text},{yearMenu.Text},{fName.Text},{lName.Text},{txtTelephone.Text}");
            }
        }
    }
}
