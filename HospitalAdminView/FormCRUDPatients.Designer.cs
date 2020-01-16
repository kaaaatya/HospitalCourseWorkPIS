namespace HospitalAdminView
{
    partial class FormCRUDPatients
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearchNumber = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonFree = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxInCompany = new System.Windows.Forms.TextBox();
            this.maskedTextBoxInNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPassport = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonNewPatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(956, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(6, 81);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(149, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Применить ";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск пациента:";
            // 
            // textBoxSearchFIO
            // 
            this.textBoxSearchFIO.Location = new System.Drawing.Point(109, 29);
            this.textBoxSearchFIO.Name = "textBoxSearchFIO";
            this.textBoxSearchFIO.Size = new System.Drawing.Size(143, 20);
            this.textBoxSearchFIO.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "По № страховки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "По ФИО";
            // 
            // textBoxSearchNumber
            // 
            this.textBoxSearchNumber.Location = new System.Drawing.Point(109, 55);
            this.textBoxSearchNumber.Name = "textBoxSearchNumber";
            this.textBoxSearchNumber.Size = new System.Drawing.Size(143, 20);
            this.textBoxSearchNumber.TabIndex = 6;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(161, 81);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Сбросить ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonFree
            // 
            this.buttonFree.Location = new System.Drawing.Point(258, 81);
            this.buttonFree.Name = "buttonFree";
            this.buttonFree.Size = new System.Drawing.Size(221, 23);
            this.buttonFree.TabIndex = 8;
            this.buttonFree.Text = "Выписать пациента";
            this.buttonFree.UseVisualStyleBackColor = true;
            this.buttonFree.Click += new System.EventHandler(this.buttonFree_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(981, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Прием нового больного:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(981, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ФИО";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(981, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Статус";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(981, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Номер телефона";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(981, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Адрес проживания";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(981, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Дата рождения";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(981, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Номер паспорта";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(981, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "№ страховки";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(981, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Страховая компания";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(1112, 31);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(143, 20);
            this.textBoxFIO.TabIndex = 18;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(1112, 175);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(143, 20);
            this.textBoxAddress.TabIndex = 21;
            // 
            // textBoxInCompany
            // 
            this.textBoxInCompany.Location = new System.Drawing.Point(1112, 61);
            this.textBoxInCompany.Name = "textBoxInCompany";
            this.textBoxInCompany.Size = new System.Drawing.Size(143, 20);
            this.textBoxInCompany.TabIndex = 24;
            // 
            // maskedTextBoxInNumber
            // 
            this.maskedTextBoxInNumber.Location = new System.Drawing.Point(1112, 90);
            this.maskedTextBoxInNumber.Mask = "0000-0000-0000-0000";
            this.maskedTextBoxInNumber.Name = "maskedTextBoxInNumber";
            this.maskedTextBoxInNumber.Size = new System.Drawing.Size(143, 20);
            this.maskedTextBoxInNumber.TabIndex = 25;
            // 
            // maskedTextBoxPassport
            // 
            this.maskedTextBoxPassport.Location = new System.Drawing.Point(1112, 116);
            this.maskedTextBoxPassport.Mask = "0000-000000";
            this.maskedTextBoxPassport.Name = "maskedTextBoxPassport";
            this.maskedTextBoxPassport.Size = new System.Drawing.Size(143, 20);
            this.maskedTextBoxPassport.TabIndex = 26;
            // 
            // maskedTextBoxBirthDate
            // 
            this.maskedTextBoxBirthDate.Location = new System.Drawing.Point(1112, 142);
            this.maskedTextBoxBirthDate.Mask = "00/00/0000";
            this.maskedTextBoxBirthDate.Name = "maskedTextBoxBirthDate";
            this.maskedTextBoxBirthDate.Size = new System.Drawing.Size(143, 20);
            this.maskedTextBoxBirthDate.TabIndex = 27;
            this.maskedTextBoxBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(1112, 209);
            this.maskedTextBoxPhoneNumber.Mask = "(999) 000-0000";
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(143, 20);
            this.maskedTextBoxPhoneNumber.TabIndex = 28;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Учащийся",
            "Работающий",
            "Пенсионер",
            "Безработный"});
            this.comboBoxStatus.Location = new System.Drawing.Point(1112, 241);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(143, 21);
            this.comboBoxStatus.TabIndex = 29;
            // 
            // buttonNewPatient
            // 
            this.buttonNewPatient.Location = new System.Drawing.Point(984, 281);
            this.buttonNewPatient.Name = "buttonNewPatient";
            this.buttonNewPatient.Size = new System.Drawing.Size(271, 23);
            this.buttonNewPatient.TabIndex = 30;
            this.buttonNewPatient.Text = "Принять и распределить пациента";
            this.buttonNewPatient.UseVisualStyleBackColor = true;
            this.buttonNewPatient.Click += new System.EventHandler(this.buttonNewPatient_Click);
            // 
            // FormCRUDPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 450);
            this.Controls.Add(this.buttonNewPatient);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.Controls.Add(this.maskedTextBoxBirthDate);
            this.Controls.Add(this.maskedTextBoxPassport);
            this.Controls.Add(this.maskedTextBoxInNumber);
            this.Controls.Add(this.textBoxInCompany);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonFree);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxSearchNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearchFIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCRUDPatients";
            this.Text = "Пациенты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearchNumber;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonFree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxInCompany;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassport;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBirthDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonNewPatient;
    }
}