namespace WF_HW_Module_4
{
    partial class Form1
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
            this.listBox_humans = new System.Windows.Forms.ListBox();
            this.label1_Info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_FatherName = new System.Windows.Forms.Label();
            this.label_Sex = new System.Windows.Forms.Label();
            this.label_DateBirth = new System.Windows.Forms.Label();
            this.label_FamilyStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_humans
            // 
            this.listBox_humans.FormattingEnabled = true;
            this.listBox_humans.Location = new System.Drawing.Point(26, 37);
            this.listBox_humans.Name = "listBox_humans";
            this.listBox_humans.Size = new System.Drawing.Size(114, 212);
            this.listBox_humans.TabIndex = 0;
            this.listBox_humans.SelectedIndexChanged += new System.EventHandler(this.listBox_humans_SelectedIndexChanged);
            // 
            // label1_Info
            // 
            this.label1_Info.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1_Info.Location = new System.Drawing.Point(242, 37);
            this.label1_Info.Name = "label1_Info";
            this.label1_Info.Size = new System.Drawing.Size(379, 212);
            this.label1_Info.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Анкета для нового пользователя";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(30, 322);
            this.label_Name.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(29, 13);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Имя";
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Location = new System.Drawing.Point(28, 349);
            this.label_Surname.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(56, 13);
            this.label_Surname.TabIndex = 4;
            this.label_Surname.Text = "Фамилия";
            // 
            // label_FatherName
            // 
            this.label_FatherName.AutoSize = true;
            this.label_FatherName.Location = new System.Drawing.Point(30, 373);
            this.label_FatherName.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.label_FatherName.Name = "label_FatherName";
            this.label_FatherName.Size = new System.Drawing.Size(54, 13);
            this.label_FatherName.TabIndex = 5;
            this.label_FatherName.Text = "Отчество";
            // 
            // label_Sex
            // 
            this.label_Sex.AutoSize = true;
            this.label_Sex.Location = new System.Drawing.Point(30, 399);
            this.label_Sex.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.label_Sex.Name = "label_Sex";
            this.label_Sex.Size = new System.Drawing.Size(27, 13);
            this.label_Sex.TabIndex = 6;
            this.label_Sex.Text = "Пол";
            // 
            // label_DateBirth
            // 
            this.label_DateBirth.AutoSize = true;
            this.label_DateBirth.Location = new System.Drawing.Point(30, 425);
            this.label_DateBirth.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.label_DateBirth.Name = "label_DateBirth";
            this.label_DateBirth.Size = new System.Drawing.Size(86, 13);
            this.label_DateBirth.TabIndex = 7;
            this.label_DateBirth.Text = "Дата рождения";
            // 
            // label_FamilyStatus
            // 
            this.label_FamilyStatus.AutoSize = true;
            this.label_FamilyStatus.Location = new System.Drawing.Point(30, 451);
            this.label_FamilyStatus.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.label_FamilyStatus.Name = "label_FamilyStatus";
            this.label_FamilyStatus.Size = new System.Drawing.Size(117, 13);
            this.label_FamilyStatus.TabIndex = 8;
            this.label_FamilyStatus.Text = "Семейное положение";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 315);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 342);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(268, 366);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 418);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(268, 442);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(268, 392);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(29, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Добавить нового пользователя";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Удалить ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 574);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Сохранить текущую базу в файл";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Дополнительная информация";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(268, 477);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 20;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(372, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Изменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(418, 538);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(285, 59);
            this.button5.TabIndex = 22;
            this.button5.Text = "ЕСЛИ ВЫ УЖЕ СОХРАНЯЛИ  ТЕКУЩУЮ БАЗУ ДАННЫХ  В ФАЙЛ , ТО МОЖЕТЕ ВОСПОЛЬЗОВАТЬСЯ ЭТ" +
    "ОЙ КНОПКОЙ ДЛЯ ЗАГРУЗКИ ЕЕ ЖЕ!!! ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1008, 929);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_FamilyStatus);
            this.Controls.Add(this.label_DateBirth);
            this.Controls.Add(this.label_Sex);
            this.Controls.Add(this.label_FatherName);
            this.Controls.Add(this.label_Surname);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label1_Info);
            this.Controls.Add(this.listBox_humans);
            this.Name = "Form1";
            this.Text = "Анкета";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_humans;
        private System.Windows.Forms.Label label1_Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_FatherName;
        private System.Windows.Forms.Label label_Sex;
        private System.Windows.Forms.Label label_DateBirth;
        private System.Windows.Forms.Label label_FamilyStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

