namespace hangman
{
    partial class oneplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oneplayer));
            this.buttonback = new System.Windows.Forms.Button();
            this.userGuessLetter = new System.Windows.Forms.TextBox();
            this.labelEnter = new System.Windows.Forms.Label();
            this.labelcategory = new System.Windows.Forms.Label();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.choosecategory = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hiddenword_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.Color.LightPink;
            this.buttonback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonback.Location = new System.Drawing.Point(12, 560);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(106, 38);
            this.buttonback.TabIndex = 6;
            this.buttonback.Text = "В меню";
            this.buttonback.UseVisualStyleBackColor = false;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // userGuessLetter
            // 
            this.userGuessLetter.BackColor = System.Drawing.Color.Linen;
            this.userGuessLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userGuessLetter.Location = new System.Drawing.Point(676, 473);
            this.userGuessLetter.MaxLength = 1;
            this.userGuessLetter.Name = "userGuessLetter";
            this.userGuessLetter.Size = new System.Drawing.Size(74, 29);
            this.userGuessLetter.TabIndex = 3;
            this.userGuessLetter.Visible = false;
            this.userGuessLetter.TextChanged += new System.EventHandler(this.userGuessLetter_TextChanged);
            this.userGuessLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userGuessLetter_KeyPress);
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnter.Location = new System.Drawing.Point(532, 474);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(138, 22);
            this.labelEnter.TabIndex = 2;
            this.labelEnter.Text = "Введите букву:";
            this.labelEnter.Visible = false;
            // 
            // labelcategory
            // 
            this.labelcategory.AutoSize = true;
            this.labelcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcategory.Location = new System.Drawing.Point(543, 61);
            this.labelcategory.Name = "labelcategory";
            this.labelcategory.Size = new System.Drawing.Size(152, 31);
            this.labelcategory.TabIndex = 3;
            this.labelcategory.Text = "Категория:\r\n";
            // 
            // buttonGuess
            // 
            this.buttonGuess.BackColor = System.Drawing.Color.Linen;
            this.buttonGuess.Enabled = false;
            this.buttonGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGuess.Location = new System.Drawing.Point(772, 473);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(171, 28);
            this.buttonGuess.TabIndex = 4;
            this.buttonGuess.Text = "Испытать удачу";
            this.buttonGuess.UseVisualStyleBackColor = false;
            this.buttonGuess.Visible = false;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // choosecategory
            // 
            this.choosecategory.BackColor = System.Drawing.Color.Linen;
            this.choosecategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choosecategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choosecategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choosecategory.FormattingEnabled = true;
            this.choosecategory.Items.AddRange(new object[] {
            "Случайная категория",
            "Музыкальные инструменты",
            "Профессии",
            "Спорт",
            "Страны",
            "Фрукты и ягоды"});
            this.choosecategory.Location = new System.Drawing.Point(703, 64);
            this.choosecategory.Name = "choosecategory";
            this.choosecategory.Size = new System.Drawing.Size(261, 28);
            this.choosecategory.TabIndex = 7;
            this.choosecategory.SelectedIndexChanged += new System.EventHandler(this.choosecategory_SelectedIndexChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Linen;
            this.buttonStart.Enabled = false;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(676, 130);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(103, 42);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Играть!";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 469);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // hiddenword_label
            // 
            this.hiddenword_label.AutoSize = true;
            this.hiddenword_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hiddenword_label.Location = new System.Drawing.Point(628, 365);
            this.hiddenword_label.Name = "hiddenword_label";
            this.hiddenword_label.Size = new System.Drawing.Size(190, 25);
            this.hiddenword_label.TabIndex = 4;
            this.hiddenword_label.Text = "(загаданное слово)";
            this.hiddenword_label.Visible = false;
            // 
            // oneplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1025, 617);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.choosecategory);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.hiddenword_label);
            this.Controls.Add(this.labelcategory);
            this.Controls.Add(this.labelEnter);
            this.Controls.Add(this.userGuessLetter);
            this.Controls.Add(this.buttonback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "oneplayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виселица";
            this.Load += new System.EventHandler(this.oneplayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.TextBox userGuessLetter;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.Label labelcategory;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.ComboBox choosecategory;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label hiddenword_label;
    }
}