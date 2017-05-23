namespace forms_testing
{
    partial class verticle_pos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftBtn = new System.Windows.Forms.Button();
            this.keyBoard = new System.Windows.Forms.Button();
            this.rightBtn = new System.Windows.Forms.Button();
            this.printOptions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(100, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // leftBtn
            // 
            this.leftBtn.Location = new System.Drawing.Point(100, 666);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(140, 50);
            this.leftBtn.TabIndex = 1;
            this.leftBtn.Text = "Left";
            this.leftBtn.UseVisualStyleBackColor = true;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // keyBoard
            // 
            this.keyBoard.Location = new System.Drawing.Point(100, 772);
            this.keyBoard.Name = "keyBoard";
            this.keyBoard.Size = new System.Drawing.Size(140, 50);
            this.keyBoard.TabIndex = 2;
            this.keyBoard.Text = "Keyboard";
            this.keyBoard.UseVisualStyleBackColor = true;
            // 
            // rightBtn
            // 
            this.rightBtn.Location = new System.Drawing.Point(355, 666);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(140, 50);
            this.rightBtn.TabIndex = 3;
            this.rightBtn.Text = "Right";
            this.rightBtn.UseVisualStyleBackColor = true;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // printOptions
            // 
            this.printOptions.Location = new System.Drawing.Point(355, 772);
            this.printOptions.Name = "printOptions";
            this.printOptions.Size = new System.Drawing.Size(140, 50);
            this.printOptions.TabIndex = 4;
            this.printOptions.Text = "Print Options";
            this.printOptions.UseVisualStyleBackColor = true;
            this.printOptions.Click += new System.EventHandler(this.printOptions_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 861);
            this.Controls.Add(this.printOptions);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.keyBoard);
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.Button keyBoard;
        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Button printOptions;
    }
}