using ControlLibrary;
using NovaCommon;

namespace NewGame
{
   partial class NewGameWizard
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGameWizard));
          this.label2 = new System.Windows.Forms.Label();
          this.groupBox1 = new System.Windows.Forms.GroupBox();
          this.TotalScore = new ControlLibrary.EnabledCounter();
          this.ExceedSecondPlace = new ControlLibrary.EnabledCounter();
          this.HighestScore = new ControlLibrary.EnabledCounter();
          this.CapitalShips = new ControlLibrary.EnabledCounter();
          this.ProductionCapacity = new ControlLibrary.EnabledCounter();
          this.NumberOfFields = new ControlLibrary.EnabledCounter();
          this.TechLevels = new ControlLibrary.EnabledCounter();
          this.PlanetsOwned = new ControlLibrary.EnabledCounter();
          this.label1 = new System.Windows.Forms.Label();
          this.groupBox2 = new System.Windows.Forms.GroupBox();
          this.MinimumGameTime = new System.Windows.Forms.NumericUpDown();
          this.label5 = new System.Windows.Forms.Label();
          this.TargetsToMeet = new System.Windows.Forms.NumericUpDown();
          this.label4 = new System.Windows.Forms.Label();
          this.CancelSelected = new System.Windows.Forms.Button();
          this.OKSelected = new System.Windows.Forms.Button();
          this.tabControl1 = new System.Windows.Forms.TabControl();
          this.tabGameOptions = new System.Windows.Forms.TabPage();
          this.groupBox3 = new System.Windows.Forms.GroupBox();
          this.mapWidth = new System.Windows.Forms.NumericUpDown();
          this.mapHeight = new System.Windows.Forms.NumericUpDown();
          this.label6 = new System.Windows.Forms.Label();
          this.label3 = new System.Windows.Forms.Label();
          this.tabPlayers = new System.Windows.Forms.TabPage();
          this.groupBox5 = new System.Windows.Forms.GroupBox();
          this.playerList = new System.Windows.Forms.ListView();
          this.PlayerNumber = new System.Windows.Forms.ColumnHeader();
          this.Race = new System.Windows.Forms.ColumnHeader();
          this.Ai = new System.Windows.Forms.ColumnHeader();
          this.playerDeleteButton = new System.Windows.Forms.Button();
          this.playerDownButton = new System.Windows.Forms.Button();
          this.playerUpButton = new System.Windows.Forms.Button();
          this.groupBox4 = new System.Windows.Forms.GroupBox();
          this.addPlayerButton = new System.Windows.Forms.Button();
          this.aiBrowseButton = new System.Windows.Forms.Button();
          this.raceBrowseButton = new System.Windows.Forms.Button();
          this.aiSelectionBox = new System.Windows.Forms.ComboBox();
          this.raceSelectionBox = new System.Windows.Forms.ComboBox();
          this.label8 = new System.Windows.Forms.Label();
          this.label7 = new System.Windows.Forms.Label();
          this.tabVictoryConditions = new System.Windows.Forms.TabPage();
          this.newRaceButton = new System.Windows.Forms.Button();
          this.groupBox1.SuspendLayout();
          this.groupBox2.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.MinimumGameTime)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.TargetsToMeet)).BeginInit();
          this.tabControl1.SuspendLayout();
          this.tabGameOptions.SuspendLayout();
          this.groupBox3.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.mapWidth)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.mapHeight)).BeginInit();
          this.tabPlayers.SuspendLayout();
          this.groupBox5.SuspendLayout();
          this.groupBox4.SuspendLayout();
          this.tabVictoryConditions.SuspendLayout();
          this.SuspendLayout();
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Enabled = false;
          this.label2.Location = new System.Drawing.Point(69, 57);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(0, 13);
          this.label2.TabIndex = 3;
          // 
          // groupBox1
          // 
          this.groupBox1.Controls.Add(this.TotalScore);
          this.groupBox1.Controls.Add(this.ExceedSecondPlace);
          this.groupBox1.Controls.Add(this.HighestScore);
          this.groupBox1.Controls.Add(this.CapitalShips);
          this.groupBox1.Controls.Add(this.ProductionCapacity);
          this.groupBox1.Controls.Add(this.NumberOfFields);
          this.groupBox1.Controls.Add(this.TechLevels);
          this.groupBox1.Controls.Add(this.PlanetsOwned);
          this.groupBox1.Controls.Add(this.label1);
          this.groupBox1.Controls.Add(this.label2);
          this.groupBox1.Location = new System.Drawing.Point(14, 20);
          this.groupBox1.Name = "groupBox1";
          this.groupBox1.Size = new System.Drawing.Size(352, 285);
          this.groupBox1.TabIndex = 20;
          this.groupBox1.TabStop = false;
          this.groupBox1.Text = "Victory Conditions";
          // 
          // TotalScore
          // 
          this.TotalScore.ControlCounter = 100;
          this.TotalScore.ControlSelected = false;
          this.TotalScore.ControlText = "Exceeds a score of";
          this.TotalScore.Location = new System.Drawing.Point(7, 135);
          this.TotalScore.Maximum = 10000;
          this.TotalScore.Minimum = 0;
          this.TotalScore.Name = "TotalScore";
          this.TotalScore.Size = new System.Drawing.Size(338, 23);
          this.TotalScore.TabIndex = 11;
          this.TotalScore.Value = ((NovaCommon.EnabledValue)(resources.GetObject("TotalScore.Value")));
          // 
          // ExceedSecondPlace
          // 
          this.ExceedSecondPlace.ControlCounter = 100;
          this.ExceedSecondPlace.ControlSelected = false;
          this.ExceedSecondPlace.ControlText = "Exceed second place score by (%)";
          this.ExceedSecondPlace.Location = new System.Drawing.Point(6, 254);
          this.ExceedSecondPlace.Maximum = 10000;
          this.ExceedSecondPlace.Minimum = 0;
          this.ExceedSecondPlace.Name = "ExceedSecondPlace";
          this.ExceedSecondPlace.Size = new System.Drawing.Size(339, 23);
          this.ExceedSecondPlace.TabIndex = 10;
          this.ExceedSecondPlace.Value = ((NovaCommon.EnabledValue)(resources.GetObject("ExceedSecondPlace.Value")));
          // 
          // HighestScore
          // 
          this.HighestScore.ControlCounter = 100;
          this.HighestScore.ControlSelected = false;
          this.HighestScore.ControlText = "Has the highest score after (years)";
          this.HighestScore.Location = new System.Drawing.Point(6, 224);
          this.HighestScore.Maximum = 10000;
          this.HighestScore.Minimum = 0;
          this.HighestScore.Name = "HighestScore";
          this.HighestScore.Size = new System.Drawing.Size(339, 23);
          this.HighestScore.TabIndex = 9;
          this.HighestScore.Value = ((NovaCommon.EnabledValue)(resources.GetObject("HighestScore.Value")));
          // 
          // CapitalShips
          // 
          this.CapitalShips.ControlCounter = 100;
          this.CapitalShips.ControlSelected = false;
          this.CapitalShips.ControlText = "Number of capital ships";
          this.CapitalShips.Location = new System.Drawing.Point(6, 194);
          this.CapitalShips.Maximum = 10000;
          this.CapitalShips.Minimum = 0;
          this.CapitalShips.Name = "CapitalShips";
          this.CapitalShips.Size = new System.Drawing.Size(339, 23);
          this.CapitalShips.TabIndex = 8;
          this.CapitalShips.Value = ((NovaCommon.EnabledValue)(resources.GetObject("CapitalShips.Value")));
          // 
          // ProductionCapacity
          // 
          this.ProductionCapacity.ControlCounter = 100;
          this.ProductionCapacity.ControlSelected = false;
          this.ProductionCapacity.ControlText = "Has  production capacity of (in K resources)";
          this.ProductionCapacity.Location = new System.Drawing.Point(6, 164);
          this.ProductionCapacity.Maximum = 10000;
          this.ProductionCapacity.Minimum = 0;
          this.ProductionCapacity.Name = "ProductionCapacity";
          this.ProductionCapacity.Size = new System.Drawing.Size(339, 23);
          this.ProductionCapacity.TabIndex = 7;
          this.ProductionCapacity.Value = ((NovaCommon.EnabledValue)(resources.GetObject("ProductionCapacity.Value")));
          // 
          // NumberOfFields
          // 
          this.NumberOfFields.ControlCounter = 4;
          this.NumberOfFields.ControlSelected = false;
          this.NumberOfFields.ControlText = "In the following number of fields";
          this.NumberOfFields.Location = new System.Drawing.Point(7, 105);
          this.NumberOfFields.Maximum = 6;
          this.NumberOfFields.Minimum = 0;
          this.NumberOfFields.Name = "NumberOfFields";
          this.NumberOfFields.Size = new System.Drawing.Size(339, 23);
          this.NumberOfFields.TabIndex = 6;
          this.NumberOfFields.Value = ((NovaCommon.EnabledValue)(resources.GetObject("NumberOfFields.Value")));
          // 
          // TechLevels
          // 
          this.TechLevels.ControlCounter = 22;
          this.TechLevels.ControlSelected = false;
          this.TechLevels.ControlText = "Attains the following tech-level";
          this.TechLevels.Location = new System.Drawing.Point(6, 73);
          this.TechLevels.Maximum = 10000;
          this.TechLevels.Minimum = 0;
          this.TechLevels.Name = "TechLevels";
          this.TechLevels.Size = new System.Drawing.Size(339, 23);
          this.TechLevels.TabIndex = 5;
          this.TechLevels.Value = ((NovaCommon.EnabledValue)(resources.GetObject("TechLevels.Value")));
          // 
          // PlanetsOwned
          // 
          this.PlanetsOwned.ControlCounter = 60;
          this.PlanetsOwned.ControlSelected = false;
          this.PlanetsOwned.ControlText = "Owns the following number of planets (%)";
          this.PlanetsOwned.Location = new System.Drawing.Point(7, 45);
          this.PlanetsOwned.Maximum = 10000;
          this.PlanetsOwned.Minimum = 0;
          this.PlanetsOwned.Name = "PlanetsOwned";
          this.PlanetsOwned.Size = new System.Drawing.Size(339, 23);
          this.PlanetsOwned.TabIndex = 4;
          this.PlanetsOwned.Value = ((NovaCommon.EnabledValue)(resources.GetObject("PlanetsOwned.Value")));
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Enabled = false;
          this.label1.Location = new System.Drawing.Point(14, 28);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(165, 13);
          this.label1.TabIndex = 2;
          this.label1.Text = "Victory is declared when a player:";
          // 
          // groupBox2
          // 
          this.groupBox2.Controls.Add(this.MinimumGameTime);
          this.groupBox2.Controls.Add(this.label5);
          this.groupBox2.Controls.Add(this.TargetsToMeet);
          this.groupBox2.Controls.Add(this.label4);
          this.groupBox2.Location = new System.Drawing.Point(14, 321);
          this.groupBox2.Name = "groupBox2";
          this.groupBox2.Size = new System.Drawing.Size(352, 77);
          this.groupBox2.TabIndex = 24;
          this.groupBox2.TabStop = false;
          this.groupBox2.Text = "Main criteria";
          // 
          // MinimumGameTime
          // 
          this.MinimumGameTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
          this.MinimumGameTime.Location = new System.Drawing.Point(277, 47);
          this.MinimumGameTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
          this.MinimumGameTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
          this.MinimumGameTime.Name = "MinimumGameTime";
          this.MinimumGameTime.Size = new System.Drawing.Size(69, 20);
          this.MinimumGameTime.TabIndex = 34;
          this.MinimumGameTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
          this.MinimumGameTime.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
          // 
          // label5
          // 
          this.label5.Location = new System.Drawing.Point(17, 47);
          this.label5.Name = "label5";
          this.label5.Size = new System.Drawing.Size(195, 20);
          this.label5.TabIndex = 33;
          this.label5.Text = "Minimum game time (years)";
          this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
          // 
          // TargetsToMeet
          // 
          this.TargetsToMeet.Anchor = System.Windows.Forms.AnchorStyles.Right;
          this.TargetsToMeet.Location = new System.Drawing.Point(277, 17);
          this.TargetsToMeet.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
          this.TargetsToMeet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
          this.TargetsToMeet.Name = "TargetsToMeet";
          this.TargetsToMeet.Size = new System.Drawing.Size(69, 20);
          this.TargetsToMeet.TabIndex = 32;
          this.TargetsToMeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
          this.TargetsToMeet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
          // 
          // label4
          // 
          this.label4.Location = new System.Drawing.Point(17, 17);
          this.label4.Name = "label4";
          this.label4.Size = new System.Drawing.Size(195, 20);
          this.label4.TabIndex = 31;
          this.label4.Text = "Number of targets to meet";
          this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
          // 
          // CancelSelected
          // 
          this.CancelSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
          this.CancelSelected.DialogResult = System.Windows.Forms.DialogResult.Cancel;
          this.CancelSelected.Location = new System.Drawing.Point(12, 445);
          this.CancelSelected.Name = "CancelSelected";
          this.CancelSelected.Size = new System.Drawing.Size(75, 23);
          this.CancelSelected.TabIndex = 26;
          this.CancelSelected.Text = "Cancel";
          this.CancelSelected.UseVisualStyleBackColor = true;
          // 
          // OKSelected
          // 
          this.OKSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
          this.OKSelected.DialogResult = System.Windows.Forms.DialogResult.OK;
          this.OKSelected.Location = new System.Drawing.Point(270, 445);
          this.OKSelected.Name = "OKSelected";
          this.OKSelected.Size = new System.Drawing.Size(99, 23);
          this.OKSelected.TabIndex = 27;
          this.OKSelected.Text = "Create Game";
          this.OKSelected.UseVisualStyleBackColor = true;
          this.OKSelected.Click += new System.EventHandler(this.OKSelected_Click);
          // 
          // tabControl1
          // 
          this.tabControl1.Controls.Add(this.tabGameOptions);
          this.tabControl1.Controls.Add(this.tabPlayers);
          this.tabControl1.Controls.Add(this.tabVictoryConditions);
          this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
          this.tabControl1.Location = new System.Drawing.Point(0, 0);
          this.tabControl1.Name = "tabControl1";
          this.tabControl1.SelectedIndex = 0;
          this.tabControl1.Size = new System.Drawing.Size(389, 439);
          this.tabControl1.TabIndex = 28;
          // 
          // tabGameOptions
          // 
          this.tabGameOptions.Controls.Add(this.groupBox3);
          this.tabGameOptions.Location = new System.Drawing.Point(4, 22);
          this.tabGameOptions.Name = "tabGameOptions";
          this.tabGameOptions.Padding = new System.Windows.Forms.Padding(3);
          this.tabGameOptions.Size = new System.Drawing.Size(381, 413);
          this.tabGameOptions.TabIndex = 0;
          this.tabGameOptions.Text = "Game Options";
          this.tabGameOptions.UseVisualStyleBackColor = true;
          // 
          // groupBox3
          // 
          this.groupBox3.Controls.Add(this.mapWidth);
          this.groupBox3.Controls.Add(this.mapHeight);
          this.groupBox3.Controls.Add(this.label6);
          this.groupBox3.Controls.Add(this.label3);
          this.groupBox3.Location = new System.Drawing.Point(21, 26);
          this.groupBox3.Name = "groupBox3";
          this.groupBox3.Size = new System.Drawing.Size(137, 88);
          this.groupBox3.TabIndex = 0;
          this.groupBox3.TabStop = false;
          this.groupBox3.Text = "Map";
          // 
          // mapWidth
          // 
          this.mapWidth.Location = new System.Drawing.Point(57, 48);
          this.mapWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
          this.mapWidth.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
          this.mapWidth.Name = "mapWidth";
          this.mapWidth.Size = new System.Drawing.Size(74, 20);
          this.mapWidth.TabIndex = 3;
          this.mapWidth.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
          this.mapWidth.ValueChanged += new System.EventHandler(this.mapWidth_ValueChanged);
          // 
          // mapHeight
          // 
          this.mapHeight.Location = new System.Drawing.Point(57, 19);
          this.mapHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
          this.mapHeight.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
          this.mapHeight.Name = "mapHeight";
          this.mapHeight.Size = new System.Drawing.Size(74, 20);
          this.mapHeight.TabIndex = 2;
          this.mapHeight.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
          this.mapHeight.ValueChanged += new System.EventHandler(this.mapHeight_ValueChanged);
          // 
          // label6
          // 
          this.label6.AutoSize = true;
          this.label6.Location = new System.Drawing.Point(13, 50);
          this.label6.Name = "label6";
          this.label6.Size = new System.Drawing.Size(35, 13);
          this.label6.TabIndex = 1;
          this.label6.Text = "Width";
          // 
          // label3
          // 
          this.label3.AutoSize = true;
          this.label3.Location = new System.Drawing.Point(13, 21);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(38, 13);
          this.label3.TabIndex = 0;
          this.label3.Text = "Height";
          // 
          // tabPlayers
          // 
          this.tabPlayers.Controls.Add(this.groupBox5);
          this.tabPlayers.Controls.Add(this.groupBox4);
          this.tabPlayers.Location = new System.Drawing.Point(4, 22);
          this.tabPlayers.Name = "tabPlayers";
          this.tabPlayers.Padding = new System.Windows.Forms.Padding(3);
          this.tabPlayers.Size = new System.Drawing.Size(381, 413);
          this.tabPlayers.TabIndex = 1;
          this.tabPlayers.Text = "Players";
          this.tabPlayers.UseVisualStyleBackColor = true;
          // 
          // groupBox5
          // 
          this.groupBox5.Controls.Add(this.playerList);
          this.groupBox5.Controls.Add(this.playerDeleteButton);
          this.groupBox5.Controls.Add(this.playerDownButton);
          this.groupBox5.Controls.Add(this.playerUpButton);
          this.groupBox5.Location = new System.Drawing.Point(3, 6);
          this.groupBox5.Name = "groupBox5";
          this.groupBox5.Size = new System.Drawing.Size(370, 267);
          this.groupBox5.TabIndex = 9;
          this.groupBox5.TabStop = false;
          this.groupBox5.Text = "Player List";
          // 
          // playerList
          // 
          this.playerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PlayerNumber,
            this.Race,
            this.Ai});
          this.playerList.FullRowSelect = true;
          this.playerList.HideSelection = false;
          this.playerList.Location = new System.Drawing.Point(6, 19);
          this.playerList.MultiSelect = false;
          this.playerList.Name = "playerList";
          this.playerList.Size = new System.Drawing.Size(300, 242);
          this.playerList.TabIndex = 4;
          this.playerList.UseCompatibleStateImageBehavior = false;
          this.playerList.View = System.Windows.Forms.View.Details;
          this.playerList.SelectedIndexChanged += new System.EventHandler(this.playerList_SelectedIndexChanged);
          // 
          // PlayerNumber
          // 
          this.PlayerNumber.Text = "Player #";
          // 
          // Race
          // 
          this.Race.Text = "Race";
          this.Race.Width = 119;
          // 
          // Ai
          // 
          this.Ai.Text = "AI / Human";
          this.Ai.Width = 104;
          // 
          // playerDeleteButton
          // 
          this.playerDeleteButton.Location = new System.Drawing.Point(312, 93);
          this.playerDeleteButton.Name = "playerDeleteButton";
          this.playerDeleteButton.Size = new System.Drawing.Size(50, 23);
          this.playerDeleteButton.TabIndex = 8;
          this.playerDeleteButton.Text = "Delete";
          this.playerDeleteButton.UseVisualStyleBackColor = true;
          this.playerDeleteButton.Click += new System.EventHandler(this.playerDeleteButton_Click);
          // 
          // playerDownButton
          // 
          this.playerDownButton.Location = new System.Drawing.Point(312, 131);
          this.playerDownButton.Name = "playerDownButton";
          this.playerDownButton.Size = new System.Drawing.Size(50, 23);
          this.playerDownButton.TabIndex = 7;
          this.playerDownButton.Text = "Down";
          this.playerDownButton.UseVisualStyleBackColor = true;
          this.playerDownButton.Click += new System.EventHandler(this.playerDownButton_Click);
          // 
          // playerUpButton
          // 
          this.playerUpButton.Location = new System.Drawing.Point(312, 55);
          this.playerUpButton.Name = "playerUpButton";
          this.playerUpButton.Size = new System.Drawing.Size(50, 23);
          this.playerUpButton.TabIndex = 6;
          this.playerUpButton.Text = "Up";
          this.playerUpButton.UseVisualStyleBackColor = true;
          this.playerUpButton.Click += new System.EventHandler(this.playerUpButton_Click);
          // 
          // groupBox4
          // 
          this.groupBox4.Controls.Add(this.newRaceButton);
          this.groupBox4.Controls.Add(this.addPlayerButton);
          this.groupBox4.Controls.Add(this.aiBrowseButton);
          this.groupBox4.Controls.Add(this.raceBrowseButton);
          this.groupBox4.Controls.Add(this.aiSelectionBox);
          this.groupBox4.Controls.Add(this.raceSelectionBox);
          this.groupBox4.Controls.Add(this.label8);
          this.groupBox4.Controls.Add(this.label7);
          this.groupBox4.Location = new System.Drawing.Point(6, 279);
          this.groupBox4.Name = "groupBox4";
          this.groupBox4.Size = new System.Drawing.Size(369, 128);
          this.groupBox4.TabIndex = 5;
          this.groupBox4.TabStop = false;
          this.groupBox4.Text = "Add Player";
          // 
          // addPlayerButton
          // 
          this.addPlayerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
          this.addPlayerButton.Location = new System.Drawing.Point(285, 99);
          this.addPlayerButton.Name = "addPlayerButton";
          this.addPlayerButton.Size = new System.Drawing.Size(75, 23);
          this.addPlayerButton.TabIndex = 6;
          this.addPlayerButton.Text = "Add Player";
          this.addPlayerButton.UseVisualStyleBackColor = true;
          this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
          // 
          // aiBrowseButton
          // 
          this.aiBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
          this.aiBrowseButton.Location = new System.Drawing.Point(285, 66);
          this.aiBrowseButton.Name = "aiBrowseButton";
          this.aiBrowseButton.Size = new System.Drawing.Size(75, 23);
          this.aiBrowseButton.TabIndex = 5;
          this.aiBrowseButton.Text = "Browse";
          this.aiBrowseButton.UseVisualStyleBackColor = true;
          this.aiBrowseButton.Click += new System.EventHandler(this.aiBrowseButton_Click);
          // 
          // raceBrowseButton
          // 
          this.raceBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
          this.raceBrowseButton.Location = new System.Drawing.Point(284, 20);
          this.raceBrowseButton.Name = "raceBrowseButton";
          this.raceBrowseButton.Size = new System.Drawing.Size(75, 23);
          this.raceBrowseButton.TabIndex = 4;
          this.raceBrowseButton.Text = "Browse";
          this.raceBrowseButton.UseVisualStyleBackColor = true;
          this.raceBrowseButton.Click += new System.EventHandler(this.raceBrowseButton_Click);
          // 
          // aiSelectionBox
          // 
          this.aiSelectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
          this.aiSelectionBox.FormattingEnabled = true;
          this.aiSelectionBox.Items.AddRange(new object[] {
            "Human",
            "Default AI"});
          this.aiSelectionBox.Location = new System.Drawing.Point(76, 66);
          this.aiSelectionBox.Name = "aiSelectionBox";
          this.aiSelectionBox.Size = new System.Drawing.Size(202, 21);
          this.aiSelectionBox.TabIndex = 3;
          this.aiSelectionBox.Text = "Human";
          // 
          // raceSelectionBox
          // 
          this.raceSelectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
          this.raceSelectionBox.FormattingEnabled = true;
          this.raceSelectionBox.Location = new System.Drawing.Point(76, 22);
          this.raceSelectionBox.Name = "raceSelectionBox";
          this.raceSelectionBox.Size = new System.Drawing.Size(202, 21);
          this.raceSelectionBox.TabIndex = 2;
          // 
          // label8
          // 
          this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
          this.label8.AutoSize = true;
          this.label8.Location = new System.Drawing.Point(6, 69);
          this.label8.Name = "label8";
          this.label8.Size = new System.Drawing.Size(62, 13);
          this.label8.TabIndex = 1;
          this.label8.Text = "Human / AI";
          // 
          // label7
          // 
          this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
          this.label7.AutoSize = true;
          this.label7.Location = new System.Drawing.Point(6, 25);
          this.label7.Name = "label7";
          this.label7.Size = new System.Drawing.Size(64, 13);
          this.label7.TabIndex = 0;
          this.label7.Text = "Race Name";
          // 
          // tabVictoryConditions
          // 
          this.tabVictoryConditions.Controls.Add(this.groupBox1);
          this.tabVictoryConditions.Controls.Add(this.groupBox2);
          this.tabVictoryConditions.Location = new System.Drawing.Point(4, 22);
          this.tabVictoryConditions.Name = "tabVictoryConditions";
          this.tabVictoryConditions.Size = new System.Drawing.Size(381, 413);
          this.tabVictoryConditions.TabIndex = 2;
          this.tabVictoryConditions.Text = "Victory Conditions";
          this.tabVictoryConditions.UseVisualStyleBackColor = true;
          // 
          // newRaceButton
          // 
          this.newRaceButton.Location = new System.Drawing.Point(46, 99);
          this.newRaceButton.Name = "newRaceButton";
          this.newRaceButton.Size = new System.Drawing.Size(156, 23);
          this.newRaceButton.TabIndex = 7;
          this.newRaceButton.Text = "Race Designer";
          this.newRaceButton.UseVisualStyleBackColor = true;
          this.newRaceButton.Click += new System.EventHandler(this.newRaceButton_Click);
          // 
          // NewGameWizard
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(389, 480);
          this.Controls.Add(this.tabControl1);
          this.Controls.Add(this.OKSelected);
          this.Controls.Add(this.CancelSelected);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.Name = "NewGameWizard";
          this.Text = "Nova Victory Conditions";
          this.groupBox1.ResumeLayout(false);
          this.groupBox1.PerformLayout();
          this.groupBox2.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)(this.MinimumGameTime)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.TargetsToMeet)).EndInit();
          this.tabControl1.ResumeLayout(false);
          this.tabGameOptions.ResumeLayout(false);
          this.groupBox3.ResumeLayout(false);
          this.groupBox3.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.mapWidth)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.mapHeight)).EndInit();
          this.tabPlayers.ResumeLayout(false);
          this.groupBox5.ResumeLayout(false);
          this.groupBox4.ResumeLayout(false);
          this.groupBox4.PerformLayout();
          this.tabVictoryConditions.ResumeLayout(false);
          this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.Button CancelSelected;
      private System.Windows.Forms.Button OKSelected;
       private System.Windows.Forms.NumericUpDown TargetsToMeet;
       private System.Windows.Forms.Label label4;
       private System.Windows.Forms.Label label5;
       private System.Windows.Forms.NumericUpDown MinimumGameTime;
       private System.Windows.Forms.TabControl tabControl1;
       private System.Windows.Forms.TabPage tabGameOptions;
       private System.Windows.Forms.TabPage tabPlayers;
       private System.Windows.Forms.TabPage tabVictoryConditions;
       private System.Windows.Forms.GroupBox groupBox3;
       private System.Windows.Forms.NumericUpDown mapWidth;
       private System.Windows.Forms.NumericUpDown mapHeight;
       private System.Windows.Forms.Label label6;
       private System.Windows.Forms.Label label3;
       private EnabledCounter PlanetsOwned;
       private EnabledCounter ExceedSecondPlace;
       private EnabledCounter HighestScore;
       private EnabledCounter CapitalShips;
       private EnabledCounter ProductionCapacity;
       private EnabledCounter NumberOfFields;
       private EnabledCounter TechLevels;
       private EnabledCounter TotalScore;
       private System.Windows.Forms.ListView playerList;
       private System.Windows.Forms.ColumnHeader PlayerNumber;
       private System.Windows.Forms.ColumnHeader Race;
       private System.Windows.Forms.ColumnHeader Ai;
       private System.Windows.Forms.Button playerDeleteButton;
       private System.Windows.Forms.Button playerDownButton;
       private System.Windows.Forms.Button playerUpButton;
       private System.Windows.Forms.GroupBox groupBox4;
       private System.Windows.Forms.Button addPlayerButton;
       private System.Windows.Forms.Button aiBrowseButton;
       private System.Windows.Forms.Button raceBrowseButton;
       private System.Windows.Forms.ComboBox aiSelectionBox;
       private System.Windows.Forms.ComboBox raceSelectionBox;
       private System.Windows.Forms.Label label8;
       private System.Windows.Forms.Label label7;
       private System.Windows.Forms.GroupBox groupBox5;
       private System.Windows.Forms.Button newRaceButton;
   }
}