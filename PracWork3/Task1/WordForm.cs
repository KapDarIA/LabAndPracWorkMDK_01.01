using Word = Microsoft.Office.Interop.Word;
namespace Task1
{
    public partial class WordForm : Form
    {
        public WordForm()
        {
            InitializeComponent();
        }

        private void TemplateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(infoTextBox.Text) || String.IsNullOrEmpty(rowsTextBox.Text))
            {
                MessageBox.Show("¬ведите корректный текст и количество строк!");
                return;
            }
            if (!double.TryParse(rowsTextBox.Text, out var parsedNumber))
            {
                MessageBox.Show("¬ведите правильное число!");
                return;
            }

            var app = new Word.Application();
            app.Visible = true;
            var document = app.Documents.Add(Path.Combine(Environment.CurrentDirectory, "Ўаблон.docx"));
            string findText = "“екст»зѕол€¬вода";
            for (int i = 0; i < infoTextBox.Text.Length / 254; i += 254)
            {
                document.Content.Find.Execute(FindText: findText, ReplaceWith: infoTextBox.Text);
            }
            document.Content.Find.Execute(FindText: "дд.мм.гггг чч:мм", ReplaceWith: DateTime.Now);

            var paragraph = document.Paragraphs.Add();
            var range = paragraph.Range;
            var table = document.Tables[1];
            int rows = Convert.ToInt32(rowsTextBox.Text);
            for (int i = 1; i < rows; i++)
            {
                table.Rows.Add();
                table.Cell(i+1, 1).Range.Text = i.ToString();
            }
            table.Cell(rows+1, 1).Range.Text = rows.ToString();
        }
    }
}
