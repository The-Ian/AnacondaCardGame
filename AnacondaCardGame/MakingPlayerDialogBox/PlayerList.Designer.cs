namespace MakingPlayerDialogBox
{
    partial class PlayerList
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.op1CB = new System.Windows.Forms.ComboBox();
            this.op2CB = new System.Windows.Forms.ComboBox();
            this.op3CB = new System.Windows.Forms.ComboBox();
            this.op4CB = new System.Windows.Forms.ComboBox();
            this.op5CB = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(127, 160);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a New Player:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Players:";
            // 
            // op1CB
            // 
            this.op1CB.FormattingEnabled = true;
            this.op1CB.Items.AddRange(new object[] {
            "Dio Brando",
            "Hisoka Morrow",
            "Van Hohenheim",
            "Raoh",
            "Meruem",
            "Baron Zemo",
            "Victor Von Doom",
            "Erik Lehnsherr",
            "En Sabah Nur",
            "Lex Luthor"});
            this.op1CB.Location = new System.Drawing.Point(165, 30);
            this.op1CB.Name = "op1CB";
            this.op1CB.Size = new System.Drawing.Size(121, 21);
            this.op1CB.TabIndex = 4;
            // 
            // op2CB
            // 
            this.op2CB.FormattingEnabled = true;
            this.op2CB.Items.AddRange(new object[] {
            "Dio Brando",
            "Hisoka Morrow",
            "Van Hohenheim",
            "Raoh",
            "Meruem",
            "Baron Zemo",
            "Victor Von Doom",
            "Erik Lehnsherr",
            "En Sabah Nur",
            "Lex Luthor"});
            this.op2CB.Location = new System.Drawing.Point(165, 63);
            this.op2CB.Name = "op2CB";
            this.op2CB.Size = new System.Drawing.Size(121, 21);
            this.op2CB.TabIndex = 5;
            // 
            // op3CB
            // 
            this.op3CB.FormattingEnabled = true;
            this.op3CB.Items.AddRange(new object[] {
            "Dio Brando",
            "Hisoka Morrow",
            "Van Hohenheim",
            "Raoh",
            "Meruem",
            "Baron Zemo",
            "Victor Von Doom",
            "Erik Lehnsherr",
            "En Sabah Nur",
            "Lex Luthor"});
            this.op3CB.Location = new System.Drawing.Point(165, 100);
            this.op3CB.Name = "op3CB";
            this.op3CB.Size = new System.Drawing.Size(121, 21);
            this.op3CB.TabIndex = 6;
            // 
            // op4CB
            // 
            this.op4CB.FormattingEnabled = true;
            this.op4CB.Items.AddRange(new object[] {
            "Dio Brando",
            "Hisoka Morrow",
            "Van Hohenheim",
            "Raoh",
            "Meruem",
            "Baron Zemo",
            "Victor Von Doom",
            "Erik Lehnsherr",
            "En Sabah Nur",
            "Lex Luthor"});
            this.op4CB.Location = new System.Drawing.Point(164, 134);
            this.op4CB.Name = "op4CB";
            this.op4CB.Size = new System.Drawing.Size(121, 21);
            this.op4CB.TabIndex = 7;
            // 
            // op5CB
            // 
            this.op5CB.FormattingEnabled = true;
            this.op5CB.Items.AddRange(new object[] {
            "Dio Brando",
            "Hisoka Morrow",
            "Van Hohenheim",
            "Raoh",
            "Meruem",
            "Baron Zemo",
            "Victor Von Doom",
            "Erik Lehnsherr",
            "En Sabah Nur",
            "Lex Luthor"});
            this.op5CB.Location = new System.Drawing.Point(165, 168);
            this.op5CB.Name = "op5CB";
            this.op5CB.Size = new System.Drawing.Size(121, 21);
            this.op5CB.TabIndex = 8;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Novice",
            "Intermiediate",
            "Expert"});
            this.comboBox6.Location = new System.Drawing.Point(165, 235);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(72, 21);
            this.comboBox6.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Difficulty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Opposition:";
            // 
            // PlayerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 285);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.op5CB);
            this.Controls.Add(this.op4CB);
            this.Controls.Add(this.op3CB);
            this.Controls.Add(this.op2CB);
            this.Controls.Add(this.op1CB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "PlayerList";
            this.Text = "PlayerList";
            this.Load += new System.EventHandler(this.PlayerList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox op1CB;
        private System.Windows.Forms.ComboBox op2CB;
        private System.Windows.Forms.ComboBox op3CB;
        private System.Windows.Forms.ComboBox op4CB;
        private System.Windows.Forms.ComboBox op5CB;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}