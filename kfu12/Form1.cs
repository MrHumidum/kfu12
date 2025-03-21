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
            sortComboBox.SelectedIndex = 0;
            pictureBox.ErrorImage = Image.FromFile("../../data/images/brokenImage.png");
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
            if (imageStringData.path != null)
            {
                listBox.Items.Add(imageStringData);
                listBox.SelectedItem = imageStringData;
            }
            SortListBox();
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
            SortListBox();

        }

        private void listBox_SelectItem(object sender, EventArgs e)
        {
            var selectedItem = listBox.SelectedItem as ImageStringData;
            if (selectedItem != null && File.Exists(selectedItem.path))
            {
                pictureBox.Image = Image.FromFile(selectedItem.path);
                textBox.Text = selectedItem.title;
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
            if (listBox.SelectedItem != null)
            {
                var selectedItem = listBox.SelectedItem as ImageStringData;
                selectedItem.title = textBox.Text;
            }
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
            listBox.SelectedIndex = -1;
            pictureBox.Image = null;
            textBox.Text = string.Empty;
            SortListBox();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();  
            textBox.Text = string.Empty;
            pictureBox.Image = null;
            SortListBox();
        }

        private void SortListBox()
        {
            if (sortComboBox.SelectedIndex == 0) 
            {
                listBox.Sorted = true;
            }
            else if (sortComboBox.SelectedIndex == 1) 
            {
                SortListBoxDescending();
            }
        }
        private void SortListBoxDescending()
        {
            listBox.Sorted = true;
            listBox.Sorted = false;
            List<ImageStringData> items = new List<ImageStringData>();
            foreach (ImageStringData item in listBox.Items)
            {
                items.Add(item);
            }
            items.Reverse();
            listBox.Items.Clear();
            foreach (var item in items)
            {
                listBox.Items.Add(item);
            }
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortListBox();

        }
    }
}
