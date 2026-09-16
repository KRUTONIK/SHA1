namespace Sha1FileHasher;

public partial class MainForm : Form
{
    private FileHashResult? currentResult;

    public MainForm()
    {
        InitializeComponent();
    }

    private void SelectFile()
    {
        using var dialog = new OpenFileDialog
        {
            Title = "Выберите файл для вычисления SHA-1",
            Filter = "Все файлы (*.*)|*.*",
            CheckFileExists = true
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
            return;

        filePathTextBox.Text = dialog.FileName;
        hashTextBox.Clear();
        sizeValueLabel.Text = new FileInfo(dialog.FileName).Length + " байт";
        currentResult = null;
        saveButton.Enabled = false;
    }

    private void CalculateHash()
    {
        try
        {
            currentResult = FileHashService.Calculate(filePathTextBox.Text);
            hashTextBox.Text = currentResult.Hash;
            sizeValueLabel.Text = currentResult.FileSize + " байт";
            saveButton.Enabled = true;

            if (currentResult.FileSize < 1024)
            {
                MessageBox.Show(
                    this,
                    "Для демонстрации рекомендуется использовать файл размером не менее 1 КБ.",
                    "Информация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SaveResult()
    {
        if (currentResult is null)
            return;

        using var dialog = new SaveFileDialog
        {
            Title = "Сохранить результат хеширования",
            Filter = "Текстовый файл (*.txt)|*.txt|Все файлы (*.*)|*.*",
            FileName = Path.GetFileName(currentResult.FilePath) + ".sha1.txt"
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
            return;

        try
        {
            FileHashService.SaveResult(currentResult, dialog.FileName);
            MessageBox.Show(this, "Результат сохранён.", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CopyHash()
    {
        if (!string.IsNullOrWhiteSpace(hashTextBox.Text))
            Clipboard.SetText(hashTextBox.Text);
    }

    private void studentInfoMenuItem_Click(object? sender, EventArgs e) =>
        MessageBox.Show(
            this,
            "Покладов Н.Н.\nГруппа ПИбд-42\nДисциплина: «Информационная безопасность»",
            "Данные студента",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

    private void variantMenuItem_Click(object? sender, EventArgs e) =>
        MessageBox.Show(
            this,
            "Номер варианта: 11(3)\nХэш-функция: SHA-1",
            "Вариант",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

    private void algorithmMenuItem_Click(object? sender, EventArgs e) =>
        MessageBox.Show(
            this,
            "SHA-1 формирует 160-битный хэш. Сообщение дополняется до длины, кратной 512 битам, делится на 512-битные блоки, а каждый блок обрабатывается 80 раундами над пятью 32-битными словами состояния. В программе алгоритм реализован самостоятельно.",
            "Алгоритм SHA-1",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

    private void aboutMenuItem_Click(object? sender, EventArgs e) =>
        MessageBox.Show(
            this,
            "Программа вычисляет SHA-1 для файла любого формата и позволяет сохранить полученное значение в текстовый файл.\n\nSHA-1 считается криптографически устаревшим из-за известных коллизий.",
            "О программе",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

    private void selectFileButton_Click(object? sender, EventArgs e) => SelectFile();
    private void calculateButton_Click(object? sender, EventArgs e) => CalculateHash();
    private void saveButton_Click(object? sender, EventArgs e) => SaveResult();
    private void copyButton_Click(object? sender, EventArgs e) => CopyHash();
    private void selectFileMenuItem_Click(object? sender, EventArgs e) => SelectFile();
    private void saveMenuItem_Click(object? sender, EventArgs e) => SaveResult();
    private void exitMenuItem_Click(object? sender, EventArgs e) => Close();
}
