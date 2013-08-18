namespace BlackJack
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
            this.deal = new System.Windows.Forms.Button();
            this.stand = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.card = new System.Windows.Forms.Label();
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
            // stand
            // 
            this.stand.Location = new System.Drawing.Point(197, 218);
            this.stand.Name = "stand";
            this.stand.Size = new System.Drawing.Size(75, 23);
            this.stand.TabIndex = 1;
            this.stand.Text = "STAND";
            this.stand.UseVisualStyleBackColor = true;
            this.stand.Click += new System.EventHandler(this.stand_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(55, 69);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 2;
            // 
            // card
            // 
            this.card.AutoSize = true;
            this.card.Location = new System.Drawing.Point(132, 140);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(29, 13);
            this.card.TabIndex = 3;
            this.card.Text = "label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 284);
            this.Controls.Add(this.card);
            this.Controls.Add(this.result);
            this.Controls.Add(this.stand);
            this.Controls.Add(this.deal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deal;
        private System.Windows.Forms.Button stand;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label card;
    }
}

