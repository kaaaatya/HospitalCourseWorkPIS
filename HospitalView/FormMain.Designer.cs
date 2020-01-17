namespace HospitalView
{
    partial class FormMain
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
            this.buttonArchive = new System.Windows.Forms.Button();
            this.buttonPlan = new System.Windows.Forms.Button();
            this.buttonPatients = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArchive
            // 
            this.buttonArchive.Location = new System.Drawing.Point(12, 70);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(210, 23);
            this.buttonArchive.TabIndex = 5;
            this.buttonArchive.Text = "Архивация";
            this.buttonArchive.UseVisualStyleBackColor = true;
            this.buttonArchive.Click += new System.EventHandler(this.buttonArchive_Click);
            // 
            // buttonPlan
            // 
            this.buttonPlan.Location = new System.Drawing.Point(12, 41);
            this.buttonPlan.Name = "buttonPlan";
            this.buttonPlan.Size = new System.Drawing.Size(210, 23);
            this.buttonPlan.TabIndex = 4;
            this.buttonPlan.Text = "План больницы";
            this.buttonPlan.UseVisualStyleBackColor = true;
            this.buttonPlan.Click += new System.EventHandler(this.buttonPlan_Click);
            // 
            // buttonPatients
            // 
            this.buttonPatients.Location = new System.Drawing.Point(12, 12);
            this.buttonPatients.Name = "buttonPatients";
            this.buttonPatients.Size = new System.Drawing.Size(210, 23);
            this.buttonPatients.TabIndex = 3;
            this.buttonPatients.Text = "Список больных";
            this.buttonPatients.UseVisualStyleBackColor = true;
            this.buttonPatients.Click += new System.EventHandler(this.buttonPatients_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(12, 99);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(210, 23);
            this.buttonInfo.TabIndex = 6;
            this.buttonInfo.Text = "О программе и авторе";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 126);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonArchive);
            this.Controls.Add(this.buttonPlan);
            this.Controls.Add(this.buttonPatients);
            this.Name = "FormMain";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonArchive;
        private System.Windows.Forms.Button buttonPlan;
        private System.Windows.Forms.Button buttonPatients;
        private System.Windows.Forms.Button buttonInfo;
    }
}