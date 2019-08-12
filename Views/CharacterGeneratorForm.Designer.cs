namespace COMP123_S2019_FinalTest.Views
{
    partial class CharacterGeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterGeneratorForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.IdentityPage = new System.Windows.Forms.TabPage();
            this.IdentityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.FirstNameLable = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CharacterNameLabel = new System.Windows.Forms.Label();
            this.LastNameLable = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.GenerateNameButton = new System.Windows.Forms.Button();
            this.AbilitiesPage = new System.Windows.Forms.TabPage();
            this.InventoryPage = new System.Windows.Forms.TabPage();
            this.CharacterSheetPage = new System.Windows.Forms.TabPage();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.AbilitiesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.ConstritutionLabel = new System.Windows.Forms.Label();
            this.WisdomLabel = new System.Windows.Forms.Label();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.IntelligenceLabel = new System.Windows.Forms.Label();
            this.CharismaLabel = new System.Windows.Forms.Label();
            this.GenerateAbilitiesButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StrengthDataLabel = new System.Windows.Forms.Label();
            this.DexterityDataLabel = new System.Windows.Forms.Label();
            this.ConstitutionLabel = new System.Windows.Forms.Label();
            this.IntelligenceDataLabel = new System.Windows.Forms.Label();
            this.WisdomDataLabel = new System.Windows.Forms.Label();
            this.CharismaDataLabel = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.IdentityPage.SuspendLayout();
            this.IdentityTableLayoutPanel.SuspendLayout();
            this.AbilitiesPage.SuspendLayout();
            this.CharacterSheetPage.SuspendLayout();
            this.AbilitiesTableLayoutPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.IdentityPage);
            this.mainTabControl.Controls.Add(this.AbilitiesPage);
            this.mainTabControl.Controls.Add(this.InventoryPage);
            this.mainTabControl.Controls.Add(this.CharacterSheetPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(778, 462);
            this.mainTabControl.TabIndex = 1;
            // 
            // IdentityPage
            // 
            this.IdentityPage.Controls.Add(this.IdentityTableLayoutPanel);
            this.IdentityPage.Location = new System.Drawing.Point(4, 41);
            this.IdentityPage.Name = "IdentityPage";
            this.IdentityPage.Padding = new System.Windows.Forms.Padding(3);
            this.IdentityPage.Size = new System.Drawing.Size(770, 417);
            this.IdentityPage.TabIndex = 0;
            this.IdentityPage.Text = "Identity";
            this.IdentityPage.UseVisualStyleBackColor = true;
            // 
            // IdentityTableLayoutPanel
            // 
            this.IdentityTableLayoutPanel.ColumnCount = 4;
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPanel.Controls.Add(this.FirstNameDataLabel, 1, 1);
            this.IdentityTableLayoutPanel.Controls.Add(this.FirstNameLable, 0, 1);
            this.IdentityTableLayoutPanel.Controls.Add(this.textBox1, 1, 0);
            this.IdentityTableLayoutPanel.Controls.Add(this.CharacterNameLabel, 0, 0);
            this.IdentityTableLayoutPanel.Controls.Add(this.LastNameLable, 0, 2);
            this.IdentityTableLayoutPanel.Controls.Add(this.LastNameDataLabel, 1, 2);
            this.IdentityTableLayoutPanel.Controls.Add(this.GenerateNameButton, 2, 4);
            this.IdentityTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.IdentityTableLayoutPanel.Name = "IdentityTableLayoutPanel";
            this.IdentityTableLayoutPanel.RowCount = 5;
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.IdentityTableLayoutPanel.Size = new System.Drawing.Size(764, 311);
            this.IdentityTableLayoutPanel.TabIndex = 0;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameDataLabel.AutoSize = true;
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayoutPanel.SetColumnSpan(this.FirstNameDataLabel, 3);
            this.FirstNameDataLabel.Location = new System.Drawing.Point(232, 62);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(529, 62);
            this.FirstNameDataLabel.TabIndex = 4;
            // 
            // FirstNameLable
            // 
            this.FirstNameLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLable.AutoSize = true;
            this.FirstNameLable.Location = new System.Drawing.Point(3, 62);
            this.FirstNameLable.Name = "FirstNameLable";
            this.FirstNameLable.Size = new System.Drawing.Size(223, 62);
            this.FirstNameLable.TabIndex = 2;
            this.FirstNameLable.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentityTableLayoutPanel.SetColumnSpan(this.textBox1, 3);
            this.textBox1.Location = new System.Drawing.Point(232, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(529, 56);
            this.textBox1.TabIndex = 0;
            // 
            // CharacterNameLabel
            // 
            this.CharacterNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharacterNameLabel.AutoSize = true;
            this.CharacterNameLabel.Location = new System.Drawing.Point(3, 0);
            this.CharacterNameLabel.Name = "CharacterNameLabel";
            this.CharacterNameLabel.Size = new System.Drawing.Size(223, 62);
            this.CharacterNameLabel.TabIndex = 1;
            this.CharacterNameLabel.Text = "Character";
            // 
            // LastNameLable
            // 
            this.LastNameLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLable.AutoSize = true;
            this.LastNameLable.Location = new System.Drawing.Point(3, 124);
            this.LastNameLable.Name = "LastNameLable";
            this.LastNameLable.Size = new System.Drawing.Size(223, 62);
            this.LastNameLable.TabIndex = 3;
            this.LastNameLable.Text = "Last Name";
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameDataLabel.AutoSize = true;
            this.LastNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayoutPanel.SetColumnSpan(this.LastNameDataLabel, 3);
            this.LastNameDataLabel.Location = new System.Drawing.Point(232, 124);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(529, 62);
            this.LastNameDataLabel.TabIndex = 4;
            this.LastNameDataLabel.Click += new System.EventHandler(this.FirstNameDataLabel_Click);
            // 
            // GenerateNameButton
            // 
            this.GenerateNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentityTableLayoutPanel.SetColumnSpan(this.GenerateNameButton, 2);
            this.GenerateNameButton.Location = new System.Drawing.Point(384, 251);
            this.GenerateNameButton.Name = "GenerateNameButton";
            this.GenerateNameButton.Size = new System.Drawing.Size(377, 57);
            this.GenerateNameButton.TabIndex = 5;
            this.GenerateNameButton.Text = "Generate Name";
            this.GenerateNameButton.UseVisualStyleBackColor = true;
            // 
            // AbilitiesPage
            // 
            this.AbilitiesPage.Controls.Add(this.AbilitiesTableLayoutPanel);
            this.AbilitiesPage.Location = new System.Drawing.Point(4, 41);
            this.AbilitiesPage.Name = "AbilitiesPage";
            this.AbilitiesPage.Padding = new System.Windows.Forms.Padding(3);
            this.AbilitiesPage.Size = new System.Drawing.Size(770, 417);
            this.AbilitiesPage.TabIndex = 1;
            this.AbilitiesPage.Text = "Abilities";
            this.AbilitiesPage.UseVisualStyleBackColor = true;
            // 
            // InventoryPage
            // 
            this.InventoryPage.Location = new System.Drawing.Point(4, 41);
            this.InventoryPage.Name = "InventoryPage";
            this.InventoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryPage.Size = new System.Drawing.Size(770, 417);
            this.InventoryPage.TabIndex = 2;
            this.InventoryPage.Text = "Inventory";
            this.InventoryPage.UseVisualStyleBackColor = true;
            // 
            // CharacterSheetPage
            // 
            this.CharacterSheetPage.Controls.Add(this.toolStrip1);
            this.CharacterSheetPage.Controls.Add(this.menuStrip1);
            this.CharacterSheetPage.Location = new System.Drawing.Point(4, 41);
            this.CharacterSheetPage.Name = "CharacterSheetPage";
            this.CharacterSheetPage.Padding = new System.Windows.Forms.Padding(3);
            this.CharacterSheetPage.Size = new System.Drawing.Size(770, 417);
            this.CharacterSheetPage.TabIndex = 3;
            this.CharacterSheetPage.Text = "Character Sheet";
            this.CharacterSheetPage.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 476);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(119, 56);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(647, 476);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(119, 56);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // AbilitiesTableLayoutPanel
            // 
            this.AbilitiesTableLayoutPanel.ColumnCount = 4;
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiesTableLayoutPanel.Controls.Add(this.CharismaDataLabel, 1, 5);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.WisdomDataLabel, 1, 4);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.IntelligenceDataLabel, 1, 3);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.ConstitutionLabel, 1, 2);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.DexterityDataLabel, 1, 1);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.StrengthDataLabel, 1, 0);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.DexterityLabel, 0, 1);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.StrengthLabel, 0, 0);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.ConstritutionLabel, 0, 2);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.IntelligenceLabel, 0, 3);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.WisdomLabel, 0, 4);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.CharismaLabel, 0, 5);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.GenerateAbilitiesButton, 2, 7);
            this.AbilitiesTableLayoutPanel.Location = new System.Drawing.Point(9, 7);
            this.AbilitiesTableLayoutPanel.Name = "AbilitiesTableLayoutPanel";
            this.AbilitiesTableLayoutPanel.RowCount = 8;
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AbilitiesTableLayoutPanel.Size = new System.Drawing.Size(753, 366);
            this.AbilitiesTableLayoutPanel.TabIndex = 0;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Location = new System.Drawing.Point(3, 0);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(182, 45);
            this.StrengthLabel.TabIndex = 0;
            this.StrengthLabel.Text = "Strength";
            this.StrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConstritutionLabel
            // 
            this.ConstritutionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConstritutionLabel.AutoSize = true;
            this.ConstritutionLabel.Location = new System.Drawing.Point(3, 90);
            this.ConstritutionLabel.Name = "ConstritutionLabel";
            this.ConstritutionLabel.Size = new System.Drawing.Size(182, 45);
            this.ConstritutionLabel.TabIndex = 1;
            this.ConstritutionLabel.Text = "Constitution";
            this.ConstritutionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WisdomLabel
            // 
            this.WisdomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WisdomLabel.AutoSize = true;
            this.WisdomLabel.Location = new System.Drawing.Point(3, 180);
            this.WisdomLabel.Name = "WisdomLabel";
            this.WisdomLabel.Size = new System.Drawing.Size(182, 45);
            this.WisdomLabel.TabIndex = 2;
            this.WisdomLabel.Text = "Wisdom";
            this.WisdomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityLabel.AutoSize = true;
            this.DexterityLabel.Location = new System.Drawing.Point(3, 45);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(182, 45);
            this.DexterityLabel.TabIndex = 4;
            this.DexterityLabel.Text = "Dexterity";
            this.DexterityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IntelligenceLabel
            // 
            this.IntelligenceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntelligenceLabel.AutoSize = true;
            this.IntelligenceLabel.Location = new System.Drawing.Point(3, 135);
            this.IntelligenceLabel.Name = "IntelligenceLabel";
            this.IntelligenceLabel.Size = new System.Drawing.Size(182, 45);
            this.IntelligenceLabel.TabIndex = 5;
            this.IntelligenceLabel.Text = "Intelligence";
            this.IntelligenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CharismaLabel
            // 
            this.CharismaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharismaLabel.AutoSize = true;
            this.CharismaLabel.Location = new System.Drawing.Point(3, 225);
            this.CharismaLabel.Name = "CharismaLabel";
            this.CharismaLabel.Size = new System.Drawing.Size(182, 45);
            this.CharismaLabel.TabIndex = 6;
            this.CharismaLabel.Text = "Charisma";
            this.CharismaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenerateAbilitiesButton
            // 
            this.GenerateAbilitiesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilitiesTableLayoutPanel.SetColumnSpan(this.GenerateAbilitiesButton, 2);
            this.GenerateAbilitiesButton.Location = new System.Drawing.Point(379, 318);
            this.GenerateAbilitiesButton.Name = "GenerateAbilitiesButton";
            this.GenerateAbilitiesButton.Size = new System.Drawing.Size(371, 45);
            this.GenerateAbilitiesButton.TabIndex = 7;
            this.GenerateAbilitiesButton.Text = "Generate Abilities";
            this.GenerateAbilitiesButton.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(764, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator7,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(267, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // StrengthDataLabel
            // 
            this.StrengthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthDataLabel.AutoSize = true;
            this.StrengthDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StrengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthDataLabel.Location = new System.Drawing.Point(191, 0);
            this.StrengthDataLabel.Name = "StrengthDataLabel";
            this.StrengthDataLabel.Size = new System.Drawing.Size(182, 45);
            this.StrengthDataLabel.TabIndex = 8;
            // 
            // DexterityDataLabel
            // 
            this.DexterityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityDataLabel.AutoSize = true;
            this.DexterityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DexterityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DexterityDataLabel.Location = new System.Drawing.Point(191, 45);
            this.DexterityDataLabel.Name = "DexterityDataLabel";
            this.DexterityDataLabel.Size = new System.Drawing.Size(182, 45);
            this.DexterityDataLabel.TabIndex = 11;
            // 
            // ConstitutionLabel
            // 
            this.ConstitutionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConstitutionLabel.AutoSize = true;
            this.ConstitutionLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ConstitutionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConstitutionLabel.Location = new System.Drawing.Point(191, 90);
            this.ConstitutionLabel.Name = "ConstitutionLabel";
            this.ConstitutionLabel.Size = new System.Drawing.Size(182, 45);
            this.ConstitutionLabel.TabIndex = 14;
            // 
            // IntelligenceDataLabel
            // 
            this.IntelligenceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntelligenceDataLabel.AutoSize = true;
            this.IntelligenceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IntelligenceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntelligenceDataLabel.Location = new System.Drawing.Point(191, 135);
            this.IntelligenceDataLabel.Name = "IntelligenceDataLabel";
            this.IntelligenceDataLabel.Size = new System.Drawing.Size(182, 45);
            this.IntelligenceDataLabel.TabIndex = 17;
            // 
            // WisdomDataLabel
            // 
            this.WisdomDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WisdomDataLabel.AutoSize = true;
            this.WisdomDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WisdomDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WisdomDataLabel.Location = new System.Drawing.Point(191, 180);
            this.WisdomDataLabel.Name = "WisdomDataLabel";
            this.WisdomDataLabel.Size = new System.Drawing.Size(182, 45);
            this.WisdomDataLabel.TabIndex = 20;
            // 
            // CharismaDataLabel
            // 
            this.CharismaDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharismaDataLabel.AutoSize = true;
            this.CharismaDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CharismaDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CharismaDataLabel.Location = new System.Drawing.Point(191, 225);
            this.CharismaDataLabel.Name = "CharismaDataLabel";
            this.CharismaDataLabel.Size = new System.Drawing.Size(182, 45);
            this.CharismaDataLabel.TabIndex = 23;
            // 
            // CharacterGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.mainTabControl);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CharacterGeneratorForm";
            this.Text = "Character Generator";
            this.mainTabControl.ResumeLayout(false);
            this.IdentityPage.ResumeLayout(false);
            this.IdentityTableLayoutPanel.ResumeLayout(false);
            this.IdentityTableLayoutPanel.PerformLayout();
            this.AbilitiesPage.ResumeLayout(false);
            this.CharacterSheetPage.ResumeLayout(false);
            this.CharacterSheetPage.PerformLayout();
            this.AbilitiesTableLayoutPanel.ResumeLayout(false);
            this.AbilitiesTableLayoutPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage IdentityPage;
        private System.Windows.Forms.TabPage AbilitiesPage;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TabPage InventoryPage;
        private System.Windows.Forms.TabPage CharacterSheetPage;
        private System.Windows.Forms.TableLayoutPanel IdentityTableLayoutPanel;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label FirstNameLable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CharacterNameLabel;
        private System.Windows.Forms.Label LastNameLable;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.Button GenerateNameButton;
        private System.Windows.Forms.TableLayoutPanel AbilitiesTableLayoutPanel;
        private System.Windows.Forms.Label CharismaDataLabel;
        private System.Windows.Forms.Label WisdomDataLabel;
        private System.Windows.Forms.Label IntelligenceDataLabel;
        private System.Windows.Forms.Label ConstitutionLabel;
        private System.Windows.Forms.Label DexterityDataLabel;
        private System.Windows.Forms.Label StrengthDataLabel;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label ConstritutionLabel;
        private System.Windows.Forms.Label IntelligenceLabel;
        private System.Windows.Forms.Label WisdomLabel;
        private System.Windows.Forms.Label CharismaLabel;
        private System.Windows.Forms.Button GenerateAbilitiesButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}
