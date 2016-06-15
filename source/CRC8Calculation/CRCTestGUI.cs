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

/* Author:      Kyle Boudreau
 * Date:	    26 Feb 2015 
 * Description: A simple application to test CRC-8 calculation on a .txt f ile.
 */
namespace CRC8Calculation
{
    public partial class CRCTestGUI : Form
    {
        String fileText;

        public CRCTestGUI()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            // local variables
            String info;

            // declare & instantiate an OpenFileDialog object
            OpenFileDialog fDial = new OpenFileDialog();

            // ininitalize file search to current folder
            fDial.InitialDirectory = Path.Combine(Application.StartupPath, "");

            // filter for only text files in the working folder
            fDial.Filter = "Text Files (*.txt) | *.txt";

            // show dialog, select and display text file
            if (fDial.ShowDialog() == DialogResult.OK)
            {
                // initialize String to absolute path the selected text file
                String file = fDial.FileName;
                /* instantiate and initialize a StreamReader object to the 
                 * selected text file
                 */
                StreamReader reader = new StreamReader(file);
                // copy the absolute path name of text file to textBox1
                selectedFileName.Text = file;
                info = reader.ReadToEnd();
                selectedFileText.Text = (info + "\r\n\r\n");
                reader.Close(); // close file reading resources
                //restore OpenFileDialog opening directory to original directory
                fDial.RestoreDirectory = true;

                selectedFileText.BackColor = Color.White;
                selectedFileName.BackColor = Color.White;

                fileText = info;
            }
            else
            {
                // something wrong if this path is taken
                selectedFileText.Text = "Error reading text file..\r\n\r\n";
                selectedFileText.BackColor = Color.White;
            }

        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1: Click the 'Open File' icon." + "\n" + "2: Select a .txt file." + "\n"
                            + "3: Click the 'Calculate CRC' button.");
        }

        private void calculateCrcButton_Click(object sender, EventArgs e)
        {
            CRC8Calculation CRC = new CRC8Calculation(fileText); //create CRC object 
            byte crcResult = CRC.calculateCRC(); //calculate CRC
            //output CRC in dec, hex, octal, and binary
            crcDecimal.Text = crcResult.ToString("D");
            crcDecimal.BackColor = Color.White;
            crcHex.Text = crcResult.ToString("X");
            crcHex.BackColor = Color.White;
            crcOctal.Text = Convert.ToString(crcResult, 8);
            crcOctal.BackColor = Color.White;
            crcBinary.Text = Convert.ToString(crcResult, 2);
            crcBinary.BackColor = Color.White;
        }
    }
}
