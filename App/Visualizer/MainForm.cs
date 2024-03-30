using AlgorithmVisualizer.Business.CodingChallenges;
using AlgorithmVisualizer.Contracts.Models;

namespace Visualizer;

public partial class MainForm : Form
{
    private IDrawable? _activeDrawable = null;
    private Graphics? _panelGraphics;

    long _lastTick = DateTime.Now.Ticks;
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainPanel_Paint(object sender, PaintEventArgs e)
    {
        if (_activeDrawable is not null)
        {
            if (_panelGraphics is null) SetupGraphics();
            bool finished = _activeDrawable.Draw(_panelGraphics!, TimeSpan.FromTicks(DateTime.Now.Ticks - _lastTick));
            if (!finished)
            {
                _lastTick = DateTime.Now.Ticks;
                Thread.Sleep(50); //TODO: update this to get an actual frame rate
                MainPanel.Invalidate(true);
            }
        }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        ContentSplitter.SplitterDistance = (int)(this.Width * .8);
        LoadCodingChallenges();
    }

    private void ClearChecks()
    {
        foreach (ToolStripMenuItem menu in CodingChallengesMenu.DropDownItems)
        {
            menu.Checked = false;
        }
    }

    private void LoadCodingChallenges()
    {
        foreach (string challenge in ChallengesFactory.ListCodingChallenges())
        {
            ToolStripMenuItem challengeMenu = new(challenge)
            {
                Tag = challenge
            };
            challengeMenu.Click += ChallengeMenuItem_Click;
            CodingChallengesMenu.DropDownItems.Add(challengeMenu);
        }
    }

    private void ChallengeMenuItem_Click(object? sender, EventArgs e)
    {
        if (sender is not ToolStripMenuItem challengeMenuItem) return;

        ClearChecks();

        challengeMenuItem.Checked = true;

        if (challengeMenuItem.Tag is not string tag) return;

        if (_panelGraphics is null)
            SetupGraphics();

        StartChallenge(tag);
    }

    private void StartChallenge(string tag)
    {
        _activeDrawable = ChallengesFactory.GetDrawable(tag);
        if (_activeDrawable is null) return;
        if (_panelGraphics is null) SetupGraphics();

        MainPanel.BackColor = _activeDrawable.GetBackgroundColor();
        _activeDrawable.Setup(_panelGraphics!);
        _lastTick = DateTime.Now.Ticks;
        MainPanel.Invalidate();
    }

    private void MenuFileExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void SetupGraphics()
    {
        _panelGraphics = MainPanel.CreateGraphics();
        _panelGraphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
        _panelGraphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
    }

    private void MainForm_ResizeEnd(object sender, EventArgs e)
    {
        SetupGraphics();
        MainPanel.Invalidate();
    }

    private void ContentSplitter_SplitterMoved(object sender, SplitterEventArgs e)
    {
        SetupGraphics();
        MainPanel.Invalidate();
    }
}
