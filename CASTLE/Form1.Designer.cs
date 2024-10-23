namespace CASTLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Button();
            this.displayText = new System.Windows.Forms.Label();
            this.option1Text = new System.Windows.Forms.Label();
            this.option2Text = new System.Windows.Forms.Label();
            this.option3Text = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Option1
            // 
            this.Option1.Location = new System.Drawing.Point(3, 385);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(75, 23);
            this.Option1.TabIndex = 1;
            this.Option1.Text = "button1";
            this.Option1.UseVisualStyleBackColor = true;
            this.Option1.Click += new System.EventHandler(this.Option1_Click);
            // 
            // option2
            // 
            this.option2.Location = new System.Drawing.Point(3, 425);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(75, 23);
            this.option2.TabIndex = 2;
            this.option2.Text = "button2";
            this.option2.UseVisualStyleBackColor = true;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // option3
            // 
            this.option3.Location = new System.Drawing.Point(4, 470);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(75, 23);
            this.option3.TabIndex = 3;
            this.option3.Text = "button3";
            this.option3.UseVisualStyleBackColor = true;
            this.option3.Click += new System.EventHandler(this.option3_Click);
            // 
            // displayText
            // 
            this.displayText.AutoSize = true;
            this.displayText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displayText.Location = new System.Drawing.Point(124, 75);
            this.displayText.Name = "displayText";
            this.displayText.Size = new System.Drawing.Size(35, 13);
            this.displayText.TabIndex = 4;
            this.displayText.Text = "label1";
            // 
            // option1Text
            // 
            this.option1Text.AutoSize = true;
            this.option1Text.ForeColor = System.Drawing.Color.Transparent;
            this.option1Text.Location = new System.Drawing.Point(115, 395);
            this.option1Text.Name = "option1Text";
            this.option1Text.Size = new System.Drawing.Size(35, 13);
            this.option1Text.TabIndex = 5;
            this.option1Text.Text = "label1";
            // 
            // option2Text
            // 
            this.option2Text.AutoSize = true;
            this.option2Text.ForeColor = System.Drawing.Color.Transparent;
            this.option2Text.Location = new System.Drawing.Point(115, 425);
            this.option2Text.Name = "option2Text";
            this.option2Text.Size = new System.Drawing.Size(35, 13);
            this.option2Text.TabIndex = 6;
            this.option2Text.Text = "label1";
            // 
            // option3Text
            // 
            this.option3Text.AutoSize = true;
            this.option3Text.ForeColor = System.Drawing.Color.Transparent;
            this.option3Text.Location = new System.Drawing.Point(115, 475);
            this.option3Text.Name = "option3Text";
            this.option3Text.Size = new System.Drawing.Size(35, 13);
            this.option3Text.TabIndex = 7;
            this.option3Text.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CASTLE.Properties.Resources.page1drawing;
            this.pictureBox1.Location = new System.Drawing.Point(3, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 259);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(404, 508);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.option3Text);
            this.Controls.Add(this.option2Text);
            this.Controls.Add(this.option1Text);
            this.Controls.Add(this.displayText);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.Option1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DRAGON";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Button option3;
        private System.Windows.Forms.Label displayText;
        private System.Windows.Forms.Label option1Text;
        private System.Windows.Forms.Label option2Text;
        private System.Windows.Forms.Label option3Text;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

