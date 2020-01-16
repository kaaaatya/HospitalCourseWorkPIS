namespace HospitalView
{
    partial class FormPatients
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearchFIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearchByFIO = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.buttonNowTreated = new System.Windows.Forms.Button();
            this.buttonSearchByNumber = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 134);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(246, 23);
            this.buttonCancel.TabIndex = 38;
            this.buttonCancel.Text = "Сбросить ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "По ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "По № страховки";
            // 
            // textBoxSearchFIO
            // 
            this.textBoxSearchFIO.Location = new System.Drawing.Point(115, 27);
            this.textBoxSearchFIO.Name = "textBoxSearchFIO";
            this.textBoxSearchFIO.Size = new System.Drawing.Size(143, 20);
            this.textBoxSearchFIO.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Поиск пациента:";
            // 
            // buttonSearchByFIO
            // 
            this.buttonSearchByFIO.Location = new System.Drawing.Point(115, 53);
            this.buttonSearchByFIO.Name = "buttonSearchByFIO";
            this.buttonSearchByFIO.Size = new System.Drawing.Size(143, 23);
            this.buttonSearchByFIO.TabIndex = 32;
            this.buttonSearchByFIO.Text = "Поиск по ФИО";
            this.buttonSearchByFIO.UseVisualStyleBackColor = true;
            this.buttonSearchByFIO.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1111, 283);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(264, 82);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(221, 23);
            this.buttonAdd.TabIndex = 40;
            this.buttonAdd.Text = "Добавить пациента";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(115, 81);
            this.maskedTextBoxNumber.Mask = "0000-0000-0000-0000";
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(143, 20);
            this.maskedTextBoxNumber.TabIndex = 42;
            // 
            // buttonNowTreated
            // 
            this.buttonNowTreated.Location = new System.Drawing.Point(264, 108);
            this.buttonNowTreated.Name = "buttonNowTreated";
            this.buttonNowTreated.Size = new System.Drawing.Size(221, 23);
            this.buttonNowTreated.TabIndex = 43;
            this.buttonNowTreated.Text = "Проходят лечение сейчас";
            this.buttonNowTreated.UseVisualStyleBackColor = true;
            this.buttonNowTreated.Click += new System.EventHandler(this.buttonNowTreated_Click);
            // 
            // buttonSearchByNumber
            // 
            this.buttonSearchByNumber.Location = new System.Drawing.Point(115, 108);
            this.buttonSearchByNumber.Name = "buttonSearchByNumber";
            this.buttonSearchByNumber.Size = new System.Drawing.Size(143, 23);
            this.buttonSearchByNumber.TabIndex = 44;
            this.buttonSearchByNumber.Text = "Поиск по № страховки";
            this.buttonSearchByNumber.UseVisualStyleBackColor = true;
            this.buttonSearchByNumber.Click += new System.EventHandler(this.buttonSearchByNumber_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(264, 134);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(221, 23);
            this.buttonUpd.TabIndex = 45;
            this.buttonUpd.Text = "Обновить";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // FormPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 455);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.buttonSearchByNumber);
            this.Controls.Add(this.buttonNowTreated);
            this.Controls.Add(this.maskedTextBoxNumber);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearchFIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearchByFIO);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPatients";
            this.Text = "Пациенты";
            this.Load += new System.EventHandler(this.FormPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearchFIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchByFIO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Button buttonNowTreated;
        private System.Windows.Forms.Button buttonSearchByNumber;
        private System.Windows.Forms.Button buttonUpd;
    }
}

