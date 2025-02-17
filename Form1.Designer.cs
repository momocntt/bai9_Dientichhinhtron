namespace bai9_Dientichhinhtron
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
            this.lblKq = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCv = new System.Windows.Forms.Button();
            this.btnDt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCv = new System.Windows.Forms.RadioButton();
            this.rdbDt = new System.Windows.Forms.RadioButton();
            this.txtBk = new System.Windows.Forms.TextBox();
            this.lblKqmoi = new System.Windows.Forms.Label();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.txtKqmoi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chu vi diện tích hình tròn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập bán kính";
            // 
            // lblKq
            // 
            this.lblKq.AutoSize = true;
            this.lblKq.Location = new System.Drawing.Point(90, 293);
            this.lblKq.Name = "lblKq";
            this.lblKq.Size = new System.Drawing.Size(44, 13);
            this.lblKq.TabIndex = 1;
            this.lblKq.Text = "Kết quả";
            this.lblKq.Click += new System.EventHandler(this.lblKq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 1;
            // 
            // btnCv
            // 
            this.btnCv.Location = new System.Drawing.Point(93, 189);
            this.btnCv.Name = "btnCv";
            this.btnCv.Size = new System.Drawing.Size(113, 44);
            this.btnCv.TabIndex = 2;
            this.btnCv.Text = "Chu vi";
            this.btnCv.UseVisualStyleBackColor = true;
            // 
            // btnDt
            // 
            this.btnDt.Location = new System.Drawing.Point(217, 189);
            this.btnDt.Name = "btnDt";
            this.btnDt.Size = new System.Drawing.Size(113, 44);
            this.btnDt.TabIndex = 2;
            this.btnDt.Text = "Diện tích";
            this.btnDt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDt);
            this.groupBox1.Controls.Add(this.rdbCv);
            this.groupBox1.Location = new System.Drawing.Point(511, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 199);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbCv
            // 
            this.rdbCv.AutoSize = true;
            this.rdbCv.Location = new System.Drawing.Point(10, 43);
            this.rdbCv.Name = "rdbCv";
            this.rdbCv.Size = new System.Drawing.Size(55, 17);
            this.rdbCv.TabIndex = 0;
            this.rdbCv.TabStop = true;
            this.rdbCv.Text = "Chu vi";
            this.rdbCv.UseVisualStyleBackColor = true;
            // 
            // rdbDt
            // 
            this.rdbDt.AutoSize = true;
            this.rdbDt.Location = new System.Drawing.Point(10, 112);
            this.rdbDt.Name = "rdbDt";
            this.rdbDt.Size = new System.Drawing.Size(69, 17);
            this.rdbDt.TabIndex = 0;
            this.rdbDt.TabStop = true;
            this.rdbDt.Text = "Diện tích";
            this.rdbDt.UseVisualStyleBackColor = true;
            // 
            // txtBk
            // 
            this.txtBk.Location = new System.Drawing.Point(184, 87);
            this.txtBk.Name = "txtBk";
            this.txtBk.Size = new System.Drawing.Size(115, 20);
            this.txtBk.TabIndex = 4;
            // 
            // lblKqmoi
            // 
            this.lblKqmoi.AutoSize = true;
            this.lblKqmoi.Location = new System.Drawing.Point(447, 343);
            this.lblKqmoi.Name = "lblKqmoi";
            this.lblKqmoi.Size = new System.Drawing.Size(44, 13);
            this.lblKqmoi.TabIndex = 1;
            this.lblKqmoi.Text = "Kết quả";
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(170, 283);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(118, 20);
            this.txtKq.TabIndex = 5;
            this.txtKq.TextChanged += new System.EventHandler(this.txtKq_TextChanged);
            // 
            // txtKqmoi
            // 
            this.txtKqmoi.Location = new System.Drawing.Point(539, 336);
            this.txtKqmoi.Name = "txtKqmoi";
            this.txtKqmoi.Size = new System.Drawing.Size(118, 20);
            this.txtKqmoi.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKqmoi);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtBk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDt);
            this.Controls.Add(this.btnCv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKqmoi);
            this.Controls.Add(this.lblKq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCv;
        private System.Windows.Forms.Button btnDt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDt;
        private System.Windows.Forms.RadioButton rdbCv;
        private System.Windows.Forms.TextBox txtBk;
        private System.Windows.Forms.Label lblKqmoi;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.TextBox txtKqmoi;
    }
}

