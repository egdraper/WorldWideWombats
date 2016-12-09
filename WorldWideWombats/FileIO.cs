using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace WorldWideWombats
{
    public class FileIO : IFileAccess
    {
        public const uint START_INDEX = 0;
        public SortedDictionary<uint, Employee> EmployeeDB { get; set; }
        public static uint currentIndex = START_INDEX;

        /// <summary>
        /// Writes file to the disk.
        /// </summary>
        public void WriteFileDB()
        {
            /*Taken from MSDN -> https://msdn.microsoft.com/en-us/library/system.windows.forms.openfiledialog(v=vs.110).aspx */

            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "inf files (*.inf)|*.inf";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {

                    var bformatter = new BinaryFormatter();
                    bformatter.Serialize(myStream, EmployeeDB);
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }

        /// <summary>
        /// Reads file from the disk
        /// </summary>
        public void ReadFileDB()
        {
            /*Taken from MSDN -> https://msdn.microsoft.com/en-us/library/system.windows.forms.openfiledialog(v=vs.110).aspx */

            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "inf files (*.inf)|*.inf";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            var bformatter = new BinaryFormatter();
                            EmployeeDB = (SortedDictionary<uint, Employee>)bformatter.Deserialize(myStream);
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }


        /// <summary>
        /// Originally was for opening the stream (I assume)
        /// </summary>
        public void OpenFileDB()
        {
            //This function is not necessary any more because the open file dialog handles it

        }

        /// <summary>
        /// origianlly was for closing the stream (I assume)
        /// </summary>
        public void CloseFileDB()
        {
            //This function is not necessary any more because the open file dialog handles it
        }

    }
}
