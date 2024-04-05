
namespace atm
{
    partial class fast
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
            this.rs5000 = new System.Windows.Forms.Button();
            this.rs500 = new System.Windows.Forms.Button();
            this.rs2000 = new System.Windows.Forms.Button();
            this.rs100 = new System.Windows.Forms.Button();
            this.rs1000 = new System.Windows.Forms.Button();
            this.rs200 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rs5000
            // 
            this.rs5000.BackColor = System.Drawing.Color.Green;
            this.rs5000.ForeColor = System.Drawing.Color.White;
            this.rs5000.Location = new System.Drawing.Point(386, 278);
            this.rs5000.Name = "rs5000";
            this.rs5000.Size = new System.Drawing.Size(111, 47);
            this.rs5000.TabIndex = 7;
            this.rs5000.Text = "5000";
            this.rs5000.UseVisualStyleBackColor = false;
            // 
            // rs500
            // 
            this.rs500.BackColor = System.Drawing.Color.Green;
            this.rs500.ForeColor = System.Drawing.Color.White;
            this.rs500.Location = new System.Drawing.Point(93, 196);
            this.rs500.Name = "rs500";
            this.rs500.Size = new System.Drawing.Size(111, 47);
            this.rs500.TabIndex = 6;
            this.rs500.Text = "500";
            this.rs500.UseVisualStyleBackColor = false;
            // 
            // rs2000
            // 
            this.rs2000.BackColor = System.Drawing.Color.Green;
            this.rs2000.ForeColor = System.Drawing.Color.White;
            this.rs2000.Location = new System.Drawing.Point(93, 278);
            this.rs2000.Name = "rs2000";
            this.rs2000.Size = new System.Drawing.Size(111, 47);
            this.rs2000.TabIndex = 5;
            this.rs2000.Text = "2000";
            this.rs2000.UseVisualStyleBackColor = false;
            // 
            // rs100
            // 
            this.rs100.BackColor = System.Drawing.Color.Green;
            this.rs100.ForeColor = System.Drawing.Color.White;
            this.rs100.Location = new System.Drawing.Point(93, 110);
            this.rs100.Name = "rs100";
            this.rs100.Size = new System.Drawing.Size(111, 47);
            this.rs100.TabIndex = 4;
            this.rs100.Text = "100";
            this.rs100.UseVisualStyleBackColor = false;
            // 
            // rs1000
            // 
            this.rs1000.BackColor = System.Drawing.Color.Green;
            this.rs1000.ForeColor = System.Drawing.Color.White;
            this.rs1000.Location = new System.Drawing.Point(386, 196);
            this.rs1000.Name = "rs1000";
            this.rs1000.Size = new System.Drawing.Size(111, 47);
            this.rs1000.TabIndex = 9;
            this.rs1000.Text = "1000";
            this.rs1000.UseVisualStyleBackColor = false;
            // 
            // rs200
            // 
            this.rs200.BackColor = System.Drawing.Color.Green;
            this.rs200.ForeColor = System.Drawing.Color.White;
            this.rs200.Location = new System.Drawing.Point(386, 110);
            this.rs200.Name = "rs200";
            this.rs200.Size = new System.Drawing.Size(111, 47);
            this.rs200.TabIndex = 8;
            this.rs200.Text = "200";
            this.rs200.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "เลือกจำนวนเงิน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "ออก";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 379);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rs1000);
            this.Controls.Add(this.rs200);
            this.Controls.Add(this.rs5000);
            this.Controls.Add(this.rs500);
            this.Controls.Add(this.rs2000);
            this.Controls.Add(this.rs100);
            this.Name = "fast";
            this.Text = "ถอนด่วน";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rs5000;
        private System.Windows.Forms.Button rs500;
        private System.Windows.Forms.Button rs2000;
        private System.Windows.Forms.Button rs100;
        private System.Windows.Forms.Button rs1000;
        private System.Windows.Forms.Button rs200;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}