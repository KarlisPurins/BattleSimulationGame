
namespace KursaDarbsDotNet
{
    partial class Battle
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
            this.cbox1 = new System.Windows.Forms.CheckBox();
            this.cbox2 = new System.Windows.Forms.CheckBox();
            this.cbox3 = new System.Windows.Forms.CheckBox();
            this.cbox4 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbox5 = new System.Windows.Forms.CheckBox();
            this.lblSelectedUnit = new System.Windows.Forms.Label();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.armySelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.battleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartBattle = new System.Windows.Forms.Button();
            this.lblTestText = new System.Windows.Forms.Label();
            this.lblYourArmy = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox1
            // 
            this.cbox1.AutoSize = true;
            this.cbox1.Location = new System.Drawing.Point(188, 271);
            this.cbox1.Name = "cbox1";
            this.cbox1.Size = new System.Drawing.Size(18, 17);
            this.cbox1.TabIndex = 0;
            this.cbox1.UseVisualStyleBackColor = true;
            this.cbox1.CheckedChanged += new System.EventHandler(this.cbox1_CheckedChanged);
            // 
            // cbox2
            // 
            this.cbox2.AutoSize = true;
            this.cbox2.Location = new System.Drawing.Point(296, 271);
            this.cbox2.Name = "cbox2";
            this.cbox2.Size = new System.Drawing.Size(18, 17);
            this.cbox2.TabIndex = 1;
            this.cbox2.UseVisualStyleBackColor = true;
            this.cbox2.CheckedChanged += new System.EventHandler(this.cbox2_CheckedChanged);
            // 
            // cbox3
            // 
            this.cbox3.AutoSize = true;
            this.cbox3.Location = new System.Drawing.Point(406, 271);
            this.cbox3.Name = "cbox3";
            this.cbox3.Size = new System.Drawing.Size(18, 17);
            this.cbox3.TabIndex = 2;
            this.cbox3.UseVisualStyleBackColor = true;
            this.cbox3.CheckedChanged += new System.EventHandler(this.cbox3_CheckedChanged);
            // 
            // cbox4
            // 
            this.cbox4.AutoSize = true;
            this.cbox4.Location = new System.Drawing.Point(517, 271);
            this.cbox4.Name = "cbox4";
            this.cbox4.Size = new System.Drawing.Size(18, 17);
            this.cbox4.TabIndex = 3;
            this.cbox4.UseVisualStyleBackColor = true;
            this.cbox4.CheckedChanged += new System.EventHandler(this.cbox4_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button1.Location = new System.Drawing.Point(42, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Select Unit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbox5
            // 
            this.cbox5.AutoSize = true;
            this.cbox5.Location = new System.Drawing.Point(625, 271);
            this.cbox5.Name = "cbox5";
            this.cbox5.Size = new System.Drawing.Size(18, 17);
            this.cbox5.TabIndex = 5;
            this.cbox5.UseVisualStyleBackColor = true;
            this.cbox5.CheckedChanged += new System.EventHandler(this.cbox5_CheckedChanged);
            // 
            // lblSelectedUnit
            // 
            this.lblSelectedUnit.AutoSize = true;
            this.lblSelectedUnit.Location = new System.Drawing.Point(46, 315);
            this.lblSelectedUnit.Name = "lblSelectedUnit";
            this.lblSelectedUnit.Size = new System.Drawing.Size(0, 17);
            this.lblSelectedUnit.TabIndex = 6;
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(800, 30);
            this.mnuMainMenu.TabIndex = 15;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.armySelectionToolStripMenuItem,
            this.battleToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // armySelectionToolStripMenuItem
            // 
            this.armySelectionToolStripMenuItem.Name = "armySelectionToolStripMenuItem";
            this.armySelectionToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.armySelectionToolStripMenuItem.Text = "ArmySelection";
            this.armySelectionToolStripMenuItem.Click += new System.EventHandler(this.armySelectionToolStripMenuItem_Click);
            // 
            // battleToolStripMenuItem
            // 
            this.battleToolStripMenuItem.Name = "battleToolStripMenuItem";
            this.battleToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.battleToolStripMenuItem.Text = "Battle";
            this.battleToolStripMenuItem.Click += new System.EventHandler(this.battleToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.howToPlayToolStripMenuItem.Text = "How To Play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnStartBattle
            // 
            this.btnStartBattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnStartBattle.Location = new System.Drawing.Point(317, 349);
            this.btnStartBattle.Name = "btnStartBattle";
            this.btnStartBattle.Size = new System.Drawing.Size(239, 47);
            this.btnStartBattle.TabIndex = 16;
            this.btnStartBattle.Text = "Start Battle";
            this.btnStartBattle.UseVisualStyleBackColor = true;
            this.btnStartBattle.Click += new System.EventHandler(this.btnStartBattle_Click);
            // 
            // lblTestText
            // 
            this.lblTestText.AutoSize = true;
            this.lblTestText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblTestText.Location = new System.Drawing.Point(46, 116);
            this.lblTestText.Name = "lblTestText";
            this.lblTestText.Size = new System.Drawing.Size(53, 20);
            this.lblTestText.TabIndex = 17;
            this.lblTestText.Text = "label1";
            // 
            // lblYourArmy
            // 
            this.lblYourArmy.AutoSize = true;
            this.lblYourArmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblYourArmy.Location = new System.Drawing.Point(42, 76);
            this.lblYourArmy.Name = "lblYourArmy";
            this.lblYourArmy.Size = new System.Drawing.Size(210, 29);
            this.lblYourArmy.TabIndex = 18;
            this.lblYourArmy.Text = "Army left to deploy";
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblYourArmy);
            this.Controls.Add(this.lblTestText);
            this.Controls.Add(this.btnStartBattle);
            this.Controls.Add(this.mnuMainMenu);
            this.Controls.Add(this.lblSelectedUnit);
            this.Controls.Add(this.cbox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbox4);
            this.Controls.Add(this.cbox3);
            this.Controls.Add(this.cbox2);
            this.Controls.Add(this.cbox1);
            this.Name = "Battle";
            this.Text = "Battle";
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbox1;
        private System.Windows.Forms.CheckBox cbox2;
        private System.Windows.Forms.CheckBox cbox3;
        private System.Windows.Forms.CheckBox cbox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbox5;
        private System.Windows.Forms.Label lblSelectedUnit;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem armySelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem battleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnStartBattle;
        private System.Windows.Forms.Label lblTestText;
        private System.Windows.Forms.Label lblYourArmy;
    }
}