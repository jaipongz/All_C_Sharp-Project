
namespace Homework1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.hrin1 = new System.Windows.Forms.TextBox();
            this.minout1 = new System.Windows.Forms.TextBox();
            this.secout1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minin = new System.Windows.Forms.TextBox();
            this.secout2 = new System.Windows.Forms.TextBox();
            this.hrout2 = new System.Windows.Forms.TextBox();
            this.secin = new System.Windows.Forms.TextBox();
            this.minout3 = new System.Windows.Forms.TextBox();
            this.hrout3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "โปรแกรมแปลงค่า";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "นาย ธีรพงษ์ ตั้งมั่น 633121070116";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "แปลงค่า";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hrin1
            // 
            this.hrin1.Location = new System.Drawing.Point(91, 97);
            this.hrin1.Name = "hrin1";
            this.hrin1.Size = new System.Drawing.Size(139, 20);
            this.hrin1.TabIndex = 5;
            // 
            // minout1
            // 
            this.minout1.Location = new System.Drawing.Point(291, 97);
            this.minout1.Name = "minout1";
            this.minout1.Size = new System.Drawing.Size(135, 20);
            this.minout1.TabIndex = 6;
            this.minout1.TextChanged += new System.EventHandler(this.minout1_TextChanged);
            // 
            // secout1
            // 
            this.secout1.Location = new System.Drawing.Point(477, 97);
            this.secout1.Name = "secout1";
            this.secout1.Size = new System.Drawing.Size(135, 20);
            this.secout1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ชั่วโมง  =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "นาที  =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "วินาที =";
            // 
            // minin
            // 
            this.minin.Location = new System.Drawing.Point(91, 159);
            this.minin.Name = "minin";
            this.minin.Size = new System.Drawing.Size(139, 20);
            this.minin.TabIndex = 11;
            this.minin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // secout2
            // 
            this.secout2.Location = new System.Drawing.Point(291, 159);
            this.secout2.Name = "secout2";
            this.secout2.Size = new System.Drawing.Size(135, 20);
            this.secout2.TabIndex = 12;
            // 
            // hrout2
            // 
            this.hrout2.Location = new System.Drawing.Point(477, 159);
            this.hrout2.Name = "hrout2";
            this.hrout2.Size = new System.Drawing.Size(135, 20);
            this.hrout2.TabIndex = 13;
            // 
            // secin
            // 
            this.secin.Location = new System.Drawing.Point(91, 227);
            this.secin.Name = "secin";
            this.secin.Size = new System.Drawing.Size(139, 20);
            this.secin.TabIndex = 14;
            // 
            // minout3
            // 
            this.minout3.Location = new System.Drawing.Point(291, 227);
            this.minout3.Name = "minout3";
            this.minout3.Size = new System.Drawing.Size(135, 20);
            this.minout3.TabIndex = 15;
            // 
            // hrout3
            // 
            this.hrout3.Location = new System.Drawing.Point(477, 227);
            this.hrout3.Name = "hrout3";
            this.hrout3.Size = new System.Drawing.Size(135, 20);
            this.hrout3.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.hrout3);
            this.Controls.Add(this.minout3);
            this.Controls.Add(this.secin);
            this.Controls.Add(this.hrout2);
            this.Controls.Add(this.secout2);
            this.Controls.Add(this.minin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secout1);
            this.Controls.Add(this.minout1);
            this.Controls.Add(this.hrin1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox hrin1;
        private System.Windows.Forms.TextBox minout1;
        private System.Windows.Forms.TextBox secout1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox minin;
        private System.Windows.Forms.TextBox secout2;
        private System.Windows.Forms.TextBox hrout2;
        private System.Windows.Forms.TextBox secin;
        private System.Windows.Forms.TextBox minout3;
        private System.Windows.Forms.TextBox hrout3;
    }
}

