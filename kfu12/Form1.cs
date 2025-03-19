using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kfu12
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt";
            openFileDialog2.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.tif)|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void readImageFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            ImageStringData imageStringData = new ImageStringData(openFileDialog2.FileName + ";");
            listBox.Items.Add(imageStringData);
        }

        private void readfileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string[] fileData = File.ReadAllLines(filename);
            for (int i = 0; i < fileData.Length; i++)
            {
                ImageStringData imageStringData = new ImageStringData(fileData[i]);
                if (imageStringData.path != null)
                {
                    listBox.Items.Add(imageStringData);
                }
            }
        }

        private void listBox_SelectItem(object sender, EventArgs e)
        {
            var selectedItem = listBox.SelectedItem as ImageStringData;
            if (selectedItem != null && File.Exists(selectedItem.path))
            {
                pictureBox.Image = Image.FromFile(selectedItem.path);
                textBox.Text = selectedItem.title;
            }
            else
            {
                pictureBox.Image = Image.FromFile("../../data/images/brokenImage.png");
                textBox.Text = "Файл изображения не найден!";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            string saveText = string.Empty; 
            foreach (ImageStringData item in listBox.Items) 
            {
                saveText += item.ToSave();
            }
            System.IO.File.WriteAllText(filename, saveText);

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text != "Файл изображения не найден!")
            {
                var selectedItem = listBox.SelectedItem as ImageStringData;
                selectedItem.title = textBox.Text;
            }
        }

    }
}
