namespace Lab4
{
    public partial class ToolsOptionsForm : Form
    {
        public ToolsOptionsForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.OptionsList = new System.Windows.Forms.ListBox();
            this.SearchOptions = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.VisualExperienceGroup = new System.Windows.Forms.GroupBox();
            this.RenderingNotice = new System.Windows.Forms.Label();
            this.UseHardwareGraphicsAcceleration = new System.Windows.Forms.CheckBox();
            this.AutoAdjustingOnClientPerformance = new System.Windows.Forms.CheckBox();
            this.EnableRichVisualExperience = new System.Windows.Forms.CheckBox();
            this.OptimizeRendering = new System.Windows.Forms.CheckBox();
            this.UseCompactMenuAndSearchBar = new System.Windows.Forms.CheckBox();
            this.ApplyTitleCaseStyling = new System.Windows.Forms.CheckBox();
            this.UseWindowsHighContrast = new System.Windows.Forms.CheckBox();
            this.ColorThemeLabel = new System.Windows.Forms.Label();
            this.ColorTheme = new System.Windows.Forms.ComboBox();
            this.ShowStatusBar = new System.Windows.Forms.CheckBox();
            this.AutoHideAffectsOnlyActive = new System.Windows.Forms.CheckBox();
            this.CloseButtonAffectsOnlyActive = new System.Windows.Forms.CheckBox();
            this.WindowMenuItemsLength = new System.Windows.Forms.TextBox();
            this.RecentlyUsedListLength = new System.Windows.Forms.TextBox();
            this.WindowMenuItems = new System.Windows.Forms.Label();
            this.RecentlyUsedItems = new System.Windows.Forms.Label();
            this.OpenOnStartup = new System.Windows.Forms.ComboBox();
            this.OnStartupOpen = new System.Windows.Forms.Label();
            this.VisualExperienceGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsList
            // 
            this.OptionsList.FormattingEnabled = true;
            this.OptionsList.ItemHeight = 15;
            this.OptionsList.Items.AddRange(new object[] {
            "General",
            "Accounts",
            "AutoRecover",
            "Documents",
            "Extensions",
            "Find and Replace",
            "Fonts and Colors",
            "Import and Export Settings",
            "International Settings",
            "Keyboard",
            "Preview Features",
            "Product Updates",
            "Tabs and Windows",
            "Task List",
            "Terminal",
            "Trust Settings"});
            this.OptionsList.Location = new System.Drawing.Point(12, 47);
            this.OptionsList.Name = "OptionsList";
            this.OptionsList.Size = new System.Drawing.Size(274, 229);
            this.OptionsList.TabIndex = 0;
            this.OptionsList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SearchOptions
            // 
            this.SearchOptions.AccessibleDescription = "";
            this.SearchOptions.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SearchOptions.Location = new System.Drawing.Point(12, 12);
            this.SearchOptions.Name = "SearchOptions";
            this.SearchOptions.Size = new System.Drawing.Size(274, 23);
            this.SearchOptions.TabIndex = 1;
            this.SearchOptions.Text = "Search Options (Ctrl + E)";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(558, 482);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(131, 30);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(695, 482);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 30);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // VisualExperienceGroup
            // 
            this.VisualExperienceGroup.Controls.Add(this.RenderingNotice);
            this.VisualExperienceGroup.Controls.Add(this.UseHardwareGraphicsAcceleration);
            this.VisualExperienceGroup.Controls.Add(this.AutoAdjustingOnClientPerformance);
            this.VisualExperienceGroup.Controls.Add(this.EnableRichVisualExperience);
            this.VisualExperienceGroup.Controls.Add(this.OptimizeRendering);
            this.VisualExperienceGroup.Controls.Add(this.UseCompactMenuAndSearchBar);
            this.VisualExperienceGroup.Controls.Add(this.ApplyTitleCaseStyling);
            this.VisualExperienceGroup.Controls.Add(this.UseWindowsHighContrast);
            this.VisualExperienceGroup.Controls.Add(this.ColorThemeLabel);
            this.VisualExperienceGroup.Controls.Add(this.ColorTheme);
            this.VisualExperienceGroup.Location = new System.Drawing.Point(292, 12);
            this.VisualExperienceGroup.Name = "VisualExperienceGroup";
            this.VisualExperienceGroup.Size = new System.Drawing.Size(477, 272);
            this.VisualExperienceGroup.TabIndex = 0;
            this.VisualExperienceGroup.TabStop = false;
            this.VisualExperienceGroup.Text = "Visual Experience";
            // 
            // RenderingNotice
            // 
            this.RenderingNotice.AllowDrop = true;
            this.RenderingNotice.AutoSize = true;
            this.RenderingNotice.Location = new System.Drawing.Point(6, 234);
            this.RenderingNotice.Name = "RenderingNotice";
            this.RenderingNotice.Size = new System.Drawing.Size(406, 30);
            this.RenderingNotice.TabIndex = 10;
            this.RenderingNotice.Text = "Visual Studio is currenctly using hardware-accelerated rendering. The visual \r\nex" +
    "perience settings are based on system capabilities";
            this.RenderingNotice.Click += new System.EventHandler(this.label2_Click);
            // 
            // UseHardwareGraphicsAcceleration
            // 
            this.UseHardwareGraphicsAcceleration.AutoSize = true;
            this.UseHardwareGraphicsAcceleration.Checked = true;
            this.UseHardwareGraphicsAcceleration.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseHardwareGraphicsAcceleration.Location = new System.Drawing.Point(19, 212);
            this.UseHardwareGraphicsAcceleration.Name = "UseHardwareGraphicsAcceleration";
            this.UseHardwareGraphicsAcceleration.Size = new System.Drawing.Size(263, 19);
            this.UseHardwareGraphicsAcceleration.TabIndex = 9;
            this.UseHardwareGraphicsAcceleration.Text = "Use hardware graphic acceleration if possible";
            this.UseHardwareGraphicsAcceleration.UseVisualStyleBackColor = true;
            // 
            // AutoAdjustingOnClientPerformance
            // 
            this.AutoAdjustingOnClientPerformance.AutoSize = true;
            this.AutoAdjustingOnClientPerformance.Checked = true;
            this.AutoAdjustingOnClientPerformance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoAdjustingOnClientPerformance.Enabled = false;
            this.AutoAdjustingOnClientPerformance.Location = new System.Drawing.Point(6, 162);
            this.AutoAdjustingOnClientPerformance.Name = "AutoAdjustingOnClientPerformance";
            this.AutoAdjustingOnClientPerformance.Size = new System.Drawing.Size(382, 19);
            this.AutoAdjustingOnClientPerformance.TabIndex = 7;
            this.AutoAdjustingOnClientPerformance.Text = "Automatically adjust visual experience based on client performance";
            this.AutoAdjustingOnClientPerformance.UseVisualStyleBackColor = true;
            // 
            // EnableRichVisualExperience
            // 
            this.EnableRichVisualExperience.AutoSize = true;
            this.EnableRichVisualExperience.Location = new System.Drawing.Point(19, 187);
            this.EnableRichVisualExperience.Name = "EnableRichVisualExperience";
            this.EnableRichVisualExperience.Size = new System.Drawing.Size(209, 19);
            this.EnableRichVisualExperience.TabIndex = 8;
            this.EnableRichVisualExperience.Text = "Enable rich client visual experience";
            this.EnableRichVisualExperience.UseVisualStyleBackColor = true;
            this.EnableRichVisualExperience.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // OptimizeRendering
            // 
            this.OptimizeRendering.AutoSize = true;
            this.OptimizeRendering.Checked = true;
            this.OptimizeRendering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OptimizeRendering.Location = new System.Drawing.Point(6, 137);
            this.OptimizeRendering.Name = "OptimizeRendering";
            this.OptimizeRendering.Size = new System.Drawing.Size(430, 19);
            this.OptimizeRendering.TabIndex = 6;
            this.OptimizeRendering.Text = "Optimize Rendering for screens with different pizel densities (requires restart)";
            this.OptimizeRendering.UseVisualStyleBackColor = true;
            // 
            // UseCompactMenuAndSearchBar
            // 
            this.UseCompactMenuAndSearchBar.AutoSize = true;
            this.UseCompactMenuAndSearchBar.Checked = true;
            this.UseCompactMenuAndSearchBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseCompactMenuAndSearchBar.Location = new System.Drawing.Point(6, 112);
            this.UseCompactMenuAndSearchBar.Name = "UseCompactMenuAndSearchBar";
            this.UseCompactMenuAndSearchBar.Size = new System.Drawing.Size(303, 19);
            this.UseCompactMenuAndSearchBar.TabIndex = 5;
            this.UseCompactMenuAndSearchBar.Text = "Use Compact Menu And Search Bar (requires restart)";
            this.UseCompactMenuAndSearchBar.UseVisualStyleBackColor = true;
            // 
            // ApplyTitleCaseStyling
            // 
            this.ApplyTitleCaseStyling.AutoSize = true;
            this.ApplyTitleCaseStyling.Location = new System.Drawing.Point(6, 87);
            this.ApplyTitleCaseStyling.Name = "ApplyTitleCaseStyling";
            this.ApplyTitleCaseStyling.Size = new System.Drawing.Size(212, 19);
            this.ApplyTitleCaseStyling.TabIndex = 4;
            this.ApplyTitleCaseStyling.Text = "Apply title case styling to menu bar";
            this.ApplyTitleCaseStyling.UseVisualStyleBackColor = true;
            this.ApplyTitleCaseStyling.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // UseWindowsHighContrast
            // 
            this.UseWindowsHighContrast.AutoSize = true;
            this.UseWindowsHighContrast.Checked = true;
            this.UseWindowsHighContrast.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseWindowsHighContrast.Location = new System.Drawing.Point(6, 62);
            this.UseWindowsHighContrast.Name = "UseWindowsHighContrast";
            this.UseWindowsHighContrast.Size = new System.Drawing.Size(303, 19);
            this.UseWindowsHighContrast.TabIndex = 3;
            this.UseWindowsHighContrast.Text = "Use Windows High Contrast setings (requires restart)";
            this.UseWindowsHighContrast.UseVisualStyleBackColor = true;
            // 
            // ColorThemeLabel
            // 
            this.ColorThemeLabel.AutoSize = true;
            this.ColorThemeLabel.Location = new System.Drawing.Point(6, 29);
            this.ColorThemeLabel.Name = "ColorThemeLabel";
            this.ColorThemeLabel.Size = new System.Drawing.Size(75, 15);
            this.ColorThemeLabel.TabIndex = 2;
            this.ColorThemeLabel.Text = "Color Theme";
            this.ColorThemeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ColorTheme
            // 
            this.ColorTheme.Enabled = false;
            this.ColorTheme.FormattingEnabled = true;
            this.ColorTheme.Location = new System.Drawing.Point(123, 26);
            this.ColorTheme.Name = "ColorTheme";
            this.ColorTheme.Size = new System.Drawing.Size(109, 23);
            this.ColorTheme.TabIndex = 1;
            this.ColorTheme.Text = "Dark";
            // 
            // ShowStatusBar
            // 
            this.ShowStatusBar.AutoSize = true;
            this.ShowStatusBar.Checked = true;
            this.ShowStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowStatusBar.Location = new System.Drawing.Point(298, 358);
            this.ShowStatusBar.Name = "ShowStatusBar";
            this.ShowStatusBar.Size = new System.Drawing.Size(198, 19);
            this.ShowStatusBar.TabIndex = 5;
            this.ShowStatusBar.Text = "Show status bar (requires restart)";
            this.ShowStatusBar.UseVisualStyleBackColor = true;
            // 
            // AutoHideAffectsOnlyActive
            // 
            this.AutoHideAffectsOnlyActive.AutoSize = true;
            this.AutoHideAffectsOnlyActive.Location = new System.Drawing.Point(298, 408);
            this.AutoHideAffectsOnlyActive.Name = "AutoHideAffectsOnlyActive";
            this.AutoHideAffectsOnlyActive.Size = new System.Drawing.Size(286, 19);
            this.AutoHideAffectsOnlyActive.TabIndex = 6;
            this.AutoHideAffectsOnlyActive.Text = "Auto Hide button affects active tool window only";
            this.AutoHideAffectsOnlyActive.UseVisualStyleBackColor = true;
            // 
            // CloseButtonAffectsOnlyActive
            // 
            this.CloseButtonAffectsOnlyActive.AutoSize = true;
            this.CloseButtonAffectsOnlyActive.Checked = true;
            this.CloseButtonAffectsOnlyActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CloseButtonAffectsOnlyActive.Location = new System.Drawing.Point(298, 383);
            this.CloseButtonAffectsOnlyActive.Name = "CloseButtonAffectsOnlyActive";
            this.CloseButtonAffectsOnlyActive.Size = new System.Drawing.Size(261, 19);
            this.CloseButtonAffectsOnlyActive.TabIndex = 7;
            this.CloseButtonAffectsOnlyActive.Text = "Close button affects active tool window only";
            this.CloseButtonAffectsOnlyActive.UseVisualStyleBackColor = true;
            // 
            // WindowMenuItemsLength
            // 
            this.WindowMenuItemsLength.Location = new System.Drawing.Point(549, 299);
            this.WindowMenuItemsLength.Name = "WindowMenuItemsLength";
            this.WindowMenuItemsLength.Size = new System.Drawing.Size(39, 23);
            this.WindowMenuItemsLength.TabIndex = 8;
            this.WindowMenuItemsLength.Text = "10";
            // 
            // RecentlyUsedListLength
            // 
            this.RecentlyUsedListLength.Location = new System.Drawing.Point(549, 328);
            this.RecentlyUsedListLength.Name = "RecentlyUsedListLength";
            this.RecentlyUsedListLength.Size = new System.Drawing.Size(39, 23);
            this.RecentlyUsedListLength.TabIndex = 9;
            this.RecentlyUsedListLength.Text = "7";
            // 
            // WindowMenuItems
            // 
            this.WindowMenuItems.AutoSize = true;
            this.WindowMenuItems.Location = new System.Drawing.Point(292, 299);
            this.WindowMenuItems.Name = "WindowMenuItems";
            this.WindowMenuItems.Size = new System.Drawing.Size(175, 15);
            this.WindowMenuItems.TabIndex = 10;
            this.WindowMenuItems.Text = "Items to show in Window menu";
            // 
            // RecentlyUsedItems
            // 
            this.RecentlyUsedItems.AutoSize = true;
            this.RecentlyUsedItems.Location = new System.Drawing.Point(292, 328);
            this.RecentlyUsedItems.Name = "RecentlyUsedItems";
            this.RecentlyUsedItems.Size = new System.Drawing.Size(209, 15);
            this.RecentlyUsedItems.TabIndex = 11;
            this.RecentlyUsedItems.Text = "Items to show in recently used files list";
            // 
            // OpenOnStartup
            // 
            this.OpenOnStartup.FormattingEnabled = true;
            this.OpenOnStartup.Location = new System.Drawing.Point(417, 438);
            this.OpenOnStartup.Name = "OpenOnStartup";
            this.OpenOnStartup.Size = new System.Drawing.Size(157, 23);
            this.OpenOnStartup.TabIndex = 12;
            this.OpenOnStartup.Text = "Start Window";
            // 
            // OnStartupOpen
            // 
            this.OnStartupOpen.AutoSize = true;
            this.OnStartupOpen.Location = new System.Drawing.Point(298, 441);
            this.OnStartupOpen.Name = "OnStartupOpen";
            this.OnStartupOpen.Size = new System.Drawing.Size(97, 15);
            this.OnStartupOpen.TabIndex = 13;
            this.OnStartupOpen.Text = "On Startup open:";
            // 
            // ToolsOptionsForm
            // 
            this.ClientSize = new System.Drawing.Size(781, 519);
            this.Controls.Add(this.OnStartupOpen);
            this.Controls.Add(this.OpenOnStartup);
            this.Controls.Add(this.RecentlyUsedItems);
            this.Controls.Add(this.WindowMenuItems);
            this.Controls.Add(this.RecentlyUsedListLength);
            this.Controls.Add(this.WindowMenuItemsLength);
            this.Controls.Add(this.CloseButtonAffectsOnlyActive);
            this.Controls.Add(this.AutoHideAffectsOnlyActive);
            this.Controls.Add(this.ShowStatusBar);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.VisualExperienceGroup);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SearchOptions);
            this.Controls.Add(this.OptionsList);
            this.Name = "ToolsOptionsForm";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VisualExperienceGroup.ResumeLayout(false);
            this.VisualExperienceGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ListBox OptionsList;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private TextBox SearchOptions;
        private Button CancelButton;
        private Button OKButton;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private GroupBox VisualExperienceGroup;
        private Label RenderingNotice;
        private CheckBox UseHardwareGraphicsAcceleration;
        private CheckBox AutoAdjustingOnClientPerformance;
        private CheckBox EnableRichVisualExperience;
        private CheckBox OptimizeRendering;
        private CheckBox UseCompactMenuAndSearchBar;
        private CheckBox ApplyTitleCaseStyling;
        private CheckBox UseWindowsHighContrast;
        private Label ColorThemeLabel;
        private ComboBox ColorTheme;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private CheckBox ShowStatusBar;
        private CheckBox AutoHideAffectsOnlyActive;
        private CheckBox CloseButtonAffectsOnlyActive;
        private TextBox WindowMenuItemsLength;
        private TextBox RecentlyUsedListLength;
        private Label WindowMenuItems;
        private Label RecentlyUsedItems;
        private ComboBox OpenOnStartup;
        private Label OnStartupOpen;
    }
}