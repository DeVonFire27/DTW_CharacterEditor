namespace CharacterFormsApplication1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.File_Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StealthLabel = new System.Windows.Forms.Label();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.LeadershipLabel = new System.Windows.Forms.Label();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.KnowledgeLabel = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.HealingLabel = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.EnduranceLabel = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.DisguiseLabel = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.CheatingLabel = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.BraveryLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelRace = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelLName = new System.Windows.Forms.Label();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.LabelFName = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.actionsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNew,
            this.Menu_File_Open,
            this.File_Menu_Save,
            this.Menu_File_Exit});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(44, 24);
            this.Menu_File.Text = "&File";
            // 
            // MenuNew
            // 
            this.MenuNew.Name = "MenuNew";
            this.MenuNew.Size = new System.Drawing.Size(152, 24);
            this.MenuNew.Text = "&New";
            this.MenuNew.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // Menu_File_Open
            // 
            this.Menu_File_Open.Name = "Menu_File_Open";
            this.Menu_File_Open.Size = new System.Drawing.Size(152, 24);
            this.Menu_File_Open.Text = "&Open";
            this.Menu_File_Open.Click += new System.EventHandler(this.Menu_File_Open_Click);
            // 
            // File_Menu_Save
            // 
            this.File_Menu_Save.Name = "File_Menu_Save";
            this.File_Menu_Save.Size = new System.Drawing.Size(152, 24);
            this.File_Menu_Save.Text = "&Save As";
            this.File_Menu_Save.Click += new System.EventHandler(this.File_Menu_Save_Click);
            // 
            // Menu_File_Exit
            // 
            this.Menu_File_Exit.Name = "Menu_File_Exit";
            this.Menu_File_Exit.Size = new System.Drawing.Size(152, 24);
            this.Menu_File_Exit.Text = "E&xit";
            this.Menu_File_Exit.Click += new System.EventHandler(this.Menu_File_Exit_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCharactersToolStripMenuItem,
            this.updateCharactersToolStripMenuItem,
            this.deselectCharactersToolStripMenuItem,
            this.removeCharacterToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.actionsToolStripMenuItem.Text = "&Actions";
            // 
            // addCharactersToolStripMenuItem
            // 
            this.addCharactersToolStripMenuItem.Name = "addCharactersToolStripMenuItem";
            this.addCharactersToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.addCharactersToolStripMenuItem.Text = "Add &Character";
            this.addCharactersToolStripMenuItem.Click += new System.EventHandler(this.addCharactersToolStripMenuItem_Click);
            // 
            // updateCharactersToolStripMenuItem
            // 
            this.updateCharactersToolStripMenuItem.Name = "updateCharactersToolStripMenuItem";
            this.updateCharactersToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.updateCharactersToolStripMenuItem.Text = "&Update Character";
            this.updateCharactersToolStripMenuItem.Click += new System.EventHandler(this.updateCharactersToolStripMenuItem_Click);
            // 
            // deselectCharactersToolStripMenuItem
            // 
            this.deselectCharactersToolStripMenuItem.Name = "deselectCharactersToolStripMenuItem";
            this.deselectCharactersToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.deselectCharactersToolStripMenuItem.Text = "&Deselect Character";
            this.deselectCharactersToolStripMenuItem.Click += new System.EventHandler(this.deselectCharactersToolStripMenuItem_Click);
            // 
            // removeCharacterToolStripMenuItem
            // 
            this.removeCharacterToolStripMenuItem.Name = "removeCharacterToolStripMenuItem";
            this.removeCharacterToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.removeCharacterToolStripMenuItem.Text = "&Remove Character";
            this.removeCharacterToolStripMenuItem.Click += new System.EventHandler(this.removeCharacterToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skillsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // skillsToolStripMenuItem
            // 
            this.skillsToolStripMenuItem.Checked = true;
            this.skillsToolStripMenuItem.CheckOnClick = true;
            this.skillsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skillsToolStripMenuItem.Name = "skillsToolStripMenuItem";
            this.skillsToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.skillsToolStripMenuItem.Text = "S&kills";
            this.skillsToolStripMenuItem.Click += new System.EventHandler(this.skillsToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Size = new System.Drawing.Size(680, 475);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StealthLabel);
            this.groupBox2.Controls.Add(this.numericUpDown8);
            this.groupBox2.Controls.Add(this.LeadershipLabel);
            this.groupBox2.Controls.Add(this.numericUpDown7);
            this.groupBox2.Controls.Add(this.KnowledgeLabel);
            this.groupBox2.Controls.Add(this.numericUpDown6);
            this.groupBox2.Controls.Add(this.HealingLabel);
            this.groupBox2.Controls.Add(this.numericUpDown5);
            this.groupBox2.Controls.Add(this.EnduranceLabel);
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.DisguiseLabel);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.CheatingLabel);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.BraveryLabel);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(11, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 294);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Skills";
            // 
            // StealthLabel
            // 
            this.StealthLabel.AutoSize = true;
            this.StealthLabel.Location = new System.Drawing.Point(6, 222);
            this.StealthLabel.Name = "StealthLabel";
            this.StealthLabel.Size = new System.Drawing.Size(52, 17);
            this.StealthLabel.TabIndex = 21;
            this.StealthLabel.Text = "Stealth";
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(102, 217);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(103, 22);
            this.numericUpDown8.TabIndex = 20;
            // 
            // LeadershipLabel
            // 
            this.LeadershipLabel.AutoSize = true;
            this.LeadershipLabel.Location = new System.Drawing.Point(6, 194);
            this.LeadershipLabel.Name = "LeadershipLabel";
            this.LeadershipLabel.Size = new System.Drawing.Size(79, 17);
            this.LeadershipLabel.TabIndex = 19;
            this.LeadershipLabel.Text = "Leadership";
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(102, 189);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(103, 22);
            this.numericUpDown7.TabIndex = 18;
            // 
            // KnowledgeLabel
            // 
            this.KnowledgeLabel.AutoSize = true;
            this.KnowledgeLabel.Location = new System.Drawing.Point(6, 166);
            this.KnowledgeLabel.Name = "KnowledgeLabel";
            this.KnowledgeLabel.Size = new System.Drawing.Size(77, 17);
            this.KnowledgeLabel.TabIndex = 17;
            this.KnowledgeLabel.Text = "Knowledge";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(102, 161);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(103, 22);
            this.numericUpDown6.TabIndex = 16;
            // 
            // HealingLabel
            // 
            this.HealingLabel.AutoSize = true;
            this.HealingLabel.Location = new System.Drawing.Point(6, 138);
            this.HealingLabel.Name = "HealingLabel";
            this.HealingLabel.Size = new System.Drawing.Size(56, 17);
            this.HealingLabel.TabIndex = 15;
            this.HealingLabel.Text = "Healing";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(102, 133);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(103, 22);
            this.numericUpDown5.TabIndex = 14;
            // 
            // EnduranceLabel
            // 
            this.EnduranceLabel.AutoSize = true;
            this.EnduranceLabel.Location = new System.Drawing.Point(6, 110);
            this.EnduranceLabel.Name = "EnduranceLabel";
            this.EnduranceLabel.Size = new System.Drawing.Size(77, 17);
            this.EnduranceLabel.TabIndex = 13;
            this.EnduranceLabel.Text = "Endurance";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(102, 105);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(103, 22);
            this.numericUpDown4.TabIndex = 12;
            // 
            // DisguiseLabel
            // 
            this.DisguiseLabel.AutoSize = true;
            this.DisguiseLabel.Location = new System.Drawing.Point(6, 82);
            this.DisguiseLabel.Name = "DisguiseLabel";
            this.DisguiseLabel.Size = new System.Drawing.Size(62, 17);
            this.DisguiseLabel.TabIndex = 11;
            this.DisguiseLabel.Text = "Disguise";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(102, 77);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(103, 22);
            this.numericUpDown3.TabIndex = 10;
            // 
            // CheatingLabel
            // 
            this.CheatingLabel.AutoSize = true;
            this.CheatingLabel.Location = new System.Drawing.Point(6, 54);
            this.CheatingLabel.Name = "CheatingLabel";
            this.CheatingLabel.Size = new System.Drawing.Size(64, 17);
            this.CheatingLabel.TabIndex = 9;
            this.CheatingLabel.Text = "Cheating";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(102, 49);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(103, 22);
            this.numericUpDown2.TabIndex = 8;
            // 
            // BraveryLabel
            // 
            this.BraveryLabel.AutoSize = true;
            this.BraveryLabel.Location = new System.Drawing.Point(6, 26);
            this.BraveryLabel.Name = "BraveryLabel";
            this.BraveryLabel.Size = new System.Drawing.Size(57, 17);
            this.BraveryLabel.TabIndex = 7;
            this.BraveryLabel.Text = "Bravery";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(102, 21);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(103, 22);
            this.numericUpDown1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Randomize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelRace);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.LabelLName);
            this.groupBox1.Controls.Add(this.LNameBox);
            this.groupBox1.Controls.Add(this.FNameBox);
            this.groupBox1.Controls.Add(this.Age);
            this.groupBox1.Controls.Add(this.LabelFName);
            this.groupBox1.Controls.Add(this.AgeBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Info";
            // 
            // LabelRace
            // 
            this.LabelRace.AutoSize = true;
            this.LabelRace.Location = new System.Drawing.Point(55, 116);
            this.LabelRace.Name = "LabelRace";
            this.LabelRace.Size = new System.Drawing.Size(41, 17);
            this.LabelRace.TabIndex = 7;
            this.LabelRace.Text = "Race";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Elf",
            "Giant",
            "Hobbit",
            "Human",
            "Troll",
            "Wizard",
            "None"});
            this.comboBox1.Location = new System.Drawing.Point(102, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "None";
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // LabelLName
            // 
            this.LabelLName.AutoSize = true;
            this.LabelLName.Location = new System.Drawing.Point(20, 56);
            this.LabelLName.Name = "LabelLName";
            this.LabelLName.Size = new System.Drawing.Size(76, 17);
            this.LabelLName.TabIndex = 5;
            this.LabelLName.Text = "Last Name";
            // 
            // LNameBox
            // 
            this.LNameBox.Location = new System.Drawing.Point(102, 56);
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(167, 22);
            this.LNameBox.TabIndex = 2;
            // 
            // FNameBox
            // 
            this.FNameBox.Location = new System.Drawing.Point(102, 28);
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(167, 22);
            this.FNameBox.TabIndex = 0;
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(63, 84);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(33, 17);
            this.Age.TabIndex = 3;
            this.Age.Text = "Age";
            // 
            // LabelFName
            // 
            this.LabelFName.AutoSize = true;
            this.LabelFName.Location = new System.Drawing.Point(20, 28);
            this.LabelFName.Name = "LabelFName";
            this.LabelFName.Size = new System.Drawing.Size(76, 17);
            this.LabelFName.TabIndex = 1;
            this.LabelFName.Text = "First Name";
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(102, 84);
            this.AgeBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(167, 22);
            this.AgeBox.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(384, 473);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 503);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label LabelFName;
        private System.Windows.Forms.NumericUpDown AgeBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem MenuNew;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Open;
        private System.Windows.Forms.ToolStripMenuItem File_Menu_Save;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skillsToolStripMenuItem;
        private System.Windows.Forms.TextBox LNameBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label StealthLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.Label LeadershipLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.Label KnowledgeLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label HealingLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label EnduranceLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label DisguiseLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label CheatingLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label BraveryLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label LabelRace;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelLName;
    }
}

