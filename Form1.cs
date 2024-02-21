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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace File1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveText_Click(object sender, EventArgs e)
        {
            //Create object of FileInfo for specified path            
            //FileInfo fi = new FileInfo(@"DummyFile.txt");

            //Open file for Read\Write
            //FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);

            //Create StreamWriter object to write string to FileSream
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine(readFileContent.Text);
            //sw.Close();

            using (StreamWriter sw = new StreamWriter("@DummyFile.txt"))
            {
                sw.WriteLine(readFileContent.Text);
            }
        }

        private void readFromFile_Click(object sender, EventArgs e)
        {
            ////Create an object of FileInfo for specified path            
            //FileInfo fi = new FileInfo(@"D:\DummyFile.txt");

            ////Open a file for Read\Write
            //FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

            ////Create an object of StreamReader by passing FileStream object on which it needs to operates on
            //StreamReader sr = new StreamReader(fs);

            ////Use the ReadToEnd method to read all the content from file
            //string fileContent = sr.ReadToEnd();

            //string readFileContent = sr.ReadToEnd() ;

            ////Close the StreamReader object after operation
            //sr.Close();
            //fs.Close();

            using (StreamReader sr = new StreamReader("@DummyFile.txt"))
            {
                readFileContent.Text = "";
                while (!sr.EndOfStream)
                {
                    readFileContent.Text = sr.ReadLine();
                }
            }
        }

        private void fileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }

            using (StreamReader sr = new StreamReader(textBox1.Text))
            {
                readFileContent.Text = sr.ReadToEnd();
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog

            {
                InitialDirectory = @"C:\",
                Title = "Save As Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = saveFileDialog1.FileName;
            }

            using (StreamWriter sw = new StreamWriter(textBox1.Text))
            {
                sw.WriteLine(readFileContent.Text);
            }

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create object of FileInfo for specified path            
            //FileInfo fi = new FileInfo(@"DummyFile.txt");

            //Open file for Read\Write
            //FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);

            //Create StreamWriter object to write string to FileSream
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine(readFileContent.Text);
            //sw.Close();

            using (StreamWriter sw = new StreamWriter("@TestFile.txt"))
            {
                sw.WriteLine(readFileContent.Text);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog

            {
                InitialDirectory = @"C:\",
                Title = "Save As Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = saveFileDialog1.FileName;
            }

            using (StreamWriter sw = new StreamWriter(textBox1.Text))
            {
                sw.WriteLine(readFileContent.Text);
            }

        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();   //Basically the same as "new"??
            this.Hide();
            myForm.ShowDialog();
            this.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }

            using (StreamReader sr = new StreamReader(textBox1.Text))
            {
                readFileContent.Text = sr.ReadToEnd();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Show();
        }
    }
}
