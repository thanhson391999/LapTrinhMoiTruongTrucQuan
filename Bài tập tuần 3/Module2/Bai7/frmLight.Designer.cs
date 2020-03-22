namespace Bai7
{
    partial class frmLight
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesign = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesign = new System.Windows.Forms.TextBox();
            this.txtOn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picOff = new System.Windows.Forms.PictureBox();
            this.picOn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(47, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.lblDesign.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDesign.Location = new System.Drawing.Point(47, 164);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(58, 13);
            this.lblDesign.TabIndex = 1;
            this.lblDesign.Text = "Design By:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(112, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDesign
            // 
            this.txtDesign.Enabled = false;
            this.txtDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesign.Location = new System.Drawing.Point(136, 157);
            this.txtDesign.Name = "txtDesign";
            this.txtDesign.ReadOnly = true;
            this.txtDesign.Size = new System.Drawing.Size(112, 20);
            this.txtDesign.TabIndex = 3;
            this.txtDesign.Text = "Thanh Sơn";
            this.txtDesign.TextChanged += new System.EventHandler(this.txtDesign_TextChanged);
            // 
            // txtOn
            // 
            this.txtOn.Location = new System.Drawing.Point(12, 131);
            this.txtOn.Name = "txtOn";
            this.txtOn.ReadOnly = true;
            this.txtOn.Size = new System.Drawing.Size(359, 20);
            this.txtOn.TabIndex = 4;
            this.txtOn.TextChanged += new System.EventHandler(this.txtOn_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picOff
            // 
            this.picOff.Image = global::Bai7.Properties.Resources.icons8_light_80;
            this.picOff.Location = new System.Drawing.Point(136, 31);
            this.picOff.Name = "picOff";
            this.picOff.Size = new System.Drawing.Size(112, 93);
            this.picOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOff.TabIndex = 7;
            this.picOff.TabStop = false;
            this.picOff.Click += new System.EventHandler(this.picOff_Click);
            // 
            // picOn
            // 
            this.picOn.Location = new System.Drawing.Point(136, 31);
            this.picOn.Name = "picOn";
            this.picOn.Size = new System.Drawing.Size(112, 94);
            this.picOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOn.TabIndex = 5;
            this.picOn.TabStop = false;
            this.picOn.Click += new System.EventHandler(this.picOn_Click);
            // 
            // frmLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 195);
            this.Controls.Add(this.picOff);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picOn);
            this.Controls.Add(this.txtOn);
            this.Controls.Add(this.txtDesign);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.lblName);
            this.Name = "frmLight";
            this.Text = "Light";
            ((System.ComponentModel.ISupportInitialize)(this.picOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion



        private System.Windows.Forms.Label lblName;

        private System.Windows.Forms.Label lblDesign;

        private System.Windows.Forms.TextBox txtName;

        private System.Windows.Forms.TextBox txtDesign;

        private System.Windows.Forms.TextBox txtOn;

        private System.Windows.Forms.PictureBox picOn;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.PictureBox picOff;
    }
}

