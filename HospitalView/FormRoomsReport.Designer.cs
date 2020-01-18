namespace HospitalView
{
    partial class FormRoomsReport
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
            this.maskedTextBoxYear = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonSaveToPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1120, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // maskedTextBoxYear
            // 
            this.maskedTextBoxYear.Location = new System.Drawing.Point(102, 3);
            this.maskedTextBoxYear.Mask = "0000";
            this.maskedTextBoxYear.Name = "maskedTextBoxYear";
            this.maskedTextBoxYear.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxYear.TabIndex = 1;
            this.maskedTextBoxYear.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "За (год)";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(208, 1);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(116, 23);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Сформировать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonSaveToPDF
            // 
            this.buttonSaveToPDF.Location = new System.Drawing.Point(330, 1);
            this.buttonSaveToPDF.Name = "buttonSaveToPDF";
            this.buttonSaveToPDF.Size = new System.Drawing.Size(116, 23);
            this.buttonSaveToPDF.TabIndex = 4;
            this.buttonSaveToPDF.Text = "Сохранить в ПДФ";
            this.buttonSaveToPDF.UseVisualStyleBackColor = true;
            this.buttonSaveToPDF.Click += new System.EventHandler(this.buttonSaveToPDF_Click);
            // 
            // FormRoomsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 298);
            this.Controls.Add(this.buttonSaveToPDF);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxYear);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRoomsReport";
            this.Text = "Загрузка мест по палатам и месяцам";
            this.Load += new System.EventHandler(this.FormRoomsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSaveToPDF;
    }
}