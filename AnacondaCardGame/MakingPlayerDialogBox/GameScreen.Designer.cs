namespace MakingPlayerDialogBox
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handRanksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player:";
            // 
            // playerLabel
            // 
            this.playerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerLabel.Location = new System.Drawing.Point(12, 59);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(159, 23);
            this.playerLabel.TabIndex = 3;
            this.playerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.playerStatsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.handRanksToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // handRanksToolStripMenuItem
            // 
            this.handRanksToolStripMenuItem.Name = "handRanksToolStripMenuItem";
            this.handRanksToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.handRanksToolStripMenuItem.Text = "Hand Ranks";
            this.handRanksToolStripMenuItem.Click += new System.EventHandler(this.handRanksToolStripMenuItem_Click);
            // 
            // playerStatsToolStripMenuItem
            // 
            this.playerStatsToolStripMenuItem.Name = "playerStatsToolStripMenuItem";
            this.playerStatsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.playerStatsToolStripMenuItem.Text = "Player Stats";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Raise";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 24);
            this.button2.TabIndex = 9;
            this.button2.Text = "Call";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(359, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 24);
            this.button3.TabIndex = 10;
            this.button3.Text = "Check";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(436, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 24);
            this.button4.TabIndex = 11;
            this.button4.Text = "Fold";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(474, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 15;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(580, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 14;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pot:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Time:";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(304, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 17;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Active Player:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(528, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(152, 225);
            this.listBox1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(577, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Action Log:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(177, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 145);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 225);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Placeholder";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2_Clubs.bmp");
            this.imageList1.Images.SetKeyName(1, "2_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(2, "2_Hearts.bmp");
            this.imageList1.Images.SetKeyName(3, "2_Spades.bmp");
            this.imageList1.Images.SetKeyName(4, "3_Clubs.bmp");
            this.imageList1.Images.SetKeyName(5, "3_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(6, "3_Hearts.bmp");
            this.imageList1.Images.SetKeyName(7, "3_Spades.bmp");
            this.imageList1.Images.SetKeyName(8, "4_Clubs.bmp");
            this.imageList1.Images.SetKeyName(9, "4_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(10, "4_Hearts.bmp");
            this.imageList1.Images.SetKeyName(11, "4_Spades.bmp");
            this.imageList1.Images.SetKeyName(12, "5_Clubs.bmp");
            this.imageList1.Images.SetKeyName(13, "5_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(14, "5_Hearts.bmp");
            this.imageList1.Images.SetKeyName(15, "5_Spades.bmp");
            this.imageList1.Images.SetKeyName(16, "6_Clubs.bmp");
            this.imageList1.Images.SetKeyName(17, "6_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(18, "6_Hearts.bmp");
            this.imageList1.Images.SetKeyName(19, "6_Spades.bmp");
            this.imageList1.Images.SetKeyName(20, "7_Clubs.bmp");
            this.imageList1.Images.SetKeyName(21, "7_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(22, "7_Hearts.bmp");
            this.imageList1.Images.SetKeyName(23, "7_Spades.bmp");
            this.imageList1.Images.SetKeyName(24, "8_Clubs.bmp");
            this.imageList1.Images.SetKeyName(25, "8_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(26, "8_Hearts.bmp");
            this.imageList1.Images.SetKeyName(27, "8_Spades.bmp");
            this.imageList1.Images.SetKeyName(28, "9_Clubs.bmp");
            this.imageList1.Images.SetKeyName(29, "9_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(30, "9_Hearts.bmp");
            this.imageList1.Images.SetKeyName(31, "9_Spades.bmp");
            this.imageList1.Images.SetKeyName(32, "10_Clubs.bmp");
            this.imageList1.Images.SetKeyName(33, "10_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(34, "10_Hearts.bmp");
            this.imageList1.Images.SetKeyName(35, "10_Spades.bmp");
            this.imageList1.Images.SetKeyName(36, "Ace_Clubs.bmp");
            this.imageList1.Images.SetKeyName(37, "Ace_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(38, "Ace_Hearts.bmp");
            this.imageList1.Images.SetKeyName(39, "Ace_Spades.bmp");
            this.imageList1.Images.SetKeyName(40, "Jack_Clubs.bmp");
            this.imageList1.Images.SetKeyName(41, "Jack_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(42, "Jack_Hearts.bmp");
            this.imageList1.Images.SetKeyName(43, "Jack_Spades.bmp");
            this.imageList1.Images.SetKeyName(44, "King_Clubs.bmp");
            this.imageList1.Images.SetKeyName(45, "King_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(46, "King_Hearts.bmp");
            this.imageList1.Images.SetKeyName(47, "King_Spades.bmp");
            this.imageList1.Images.SetKeyName(48, "Queen_Clubs.bmp");
            this.imageList1.Images.SetKeyName(49, "Queen_Diamonds.bmp");
            this.imageList1.Images.SetKeyName(50, "Queen_Hearts.bmp");
            this.imageList1.Images.SetKeyName(51, "Queen_Spades.bmp");
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 378);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handRanksToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem playerStatsToolStripMenuItem;
    }
}