using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PT8
{
    /// <summary>
    /// Logika interakcji dla klasy FormDialog.xaml
    /// </summary>
    public partial class FormDialog : Window
    {
        private string path;
        private bool accepted = false;

        public FormDialog(string pth)
        {
            InitializeComponent();
            path = pth;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            bool isFileRadio = (bool)FileRB.IsChecked;
            bool isDirRadio = (bool)DirectoryRB.IsChecked;

            bool isRegexValid = Regex.IsMatch(fileName.Text, "^[a-zA-Z0-9_~-]{1,8}(.txt|.php|.html)$");

            if(isFileRadio && !isRegexValid)
            {
                System.Windows.MessageBox.Show("Nieprawidłowa nazwa pliku!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                FileAttributes newAtrs = FileAttributes.Normal; 
                if ((bool)ReadOnlyCB.IsChecked) 
                {
                    newAtrs = newAtrs | FileAttributes.ReadOnly;
                }

                if ((bool)ArchiveCB.IsChecked)
                {
                    newAtrs = newAtrs | FileAttributes.Archive;
                }

                if ((bool)SystemCB.IsChecked)
                {
                    newAtrs = newAtrs | FileAttributes.System;
                }

                if ((bool)HiddenCB.IsChecked)
                {
                    newAtrs = newAtrs | FileAttributes.Hidden;
                }

                path = path + "\\" + fileName.Text;
                if (isDirRadio)
                {
                    Directory.CreateDirectory(path);
                }
                else
                {
                    File.Create(path);
                }
                this.Close(); 
                File.SetAttributes(path, newAtrs);  
                accepted = true;
               
            }
          
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public bool isAccepted()
        {
            return accepted;
        }

        public string getPath()
        {
            return path;
        }

    }
}
