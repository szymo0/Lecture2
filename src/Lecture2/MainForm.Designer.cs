namespace Lecture2
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.customControl1 = new Lecture2.Controls.CustomControl();
            this.extendedControl21 = new Lecture2.Controls.ExtendedControl2();
            this.extendedContol1 = new Lecture2.Controls.ExtendedContol();
            this.compositControl1 = new Lecture2.Controls.CompositControl();
            this.contactInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 163);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(593, 396);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(781, 396);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(685, 396);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // customControl1
            // 
            this.customControl1.ImageCroppingMode = Lecture2.Controls.CroppingMode.Automatic;
            this.customControl1.ImageCroppingType = Lecture2.Controls.CroppingType.Circle;
            this.customControl1.Location = new System.Drawing.Point(457, 146);
            this.customControl1.Margin = new System.Windows.Forms.Padding(4);
            this.customControl1.Name = "customControl1";
            this.customControl1.PercentChange = 0;
            this.customControl1.Picture = null;
            this.customControl1.Size = new System.Drawing.Size(200, 174);
            this.customControl1.TabIndex = 7;
            this.customControl1.Text = "customControl1";
            this.customControl1.UpdatePeriod = 5;
            // 
            // extendedControl21
            // 
            this.extendedControl21.Location = new System.Drawing.Point(257, 187);
            this.extendedControl21.Margin = new System.Windows.Forms.Padding(4);
            this.extendedControl21.Name = "extendedControl21";
            this.extendedControl21.Size = new System.Drawing.Size(132, 22);
            this.extendedControl21.TabIndex = 6;
            this.extendedControl21.Text = "RedFace";
            // 
            // extendedContol1
            // 
            this.extendedContol1.Location = new System.Drawing.Point(48, 187);
            this.extendedContol1.Margin = new System.Windows.Forms.Padding(4);
            this.extendedContol1.Name = "extendedContol1";
            this.extendedContol1.Size = new System.Drawing.Size(132, 22);
            this.extendedContol1.TabIndex = 5;
            // 
            // compositControl1
            // 
            this.compositControl1.Location = new System.Drawing.Point(115, 246);
            this.compositControl1.Margin = new System.Windows.Forms.Padding(5);
            this.compositControl1.MaximumSize = new System.Drawing.Size(667, 117);
            this.compositControl1.MinimumSize = new System.Drawing.Size(533, 111);
            this.compositControl1.Name = "compositControl1";
            this.compositControl1.Size = new System.Drawing.Size(667, 117);
            this.compositControl1.TabIndex = 4;
            // 
            // contactInfoBindingSource
            // 
            this.contactInfoBindingSource.DataSource = typeof(ContactsApp.Domain.ContactInfo);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 266);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customControl1);
            this.Controls.Add(this.extendedControl21);
            this.Controls.Add(this.extendedContol1);
            this.Controls.Add(this.compositControl1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource contactInfoBindingSource;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private Controls.CompositControl compositControl1;
        private Controls.ExtendedContol extendedContol1;
        private Controls.ExtendedControl2 extendedControl21;
        private Controls.CustomControl customControl1;
        private System.Windows.Forms.Button button1;
    }
}