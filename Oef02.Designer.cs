namespace Dictionaries
{
    partial class Oef02
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
            this.lblEngels = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNederlands = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEngels
            // 
            this.lblEngels.AutoSize = true;
            this.lblEngels.Location = new System.Drawing.Point(165, 15);
            this.lblEngels.Name = "lblEngels";
            this.lblEngels.Size = new System.Drawing.Size(38, 13);
            this.lblEngels.TabIndex = 5;
            this.lblEngels.Text = "engels";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "=>";
            // 
            // cbNederlands
            // 
            this.cbNederlands.FormattingEnabled = true;
            this.cbNederlands.Location = new System.Drawing.Point(12, 12);
            this.cbNederlands.Name = "cbNederlands";
            this.cbNederlands.Size = new System.Drawing.Size(121, 21);
            this.cbNederlands.TabIndex = 3;
            this.cbNederlands.SelectedIndexChanged += new System.EventHandler(this.cbNederlands_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(167, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Voeg toe/Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Oef02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 92);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEngels);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNederlands);
            this.Name = "Oef02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oef02";
            this.Load += new System.EventHandler(this.Oef02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEngels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNederlands;
        private System.Windows.Forms.Button btnAdd;
    }
}