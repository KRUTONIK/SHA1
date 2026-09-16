namespace Sha1FileHasher;

partial class MainForm
{
    private System.ComponentModel.IContainer? components = null;
    private MenuStrip menuStrip = null!;
    private ToolStripMenuItem fileMenuItem = null!;
    private ToolStripMenuItem selectFileMenuItem = null!;
    private ToolStripMenuItem saveMenuItem = null!;
    private ToolStripMenuItem exitMenuItem = null!;
    private ToolStripMenuItem helpMenuItem = null!;
    private ToolStripMenuItem studentInfoMenuItem = null!;
    private ToolStripMenuItem variantMenuItem = null!;
    private ToolStripMenuItem algorithmMenuItem = null!;
    private ToolStripMenuItem aboutMenuItem = null!;
    private GroupBox sourceGroupBox = null!;
    private TextBox filePathTextBox = null!;
    private Button selectFileButton = null!;
    private Label sizeLabel = null!;
    private Label sizeValueLabel = null!;
    private Button calculateButton = null!;
    private GroupBox resultGroupBox = null!;
    private TextBox hashTextBox = null!;
    private Button copyButton = null!;
    private Button saveButton = null!;
    private Label studentLabel = null!;
    private Label variantLabel = null!;
    private Label titleLabel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components is not null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        menuStrip = new MenuStrip();
        fileMenuItem = new ToolStripMenuItem();
        selectFileMenuItem = new ToolStripMenuItem();
        saveMenuItem = new ToolStripMenuItem();
        exitMenuItem = new ToolStripMenuItem();
        helpMenuItem = new ToolStripMenuItem();
        studentInfoMenuItem = new ToolStripMenuItem();
        variantMenuItem = new ToolStripMenuItem();
        algorithmMenuItem = new ToolStripMenuItem();
        aboutMenuItem = new ToolStripMenuItem();
        sourceGroupBox = new GroupBox();
        filePathTextBox = new TextBox();
        selectFileButton = new Button();
        sizeLabel = new Label();
        sizeValueLabel = new Label();
        calculateButton = new Button();
        resultGroupBox = new GroupBox();
        hashTextBox = new TextBox();
        copyButton = new Button();
        saveButton = new Button();
        studentLabel = new Label();
        variantLabel = new Label();
        titleLabel = new Label();
        menuStrip.SuspendLayout();
        sourceGroupBox.SuspendLayout();
        resultGroupBox.SuspendLayout();
        SuspendLayout();

        menuStrip.Items.AddRange(new ToolStripItem[] { fileMenuItem, helpMenuItem });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new Size(824, 24);

        fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectFileMenuItem, saveMenuItem, new ToolStripSeparator(), exitMenuItem });
        fileMenuItem.Text = "Файл";
        selectFileMenuItem.Text = "Выбрать файл...";
        selectFileMenuItem.Click += selectFileMenuItem_Click;
        saveMenuItem.Text = "Сохранить результат...";
        saveMenuItem.Click += saveMenuItem_Click;
        exitMenuItem.Text = "Выход";
        exitMenuItem.Click += exitMenuItem_Click;

        helpMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentInfoMenuItem, variantMenuItem, algorithmMenuItem, aboutMenuItem });
        helpMenuItem.Text = "Справка";
        studentInfoMenuItem.Text = "Данные студента";
        studentInfoMenuItem.Click += studentInfoMenuItem_Click;
        variantMenuItem.Text = "Вариант";
        variantMenuItem.Click += variantMenuItem_Click;
        algorithmMenuItem.Text = "Алгоритм SHA-1";
        algorithmMenuItem.Click += algorithmMenuItem_Click;
        aboutMenuItem.Text = "О программе";
        aboutMenuItem.Click += aboutMenuItem_Click;

        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        titleLabel.Location = new Point(24, 48);
        titleLabel.Text = "Вычисление хэш-функции SHA-1";

        sourceGroupBox.Controls.Add(filePathTextBox);
        sourceGroupBox.Controls.Add(selectFileButton);
        sourceGroupBox.Controls.Add(sizeLabel);
        sourceGroupBox.Controls.Add(sizeValueLabel);
        sourceGroupBox.Location = new Point(24, 96);
        sourceGroupBox.Size = new Size(776, 116);
        sourceGroupBox.Text = "Исходный файл";

        filePathTextBox.Location = new Point(18, 31);
        filePathTextBox.ReadOnly = true;
        filePathTextBox.Size = new Size(613, 23);

        selectFileButton.Location = new Point(642, 30);
        selectFileButton.Size = new Size(116, 25);
        selectFileButton.Text = "Выбрать...";
        selectFileButton.UseVisualStyleBackColor = true;
        selectFileButton.Click += selectFileButton_Click;

        sizeLabel.AutoSize = true;
        sizeLabel.Location = new Point(18, 76);
        sizeLabel.Text = "Размер файла:";

        sizeValueLabel.AutoSize = true;
        sizeValueLabel.Location = new Point(116, 76);
        sizeValueLabel.Text = "—";

        calculateButton.Location = new Point(24, 229);
        calculateButton.Size = new Size(184, 36);
        calculateButton.Text = "Вычислить SHA-1";
        calculateButton.UseVisualStyleBackColor = true;
        calculateButton.Click += calculateButton_Click;

        resultGroupBox.Controls.Add(hashTextBox);
        resultGroupBox.Controls.Add(copyButton);
        resultGroupBox.Controls.Add(saveButton);
        resultGroupBox.Location = new Point(24, 284);
        resultGroupBox.Size = new Size(776, 107);
        resultGroupBox.Text = "Результат";

        hashTextBox.Font = new Font("Consolas", 11F);
        hashTextBox.Location = new Point(18, 29);
        hashTextBox.ReadOnly = true;
        hashTextBox.Size = new Size(589, 25);

        copyButton.Location = new Point(618, 28);
        copyButton.Size = new Size(140, 27);
        copyButton.Text = "Копировать";
        copyButton.UseVisualStyleBackColor = true;
        copyButton.Click += copyButton_Click;

        saveButton.Enabled = false;
        saveButton.Location = new Point(18, 65);
        saveButton.Size = new Size(180, 28);
        saveButton.Text = "Сохранить результат...";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;

        studentLabel.AutoSize = true;
        studentLabel.Location = new Point(24, 418);
        studentLabel.Text = "Покладов Н.Н., ПИбд-42";

        variantLabel.AutoSize = true;
        variantLabel.Location = new Point(600, 418);
        variantLabel.Text = "Вариант 11 → SHA-1";

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(824, 454);
        Controls.Add(titleLabel);
        Controls.Add(sourceGroupBox);
        Controls.Add(calculateButton);
        Controls.Add(resultGroupBox);
        Controls.Add(studentLabel);
        Controls.Add(variantLabel);
        Controls.Add(menuStrip);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MainMenuStrip = menuStrip;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "SHA-1 — хеширование файлов";
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        sourceGroupBox.ResumeLayout(false);
        sourceGroupBox.PerformLayout();
        resultGroupBox.ResumeLayout(false);
        resultGroupBox.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
