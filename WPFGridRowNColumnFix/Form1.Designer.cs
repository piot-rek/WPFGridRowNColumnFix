namespace WPFGridRowNColumnFix
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGMinus = new System.Windows.Forms.Button();
            this.btnGPlus = new System.Windows.Forms.Button();
            this.btnCMinus = new System.Windows.Forms.Button();
            this.btnCPlus = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1077, 648);
            this.textBox1.TabIndex = 0;
            // 
            // btnGMinus
            // 
            this.btnGMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGMinus.Location = new System.Drawing.Point(13, 668);
            this.btnGMinus.Name = "btnGMinus";
            this.btnGMinus.Size = new System.Drawing.Size(174, 63);
            this.btnGMinus.TabIndex = 1;
            this.btnGMinus.Text = "Grid.Row -= 1";
            this.btnGMinus.UseVisualStyleBackColor = true;
            this.btnGMinus.Click += new System.EventHandler(this.btnGMinus_Click);
            // 
            // btnGPlus
            // 
            this.btnGPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGPlus.Location = new System.Drawing.Point(193, 668);
            this.btnGPlus.Name = "btnGPlus";
            this.btnGPlus.Size = new System.Drawing.Size(174, 63);
            this.btnGPlus.TabIndex = 2;
            this.btnGPlus.Text = "Grid.Row += 1";
            this.btnGPlus.UseVisualStyleBackColor = true;
            this.btnGPlus.Click += new System.EventHandler(this.btnGPlus_Click);
            // 
            // btnCMinus
            // 
            this.btnCMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCMinus.Location = new System.Drawing.Point(373, 666);
            this.btnCMinus.Name = "btnCMinus";
            this.btnCMinus.Size = new System.Drawing.Size(174, 63);
            this.btnCMinus.TabIndex = 3;
            this.btnCMinus.Text = "Grid.Column -= 1";
            this.btnCMinus.UseVisualStyleBackColor = true;
            this.btnCMinus.Click += new System.EventHandler(this.btnCMinus_Click);
            // 
            // btnCPlus
            // 
            this.btnCPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCPlus.Location = new System.Drawing.Point(553, 666);
            this.btnCPlus.Name = "btnCPlus";
            this.btnCPlus.Size = new System.Drawing.Size(174, 63);
            this.btnCPlus.TabIndex = 4;
            this.btnCPlus.Text = "Grid.Column += 1";
            this.btnCPlus.UseVisualStyleBackColor = true;
            this.btnCPlus.Click += new System.EventHandler(this.btnCPlus_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPaste.Location = new System.Drawing.Point(733, 666);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(174, 63);
            this.btnPaste.TabIndex = 5;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopy.Location = new System.Drawing.Point(913, 666);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(174, 63);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 742);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnCPlus);
            this.Controls.Add(this.btnCMinus);
            this.Controls.Add(this.btnGPlus);
            this.Controls.Add(this.btnGMinus);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Grid Fix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGMinus;
        private System.Windows.Forms.Button btnGPlus;
        private System.Windows.Forms.Button btnCMinus;
        private System.Windows.Forms.Button btnCPlus;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
    }
}

