namespace AppointmentApplicationDesktop
{
    partial class ClientListForm
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
            this.mlistBoxClients = new System.Windows.Forms.ListBox();
            this.mButtonExit = new System.Windows.Forms.Button();
            this.mGroupBoxDate = new System.Windows.Forms.GroupBox();
            this.mbuttonOk = new System.Windows.Forms.Button();
            this.mdateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.mlistBoxClientAppointments = new System.Windows.Forms.ListBox();
            this.mGroupBoxDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlistBoxClients
            // 
            this.mlistBoxClients.FormattingEnabled = true;
            this.mlistBoxClients.ItemHeight = 15;
            this.mlistBoxClients.Location = new System.Drawing.Point(12, 12);
            this.mlistBoxClients.Name = "mlistBoxClients";
            this.mlistBoxClients.Size = new System.Drawing.Size(176, 349);
            this.mlistBoxClients.TabIndex = 0;
            this.mlistBoxClients.SelectedIndexChanged += new System.EventHandler(this.mlistBoxClients_SelectedIndexChanged);
            this.mlistBoxClients.DoubleClick += new System.EventHandler(this.mlistBoxClients_DoubleClick);
            // 
            // mButtonExit
            // 
            this.mButtonExit.Location = new System.Drawing.Point(12, 382);
            this.mButtonExit.Name = "mButtonExit";
            this.mButtonExit.Size = new System.Drawing.Size(75, 23);
            this.mButtonExit.TabIndex = 1;
            this.mButtonExit.Text = "Çıkış";
            this.mButtonExit.UseVisualStyleBackColor = true;
            this.mButtonExit.Click += new System.EventHandler(this.mButtonExit_Click);
            // 
            // mGroupBoxDate
            // 
            this.mGroupBoxDate.Controls.Add(this.mbuttonOk);
            this.mGroupBoxDate.Controls.Add(this.mdateTimePickerDate);
            this.mGroupBoxDate.Enabled = false;
            this.mGroupBoxDate.Location = new System.Drawing.Point(208, 12);
            this.mGroupBoxDate.Name = "mGroupBoxDate";
            this.mGroupBoxDate.Size = new System.Drawing.Size(213, 99);
            this.mGroupBoxDate.TabIndex = 2;
            this.mGroupBoxDate.TabStop = false;
            this.mGroupBoxDate.Text = "Randebu Tarihi Belirle";
            // 
            // mbuttonOk
            // 
            this.mbuttonOk.Location = new System.Drawing.Point(7, 62);
            this.mbuttonOk.Name = "mbuttonOk";
            this.mbuttonOk.Size = new System.Drawing.Size(75, 23);
            this.mbuttonOk.TabIndex = 1;
            this.mbuttonOk.Text = "Randevu Al";
            this.mbuttonOk.UseVisualStyleBackColor = true;
            this.mbuttonOk.Click += new System.EventHandler(this.mbuttonOk_Click);
            // 
            // mdateTimePickerDate
            // 
            this.mdateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mdateTimePickerDate.Location = new System.Drawing.Point(6, 22);
            this.mdateTimePickerDate.Name = "mdateTimePickerDate";
            this.mdateTimePickerDate.Size = new System.Drawing.Size(200, 23);
            this.mdateTimePickerDate.TabIndex = 0;
            // 
            // mlistBoxClientAppointments
            // 
            this.mlistBoxClientAppointments.FormattingEnabled = true;
            this.mlistBoxClientAppointments.ItemHeight = 15;
            this.mlistBoxClientAppointments.Location = new System.Drawing.Point(214, 143);
            this.mlistBoxClientAppointments.Name = "mlistBoxClientAppointments";
            this.mlistBoxClientAppointments.Size = new System.Drawing.Size(200, 214);
            this.mlistBoxClientAppointments.TabIndex = 3;
            // 
            // ClientListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 419);
            this.Controls.Add(this.mlistBoxClientAppointments);
            this.Controls.Add(this.mGroupBoxDate);
            this.Controls.Add(this.mButtonExit);
            this.Controls.Add(this.mlistBoxClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Müşteriler";
            this.Load += new System.EventHandler(this.ClientListForm_Load);
            this.mGroupBoxDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox mlistBoxClients;
        private System.Windows.Forms.Button mButtonExit;
        private System.Windows.Forms.GroupBox mGroupBoxDate;
        private System.Windows.Forms.DateTimePicker mdateTimePickerDate;
        private System.Windows.Forms.Button mbuttonOk;
        private System.Windows.Forms.ListBox mlistBoxClientAppointments;
    }
}