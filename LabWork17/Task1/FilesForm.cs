namespace Task1
{
    public partial class FilesForm : Form
    {
        FileInfo[] GetFiles(string directoryName)
        {
            DirectoryInfo directory = new DirectoryInfo(directoryName);
            return directory.GetFiles("*", SearchOption.AllDirectories);
        }

        public FilesForm()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
                .Select(file => new { file.Name, file.DirectoryName, Size = file.Length, file.CreationTime })
                .OrderBy(file => file.Name)
                .ThenByDescending(file => file.CreationTime);

            filesDataGridView.DataSource = files.ToList();
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
                .GroupBy(file => file.Extension);

            filesDataGridView.DataSource = files.ToList();
        }

        private void Task3Button_Click(object sender, EventArgs e)
        {
            var extensionCount = GetFiles(directoryTextBox.Text)
                .GroupBy(file => file.Extension)
                .Select(group => new
                {
                    Extension = group.Key,
                    Count = group.Count()
                });

            filesDataGridView.DataSource = extensionCount.ToList();
        }

        private void task4Button_Click(object sender, EventArgs e)
        {
            //Написать LINQ-запрос, возвращающий список файлов с указанным
            //пользователем текстом в имени файла, используя Where()
            var files1 = GetFiles(directoryTextBox.Text);
            var files2 = GetFiles(userTextBox.Text);

            var result = files1.Where(files1 => files2.Contains(files1));

            filesDataGridView.DataSource = result.ToList();
        }
        private void task5Button_Click(object sender, EventArgs e)
        {
            //Написать LINQ-запрос, возвращающий последние 5 файлов, созданные за 
            //текущий день, используя Where() и Take().

            var files = GetFiles(directoryTextBox.Text)
                    .Select(f => new FileInfo(f))
                    .Where(f => f.CreationTime.Date == DateTime.Today)
                    .OrderByDescending(f => f.CreationTime)
                    .Take(5);

            filesDataGridView.DataSource = files.ToList();
        }

        private void task6Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
                .Select(file => new { Name = file.Name, Size = file.Length })
                .ToList();


            filesDataGridView.DataSource = files.ToList();
        }
    }
}
