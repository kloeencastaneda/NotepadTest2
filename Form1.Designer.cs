namespace File1
{
    partial class Form1
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.readFileContent = new System.Windows.Forms.RichTextBox();
        this.saveText = new System.Windows.Forms.Button();
        this.readFromFile = new System.Windows.Forms.Button();
        this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
        this.fileOpen = new System.Windows.Forms.Button();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.btnSaveAs = new System.Windows.Forms.Button();
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
        this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // readFileContent
        // 
        this.readFileContent.Location = new System.Drawing.Point(12, 27);
        this.readFileContent.Name = "readFileContent";
        this.readFileContent.Size = new System.Drawing.Size(490, 367);
        this.readFileContent.TabIndex = 0;
        this.readFileContent.Text = "";
        // 
        // saveText
        // 
        this.saveText.Location = new System.Drawing.Point(519, 97);
        this.saveText.Name = "saveText";
        this.saveText.Size = new System.Drawing.Size(138, 23);
        this.saveText.TabIndex = 1;
        this.saveText.Text = "Save Text To File";
        this.saveText.UseVisualStyleBackColor = true;
        this.saveText.Visible = false;
        this.saveText.Click += new System.EventHandler(this.saveText_Click);
        // 
        // readFromFile
        // 
        this.readFromFile.Location = new System.Drawing.Point(519, 135);
        this.readFromFile.Name = "readFromFile";
        this.readFromFile.Size = new System.Drawing.Size(138, 23);
        this.readFromFile.TabIndex = 2;
        this.readFromFile.Text = "Read From File\r\n";
        this.readFromFile.UseVisualStyleBackColor = true;
        this.readFromFile.Visible = false;
        this.readFromFile.Click += new System.EventHandler(this.readFromFile_Click);
        // 
        // fileOpen
        // 
        this.fileOpen.BackColor = System.Drawing.SystemColors.ButtonFace;
        this.fileOpen.Location = new System.Drawing.Point(519, 177);
        this.fileOpen.Name = "fileOpen";
        this.fileOpen.Size = new System.Drawing.Size(138, 23);
        this.fileOpen.TabIndex = 3;
        this.fileOpen.Text = "Open File";
        this.fileOpen.UseVisualStyleBackColor = false;
        this.fileOpen.Visible = false;
        this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(12, 400);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(490, 20);
        this.textBox1.TabIndex = 4;
        // 
        // btnSaveAs
        // 
        this.btnSaveAs.Location = new System.Drawing.Point(519, 219);
        this.btnSaveAs.Name = "btnSaveAs";
        this.btnSaveAs.Size = new System.Drawing.Size(138, 23);
        this.btnSaveAs.TabIndex = 5;
        this.btnSaveAs.Text = "Save As";
        this.btnSaveAs.UseVisualStyleBackColor = true;
        this.btnSaveAs.Visible = false;
        this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
        // 
        // menuStrip1
        // 
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(800, 24);
        this.menuStrip1.TabIndex = 6;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newWindowToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
        this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        this.fileToolStripMenuItem.Text = "File";
        this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
        // 
        // editToolStripMenuItem
        // 
        this.editToolStripMenuItem.Name = "editToolStripMenuItem";
        this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
        this.editToolStripMenuItem.Text = "Edit";
        // 
        // formatToolStripMenuItem
        // 
        this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
        this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
        this.formatToolStripMenuItem.Text = "Format";
        // 
        // viewToolStripMenuItem
        // 
        this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        this.viewToolStripMenuItem.Text = "View";
        // 
        // helpToolStripMenuItem
        // 
        this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        this.helpToolStripMenuItem.Text = "Help";
        // 
        // newToolStripMenuItem
        // 
        this.newToolStripMenuItem.Name = "newToolStripMenuItem";
        this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        this.newToolStripMenuItem.Text = "New";
        this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
        // 
        // newWindowToolStripMenuItem
        // 
        this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
        this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        this.newWindowToolStripMenuItem.Text = "New Window";
        this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
        // 
        // openToolStripMenuItem
        // 
        this.openToolStripMenuItem.Name = "openToolStripMenuItem";
        this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        this.openToolStripMenuItem.Text = "Open";
        this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
        // 
        // saveToolStripMenuItem
        // 
        this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        this.saveToolStripMenuItem.Text = "Save";
        this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
        // 
        // saveAsToolStripMenuItem
        // 
        this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        this.saveAsToolStripMenuItem.Text = "Save As";
        this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
        // 
        // exitToolStripMenuItem
        // 
        this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        this.exitToolStripMenuItem.Text = "Exit";
        this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
        // 
        // vScrollBar1
        // 
        this.vScrollBar1.Location = new System.Drawing.Point(474, 43);
        this.vScrollBar1.Name = "vScrollBar1";
        this.vScrollBar1.Size = new System.Drawing.Size(18, 338);
        this.vScrollBar1.TabIndex = 7;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.vScrollBar1);
        this.Controls.Add(this.fileOpen);
        this.Controls.Add(this.btnSaveAs);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.readFromFile);
        this.Controls.Add(this.saveText);
        this.Controls.Add(this.readFileContent);
        this.Controls.Add(this.menuStrip1);
        this.MainMenuStrip = this.menuStrip1;
        this.Name = "Form1";
        this.Text = "Form1";
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox readFileContent;
    private System.Windows.Forms.Button saveText;
    private System.Windows.Forms.Button readFromFile;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.Button fileOpen;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button btnSaveAs;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    private System.Windows.Forms.VScrollBar vScrollBar1;
}
}