namespace AppointmentApplicationDesktop
{
    partial class AddClientForm
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
            this.mName = new System.Windows.Forms.Label();
            this.mtextBoxName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.mtextBoxEmail = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.mtextBoxPhone = new System.Windows.Forms.TextBox();
            this.mButtonSave = new System.Windows.Forms.Button();
            this.mButtonCancel = new System.Windows.Forms.Button();
            this.mButtonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mName
            // 
            this.mName.AutoSize = true;
            this.mName.Location = new System.Drawing.Point(34, 15);
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(39, 15);
            this.mName.TabIndex = 0;
            this.mName.Text = "Name";
            // 
            // mtextBoxName
            // 
            this.mtextBoxName.Location = new System.Drawing.Point(100, 12);
            this.mtextBoxName.Name = "mtextBoxName";
            this.mtextBoxName.Size = new System.Drawing.Size(181, 23);
            this.mtextBoxName.TabIndex = 1;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(34, 56);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 15);
            this.Email.TabIndex = 0;
            this.Email.Text = "Email";
            // 
            // mtextBoxEmail
            // 
            this.mtextBoxEmail.Location = new System.Drawing.Point(100, 53);
            this.mtextBoxEmail.Name = "mtextBoxEmail";
            this.mtextBoxEmail.Size = new System.Drawing.Size(181, 23);
            this.mtextBoxEmail.TabIndex = 2;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(34, 102);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(41, 15);
            this.Phone.TabIndex = 0;
            this.Phone.Text = "Phone";
            // 
            // mtextBoxPhone
            // 
            this.mtextBoxPhone.Location = new System.Drawing.Point(100, 99);
            this.mtextBoxPhone.Name = "mtextBoxPhone";
            this.mtextBoxPhone.Size = new System.Drawing.Size(181, 23);
            this.mtextBoxPhone.TabIndex = 3;
            // 
            // mButtonSave
            // 
            this.mButtonSave.Location = new System.Drawing.Point(34, 150);
            this.mButtonSave.Name = "mButtonSave";
            this.mButtonSave.Size = new System.Drawing.Size(75, 23);
            this.mButtonSave.TabIndex = 4;
            this.mButtonSave.Text = "Kaydet";
            this.mButtonSave.UseVisualStyleBackColor = true;
            this.mButtonSave.Click += new System.EventHandler(this.mButtonSave_Click);
            // 
            // mButtonCancel
            // 
            this.mButtonCancel.Location = new System.Drawing.Point(206, 150);
            this.mButtonCancel.Name = "mButtonCancel";
            this.mButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.mButtonCancel.TabIndex = 6;
            this.mButtonCancel.Text = "İptal";
            this.mButtonCancel.UseVisualStyleBackColor = true;
            this.mButtonCancel.Click += new System.EventHandler(this.mButtonCancel_Click);
            // 
            // mButtonClear
            // 
            this.mButtonClear.Location = new System.Drawing.Point(125, 150);
            this.mButtonClear.Name = "mButtonClear";
            this.mButtonClear.Size = new System.Drawing.Size(75, 23);
            this.mButtonClear.TabIndex = 5;
            this.mButtonClear.Text = "Temizle";
            this.mButtonClear.UseVisualStyleBackColor = true;
            this.mButtonClear.Click += new System.EventHandler(this.mButtonClear_Click);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 450);
            this.Controls.Add(this.mButtonClear);
            this.Controls.Add(this.mButtonCancel);
            this.Controls.Add(this.mButtonSave);
            this.Controls.Add(this.mtextBoxPhone);
            this.Controls.Add(this.mtextBoxEmail);
            this.Controls.Add(this.mtextBoxName);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.mName);
            this.Name = "AddClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Müşeri Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mName;
        private System.Windows.Forms.TextBox mtextBoxName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox mtextBoxEmail;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox mtextBoxPhone;
        private System.Windows.Forms.Button mButtonSave;
        private System.Windows.Forms.Button mButtonCancel;
        private System.Windows.Forms.Button mButtonClear;
    }
}