
namespace _020964
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
            this.btndiposit = new System.Windows.Forms.Button();
            this.btnfast = new System.Windows.Forms.Button();
            this.btnwit = new System.Windows.Forms.Button();
            this.btnstage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btndiposit
            // 
            this.btndiposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiposit.Location = new System.Drawing.Point(12, 44);
            this.btndiposit.Name = "btndiposit";
            this.btndiposit.Size = new System.Drawing.Size(120, 44);
            this.btndiposit.TabIndex = 0;
            this.btndiposit.Text = "ฝากเงิน";
            this.btndiposit.UseVisualStyleBackColor = true;
            this.btndiposit.Click += new System.EventHandler(this.btndiposit_Click);
            // 
            // btnfast
            // 
            this.btnfast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfast.Location = new System.Drawing.Point(12, 108);
            this.btnfast.Name = "btnfast";
            this.btnfast.Size = new System.Drawing.Size(120, 44);
            this.btnfast.TabIndex = 1;
            this.btnfast.Text = "ถอนด่วน";
            this.btnfast.UseVisualStyleBackColor = true;
            this.btnfast.Click += new System.EventHandler(this.btnfast_Click);
            // 
            // btnwit
            // 
            this.btnwit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnwit.Location = new System.Drawing.Point(12, 174);
            this.btnwit.Name = "btnwit";
            this.btnwit.Size = new System.Drawing.Size(120, 44);
            this.btnwit.TabIndex = 2;
            this.btnwit.Text = "ถอนระบุจำนวนเงิน";
            this.btnwit.UseVisualStyleBackColor = true;
            this.btnwit.Click += new System.EventHandler(this.btnwit_Click);
            // 
            // btnstage
            // 
            this.btnstage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstage.Location = new System.Drawing.Point(12, 240);
            this.btnstage.Name = "btnstage";
            this.btnstage.Size = new System.Drawing.Size(120, 44);
            this.btnstage.TabIndex = 3;
            this.btnstage.Text = "button1";
            this.btnstage.UseVisualStyleBackColor = true;
            this.btnstage.Click += new System.EventHandler(this.btnstage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnstage);
            this.Controls.Add(this.btnwit);
            this.Controls.Add(this.btnfast);
            this.Controls.Add(this.btndiposit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndiposit;
        private System.Windows.Forms.Button btnfast;
        private System.Windows.Forms.Button btnwit;
        private System.Windows.Forms.Button btnstage;
        private System.Windows.Forms.Label label1;
    }
}

