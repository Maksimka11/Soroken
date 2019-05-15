namespace DirectoryOfPainting
{
    partial class Artists
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbFatherName = new System.Windows.Forms.TextBox();
            this.tbStyle = new System.Windows.Forms.TextBox();
            this.dtpDateBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Стиль";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(74, 6);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 5;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(53, 41);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(121, 20);
            this.tbFirstName.TabIndex = 6;
            // 
            // tbFatherName
            // 
            this.tbFatherName.Location = new System.Drawing.Point(74, 84);
            this.tbFatherName.Name = "tbFatherName";
            this.tbFatherName.Size = new System.Drawing.Size(100, 20);
            this.tbFatherName.TabIndex = 7;
            // 
            // tbStyle
            // 
            this.tbStyle.Location = new System.Drawing.Point(55, 164);
            this.tbStyle.Name = "tbStyle";
            this.tbStyle.Size = new System.Drawing.Size(119, 20);
            this.tbStyle.TabIndex = 8;
            // 
            // dtpDateBirthday
            // 
            this.dtpDateBirthday.Location = new System.Drawing.Point(104, 125);
            this.dtpDateBirthday.Name = "dtpDateBirthday";
            this.dtpDateBirthday.Size = new System.Drawing.Size(164, 20);
            this.dtpDateBirthday.TabIndex = 9;
            this.dtpDateBirthday.Value = new System.DateTime(2019, 5, 3, 0, 0, 0, 0);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(55, 210);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btn
            // 
            this.btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn.Location = new System.Drawing.Point(193, 210);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 11;
            this.btn.Text = "Отмена";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // Artists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 245);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtpDateBirthday);
            this.Controls.Add(this.tbStyle);
            this.Controls.Add(this.tbFatherName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Artists";
            this.Text = "Редактирование художника";
            this.Load += new System.EventHandler(this.Artists_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbFatherName;
        private System.Windows.Forms.TextBox tbStyle;
        private System.Windows.Forms.DateTimePicker dtpDateBirthday;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btn;
    }
}

