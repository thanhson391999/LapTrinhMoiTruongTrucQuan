namespace Bai6
{
    partial class frmMessageFormater
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
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grbColor = new System.Windows.Forms.GroupBox();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.grbAction = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.chkMessage = new System.Windows.Forms.CheckBox();
            this.picSmall = new System.Windows.Forms.PictureBox();
            this.picBig = new System.Windows.Forms.PictureBox();
            this.txtMessage1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbInput.SuspendLayout();
            this.grbColor.SuspendLayout();
            this.grbAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.txtMessage);
            this.grbInput.Controls.Add(this.txtName);
            this.grbInput.Controls.Add(this.lblMessage);
            this.grbInput.Controls.Add(this.lblName);
            this.grbInput.Location = new System.Drawing.Point(46, 31);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(502, 71);
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Input Name & Message";
            this.grbInput.Enter += new System.EventHandler(this.grbInput_Enter);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.SystemColors.Info;
            this.txtMessage.Location = new System.Drawing.Point(124, 38);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(355, 20);
            this.txtMessage.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Info;
            this.txtName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtName.Location = new System.Drawing.Point(124, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(355, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(36, 46);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // grbColor
            // 
            this.grbColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbColor.Controls.Add(this.rdbBlack);
            this.grbColor.Controls.Add(this.rdbBlue);
            this.grbColor.Controls.Add(this.rdbGreen);
            this.grbColor.Controls.Add(this.rdbRed);
            this.grbColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbColor.Location = new System.Drawing.Point(46, 146);
            this.grbColor.Name = "grbColor";
            this.grbColor.Size = new System.Drawing.Size(133, 194);
            this.grbColor.TabIndex = 3;
            this.grbColor.TabStop = false;
            this.grbColor.Text = "Color";
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Location = new System.Drawing.Point(23, 156);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(52, 17);
            this.rdbBlack.TabIndex = 0;
            this.rdbBlack.TabStop = true;
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.ForeColor = System.Drawing.Color.Aqua;
            this.rdbBlue.Location = new System.Drawing.Point(23, 120);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(46, 17);
            this.rdbBlue.TabIndex = 0;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "Blue";
            this.rdbBlue.UseVisualStyleBackColor = true;
            this.rdbBlue.CheckedChanged += new System.EventHandler(this.rdbBlue_CheckedChanged);
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.ForeColor = System.Drawing.Color.Lime;
            this.rdbGreen.Location = new System.Drawing.Point(23, 79);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(54, 17);
            this.rdbGreen.TabIndex = 0;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            this.rdbGreen.CheckedChanged += new System.EventHandler(this.rdbGreen_CheckedChanged);
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.ForeColor = System.Drawing.Color.Red;
            this.rdbRed.Location = new System.Drawing.Point(23, 43);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(45, 17);
            this.rdbRed.TabIndex = 0;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            this.rdbRed.CheckedChanged += new System.EventHandler(this.rdbRed_CheckedChanged);
            // 
            // grbAction
            // 
            this.grbAction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbAction.Controls.Add(this.btnExit);
            this.grbAction.Controls.Add(this.btnClear);
            this.grbAction.Controls.Add(this.btnDisplay);
            this.grbAction.Location = new System.Drawing.Point(404, 146);
            this.grbAction.Name = "grbAction";
            this.grbAction.Size = new System.Drawing.Size(144, 194);
            this.grbAction.TabIndex = 4;
            this.grbAction.TabStop = false;
            this.grbAction.Text = "Action";
            this.grbAction.Enter += new System.EventHandler(this.x);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(22, 120);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(22, 79);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(22, 37);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // chkMessage
            // 
            this.chkMessage.AutoSize = true;
            this.chkMessage.Location = new System.Drawing.Point(247, 146);
            this.chkMessage.Name = "chkMessage";
            this.chkMessage.Size = new System.Drawing.Size(102, 17);
            this.chkMessage.TabIndex = 2;
            this.chkMessage.Text = "Message Visible";
            this.chkMessage.UseVisualStyleBackColor = true;
            this.chkMessage.CheckedChanged += new System.EventHandler(this.chkMessage_CheckedChanged);
            // 
            // picSmall
            // 
            this.picSmall.BackgroundImage = global::Bai6.Properties.Resources.images;
            this.picSmall.ErrorImage = null;
            this.picSmall.Location = new System.Drawing.Point(264, 190);
            this.picSmall.Name = "picSmall";
            this.picSmall.Size = new System.Drawing.Size(74, 65);
            this.picSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSmall.TabIndex = 4;
            this.picSmall.TabStop = false;
            this.picSmall.Visible = false;
            // 
            // picBig
            // 
            this.picBig.BackgroundImage = global::Bai6.Properties.Resources.images;
            this.picBig.Location = new System.Drawing.Point(249, 234);
            this.picBig.Name = "picBig";
            this.picBig.Size = new System.Drawing.Size(100, 86);
            this.picBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBig.TabIndex = 5;
            this.picBig.TabStop = false;
            this.picBig.Click += new System.EventHandler(this.picBig_Click);
            // 
            // txtMessage1
            // 
            this.txtMessage1.Location = new System.Drawing.Point(46, 391);
            this.txtMessage1.Name = "txtMessage1";
            this.txtMessage1.Size = new System.Drawing.Size(502, 20);
            this.txtMessage1.TabIndex = 4;
            // 
            // frmMessageFormater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.txtMessage1);
            this.Controls.Add(this.picBig);
            this.Controls.Add(this.picSmall);
            this.Controls.Add(this.chkMessage);
            this.Controls.Add(this.grbAction);
            this.Controls.Add(this.grbColor);
            this.Controls.Add(this.grbInput);
            this.Name = "frmMessageFormater";
            this.Text = "Message Formater";
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbColor.ResumeLayout(false);
            this.grbColor.PerformLayout();
            this.grbAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbInput;

        private System.Windows.Forms.TextBox txtMessage;

        private System.Windows.Forms.TextBox txtName;

        private System.Windows.Forms.Label lblMessage;

        private System.Windows.Forms.Label lblName;

        private System.Windows.Forms.GroupBox grbColor;

        private System.Windows.Forms.GroupBox grbAction;

        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.Button btnDisplay;

        private System.Windows.Forms.RadioButton rdbBlack;

        private System.Windows.Forms.RadioButton rdbBlue;

        private System.Windows.Forms.RadioButton rdbGreen;

        private System.Windows.Forms.RadioButton rdbRed;

        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.CheckBox chkMessage;

        private System.Windows.Forms.PictureBox picSmall;

        private System.Windows.Forms.PictureBox picBig;

        private System.Windows.Forms.TextBox txtMessage1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

