﻿namespace Lecture2
{
    partial class ContactPreview
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrimaryPhone = new System.Windows.Forms.Label();
            this.tcDetails = new System.Windows.Forms.TabControl();
            this.tpPersonalData = new System.Windows.Forms.TabPage();
            this.btnEditPersonalData = new System.Windows.Forms.Button();
            this.lblRelation = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblSurnames = new System.Windows.Forms.Label();
            this.lblFirstNames = new System.Windows.Forms.Label();
            this.tpAddress = new System.Windows.Forms.TabPage();
            this.btnAddressEdit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tpPhones = new System.Windows.Forms.TabPage();
            this.btnAddAlternatePhone = new System.Windows.Forms.Button();
            this.txtAddAlternatePhone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tpEmails = new System.Windows.Forms.TabPage();
            this.btnAddEmail = new System.Windows.Forms.Button();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcDetails.SuspendLayout();
            this.tpPersonalData.SuspendLayout();
            this.tpAddress.SuspendLayout();
            this.tpPhones.SuspendLayout();
            this.tpEmails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(257, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(212, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "JAKAS DLUGA NAZWA";
            // 
            // lblPrimaryPhone
            // 
            this.lblPrimaryPhone.AutoSize = true;
            this.lblPrimaryPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrimaryPhone.Location = new System.Drawing.Point(257, 59);
            this.lblPrimaryPhone.Name = "lblPrimaryPhone";
            this.lblPrimaryPhone.Size = new System.Drawing.Size(147, 20);
            this.lblPrimaryPhone.TabIndex = 3;
            this.lblPrimaryPhone.Text = "(+48) 999-999-999";
            // 
            // tcDetails
            // 
            this.tcDetails.Controls.Add(this.tpPersonalData);
            this.tcDetails.Controls.Add(this.tpAddress);
            this.tcDetails.Controls.Add(this.tpPhones);
            this.tcDetails.Controls.Add(this.tpEmails);
            this.tcDetails.Location = new System.Drawing.Point(253, 101);
            this.tcDetails.Name = "tcDetails";
            this.tcDetails.SelectedIndex = 0;
            this.tcDetails.Size = new System.Drawing.Size(405, 278);
            this.tcDetails.TabIndex = 4;
            // 
            // tpPersonalData
            // 
            this.tpPersonalData.Controls.Add(this.btnEditPersonalData);
            this.tpPersonalData.Controls.Add(this.lblRelation);
            this.tpPersonalData.Controls.Add(this.lblSex);
            this.tpPersonalData.Controls.Add(this.lblBirthDate);
            this.tpPersonalData.Controls.Add(this.lblSurnames);
            this.tpPersonalData.Controls.Add(this.lblFirstNames);
            this.tpPersonalData.Location = new System.Drawing.Point(4, 22);
            this.tpPersonalData.Name = "tpPersonalData";
            this.tpPersonalData.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpPersonalData.Size = new System.Drawing.Size(397, 252);
            this.tpPersonalData.TabIndex = 0;
            this.tpPersonalData.Text = "Personal data";
            this.tpPersonalData.UseVisualStyleBackColor = true;
            // 
            // btnEditPersonalData
            // 
            this.btnEditPersonalData.Location = new System.Drawing.Point(316, 223);
            this.btnEditPersonalData.Name = "btnEditPersonalData";
            this.btnEditPersonalData.Size = new System.Drawing.Size(75, 23);
            this.btnEditPersonalData.TabIndex = 8;
            this.btnEditPersonalData.Text = "Edit";
            this.btnEditPersonalData.UseVisualStyleBackColor = true;
            this.btnEditPersonalData.Click += new System.EventHandler(this.btnEditPersonalData_Click);
            // 
            // lblRelation
            // 
            this.lblRelation.AutoSize = true;
            this.lblRelation.Location = new System.Drawing.Point(6, 81);
            this.lblRelation.Name = "lblRelation";
            this.lblRelation.Size = new System.Drawing.Size(86, 13);
            this.lblRelation.TabIndex = 7;
            this.lblRelation.Text = "Friend and family";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSex.Location = new System.Drawing.Point(141, 50);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(59, 15);
            this.lblSex.TabIndex = 5;
            this.lblSex.Text = "Unknown";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(6, 52);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(73, 13);
            this.lblBirthDate.TabIndex = 3;
            this.lblBirthDate.Text = "2018 - 10 - 01";
            // 
            // lblSurnames
            // 
            this.lblSurnames.AutoSize = true;
            this.lblSurnames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSurnames.Location = new System.Drawing.Point(141, 15);
            this.lblSurnames.Name = "lblSurnames";
            this.lblSurnames.Size = new System.Drawing.Size(109, 16);
            this.lblSurnames.TabIndex = 1;
            this.lblSurnames.Text = "Nazwiska Osoby";
            // 
            // lblFirstNames
            // 
            this.lblFirstNames.AutoSize = true;
            this.lblFirstNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstNames.Location = new System.Drawing.Point(6, 15);
            this.lblFirstNames.Name = "lblFirstNames";
            this.lblFirstNames.Size = new System.Drawing.Size(94, 16);
            this.lblFirstNames.TabIndex = 0;
            this.lblFirstNames.Text = "Imionia Osoby";
            // 
            // tpAddress
            // 
            this.tpAddress.Controls.Add(this.btnAddressEdit);
            this.tpAddress.Controls.Add(this.label7);
            this.tpAddress.Controls.Add(this.lblAddress);
            this.tpAddress.Location = new System.Drawing.Point(4, 22);
            this.tpAddress.Name = "tpAddress";
            this.tpAddress.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpAddress.Size = new System.Drawing.Size(397, 252);
            this.tpAddress.TabIndex = 1;
            this.tpAddress.Text = "Address";
            this.tpAddress.UseVisualStyleBackColor = true;
            // 
            // btnAddressEdit
            // 
            this.btnAddressEdit.Location = new System.Drawing.Point(316, 223);
            this.btnAddressEdit.Name = "btnAddressEdit";
            this.btnAddressEdit.Size = new System.Drawing.Size(75, 23);
            this.btnAddressEdit.TabIndex = 2;
            this.btnAddressEdit.Text = "Edit";
            this.btnAddressEdit.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Lived in:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAddress.Location = new System.Drawing.Point(73, 7);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(112, 36);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "02-344 Warsaw\r\nul. Test 11/111";
            // 
            // tpPhones
            // 
            this.tpPhones.Controls.Add(this.btnAddAlternatePhone);
            this.tpPhones.Controls.Add(this.txtAddAlternatePhone);
            this.tpPhones.Controls.Add(this.panel1);
            this.tpPhones.Location = new System.Drawing.Point(4, 22);
            this.tpPhones.Name = "tpPhones";
            this.tpPhones.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpPhones.Size = new System.Drawing.Size(397, 252);
            this.tpPhones.TabIndex = 2;
            this.tpPhones.Text = "Phones";
            this.tpPhones.UseVisualStyleBackColor = true;
            // 
            // btnAddAlternatePhone
            // 
            this.btnAddAlternatePhone.Location = new System.Drawing.Point(316, 223);
            this.btnAddAlternatePhone.Name = "btnAddAlternatePhone";
            this.btnAddAlternatePhone.Size = new System.Drawing.Size(75, 23);
            this.btnAddAlternatePhone.TabIndex = 3;
            this.btnAddAlternatePhone.Text = "Add";
            this.btnAddAlternatePhone.UseVisualStyleBackColor = true;
            this.btnAddAlternatePhone.Visible = false;
            // 
            // txtAddAlternatePhone
            // 
            this.txtAddAlternatePhone.Location = new System.Drawing.Point(6, 223);
            this.txtAddAlternatePhone.Name = "txtAddAlternatePhone";
            this.txtAddAlternatePhone.Size = new System.Drawing.Size(304, 20);
            this.txtAddAlternatePhone.TabIndex = 2;
            this.txtAddAlternatePhone.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 211);
            this.panel1.TabIndex = 0;
            // 
            // tpEmails
            // 
            this.tpEmails.Controls.Add(this.btnAddEmail);
            this.tpEmails.Controls.Add(this.txtAddEmail);
            this.tpEmails.Controls.Add(this.flowLayoutPanel1);
            this.tpEmails.Location = new System.Drawing.Point(4, 22);
            this.tpEmails.Name = "tpEmails";
            this.tpEmails.Size = new System.Drawing.Size(397, 252);
            this.tpEmails.TabIndex = 3;
            this.tpEmails.Text = "Emails";
            this.tpEmails.UseVisualStyleBackColor = true;
            // 
            // btnAddEmail
            // 
            this.btnAddEmail.Location = new System.Drawing.Point(319, 222);
            this.btnAddEmail.Name = "btnAddEmail";
            this.btnAddEmail.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmail.TabIndex = 3;
            this.btnAddEmail.Text = "Add";
            this.btnAddEmail.UseVisualStyleBackColor = true;
            this.btnAddEmail.Visible = false;
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(4, 225);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(309, 20);
            this.txtAddEmail.TabIndex = 2;
            this.txtAddEmail.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(397, 217);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.Location = new System.Drawing.Point(12, 258);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(216, 23);
            this.btnUploadPhoto.TabIndex = 5;
            this.btnUploadPhoto.Text = "Zmień zdjęcie";
            this.btnUploadPhoto.UseVisualStyleBackColor = true;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // ContactPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.btnUploadPhoto);
            this.Controls.Add(this.tcDetails);
            this.Controls.Add(this.lblPrimaryPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ContactPreview";
            this.Text = "ContactPreview";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcDetails.ResumeLayout(false);
            this.tpPersonalData.ResumeLayout(false);
            this.tpPersonalData.PerformLayout();
            this.tpAddress.ResumeLayout(false);
            this.tpAddress.PerformLayout();
            this.tpPhones.ResumeLayout(false);
            this.tpPhones.PerformLayout();
            this.tpEmails.ResumeLayout(false);
            this.tpEmails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrimaryPhone;
        private System.Windows.Forms.TabControl tcDetails;
        private System.Windows.Forms.TabPage tpPersonalData;
        private System.Windows.Forms.TabPage tpAddress;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.TabPage tpPhones;
        private System.Windows.Forms.TabPage tpEmails;
        private System.Windows.Forms.Label lblFirstNames;
        private System.Windows.Forms.Label lblSurnames;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblRelation;
        private System.Windows.Forms.Button btnEditPersonalData;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddAlternatePhone;
        private System.Windows.Forms.TextBox txtAddAlternatePhone;
        private System.Windows.Forms.Button btnAddressEdit;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.Button btnAddEmail;
    }
}