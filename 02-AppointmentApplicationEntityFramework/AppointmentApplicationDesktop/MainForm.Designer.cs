namespace AppointmentApplicationDesktop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_buttonNewClient = new System.Windows.Forms.Button();
            this.mButtonList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_buttonNewClient
            // 
            this.m_buttonNewClient.Location = new System.Drawing.Point(72, 62);
            this.m_buttonNewClient.Name = "m_buttonNewClient";
            this.m_buttonNewClient.Size = new System.Drawing.Size(128, 23);
            this.m_buttonNewClient.TabIndex = 0;
            this.m_buttonNewClient.Text = "Yeni Müşteri ";
            this.m_buttonNewClient.UseVisualStyleBackColor = true;
            this.m_buttonNewClient.Click += new System.EventHandler(this.m_buttonNewClient_Click);
            // 
            // mButtonList
            // 
            this.mButtonList.Location = new System.Drawing.Point(72, 115);
            this.mButtonList.Name = "mButtonList";
            this.mButtonList.Size = new System.Drawing.Size(128, 23);
            this.mButtonList.TabIndex = 0;
            this.mButtonList.Text = "Müşteri Listele";
            this.mButtonList.UseVisualStyleBackColor = true;
            this.mButtonList.Click += new System.EventHandler(this.mButtonList_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.mButtonList);
            this.Controls.Add(this.m_buttonNewClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Sistemi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_buttonNewClient;
        private System.Windows.Forms.Button mButtonList;
    }
}

