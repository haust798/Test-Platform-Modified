﻿namespace TestPlatform
{
    partial class FormExposition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExposition));
            this.wordLabel = new System.Windows.Forms.Label();
            this.imgPictureBox = new System.Windows.Forms.PictureBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.response_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // wordLabel
            // 
            this.wordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordLabel.AutoEllipsis = true;
            this.wordLabel.BackColor = System.Drawing.Color.Transparent;
            this.wordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 160F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLabel.Location = new System.Drawing.Point(5, 103);
            this.wordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(761, 269);
            this.wordLabel.TabIndex = 1;
            this.wordLabel.Text = "word";
            this.wordLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.wordLabel.Visible = false;
            // 
            // imgPictureBox
            // 
            this.imgPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgPictureBox.BackColor = System.Drawing.Color.White;
            this.imgPictureBox.Location = new System.Drawing.Point(124, 41);
            this.imgPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgPictureBox.Name = "imgPictureBox";
            this.imgPictureBox.Size = new System.Drawing.Size(476, 454);
            this.imgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPictureBox.TabIndex = 10;
            this.imgPictureBox.TabStop = false;
            this.imgPictureBox.Visible = false;
            // 
            // instructionLabel
            // 
            this.instructionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(8, 7);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(695, 524);
            this.instructionLabel.TabIndex = 11;
            this.instructionLabel.Text = "instruction";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.instructionLabel.Visible = false;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLabel.Enabled = false;
            this.subtitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitleLabel.Location = new System.Drawing.Point(203, 402);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(252, 76);
            this.subtitleLabel.TabIndex = 12;
            this.subtitleLabel.Text = "subtitle";
            this.subtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subtitleLabel.Visible = false;
            // 
            // response_label
            // 
            this.response_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.response_label.AutoSize = true;
            this.response_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.response_label.ForeColor = System.Drawing.Color.White;
            this.response_label.Location = new System.Drawing.Point(229, 77);
            this.response_label.Name = "response_label";
            this.response_label.Size = new System.Drawing.Size(268, 95);
            this.response_label.TabIndex = 13;
            this.response_label.Text = "label1";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(114, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 200);
            this.button1.TabIndex = 14;
            this.button1.Text = "YES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(400, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 200);
            this.button2.TabIndex = 15;
            this.button2.Text = "NO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button2_KeyDown);
            // 
            // FormExposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(715, 542);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.response_label);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.imgPictureBox);
            this.Controls.Add(this.instructionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormExposition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StroopTest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormExposition_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.PictureBox imgPictureBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label response_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

