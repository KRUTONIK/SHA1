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
        // 
        // menuStrip
        // 
        menuStrip.ImageScalingSize = new Size(24, 24);
        menuStrip.Items.AddRange(new ToolStripItem[] { fileMenuItem, helpMenuItem });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Padding = new Padding(9, 3, 0, 3);
        menuStrip.Size = new Size(1177, 35);
        menuStrip.TabIndex = 6;
        // 
        // fileMenuItem
        // 
        fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectFileMenuItem, saveMenuItem, exitMenuItem });
        fileMenuItem.Name = "fileMenuItem";
        fileMenuItem.Size = new Size(69, 29);
        fileMenuItem.Text = "Файл";
        // 
        // selectFileMenuItem
        // 
        selectFileMenuItem.Name = "selectFileMenuItem";
        selectFileMenuItem.Size = new Size(295, 34);
        selectFileMenuItem.Text = "Выбрать файл...";
        selectFileMenuItem.Click += selectFileMenuItem_Click;
        // 
        // saveMenuItem
        // 
        saveMenuItem.Name = "saveMenuItem";
        saveMenuItem.Size = new Size(295, 34);
        saveMenuItem.Text = "Сохранить результат...";
        saveMenuItem.Click += saveMenuItem_Click;
        // 
        // exitMenuItem
        // 
        exitMenuItem.Name = "exitMenuItem";
        exitMenuItem.Size = new Size(295, 34);
        exitMenuItem.Text = "Выход";
        exitMenuItem.Click += exitMenuItem_Click;
        // 
        // helpMenuItem
        // 
        helpMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentInfoMenuItem, variantMenuItem, algorithmMenuItem, aboutMenuItem });
        helpMenuItem.Name = "helpMenuItem";
        helpMenuItem.Size = new Size(97, 29);
        helpMenuItem.Text = "Справка";
        // 
        // studentInfoMenuItem
        // 
        studentInfoMenuItem.Name = "studentInfoMenuItem";
        studentInfoMenuItem.Size = new Size(251, 34);
        studentInfoMenuItem.Text = "Данные студента";
        studentInfoMenuItem.Click += studentInfoMenuItem_Click;
        // 
        // variantMenuItem
        // 
        variantMenuItem.Name = "variantMenuItem";
        variantMenuItem.Size = new Size(251, 34);
        variantMenuItem.Text = "Вариант";
        variantMenuItem.Click += variantMenuItem_Click;
        // 
        // algorithmMenuItem
        // 
        algorithmMenuItem.Name = "algorithmMenuItem";
        algorithmMenuItem.Size = new Size(251, 34);
        algorithmMenuItem.Text = "Алгоритм SHA-1";
        algorithmMenuItem.Click += algorithmMenuItem_Click;
        // 
        // aboutMenuItem
        // 
        aboutMenuItem.Name = "aboutMenuItem";
        aboutMenuItem.Size = new Size(251, 34);
        aboutMenuItem.Text = "О программе";
        aboutMenuItem.Click += aboutMenuItem_Click;
        // 
        // sourceGroupBox
        // 
        sourceGroupBox.Controls.Add(filePathTextBox);
        sourceGroupBox.Controls.Add(selectFileButton);
        sourceGroupBox.Controls.Add(sizeLabel);
        sourceGroupBox.Controls.Add(sizeValueLabel);
        sourceGroupBox.Location = new Point(34, 160);
        sourceGroupBox.Margin = new Padding(4, 5, 4, 5);
        sourceGroupBox.Name = "sourceGroupBox";
        sourceGroupBox.Padding = new Padding(4, 5, 4, 5);
        sourceGroupBox.Size = new Size(1109, 193);
        sourceGroupBox.TabIndex = 1;
        sourceGroupBox.TabStop = false;
        sourceGroupBox.Text = "Исходный файл";
        // 
        // filePathTextBox
        // 
        filePathTextBox.Location = new Point(26, 52);
        filePathTextBox.Margin = new Padding(4, 5, 4, 5);
        filePathTextBox.Name = "filePathTextBox";
        filePathTextBox.ReadOnly = true;
        filePathTextBox.Size = new Size(874, 31);
        filePathTextBox.TabIndex = 0;
        // 
        // selectFileButton
        // 
        selectFileButton.Location = new Point(917, 50);
        selectFileButton.Margin = new Padding(4, 5, 4, 5);
        selectFileButton.Name = "selectFileButton";
        selectFileButton.Size = new Size(166, 42);
        selectFileButton.TabIndex = 1;
        selectFileButton.Text = "Выбрать...";
        selectFileButton.UseVisualStyleBackColor = true;
        selectFileButton.Click += selectFileButton_Click;
        // 
        // sizeLabel
        // 
        sizeLabel.AutoSize = true;
        sizeLabel.Location = new Point(26, 127);
        sizeLabel.Margin = new Padding(4, 0, 4, 0);
        sizeLabel.Name = "sizeLabel";
        sizeLabel.Size = new Size(130, 25);
        sizeLabel.TabIndex = 2;
        sizeLabel.Text = "Размер файла:";
        // 
        // sizeValueLabel
        // 
        sizeValueLabel.AutoSize = true;
        sizeValueLabel.Location = new Point(166, 127);
        sizeValueLabel.Margin = new Padding(4, 0, 4, 0);
        sizeValueLabel.Name = "sizeValueLabel";
        sizeValueLabel.Size = new Size(30, 25);
        sizeValueLabel.TabIndex = 3;
        sizeValueLabel.Text = "—";
        // 
        // calculateButton
        // 
        calculateButton.Location = new Point(34, 382);
        calculateButton.Margin = new Padding(4, 5, 4, 5);
        calculateButton.Name = "calculateButton";
        calculateButton.Size = new Size(263, 60);
        calculateButton.TabIndex = 2;
        calculateButton.Text = "Вычислить SHA-1";
        calculateButton.UseVisualStyleBackColor = true;
        calculateButton.Click += calculateButton_Click;
        // 
        // resultGroupBox
        // 
        resultGroupBox.Controls.Add(hashTextBox);
        resultGroupBox.Controls.Add(copyButton);
        resultGroupBox.Controls.Add(saveButton);
        resultGroupBox.Location = new Point(34, 473);
        resultGroupBox.Margin = new Padding(4, 5, 4, 5);
        resultGroupBox.Name = "resultGroupBox";
        resultGroupBox.Padding = new Padding(4, 5, 4, 5);
        resultGroupBox.Size = new Size(1109, 178);
        resultGroupBox.TabIndex = 3;
        resultGroupBox.TabStop = false;
        resultGroupBox.Text = "Результат";
        // 
        // hashTextBox
        // 
        hashTextBox.Font = new Font("Consolas", 11F);
        hashTextBox.Location = new Point(26, 48);
        hashTextBox.Margin = new Padding(4, 5, 4, 5);
        hashTextBox.Name = "hashTextBox";
        hashTextBox.ReadOnly = true;
        hashTextBox.Size = new Size(840, 33);
        hashTextBox.TabIndex = 0;
        // 
        // copyButton
        // 
        copyButton.Location = new Point(883, 47);
        copyButton.Margin = new Padding(4, 5, 4, 5);
        copyButton.Name = "copyButton";
        copyButton.Size = new Size(200, 45);
        copyButton.TabIndex = 1;
        copyButton.Text = "Копировать";
        copyButton.UseVisualStyleBackColor = true;
        copyButton.Click += copyButton_Click;
        // 
        // saveButton
        // 
        saveButton.Enabled = false;
        saveButton.Location = new Point(26, 108);
        saveButton.Margin = new Padding(4, 5, 4, 5);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(257, 47);
        saveButton.TabIndex = 2;
        saveButton.Text = "Сохранить результат...";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;
        // 
        // studentLabel
        // 
        studentLabel.AutoSize = true;
        studentLabel.Location = new Point(34, 697);
        studentLabel.Margin = new Padding(4, 0, 4, 0);
        studentLabel.Name = "studentLabel";
        studentLabel.Size = new Size(215, 25);
        studentLabel.TabIndex = 4;
        studentLabel.Text = "Покладов Н.Н. ПИбд-42";
        // 
        // variantLabel
        // 
        variantLabel.AutoSize = true;
        variantLabel.Location = new Point(857, 697);
        variantLabel.Margin = new Padding(4, 0, 4, 0);
        variantLabel.Name = "variantLabel";
        variantLabel.Size = new Size(181, 25);
        variantLabel.TabIndex = 5;
        variantLabel.Text = "Вариант 11(3): SHA-1";
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        titleLabel.Location = new Point(34, 80);
        titleLabel.Margin = new Padding(4, 0, 4, 0);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(544, 45);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Вычисление хэш-функции SHA-1";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1177, 757);
        Controls.Add(titleLabel);
        Controls.Add(sourceGroupBox);
        Controls.Add(calculateButton);
        Controls.Add(resultGroupBox);
        Controls.Add(studentLabel);
        Controls.Add(variantLabel);
        Controls.Add(menuStrip);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MainMenuStrip = menuStrip;
        Margin = new Padding(4, 5, 4, 5);
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
