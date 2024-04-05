
namespace _020964
{
    partial class Dipsit
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btndiposit = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(108, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 31);
            this.textBox1.TabIndex = 0;
            // 
            // btndiposit
            // 
            this.btndiposit.Location = new System.Drawing.Point(165, 161);
            this.btndiposit.Name = "btndiposit";
            this.btndiposit.Size = new System.Drawing.Size(128, 52);
            this.btndiposit.TabIndex = 1;
            this.btndiposit.Text = "ถอน";
            this.btndiposit.UseVisualStyleBackColor = true;
            this.btndiposit.Click += new System.EventHandler(this.btndiposit_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(12, 272);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(103, 39);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "กลับหน้าหลัก";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Dipsit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 323);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btndiposit);
            this.Controls.Add(this.textBox1);
            this.Name = "Dipsit";
            this.Text = "Dipsit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btndiposit;
        private System.Windows.Forms.Button btnback;
    }
}