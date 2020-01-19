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
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.buttonFree = new System.Windows.Forms.Button();
            this.maskedTextBoxTemperature = new System.Windows.Forms.MaskedTextBox();
            this.buttonSort1 = new System.Windows.Forms.Button();
            this.buttonSort2 = new System.Windows.Forms.Button();
            this.buttonGetSickList = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonPatientsFeelings = new System.Windows.Forms.Button();
            this.buttonDiagramm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата приема";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // buttonAddToHistory
            // 
            this.buttonAddToHistory.Location = new System.Drawing.Point(88, 144);
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
            this.comboBoxDoctor.Location = new System.Drawing.Point(88, 90);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDoctor.TabIndex = 3;
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Location = new System.Drawing.Point(88, 117);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(200, 21);
            this.comboBoxRoom.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Температура";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Врач";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 117);
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
            this.dataGridView1.Size = new System.Drawing.Size(787, 333);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Пациент";
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(88, 37);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(200, 21);
            this.comboBoxPatient.TabIndex = 51;
            this.comboBoxPatient.SelectedIndexChanged += new System.EventHandler(this.comboBoxPatient_SelectedIndexChanged);
            // 
            // buttonFree
            // 
            this.buttonFree.Location = new System.Drawing.Point(598, 14);
            this.buttonFree.Name = "buttonFree";
            this.buttonFree.Size = new System.Drawing.Size(200, 23);
            this.buttonFree.TabIndex = 53;
            this.buttonFree.Text = "Выписать пациента";
            this.buttonFree.UseVisualStyleBackColor = true;
            this.buttonFree.Click += new System.EventHandler(this.buttonFree_Click);
            // 
            // maskedTextBoxTemperature
            // 
            this.maskedTextBoxTemperature.Location = new System.Drawing.Point(88, 64);
            this.maskedTextBoxTemperature.Mask = "00.0";
            this.maskedTextBoxTemperature.Name = "maskedTextBoxTemperature";
            this.maskedTextBoxTemperature.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBoxTemperature.TabIndex = 54;
            this.maskedTextBoxTemperature.ValidatingType = typeof(int);
            // 
            // buttonSort1
            // 
            this.buttonSort1.Location = new System.Drawing.Point(804, 172);
            this.buttonSort1.Name = "buttonSort1";
            this.buttonSort1.Size = new System.Drawing.Size(162, 23);
            this.buttonSort1.TabIndex = 55;
            this.buttonSort1.Text = "Сортировка по алфавиту";
            this.buttonSort1.UseVisualStyleBackColor = true;
            this.buttonSort1.Click += new System.EventHandler(this.buttonSort1_Click);
            // 
            // buttonSort2
            // 
            this.buttonSort2.Location = new System.Drawing.Point(804, 201);
            this.buttonSort2.Name = "buttonSort2";
            this.buttonSort2.Size = new System.Drawing.Size(162, 23);
            this.buttonSort2.TabIndex = 56;
            this.buttonSort2.Text = "Отменить";
            this.buttonSort2.UseVisualStyleBackColor = true;
            this.buttonSort2.Click += new System.EventHandler(this.buttonSort2_Click);
            // 
            // buttonGetSickList
            // 
            this.buttonGetSickList.Location = new System.Drawing.Point(598, 40);
            this.buttonGetSickList.Name = "buttonGetSickList";
            this.buttonGetSickList.Size = new System.Drawing.Size(200, 23);
            this.buttonGetSickList.TabIndex = 57;
            this.buttonGetSickList.Text = "Получить больничный лист";
            this.buttonGetSickList.UseVisualStyleBackColor = true;
            this.buttonGetSickList.Click += new System.EventHandler(this.buttonGetSickList_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(392, 14);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Дата выписки";
            // 
            // buttonPatientsFeelings
            // 
            this.buttonPatientsFeelings.Location = new System.Drawing.Point(804, 230);
            this.buttonPatientsFeelings.Name = "buttonPatientsFeelings";
            this.buttonPatientsFeelings.Size = new System.Drawing.Size(162, 23);
            this.buttonPatientsFeelings.TabIndex = 60;
            this.buttonPatientsFeelings.Text = "Состояние больных";
            this.buttonPatientsFeelings.UseVisualStyleBackColor = true;
            this.buttonPatientsFeelings.Click += new System.EventHandler(this.buttonPatientsFeelings_Click);
            // 
            // buttonDiagramm
            // 
            this.buttonDiagramm.Location = new System.Drawing.Point(598, 67);
            this.buttonDiagramm.Name = "buttonDiagramm";
            this.buttonDiagramm.Size = new System.Drawing.Size(200, 23);
            this.buttonDiagramm.TabIndex = 61;
            this.buttonDiagramm.Text = "Диаграмма по пациентам";
            this.buttonDiagramm.UseVisualStyleBackColor = true;
            this.buttonDiagramm.Click += new System.EventHandler(this.buttonDiagramm_Click);
            // 
            // FormSicknessHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 508);
            this.Controls.Add(this.buttonDiagramm);
            this.Controls.Add(this.buttonPatientsFeelings);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonGetSickList);
            this.Controls.Add(this.buttonSort2);
            this.Controls.Add(this.buttonSort1);
            this.Controls.Add(this.maskedTextBoxTemperature);
            this.Controls.Add(this.buttonFree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPatient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRoom);
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
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.Button buttonFree;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTemperature;
        private System.Windows.Forms.Button buttonSort1;
        private System.Windows.Forms.Button buttonSort2;
        private System.Windows.Forms.Button buttonGetSickList;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonPatientsFeelings;
        private System.Windows.Forms.Button buttonDiagramm;
    }
}