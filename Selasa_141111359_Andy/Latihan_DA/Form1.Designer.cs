namespace Latihan_DA
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
            this.dgvDaftar = new System.Windows.Forms.DataGridView();
            this.exitForm = new System.Windows.Forms.Button();
            this.deleteDB = new System.Windows.Forms.Button();
            this.resetForm = new System.Windows.Forms.Button();
            this.saveDB = new System.Windows.Forms.Button();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txPhoneNumber = new System.Windows.Forms.TextBox();
            this.txZipCode = new System.Windows.Forms.TextBox();
            this.txAddress = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDaftar
            // 
            this.dgvDaftar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaftar.Location = new System.Drawing.Point(21, 199);
            this.dgvDaftar.Name = "dgvDaftar";
            this.dgvDaftar.Size = new System.Drawing.Size(641, 204);
            this.dgvDaftar.TabIndex = 45;
            this.dgvDaftar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaftar_CellClick);
            // 
            // exitForm
            // 
            this.exitForm.Location = new System.Drawing.Point(446, 159);
            this.exitForm.Name = "exitForm";
            this.exitForm.Size = new System.Drawing.Size(95, 34);
            this.exitForm.TabIndex = 44;
            this.exitForm.Text = "Exit";
            this.exitForm.UseVisualStyleBackColor = true;
            this.exitForm.Click += new System.EventHandler(this.exitForm_Click);
            // 
            // deleteDB
            // 
            this.deleteDB.Location = new System.Drawing.Point(446, 109);
            this.deleteDB.Name = "deleteDB";
            this.deleteDB.Size = new System.Drawing.Size(95, 34);
            this.deleteDB.TabIndex = 43;
            this.deleteDB.Text = "Delete";
            this.deleteDB.UseVisualStyleBackColor = true;
            this.deleteDB.Click += new System.EventHandler(this.deleteDB_Click);
            // 
            // resetForm
            // 
            this.resetForm.Location = new System.Drawing.Point(446, 59);
            this.resetForm.Name = "resetForm";
            this.resetForm.Size = new System.Drawing.Size(95, 34);
            this.resetForm.TabIndex = 42;
            this.resetForm.Text = "Reset";
            this.resetForm.UseVisualStyleBackColor = true;
            this.resetForm.Click += new System.EventHandler(this.resetForm_Click);
            // 
            // saveDB
            // 
            this.saveDB.Location = new System.Drawing.Point(446, 9);
            this.saveDB.Name = "saveDB";
            this.saveDB.Size = new System.Drawing.Size(95, 34);
            this.saveDB.TabIndex = 41;
            this.saveDB.Text = "Save";
            this.saveDB.UseVisualStyleBackColor = true;
            this.saveDB.Click += new System.EventHandler(this.saveDB_Click);
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(113, 168);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(178, 20);
            this.txEmail.TabIndex = 40;
            // 
            // txPhoneNumber
            // 
            this.txPhoneNumber.Location = new System.Drawing.Point(113, 142);
            this.txPhoneNumber.Name = "txPhoneNumber";
            this.txPhoneNumber.Size = new System.Drawing.Size(178, 20);
            this.txPhoneNumber.TabIndex = 39;
            // 
            // txZipCode
            // 
            this.txZipCode.Location = new System.Drawing.Point(113, 116);
            this.txZipCode.Name = "txZipCode";
            this.txZipCode.Size = new System.Drawing.Size(178, 20);
            this.txZipCode.TabIndex = 38;
            // 
            // txAddress
            // 
            this.txAddress.Location = new System.Drawing.Point(113, 69);
            this.txAddress.Multiline = true;
            this.txAddress.Name = "txAddress";
            this.txAddress.Size = new System.Drawing.Size(178, 41);
            this.txAddress.TabIndex = 37;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(113, 43);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(178, 20);
            this.txName.TabIndex = 36;
            // 
            // txId
            // 
            this.txId.Enabled = false;
            this.txId.Location = new System.Drawing.Point(113, 17);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(178, 20);
            this.txId.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Zip Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 415);
            this.Controls.Add(this.dgvDaftar);
            this.Controls.Add(this.exitForm);
            this.Controls.Add(this.deleteDB);
            this.Controls.Add(this.resetForm);
            this.Controls.Add(this.saveDB);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.txPhoneNumber);
            this.Controls.Add(this.txZipCode);
            this.Controls.Add(this.txAddress);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Latihan_DA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDaftar;
        private System.Windows.Forms.Button exitForm;
        private System.Windows.Forms.Button deleteDB;
        private System.Windows.Forms.Button resetForm;
        private System.Windows.Forms.Button saveDB;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.TextBox txPhoneNumber;
        private System.Windows.Forms.TextBox txZipCode;
        private System.Windows.Forms.TextBox txAddress;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

