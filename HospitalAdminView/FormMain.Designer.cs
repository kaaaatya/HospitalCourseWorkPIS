namespace HospitalAdminView
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
            this.buttonPatients = new System.Windows.Forms.Button();
            this.buttonPlan = new System.Windows.Forms.Button();
            this.buttonArchive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPatients
            // 
            this.buttonPatients.Location = new System.Drawing.Point(12, 12);
            this.buttonPatients.Name = "buttonPatients";
            this.buttonPatients.Size = new System.Drawing.Size(210, 23);
            this.buttonPatients.TabIndex = 0;
            this.buttonPatients.Text = "Список больных";
            this.buttonPatients.UseVisualStyleBackColor = true;
            this.buttonPatients.Click += new System.EventHandler(this.buttonPatients_Click);
            // 
            // buttonPlan
            // 
            this.buttonPlan.Location = new System.Drawing.Point(12, 41);
            this.buttonPlan.Name = "buttonPlan";
            this.buttonPlan.Size = new System.Drawing.Size(210, 23);
            this.buttonPlan.TabIndex = 1;
            this.buttonPlan.Text = "Изменение плана больницы";
            this.buttonPlan.UseVisualStyleBackColor = true;
            this.buttonPlan.Click += new System.EventHandler(this.buttonPlan_Click);
            // 
            // buttonArchive
            // 
            this.buttonArchive.Location = new System.Drawing.Point(12, 70);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(210, 23);
            this.buttonArchive.TabIndex = 2;
            this.buttonArchive.Text = "Архивация";
            this.buttonArchive.UseVisualStyleBackColor = true;
            this.buttonArchive.Click += new System.EventHandler(this.buttonArchive_Click);
            // 
            // FormAvailableOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 104);
            this.Controls.Add(this.buttonArchive);
            this.Controls.Add(this.buttonPlan);
            this.Controls.Add(this.buttonPatients);
            this.Name = "FormAvailableOptions";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPatients;
        private System.Windows.Forms.Button buttonPlan;
        private System.Windows.Forms.Button buttonArchive;
    }
}