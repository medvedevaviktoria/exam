namespace hangman
{
    partial class twoplayersSECOND
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(twoplayersSECOND));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.hiddenword_label = new System.Windows.Forms.Label();
            this.label2Category = new System.Windows.Forms.Label();
            this.labelEnter = new System.Windows.Forms.Label();
            this.userGuessLetter = new System.Windows.Forms.TextBox();
            this.buttonback2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 469);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
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
            this.buttonGuess.TabIndex = 1;
            this.buttonGuess.Text = "Испытать удачу";
            this.buttonGuess.UseVisualStyleBackColor = false;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // hiddenword_label
            // 
            this.hiddenword_label.AutoSize = true;
            this.hiddenword_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hiddenword_label.Location = new System.Drawing.Point(628, 365);
            this.hiddenword_label.Name = "hiddenword_label";
            this.hiddenword_label.Size = new System.Drawing.Size(190, 25);
            this.hiddenword_label.TabIndex = 20;
            this.hiddenword_label.Text = "(загаданное слово)";
            // 
            // label2Category
            // 
            this.label2Category.AutoSize = true;
            this.label2Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2Category.Location = new System.Drawing.Point(543, 61);
            this.label2Category.Name = "label2Category";
            this.label2Category.Size = new System.Drawing.Size(152, 31);
            this.label2Category.TabIndex = 19;
            this.label2Category.Text = "Категория:\r\n";
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnter.Location = new System.Drawing.Point(532, 474);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(138, 22);
            this.labelEnter.TabIndex = 18;
            this.labelEnter.Text = "Введите букву:";
            // 
            // userGuessLetter
            // 
            this.userGuessLetter.BackColor = System.Drawing.Color.Linen;
            this.userGuessLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userGuessLetter.Location = new System.Drawing.Point(676, 473);
            this.userGuessLetter.MaxLength = 1;
            this.userGuessLetter.Name = "userGuessLetter";
            this.userGuessLetter.Size = new System.Drawing.Size(74, 29);
            this.userGuessLetter.TabIndex = 0;
            this.userGuessLetter.TextChanged += new System.EventHandler(this.userGuessLetter_TextChanged);
            this.userGuessLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userGuessLetter_KeyPress);
            // 
            // buttonback2
            // 
            this.buttonback2.BackColor = System.Drawing.Color.LightPink;
            this.buttonback2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonback2.Location = new System.Drawing.Point(12, 560);
            this.buttonback2.Name = "buttonback2";
            this.buttonback2.Size = new System.Drawing.Size(106, 38);
            this.buttonback2.TabIndex = 2;
            this.buttonback2.Text = "В меню";
            this.buttonback2.UseVisualStyleBackColor = false;
            this.buttonback2.Click += new System.EventHandler(this.buttonback2_Click);
            // 
            // twoplayersSECOND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1025, 617);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.hiddenword_label);
            this.Controls.Add(this.label2Category);
            this.Controls.Add(this.labelEnter);
            this.Controls.Add(this.userGuessLetter);
            this.Controls.Add(this.buttonback2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "twoplayersSECOND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виселица";
            this.Load += new System.EventHandler(this.twoplayersSECOND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button buttonGuess;
        public System.Windows.Forms.Label hiddenword_label;
        public System.Windows.Forms.Label label2Category;
        public System.Windows.Forms.Label labelEnter;
        public System.Windows.Forms.TextBox userGuessLetter;
        public System.Windows.Forms.Button buttonback2;
    }
}