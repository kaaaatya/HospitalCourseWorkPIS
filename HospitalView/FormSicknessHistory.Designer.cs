namespace HospitalView
{
    partial class FormSicknessHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAddToHistory = new System.Windows.Forms.Button();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSearchByNumber = new System.Windows.Forms.Button();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSearchFIO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSearchByFIO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата приема";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(364, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // buttonAddToHistory
            // 
            this.buttonAddToHistory.Location = new System.Drawing.Point(364, 113);
            this.buttonAddToHistory.Name = "buttonAddToHistory";
            this.buttonAddToHistory.Size = new System.Drawing.Size(200, 23);
            this.buttonAddToHistory.TabIndex = 2;
            this.buttonAddToHistory.Text = "Добавить запись";
            this.buttonAddToHistory.UseVisualStyleBackColor = true;
            this.buttonAddToHistory.Click += new System.EventHandler(this.buttonAddToHistory_Click);
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(364, 59);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDoctor.TabIndex = 3;
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Location = new System.Drawing.Point(364, 32);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.Size = new System.Drawing.Size(200, 20);
            this.textBoxTemperature.TabIndex = 5;
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(364, 86);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(200, 21);
            this.comboBoxRoom.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Температура";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Врач";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Палата";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(956, 333);
            this.dataGridView1.TabIndex = 50;
            // 
            // buttonSearchByNumber
            // 
            this.buttonSearchByNumber.Location = new System.Drawing.Point(118, 108);
            this.buttonSearchByNumber.Name = "buttonSearchByNumber";
            this.buttonSearchByNumber.Size = new System.Drawing.Size(143, 23);
            this.buttonSearchByNumber.TabIndex = 58;
            this.buttonSearchByNumber.Text = "Поиск по № страховки";
            this.buttonSearchByNumber.UseVisualStyleBackColor = true;
            this.buttonSearchByNumber.Click += new System.EventHandler(this.buttonSearchByNumber_Click);
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(118, 81);
            this.maskedTextBoxNumber.Mask = "0000-0000-0000-0000";
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(143, 20);
            this.maskedTextBoxNumber.TabIndex = 57;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(15, 134);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(246, 23);
            this.buttonCancel.TabIndex = 56;
            this.buttonCancel.Text = "Сбросить ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "По ФИО";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "По № страховки";
            // 
            // textBoxSearchFIO
            // 
            this.textBoxSearchFIO.Location = new System.Drawing.Point(118, 27);
            this.textBoxSearchFIO.Name = "textBoxSearchFIO";
            this.textBoxSearchFIO.Size = new System.Drawing.Size(143, 20);
            this.textBoxSearchFIO.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Поиск пациента:";
            // 
            // buttonSearchByFIO
            // 
            this.buttonSearchByFIO.Location = new System.Drawing.Point(118, 53);
            this.buttonSearchByFIO.Name = "buttonSearchByFIO";
            this.buttonSearchByFIO.Size = new System.Drawing.Size(143, 23);
            this.buttonSearchByFIO.TabIndex = 51;
            this.buttonSearchByFIO.Text = "Поиск по ФИО";
            this.buttonSearchByFIO.UseVisualStyleBackColor = true;
            this.buttonSearchByFIO.Click += new System.EventHandler(this.buttonSearchByFIO_Click);
            // 
            // FormSicknessHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 508);
            this.Controls.Add(this.buttonSearchByNumber);
            this.Controls.Add(this.maskedTextBoxNumber);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxSearchFIO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonSearchByFIO);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.textBoxTemperature);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.buttonAddToHistory);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "FormSicknessHistory";
            this.Text = "Принять пациента";
            this.Load += new System.EventHandler(this.FormSicknessHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonAddToHistory;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearchByNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSearchFIO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSearchByFIO;
    }
}