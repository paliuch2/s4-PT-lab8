using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;

namespace PT8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public TreeViewItem addTreeItem(string pth)
        {
            FileInfo file = new FileInfo(pth);
            var element = new TreeViewItem
            {
                Header = file.Name,
                Tag = pth
            };

            FileAttributes atr = File.GetAttributes(pth);
            element.ContextMenu = new System.Windows.Controls.ContextMenu();

            bool isDir = atr.HasFlag(FileAttributes.Directory);

            if (isDir)
            {
                var menuItem_Create = new System.Windows.Controls.MenuItem { Header = "Create" };
                element.ContextMenu.Items.Add(menuItem_Create);
                menuItem_Create.Click += new RoutedEventHandler(fileCreate_Click);
            }
            else
            {
                var menuItem_Open = new System.Windows.Controls.MenuItem { Header = "Open" };
                element.ContextMenu.Items.Add(menuItem_Open);
                menuItem_Open.Click += new RoutedEventHandler(fileOpen_Click);
            }

            var menuItem_Delete = new System.Windows.Controls.MenuItem { Header = "Delete" };
            element.ContextMenu.Items.Add(menuItem_Delete);
            menuItem_Delete.Click += new RoutedEventHandler(fileDelete_Click);

            element.Selected += new RoutedEventHandler(getRASH);

            return element;

        }

        private void getRASH(object sender, RoutedEventArgs e)
        {

            TreeViewItem element = (TreeViewItem)treeView.SelectedItem;
            string pth = (string)element.Tag;

            char[] letters = new char[4] { 'r', 'a', 's', 'h' };
            bool[] attrs = new bool[4] { false, false, false, false };

            FileAttributes atr = File.GetAttributes(pth);

            if (atr.HasFlag(FileAttributes.ReadOnly))
            {
                attrs[0] = true;
            }
            if (atr.HasFlag(FileAttributes.Archive))
            {
                attrs[1] = true;
            }
            if (atr.HasFlag(FileAttributes.System))
            {
                attrs[2] = true;
            }
            if (atr.HasFlag(FileAttributes.Hidden))
            {
                attrs[3] = true;
            }

            string toDisplay = ""; // ciag znakow rahs do wypisania na pasku stanu

            for (int i = 0; i < 4; i++)
            {
                if (attrs[i])
                {
                    toDisplay += letters[i];
                }
                else
                {
                    toDisplay += '-';
                }
            }

            RASHbar.Text = toDisplay;
        }

        private void fileCreate_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem element = (TreeViewItem)treeView.SelectedItem;
            string pth = (string)element.Tag;
            FormDialog fd = new FormDialog(pth);
            fd.ShowDialog();
            TreeViewItem created;
            if (fd.isAccepted())
            {
                created = addTreeItem(fd.getPath());
                element.Items.Add(created);
            }
        }

        private void fileDelete_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem element = (TreeViewItem)treeView.SelectedItem;
            string pth = (string)element.Tag;
            FileAttributes atr = File.GetAttributes(pth);
            atr = atr & ~FileAttributes.ReadOnly;
            File.SetAttributes(pth, atr);

            TreeViewItem parent = (TreeViewItem)element.Parent;
            parent.Items.Remove(element);

            bool isDir = atr.HasFlag(FileAttributes.Directory);
            if (isDir)
            {
                dirDelete(pth);
            }
            else
            {
                File.Delete(pth);
            }

        }

        private void dirDelete(string pth)
        {
            foreach (string dir in Directory.GetDirectories(pth))
            {
                dirDelete(dir);
            }
            foreach (string file in Directory.GetFiles(pth))
            {
                File.Delete(file);
            }
            Directory.Delete(pth);
        }

        private void fileOpen_Click(object sender, RoutedEventArgs e)
        {
            TreeViewItem element = (TreeViewItem)treeView.SelectedItem;
            string pth = (string)element.Tag;

            StreamReader sr = new StreamReader(pth);
            FileContent.Text = sr.ReadToEnd();

        }

        private void optionOpen_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new FolderBrowserDialog() { Description = "Select directory to open" };
            dlg.ShowDialog();
            string pth = dlg.SelectedPath;

            if (pth != "")
            {
                var root = addTreeItem(pth);
                treeView.Items.Add(root);
                BuildTree(pth, root);
            }

        }

        private void BuildTree(string pth, TreeViewItem parent)
        {
            foreach (string dir in Directory.GetDirectories(pth))
            {
                var newDir = addTreeItem(dir);
                parent.Items.Add(newDir);
                string newDirpth = System.IO.Path.GetFullPath(dir);
                BuildTree(newDirpth, newDir);
            }
            foreach (string file in Directory.GetFiles(pth))
            {
                var newFile = addTreeItem(file);
                parent.Items.Add(newFile);
            }
        }

        private void optionExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void optionAbout_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Platformy technologiczne - zadanie 2C\nAutor: Kamil Paluszewski", "Platformy technologiczne - zadanie 2C", MessageBoxButton.OK, MessageBoxImage.None);
        }


    }


}
