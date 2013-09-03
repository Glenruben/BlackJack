namespace BlackJack
{
    partial class BlackJackCat
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
            this.deal = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.cardLabel = new System.Windows.Forms.Label();
            this.pointCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bustLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deal
            // 
            this.deal.Location = new System.Drawing.Point(29, 218);
            this.deal.Name = "deal";
            this.deal.Size = new System.Drawing.Size(75, 23);
            this.deal.TabIndex = 0;
            this.deal.Text = "DEAL";
            this.deal.UseVisualStyleBackColor = true;
            this.deal.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(26, 19);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(126, 13);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "Press DEAL for new card";
            this.infoLabel.Click += new System.EventHandler(this.result_Click);
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Location = new System.Drawing.Point(48, 53);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(0, 13);
            this.cardLabel.TabIndex = 3;
            // 
            // pointCount
            // 
            this.pointCount.AutoSize = true;
            this.pointCount.Location = new System.Drawing.Point(93, 253);
            this.pointCount.Name = "pointCount";
            this.pointCount.Size = new System.Drawing.Size(13, 13);
            this.pointCount.TabIndex = 4;
            this.pointCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Points:";
            // 
            // bustLabel
            // 
            this.bustLabel.AutoSize = true;
            this.bustLabel.Location = new System.Drawing.Point(116, 176);
            this.bustLabel.Name = "bustLabel";
            this.bustLabel.Size = new System.Drawing.Size(0, 13);
            this.bustLabel.TabIndex = 6;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(193, 218);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // BlackJackCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 284);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.bustLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pointCount);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.deal);
            this.Name = "BlackJackCat";
            this.Text = "BlackJackCat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deal;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.Label pointCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bustLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

