﻿
namespace ProjectSMTPLocalHost
{
    partial class FrmSmtpLocal
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
            this.lblApp = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblFromPasswd = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtBoxFrom = new System.Windows.Forms.TextBox();
            this.txtBoxPwd = new System.Windows.Forms.TextBox();
            this.txtBoxTo = new System.Windows.Forms.TextBox();
            this.txtBoxSubject = new System.Windows.Forms.TextBox();
            this.richTBBody = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBoxGetSer = new System.Windows.Forms.RichTextBox();
            this.txtBoxSendSer = new System.Windows.Forms.RichTextBox();
            this.checkBoxShowPwd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.Location = new System.Drawing.Point(428, 9);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(286, 39);
            this.lblApp.TabIndex = 1;
            this.lblApp.Text = "Mail Sending App";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(183, 80);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(67, 25);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "From:";
            // 
            // lblFromPasswd
            // 
            this.lblFromPasswd.AutoSize = true;
            this.lblFromPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromPasswd.Location = new System.Drawing.Point(590, 80);
            this.lblFromPasswd.Name = "lblFromPasswd";
            this.lblFromPasswd.Size = new System.Drawing.Size(112, 25);
            this.lblFromPasswd.TabIndex = 3;
            this.lblFromPasswd.Text = "Password:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(183, 132);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(43, 25);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(12, 175);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(90, 25);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Subject:";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBody.Location = new System.Drawing.Point(12, 227);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(67, 25);
            this.lblBody.TabIndex = 6;
            this.lblBody.Text = "Body:";
            // 
            // txtBoxFrom
            // 
            this.txtBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFrom.Location = new System.Drawing.Point(256, 76);
            this.txtBoxFrom.Name = "txtBoxFrom";
            this.txtBoxFrom.Size = new System.Drawing.Size(315, 29);
            this.txtBoxFrom.TabIndex = 7;
            // 
            // txtBoxPwd
            // 
            this.txtBoxPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPwd.Location = new System.Drawing.Point(730, 76);
            this.txtBoxPwd.Name = "txtBoxPwd";
            this.txtBoxPwd.Size = new System.Drawing.Size(227, 29);
            this.txtBoxPwd.TabIndex = 8;
            this.txtBoxPwd.UseSystemPasswordChar = true;
            // 
            // txtBoxTo
            // 
            this.txtBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTo.Location = new System.Drawing.Point(256, 128);
            this.txtBoxTo.Name = "txtBoxTo";
            this.txtBoxTo.Size = new System.Drawing.Size(315, 29);
            this.txtBoxTo.TabIndex = 9;
            // 
            // txtBoxSubject
            // 
            this.txtBoxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSubject.Location = new System.Drawing.Point(107, 171);
            this.txtBoxSubject.Name = "txtBoxSubject";
            this.txtBoxSubject.Size = new System.Drawing.Size(850, 29);
            this.txtBoxSubject.TabIndex = 10;
            // 
            // richTBBody
            // 
            this.richTBBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTBBody.Location = new System.Drawing.Point(110, 236);
            this.richTBBody.Name = "richTBBody";
            this.richTBBody.Size = new System.Drawing.Size(847, 284);
            this.richTBBody.TabIndex = 11;
            this.richTBBody.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(976, 241);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(201, 56);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBoxGetSer
            // 
            this.txtBoxGetSer.Location = new System.Drawing.Point(114, 551);
            this.txtBoxGetSer.Name = "txtBoxGetSer";
            this.txtBoxGetSer.Size = new System.Drawing.Size(412, 308);
            this.txtBoxGetSer.TabIndex = 15;
            this.txtBoxGetSer.Text = "";
            this.txtBoxGetSer.WordWrap = false;
            // 
            // txtBoxSendSer
            // 
            this.txtBoxSendSer.Location = new System.Drawing.Point(547, 551);
            this.txtBoxSendSer.Name = "txtBoxSendSer";
            this.txtBoxSendSer.Size = new System.Drawing.Size(410, 308);
            this.txtBoxSendSer.TabIndex = 16;
            this.txtBoxSendSer.Text = "";
            this.txtBoxSendSer.WordWrap = false;
            // 
            // checkBoxShowPwd
            // 
            this.checkBoxShowPwd.AutoSize = true;
            this.checkBoxShowPwd.Location = new System.Drawing.Point(735, 121);
            this.checkBoxShowPwd.Name = "checkBoxShowPwd";
            this.checkBoxShowPwd.Size = new System.Drawing.Size(101, 17);
            this.checkBoxShowPwd.TabIndex = 17;
            this.checkBoxShowPwd.Text = "Show password";
            this.checkBoxShowPwd.UseVisualStyleBackColor = true;
            this.checkBoxShowPwd.CheckedChanged += new System.EventHandler(this.checkBoxShowPwd_CheckedChanged);
            // 
            // FrmSmtpLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 885);
            this.Controls.Add(this.checkBoxShowPwd);
            this.Controls.Add(this.txtBoxSendSer);
            this.Controls.Add(this.txtBoxGetSer);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.richTBBody);
            this.Controls.Add(this.txtBoxSubject);
            this.Controls.Add(this.txtBoxTo);
            this.Controls.Add(this.txtBoxPwd);
            this.Controls.Add(this.txtBoxFrom);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFromPasswd);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblApp);
            this.Name = "FrmSmtpLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblFromPasswd;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtBoxFrom;
        private System.Windows.Forms.TextBox txtBoxPwd;
        private System.Windows.Forms.TextBox txtBoxTo;
        private System.Windows.Forms.TextBox txtBoxSubject;
        private System.Windows.Forms.RichTextBox richTBBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox txtBoxGetSer;
        private System.Windows.Forms.RichTextBox txtBoxSendSer;
        private System.Windows.Forms.CheckBox checkBoxShowPwd;
    }
}

