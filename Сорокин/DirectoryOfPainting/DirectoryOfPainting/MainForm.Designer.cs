namespace DirectoryOfPainting
{
    partial class MainForm
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
            this.dgvAuctions = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAuDel = new System.Windows.Forms.Button();
            this.btnAuChange = new System.Windows.Forms.Button();
            this.btnAuAdd = new System.Windows.Forms.Button();
            this.dgvArtists = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPictures = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnPicDel = new System.Windows.Forms.Button();
            this.btnPicAdd = new System.Windows.Forms.Button();
            this.btnPicChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnArChange = new System.Windows.Forms.Button();
            this.btnArDel = new System.Windows.Forms.Button();
            this.btnArAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuctions)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPictures)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аукционы";
            // 
            // dgvAuctions
            // 
            this.dgvAuctions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuctions.Location = new System.Drawing.Point(15, 25);
            this.dgvAuctions.Name = "dgvAuctions";
            this.dgvAuctions.Size = new System.Drawing.Size(629, 91);
            this.dgvAuctions.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAuDel);
            this.panel1.Controls.Add(this.btnAuChange);
            this.panel1.Controls.Add(this.btnAuAdd);
            this.panel1.Location = new System.Drawing.Point(15, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 43);
            this.panel1.TabIndex = 2;
            // 
            // btnAuDel
            // 
            this.btnAuDel.Location = new System.Drawing.Point(208, 10);
            this.btnAuDel.Name = "btnAuDel";
            this.btnAuDel.Size = new System.Drawing.Size(75, 23);
            this.btnAuDel.TabIndex = 2;
            this.btnAuDel.Text = "Удалить";
            this.btnAuDel.UseVisualStyleBackColor = true;
            this.btnAuDel.Click += new System.EventHandler(this.btnAuDel_Click);
            // 
            // btnAuChange
            // 
            this.btnAuChange.Location = new System.Drawing.Point(96, 10);
            this.btnAuChange.Name = "btnAuChange";
            this.btnAuChange.Size = new System.Drawing.Size(93, 23);
            this.btnAuChange.TabIndex = 1;
            this.btnAuChange.Text = "Редактировать";
            this.btnAuChange.UseVisualStyleBackColor = true;
            this.btnAuChange.Click += new System.EventHandler(this.btnAuChange_Click);
            // 
            // btnAuAdd
            // 
            this.btnAuAdd.Location = new System.Drawing.Point(3, 10);
            this.btnAuAdd.Name = "btnAuAdd";
            this.btnAuAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAuAdd.TabIndex = 0;
            this.btnAuAdd.Text = "Добавить";
            this.btnAuAdd.UseVisualStyleBackColor = true;
            this.btnAuAdd.Click += new System.EventHandler(this.btnAuAdd_Click);
            // 
            // dgvArtists
            // 
            this.dgvArtists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtists.Location = new System.Drawing.Point(15, 180);
            this.dgvArtists.Name = "dgvArtists";
            this.dgvArtists.Size = new System.Drawing.Size(629, 91);
            this.dgvArtists.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Художники";
            // 
            // dgvPictures
            // 
            this.dgvPictures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPictures.Location = new System.Drawing.Point(15, 339);
            this.dgvPictures.Name = "dgvPictures";
            this.dgvPictures.Size = new System.Drawing.Size(629, 91);
            this.dgvPictures.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btnPicDel);
            this.panel3.Controls.Add(this.btnPicAdd);
            this.panel3.Controls.Add(this.btnPicChange);
            this.panel3.Location = new System.Drawing.Point(15, 426);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(629, 43);
            this.panel3.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(15, 426);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(629, 43);
            this.panel6.TabIndex = 12;
            // 
            // btnPicDel
            // 
            this.btnPicDel.Location = new System.Drawing.Point(208, 10);
            this.btnPicDel.Name = "btnPicDel";
            this.btnPicDel.Size = new System.Drawing.Size(75, 23);
            this.btnPicDel.TabIndex = 11;
            this.btnPicDel.Text = "Удалить";
            this.btnPicDel.UseVisualStyleBackColor = true;
            this.btnPicDel.Click += new System.EventHandler(this.btnPicDel_Click);
            // 
            // btnPicAdd
            // 
            this.btnPicAdd.Location = new System.Drawing.Point(3, 10);
            this.btnPicAdd.Name = "btnPicAdd";
            this.btnPicAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPicAdd.TabIndex = 9;
            this.btnPicAdd.Text = "Добавить";
            this.btnPicAdd.UseVisualStyleBackColor = true;
            this.btnPicAdd.Click += new System.EventHandler(this.btnPicAdd_Click);
            // 
            // btnPicChange
            // 
            this.btnPicChange.Location = new System.Drawing.Point(96, 10);
            this.btnPicChange.Name = "btnPicChange";
            this.btnPicChange.Size = new System.Drawing.Size(93, 23);
            this.btnPicChange.TabIndex = 10;
            this.btnPicChange.Text = "Редактировать";
            this.btnPicChange.UseVisualStyleBackColor = true;
            this.btnPicChange.Click += new System.EventHandler(this.btnPicChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Картины";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(96, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(191, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(15, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 43);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnArChange);
            this.panel4.Controls.Add(this.btnArDel);
            this.panel4.Controls.Add(this.btnArAdd);
            this.panel4.Location = new System.Drawing.Point(15, 267);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(629, 43);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(15, 426);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(629, 43);
            this.panel5.TabIndex = 12;
            // 
            // btnArChange
            // 
            this.btnArChange.Location = new System.Drawing.Point(96, 10);
            this.btnArChange.Name = "btnArChange";
            this.btnArChange.Size = new System.Drawing.Size(93, 23);
            this.btnArChange.TabIndex = 10;
            this.btnArChange.Text = "Редактировать";
            this.btnArChange.UseVisualStyleBackColor = true;
            this.btnArChange.Click += new System.EventHandler(this.btnArChange_Click);
            // 
            // btnArDel
            // 
            this.btnArDel.Location = new System.Drawing.Point(208, 10);
            this.btnArDel.Name = "btnArDel";
            this.btnArDel.Size = new System.Drawing.Size(75, 23);
            this.btnArDel.TabIndex = 11;
            this.btnArDel.Text = "Удалить";
            this.btnArDel.UseVisualStyleBackColor = true;
            this.btnArDel.Click += new System.EventHandler(this.btnArDel_Click);
            // 
            // btnArAdd
            // 
            this.btnArAdd.Location = new System.Drawing.Point(3, 10);
            this.btnArAdd.Name = "btnArAdd";
            this.btnArAdd.Size = new System.Drawing.Size(75, 23);
            this.btnArAdd.TabIndex = 9;
            this.btnArAdd.Text = "Добавить";
            this.btnArAdd.UseVisualStyleBackColor = true;
            this.btnArAdd.Click += new System.EventHandler(this.btnArAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 481);
            this.Controls.Add(this.dgvPictures);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvArtists);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAuctions);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник любителя живописи";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuctions)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPictures)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAuctions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAuDel;
        private System.Windows.Forms.Button btnAuChange;
        private System.Windows.Forms.Button btnAuAdd;
        private System.Windows.Forms.DataGridView dgvArtists;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPictures;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPicDel;
        private System.Windows.Forms.Button btnPicAdd;
        private System.Windows.Forms.Button btnPicChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnArChange;
        private System.Windows.Forms.Button btnArDel;
        private System.Windows.Forms.Button btnArAdd;
    }
}