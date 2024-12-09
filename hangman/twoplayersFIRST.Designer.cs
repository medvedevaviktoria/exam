namespace hangman
{
    partial class twoplayersFIRST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(twoplayersFIRST));
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.labelword = new System.Windows.Forms.Label();
            this.textBoxtCategory = new System.Windows.Forms.TextBox();
            this.labelcategory = new System.Windows.Forms.Label();
            this.buttonback1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Linen;
            this.buttonStart.Enabled = false;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(462, 373);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(103, 42);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Играть!";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxWord
            // 
            this.textBoxWord.BackColor = System.Drawing.Color.Linen;
            this.textBoxWord.Location = new System.Drawing.Point(428, 319);
            this.textBoxWord.Multiline = true;
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(175, 28);
            this.textBoxWord.TabIndex = 1;
            this.textBoxWord.TextChanged += new System.EventHandler(this.textBoxWord_TextChanged);
            this.textBoxWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWord_KeyPress);
            // 
            // labelword
            // 
            this.labelword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelword.Location = new System.Drawing.Point(428, 276);
            this.labelword.Name = "labelword";
            this.labelword.Size = new System.Drawing.Size(175, 28);
            this.labelword.TabIndex = 19;
            this.labelword.Text = "Напишите слово:";
            this.labelword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxtCategory
            // 
            this.textBoxtCategory.BackColor = System.Drawing.Color.Linen;
            this.textBoxtCategory.Location = new System.Drawing.Point(428, 205);
            this.textBoxtCategory.Multiline = true;
            this.textBoxtCategory.Name = "textBoxtCategory";
            this.textBoxtCategory.Size = new System.Drawing.Size(175, 28);
            this.textBoxtCategory.TabIndex = 0;
            this.textBoxtCategory.TextChanged += new System.EventHandler(this.textBoxtCategory_TextChanged);
            this.textBoxtCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxtCategory_KeyPress);
            // 
            // labelcategory
            // 
            this.labelcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcategory.Location = new System.Drawing.Point(414, 164);
            this.labelcategory.Name = "labelcategory";
            this.labelcategory.Size = new System.Drawing.Size(207, 28);
            this.labelcategory.TabIndex = 17;
            this.labelcategory.Text = "Укажите категорию:";
            this.labelcategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonback1
            // 
            this.buttonback1.BackColor = System.Drawing.Color.LightPink;
            this.buttonback1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonback1.Location = new System.Drawing.Point(12, 560);
            this.buttonback1.Name = "buttonback1";
            this.buttonback1.Size = new System.Drawing.Size(106, 38);
            this.buttonback1.TabIndex = 3;
            this.buttonback1.Text = "В меню";
            this.buttonback1.UseVisualStyleBackColor = false;
            this.buttonback1.Click += new System.EventHandler(this.buttonback1_Click);
            // 
            // twoplayersFIRST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1025, 617);
            this.ControlBox = false;
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.labelword);
            this.Controls.Add(this.textBoxtCategory);
            this.Controls.Add(this.labelcategory);
            this.Controls.Add(this.buttonback1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "twoplayersFIRST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виселица";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Label labelword;
        private System.Windows.Forms.TextBox textBoxtCategory;
        private System.Windows.Forms.Label labelcategory;
        private System.Windows.Forms.Button buttonback1;
    }
}