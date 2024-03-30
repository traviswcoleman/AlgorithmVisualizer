namespace Visualizer;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        MainPanel = new Panel();
        MainMenu = new MenuStrip();
        FileMenu = new ToolStripMenuItem();
        MenuFileExit = new ToolStripMenuItem();
        CodingChallengesMenu = new ToolStripMenuItem();
        statusStrip1 = new StatusStrip();
        StatusLabel = new ToolStripStatusLabel();
        ContentSplitter = new SplitContainer();
        ControlPanel = new FlowLayoutPanel();
        MainMenu.SuspendLayout();
        statusStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)ContentSplitter).BeginInit();
        ContentSplitter.Panel1.SuspendLayout();
        ContentSplitter.Panel2.SuspendLayout();
        ContentSplitter.SuspendLayout();
        SuspendLayout();
        // 
        // MainPanel
        // 
        MainPanel.Dock = DockStyle.Fill;
        MainPanel.Location = new Point(0, 0);
        MainPanel.Name = "MainPanel";
        MainPanel.Size = new Size(636, 595);
        MainPanel.TabIndex = 0;
        MainPanel.Paint += MainPanel_Paint;
        // 
        // MainMenu
        // 
        MainMenu.Items.AddRange(new ToolStripItem[] { FileMenu, CodingChallengesMenu });
        MainMenu.Location = new Point(0, 0);
        MainMenu.Name = "MainMenu";
        MainMenu.Size = new Size(831, 24);
        MainMenu.TabIndex = 1;
        MainMenu.Text = "menuStrip1";
        // 
        // FileMenu
        // 
        FileMenu.DropDownItems.AddRange(new ToolStripItem[] { MenuFileExit });
        FileMenu.Name = "FileMenu";
        FileMenu.Size = new Size(37, 20);
        FileMenu.Text = "&File";
        // 
        // MenuFileExit
        // 
        MenuFileExit.Name = "MenuFileExit";
        MenuFileExit.ShortcutKeys = Keys.Alt | Keys.F4;
        MenuFileExit.Size = new Size(135, 22);
        MenuFileExit.Text = "E&xit";
        MenuFileExit.Click += MenuFileExit_Click;
        // 
        // CodingChallengesMenu
        // 
        CodingChallengesMenu.Name = "CodingChallengesMenu";
        CodingChallengesMenu.Size = new Size(119, 20);
        CodingChallengesMenu.Text = "&Coding Challenges";
        // 
        // statusStrip1
        // 
        statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabel });
        statusStrip1.Location = new Point(0, 619);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(831, 22);
        statusStrip1.TabIndex = 2;
        statusStrip1.Text = "statusStrip1";
        // 
        // StatusLabel
        // 
        StatusLabel.Name = "StatusLabel";
        StatusLabel.Size = new Size(27, 17);
        StatusLabel.Text = "Test";
        // 
        // ContentSplitter
        // 
        ContentSplitter.Dock = DockStyle.Fill;
        ContentSplitter.Location = new Point(0, 24);
        ContentSplitter.Name = "ContentSplitter";
        // 
        // ContentSplitter.Panel1
        // 
        ContentSplitter.Panel1.Controls.Add(MainPanel);
        // 
        // ContentSplitter.Panel2
        // 
        ContentSplitter.Panel2.Controls.Add(ControlPanel);
        ContentSplitter.Size = new Size(831, 595);
        ContentSplitter.SplitterDistance = 636;
        ContentSplitter.TabIndex = 4;
        ContentSplitter.SplitterMoved += ContentSplitter_SplitterMoved;
        // 
        // ControlPanel
        // 
        ControlPanel.Dock = DockStyle.Fill;
        ControlPanel.Location = new Point(0, 0);
        ControlPanel.Name = "ControlPanel";
        ControlPanel.Padding = new Padding(5);
        ControlPanel.Size = new Size(191, 595);
        ControlPanel.TabIndex = 0;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(831, 641);
        Controls.Add(ContentSplitter);
        Controls.Add(statusStrip1);
        Controls.Add(MainMenu);
        DoubleBuffered = true;
        Margin = new Padding(3, 2, 3, 2);
        Name = "MainForm";
        Text = "Algorithm Visualizer";
        WindowState = FormWindowState.Maximized;
        Load += MainForm_Load;
        ResizeEnd += MainForm_ResizeEnd;
        MainMenu.ResumeLayout(false);
        MainMenu.PerformLayout();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ContentSplitter.Panel1.ResumeLayout(false);
        ContentSplitter.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)ContentSplitter).EndInit();
        ContentSplitter.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel MainPanel;
    private MenuStrip MainMenu;
    private ToolStripMenuItem FileMenu;
    private ToolStripMenuItem MenuFileExit;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel StatusLabel;
    private ToolStripMenuItem CodingChallengesMenu;
    private SplitContainer ContentSplitter;
    private FlowLayoutPanel ControlPanel;
}
