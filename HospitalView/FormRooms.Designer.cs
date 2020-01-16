namespace HospitalView
{
    partial class FormRooms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonChangePlan = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.buttonCountPatients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonChangePlan
            // 
            this.buttonChangePlan.Location = new System.Drawing.Point(0, 279);
            this.buttonChangePlan.Name = "buttonChangePlan";
            this.buttonChangePlan.Size = new System.Drawing.Size(155, 23);
            this.buttonChangePlan.TabIndex = 10;
            this.buttonChangePlan.Text = "Изменить план больницы";
            this.buttonChangePlan.UseVisualStyleBackColor = true;
            this.buttonChangePlan.Click += new System.EventHandler(this.buttonChangePlan_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(161, 279);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(79, 23);
            this.buttonUpd.TabIndex = 11;
            this.buttonUpd.Text = "Обновить";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // buttonCountPatients
            // 
            this.buttonCountPatients.Location = new System.Drawing.Point(246, 279);
            this.buttonCountPatients.Name = "buttonCountPatients";
            this.buttonCountPatients.Size = new System.Drawing.Size(209, 23);
            this.buttonCountPatients.TabIndex = 12;
            this.buttonCountPatients.Text = "Расчет кол-ва пациентов по палатам";
            this.buttonCountPatients.UseVisualStyleBackColor = true;
            this.buttonCountPatients.Click += new System.EventHandler(this.buttonCountPatients_Click);
            // 
            // FormRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 306);
            this.Controls.Add(this.buttonCountPatients);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.buttonChangePlan);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRooms";
            this.Text = "План больницы";
            this.Load += new System.EventHandler(this.FormRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonChangePlan;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonCountPatients;
    }
}