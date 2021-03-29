//Author: Tyler Henry
//Last Modified: March 28 2021
//Title: Lab 5 Text Editor
//Description: Text editor that allwos users to enter text input, as well as save their current work and open files
//into the text editor. Form will ask user if they want to save when replacing new text input.
using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_TylerHenry
{
    public partial class textEditor : Form
    {
        //Variable Declarations
        string openFilePath = "";
        string startingText = "";
        public textEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Reset form back to a default state, will ask user if they want to save their work
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            //Ask user if they want to save current work
            ConfirmClose();

            //Reset text box and set focus
            textBoxTextEditor.Text = "";
            textBoxTextEditor.Focus();

            //Reset any assigned Varaibles
            openFilePath = "";
            startingText = "";

            //Update Title
            UpdateFormTitle();
        }

        /// <summary>
        /// Opens text files into the text box, will ask user if they want to save current work before hand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            //Asks user if they want to save
            ConfirmClose();

            //Create open dialog instace and filter to show only text files
            OpenFileDialog openLocation = new OpenFileDialog();
            openLocation.Filter = "Text files (*.txt)|*.txt";

            //Show the SaveDialog if they click ok
            if (openLocation.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openLocation.FileName;
                
                //Create a FileStream and StreamReader.
                FileStream fileToAccess = new FileStream(openFilePath, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fileToAccess);


                //Read file to the textbox
                textBoxTextEditor.Text = reader.ReadToEnd();
                startingText = textBoxTextEditor.Text;

                //Close reader
                reader.Close();

                //Update title to file path
                UpdateFormTitle();

            }
        }

        /// <summary>
        /// Saves current text entered into text box, will open dialog menu if there is no current file path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileSave_Click(object sender, EventArgs e)
        {
            //If there is a current file path save current file
            if (openFilePath != "")
            {
                

                //Create a FileStream and StreamWriter.
                FileStream fileToAccess = new FileStream(openFilePath, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fileToAccess);


                //Write list to the file
                writer.Write(textBoxTextEditor.Text);
                startingText = textBoxTextEditor.Text;

                //Close file
                writer.Close();

                //Inform user save was successful
                MessageBox.Show("Save complete");
                
            }
            //If file path is empty save as a new file
            else { 
            //Declare default file path
            string filePath = "TextFile" + DateTime.Now.ToString("yyyMMdd") + ".txt";

            //Create save diaglog intance and set default filename and filter
            SaveFileDialog saveLocation = new SaveFileDialog();
            saveLocation.FileName = filePath;
            saveLocation.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                //Show the SaveDialog if they click ok
                if (saveLocation.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveLocation.FileName;

                    //Create a FileStream and StreamWriter.
                    FileStream fileToAccess = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(fileToAccess);


                    //Write list to the file
                    writer.Write(textBoxTextEditor.Text);
                    startingText = textBoxTextEditor.Text;

                    //Close file
                    writer.Close();

                    //Inform user save was successful
                    MessageBox.Show("Save complete");
                    openFilePath = filePath;
                    UpdateFormTitle();
                }
            }
            
        }
        /// <summary>
        /// Saves current text in text box, will always open a dialog box and create a new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            //Declare default file path
            string filePath = "TextFile" + DateTime.Now.ToString("yyyMMdd") + ".txt";

            //Create save diaglog intance and set default filename and filter
            SaveFileDialog saveLocation = new SaveFileDialog();
            saveLocation.FileName = filePath;
            saveLocation.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            //Show the SaveDialog if they click ok
            if (saveLocation.ShowDialog() == DialogResult.OK)
            {
                filePath = saveLocation.FileName;

                //Create a FileStream and StreamWriter.
                FileStream fileToAccess = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fileToAccess);


                //Write text to the file
                writer.Write(textBoxTextEditor.Text);
                startingText = textBoxTextEditor.Text;

                //Close file
                writer.Close();

                //Inform user save was successful
                MessageBox.Show("Save complete");
                openFilePath = filePath;
                UpdateFormTitle();
            }
        }
        /// <summary>
        /// Closes the form, asks user if they wish to save current work first
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            //Asks user if they wish to save
            ConfirmClose();

            //Closes the form
            Close();
        }

        /// <summary>
        /// Copies highlighted text to clip board
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditCopy_Click(object sender, EventArgs e)
        {
            //If something is highlighted, save it to clipbaord
            if (textBoxTextEditor.SelectedText.Length != 0)
            {
                Clipboard.SetText(textBoxTextEditor.SelectedText.ToString());
            }
        }

        /// <summary>
        /// Copies highlighted text to clipboard then deletes highlighted text from the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditCut_Click(object sender, EventArgs e)
        {
            //If something is highlighted, copy to clipboard and delete from form
            if (textBoxTextEditor.SelectedText.Length != 0)
            {
                Clipboard.SetText(textBoxTextEditor.SelectedText.ToString());
                textBoxTextEditor.SelectedText = "";
            }
        }

        /// <summary>
        /// Pastes contents of clip board to the beginning of the selected area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuEditPaste_Click(object sender, EventArgs e)
        {
            //Pastes contents of clip board to the beginning of the selected area
            if (Clipboard.ContainsText())
            {
                textBoxTextEditor.Text = textBoxTextEditor.Text.Insert
                    (textBoxTextEditor.SelectionStart, Clipboard.GetText());
            }
        }

        /// <summary>
        /// Makes a dialog box appear then informs user about information regaurding the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            //Open dialog box
            MessageBox.Show("NETD-2202 \nLab 5\nT. Henry", "About");
        }

        /// <summary>
        /// Allows for the form title to be updated with file path of current file in use
        /// </summary>
        private void UpdateFormTitle()
        {
            //If file path is blank, set form title to default title
            if(openFilePath == "")
            {
                this.Text = "Text Editor Please Select a File to Open";
            }

            //If file path has an entry, set it to end of form title
            else
            {
                this.Text = "Text Editor " + openFilePath;
            }
        }

        /// <summary>
        /// Asks user if they want to save their work when leaving current text
        /// </summary>
        private void ConfirmClose()
        {
            //If the current text has been changed after making a new file, saving a file, or opening a file
            if (textBoxTextEditor.Text != startingText)
            {
                //Show message box asking user if they would like to save there work
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Would you like to save your current work?", "Saving", buttons);
                //If yes button is pressed
                if (result == DialogResult.Yes)
                {
                    if (openFilePath != "")
                    {


                        //Create a FileStream and StreamWriter.
                        FileStream fileToAccess = new FileStream(openFilePath, FileMode.Create, FileAccess.Write);
                        StreamWriter writer = new StreamWriter(fileToAccess);


                        //Write text to the file
                        writer.Write(textBoxTextEditor.Text);


                        //Close file
                        writer.Close();

                        //Inform user save was successful
                        MessageBox.Show("Save complete");

                    }
                    else
                    {
                        //Declare default file path
                        string filePath = "TextFile" + DateTime.Now.ToString("yyyMMdd") + ".txt";

                        //Create save diaglog intance and set default filename and filter
                        SaveFileDialog saveLocation = new SaveFileDialog();
                        saveLocation.FileName = filePath;
                        saveLocation.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                        //Show the SaveDialog if they click ok
                        if (saveLocation.ShowDialog() == DialogResult.OK)
                        {
                            filePath = saveLocation.FileName;

                            //Create a FileStream and StreamWriter.
                            FileStream fileToAccess = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                            StreamWriter writer = new StreamWriter(fileToAccess);


                            //Write list to the file
                            writer.Write(textBoxTextEditor.Text);


                            //Close file
                            writer.Close();


                        }
                    }
                }
            }
        }

       
    }
}
