namespace Bai3
{
    partial class frmHoTen
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
            this.label3 = new System.Windows.Forms.Label();
            this.pnlHoTen = new System.Windows.Forms.Panel();
            this.lblHovaTen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHo = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlHoTen.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên";
            // 
            // pnlHoTen
            // 
            this.pnlHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlHoTen.Controls.Add(this.lblHovaTen);
            this.pnlHoTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHoTen.Location = new System.Drawing.Point(0, 0);
            this.pnlHoTen.Name = "pnlHoTen";
            this.pnlHoTen.Size = new System.Drawing.Size(314, 47);
            this.pnlHoTen.TabIndex = 4;
            // 
            // lblHovaTen
            // 
            this.lblHovaTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHovaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHovaTen.Location = new System.Drawing.Point(0, 0);
            this.lblHovaTen.Name = "lblHovaTen";
            this.lblHovaTen.Size = new System.Drawing.Size(314, 47);
            this.lblHovaTen.TabIndex = 14;
            this.lblHovaTen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHovaTen.Click += new System.EventHandler(this.lblHovaTen_Click);
            this.lblHovaTen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblHovaTen_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ Lót";
            // 
            // txtHo
            // 
            this.txtHo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtHo.Location = new System.Drawing.Point(91, 79);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(154, 20);
            this.txtHo.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(91, 114);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(154, 20);
            this.txtTen.TabIndex = 9;
            // 
            // btnHo
            // 
            this.btnHo.Location = new System.Drawing.Point(27, 162);
            this.btnHo.Name = "btnHo";
            this.btnHo.Size = new System.Drawing.Size(75, 23);
            this.btnHo.TabIndex = 10;
            this.btnHo.Text = "&Họ Lót";
            this.btnHo.UseVisualStyleBackColor = true;
            this.btnHo.Click += new System.EventHandler(this.btnHo_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(108, 162);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 23);
            this.btnTen.TabIndex = 11;
            this.btnTen.Text = "&Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.Location = new System.Drawing.Point(189, 162);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(75, 23);
            this.btnHoTen.TabIndex = 12;
            this.btnHoTen.Text = "Họ và Tên ";
            this.btnHoTen.UseVisualStyleBackColor = true;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(91, 198);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 23);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát Chương Trình";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmHoTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 233);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHo);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlHoTen);
            this.Controls.Add(this.label3);
            this.Name = "frmHoTen";
            this.Text = "Bài Tập Họ Tên";
            this.Load += new System.EventHandler(this.frmHoTen_Load);
            this.pnlHoTen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHo;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblHovaTen;
    }
}

