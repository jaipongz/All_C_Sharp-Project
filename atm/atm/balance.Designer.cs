
namespace atm
{
    partial class balance
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
            this.lbbl1 = new System.Windows.Forms.Label();
            this.lbbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbbl1
            // 
            this.lbbl1.AutoSize = true;
            this.lbbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbl1.Location = new System.Drawing.Point(78, 116);
            this.lbbl1.Name = "lbbl1";
            this.lbbl1.Size = new System.Drawing.Size(142, 25);
            this.lbbl1.TabIndex = 0;
            this.lbbl1.Text = "Your Balance";
            // 
            // lbbl2
            // 
            this.lbbl2.AutoSize = true;
            this.lbbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbl2.Location = new System.Drawing.Point(251, 116);
            this.lbbl2.Name = "lbbl2";
            this.lbbl2.Size = new System.Drawing.Size(70, 25);
            this.lbbl2.TabIndex = 1;
            this.lbbl2.Text = "label2";
            // 
            // balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(587, 379);
            this.Controls.Add(this.lbbl2);
            this.Controls.Add(this.lbbl1);
            this.Name = "balance";
            this.Text = "balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbbl1;
        private System.Windows.Forms.Label lbbl2;
    }
}