using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        private string directoryPath = @"C:\temp";
        public Form1()
        {
            InitializeComponent();
        }

        private void task1Button_Click(object sender, EventArgs e)
        {
            var filesNamesDate = Directory.EnumerateFileSystemEntries(directoryPath, "*", SearchOption.AllDirectories)
                .Select(file => new { Name = file, Created = File.GetCreationTime(file) })
                .Union(Directory.EnumerateDirectories(directoryPath, "*", SearchOption.AllDirectories)
                .Select(directory => new { Name = directory, Created = Directory.GetCreationTime(directory) }));
            dataGridView.DataSource = filesNamesDate.ToList();
        }

        private void task2Button_Click(object sender, EventArgs e)
        {
            var files = Directory.EnumerateFiles(directoryPath, "*", SearchOption.AllDirectories)
                .GroupBy(file => Path.GetExtension(file))
                .Select(group => new { Extension = group.Key, TotalSize = group.Sum(file => new FileInfo(file).Length), FileCount = group.Count() });
            dataGridView.DataSource = files.ToList();
        }

        private void task3Button_Click(object sender, EventArgs e)
        {

            var filesDate = Directory.EnumerateFiles(directoryPath, "*", SearchOption.AllDirectories)
                .GroupBy(file => new { File.GetCreationTime(file).Year, File.GetCreationTime(file).Month })
                .Select(group => new { group.Key.Year, group.Key.Month, FileCount = group.Count() });
            dataGridView.DataSource = filesDate.ToList();
        }

        private void task4Button_Click(object sender, EventArgs e)
        {
            var filesTodayFolders = Directory.EnumerateDirectories(directoryPath, "*", SearchOption.AllDirectories)
                .Where(date => Directory.GetCreationTime(date).Date == DateTime.Now.Date)
                .SelectMany(directory => Directory.EnumerateFiles(directory, "*", SearchOption.TopDirectoryOnly))
                .Select(file => new { Name = file, Folder = Path.GetDirectoryName(file) });
            dataGridView.DataSource = filesTodayFolders.ToList();
        }

        private void task5Button_Click(object sender, EventArgs e)
        {
            var foldersFileCount = Directory.EnumerateDirectories(directoryPath, "*", SearchOption.AllDirectories)
                .GroupJoin(Directory.EnumerateFiles(directoryPath, "*", SearchOption.AllDirectories),
                directory => directory,
                Path.GetDirectoryName,
                (directory, files) => new { FolderName = directory, FileCount = files.Count() });
            dataGridView.DataSource = foldersFileCount.ToList();
        }
    }
}
