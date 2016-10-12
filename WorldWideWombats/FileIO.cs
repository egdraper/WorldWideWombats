using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldWideWombats
{    
    public class FileIO : IFileAccess
    {
        private SortedDictionary<uint, Employee> EmployeeDB { get; set; }

        public void WriteFileDB(SortedDictionary<uint, Employee> employeeDB) {
            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "inf files (*.inf)|*.inf";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }
        public void ReadFileDB() {
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

        public void OpenFileDB() {
            //This function is not
           
        }

        public void CloseFileDB() {
            //this function is not used
        }
        //member data as required
        //member properties & indexers as required
        //member methods as required
    }
}
