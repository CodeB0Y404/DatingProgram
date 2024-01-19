
namespace DatingProgram.Forms
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.newElementButton = new System.Windows.Forms.Button();
            this.deleteElementButton = new System.Windows.Forms.Button();
            this.noElementsWarningLabel = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.manCheckBox = new System.Windows.Forms.CheckBox();
            this.womanCheckBox = new System.Windows.Forms.CheckBox();
            this.ageFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.ageFirstNumeric = new System.Windows.Forms.NumericUpDown();
            this.labelAge1 = new System.Windows.Forms.Label();
            this.labelAge2 = new System.Windows.Forms.Label();
            this.ageSecondNumeric = new System.Windows.Forms.NumericUpDown();
            this.cityFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.filtercCityButton = new System.Windows.Forms.Button();
            this.openArchiveButton = new System.Windows.Forms.Button();
            this.editElementButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFirstNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageSecondNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(276, 88);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(844, 329);
            this.dataGridView.TabIndex = 0;
            // 
            // newElementButton
            // 
            this.newElementButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(36)))), ((int)(((byte)(116)))));
            this.newElementButton.FlatAppearance.BorderSize = 10;
            this.newElementButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newElementButton.ForeColor = System.Drawing.Color.Black;
            this.newElementButton.Location = new System.Drawing.Point(300, 431);
            this.newElementButton.Margin = new System.Windows.Forms.Padding(2);
            this.newElementButton.Name = "newElementButton";
            this.newElementButton.Size = new System.Drawing.Size(237, 31);
            this.newElementButton.TabIndex = 1;
            this.newElementButton.Text = "Добавить запись";
            this.newElementButton.UseVisualStyleBackColor = true;
            this.newElementButton.Click += new System.EventHandler(this.newElementButton_Click);
            // 
            // deleteElementButton
            // 
            this.deleteElementButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(36)))), ((int)(((byte)(116)))));
            this.deleteElementButton.FlatAppearance.BorderSize = 10;
            this.deleteElementButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteElementButton.ForeColor = System.Drawing.Color.Black;
            this.deleteElementButton.Location = new System.Drawing.Point(869, 431);
            this.deleteElementButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteElementButton.Name = "deleteElementButton";
            this.deleteElementButton.Size = new System.Drawing.Size(237, 31);
            this.deleteElementButton.TabIndex = 3;
            this.deleteElementButton.Text = "Удалить запись";
            this.deleteElementButton.UseVisualStyleBackColor = true;
            this.deleteElementButton.Click += new System.EventHandler(this.deleteElementButton_Click);
            // 
            // noElementsWarningLabel
            // 
            this.noElementsWarningLabel.AutoSize = true;
            this.noElementsWarningLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.noElementsWarningLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noElementsWarningLabel.Location = new System.Drawing.Point(291, 135);
            this.noElementsWarningLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noElementsWarningLabel.Name = "noElementsWarningLabel";
            this.noElementsWarningLabel.Size = new System.Drawing.Size(246, 35);
            this.noElementsWarningLabel.TabIndex = 8;
            this.noElementsWarningLabel.Text = "Записи не найдены";
            this.noElementsWarningLabel.Click += new System.EventHandler(this.noElementsWarningLabel_Click);
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWarning.ForeColor = System.Drawing.Color.Aquamarine;
            this.labelWarning.Location = new System.Drawing.Point(272, 28);
            this.labelWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(159, 26);
            this.labelWarning.TabIndex = 9;
            this.labelWarning.Text = "Бюро знакомств";
            this.labelWarning.Click += new System.EventHandler(this.labelWarning_Click);
            // 
            // manCheckBox
            // 
            this.manCheckBox.AutoSize = true;
            this.manCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manCheckBox.ForeColor = System.Drawing.Color.Aquamarine;
            this.manCheckBox.Location = new System.Drawing.Point(16, 421);
            this.manCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.manCheckBox.Name = "manCheckBox";
            this.manCheckBox.Size = new System.Drawing.Size(120, 31);
            this.manCheckBox.TabIndex = 10;
            this.manCheckBox.Text = "Мужчины";
            this.manCheckBox.UseVisualStyleBackColor = true;
            this.manCheckBox.CheckedChanged += new System.EventHandler(this.manCheckBox_CheckedChanged);
            // 
            // womanCheckBox
            // 
            this.womanCheckBox.AutoSize = true;
            this.womanCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.womanCheckBox.ForeColor = System.Drawing.Color.Aquamarine;
            this.womanCheckBox.Location = new System.Drawing.Point(150, 421);
            this.womanCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.womanCheckBox.Name = "womanCheckBox";
            this.womanCheckBox.Size = new System.Drawing.Size(122, 31);
            this.womanCheckBox.TabIndex = 11;
            this.womanCheckBox.Text = "Женщины";
            this.womanCheckBox.UseVisualStyleBackColor = true;
            this.womanCheckBox.CheckedChanged += new System.EventHandler(this.womanCheckBox_CheckedChanged);
            // 
            // ageFilterCheckBox
            // 
            this.ageFilterCheckBox.AutoSize = true;
            this.ageFilterCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageFilterCheckBox.ForeColor = System.Drawing.Color.Aquamarine;
            this.ageFilterCheckBox.Location = new System.Drawing.Point(11, 279);
            this.ageFilterCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ageFilterCheckBox.Name = "ageFilterCheckBox";
            this.ageFilterCheckBox.Size = new System.Drawing.Size(251, 31);
            this.ageFilterCheckBox.TabIndex = 12;
            this.ageFilterCheckBox.Text = "Отбирать по возрасту";
            this.ageFilterCheckBox.UseVisualStyleBackColor = true;
            this.ageFilterCheckBox.CheckedChanged += new System.EventHandler(this.ageFilterCheckBox_CheckedChanged);
            // 
            // ageFirstNumeric
            // 
            this.ageFirstNumeric.Enabled = false;
            this.ageFirstNumeric.Location = new System.Drawing.Point(136, 344);
            this.ageFirstNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.ageFirstNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ageFirstNumeric.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageFirstNumeric.Name = "ageFirstNumeric";
            this.ageFirstNumeric.Size = new System.Drawing.Size(40, 20);
            this.ageFirstNumeric.TabIndex = 13;
            this.ageFirstNumeric.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ageFirstNumeric.ValueChanged += new System.EventHandler(this.ageFirstNumeric_ValueChanged);
            // 
            // labelAge1
            // 
            this.labelAge1.AutoSize = true;
            this.labelAge1.Enabled = false;
            this.labelAge1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge1.ForeColor = System.Drawing.Color.Aquamarine;
            this.labelAge1.Location = new System.Drawing.Point(11, 337);
            this.labelAge1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAge1.Name = "labelAge1";
            this.labelAge1.Size = new System.Drawing.Size(121, 27);
            this.labelAge1.TabIndex = 14;
            this.labelAge1.Text = "Возраст от";
            this.labelAge1.Click += new System.EventHandler(this.labelAge1_Click);
            // 
            // labelAge2
            // 
            this.labelAge2.AutoSize = true;
            this.labelAge2.Enabled = false;
            this.labelAge2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge2.ForeColor = System.Drawing.Color.Aquamarine;
            this.labelAge2.Location = new System.Drawing.Point(180, 337);
            this.labelAge2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAge2.Name = "labelAge2";
            this.labelAge2.Size = new System.Drawing.Size(33, 27);
            this.labelAge2.TabIndex = 15;
            this.labelAge2.Text = "до";
            this.labelAge2.Click += new System.EventHandler(this.labelAge2_Click);
            // 
            // ageSecondNumeric
            // 
            this.ageSecondNumeric.Enabled = false;
            this.ageSecondNumeric.Location = new System.Drawing.Point(213, 344);
            this.ageSecondNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.ageSecondNumeric.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.ageSecondNumeric.Minimum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.ageSecondNumeric.Name = "ageSecondNumeric";
            this.ageSecondNumeric.Size = new System.Drawing.Size(39, 20);
            this.ageSecondNumeric.TabIndex = 16;
            this.ageSecondNumeric.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ageSecondNumeric.ValueChanged += new System.EventHandler(this.ageSecondNumeric_ValueChanged);
            // 
            // cityFilterCheckBox
            // 
            this.cityFilterCheckBox.AutoSize = true;
            this.cityFilterCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityFilterCheckBox.ForeColor = System.Drawing.Color.Aquamarine;
            this.cityFilterCheckBox.Location = new System.Drawing.Point(20, 90);
            this.cityFilterCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityFilterCheckBox.Name = "cityFilterCheckBox";
            this.cityFilterCheckBox.Size = new System.Drawing.Size(227, 31);
            this.cityFilterCheckBox.TabIndex = 18;
            this.cityFilterCheckBox.Text = "Отбирать по городу";
            this.cityFilterCheckBox.UseVisualStyleBackColor = true;
            this.cityFilterCheckBox.CheckedChanged += new System.EventHandler(this.filterCityCheckBox_CheckedChanged);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Enabled = false;
            this.labelCity.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.ForeColor = System.Drawing.Color.Aquamarine;
            this.labelCity.Location = new System.Drawing.Point(15, 135);
            this.labelCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(71, 27);
            this.labelCity.TabIndex = 19;
            this.labelCity.Text = "Город:";
            this.labelCity.Click += new System.EventHandler(this.labelCity_Click);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Enabled = false;
            this.cityTextBox.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityTextBox.Location = new System.Drawing.Point(15, 182);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(237, 29);
            this.cityTextBox.TabIndex = 20;
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // filtercCityButton
            // 
            this.filtercCityButton.Enabled = false;
            this.filtercCityButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filtercCityButton.Location = new System.Drawing.Point(16, 224);
            this.filtercCityButton.Margin = new System.Windows.Forms.Padding(2);
            this.filtercCityButton.Name = "filtercCityButton";
            this.filtercCityButton.Size = new System.Drawing.Size(127, 28);
            this.filtercCityButton.TabIndex = 22;
            this.filtercCityButton.Text = "Выбрать город";
            this.filtercCityButton.UseVisualStyleBackColor = true;
            this.filtercCityButton.Click += new System.EventHandler(this.filterCityButton_Click);
            // 
            // openArchiveButton
            // 
            this.openArchiveButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openArchiveButton.Location = new System.Drawing.Point(20, 28);
            this.openArchiveButton.Margin = new System.Windows.Forms.Padding(2);
            this.openArchiveButton.Name = "openArchiveButton";
            this.openArchiveButton.Size = new System.Drawing.Size(237, 31);
            this.openArchiveButton.TabIndex = 23;
            this.openArchiveButton.Text = "Открыть архив";
            this.openArchiveButton.UseVisualStyleBackColor = true;
            this.openArchiveButton.Click += new System.EventHandler(this.openArchiveButton_Click);
            // 
            // editElementButton
            // 
            this.editElementButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(36)))), ((int)(((byte)(116)))));
            this.editElementButton.FlatAppearance.BorderSize = 10;
            this.editElementButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editElementButton.ForeColor = System.Drawing.Color.Black;
            this.editElementButton.Location = new System.Drawing.Point(577, 431);
            this.editElementButton.Margin = new System.Windows.Forms.Padding(2);
            this.editElementButton.Name = "editElementButton";
            this.editElementButton.Size = new System.Drawing.Size(237, 31);
            this.editElementButton.TabIndex = 2;
            this.editElementButton.Text = "Редактировать запись";
            this.editElementButton.UseVisualStyleBackColor = true;
            this.editElementButton.Click += new System.EventHandler(this.editElementButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1042, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 75);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1155, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.openArchiveButton);
            this.Controls.Add(this.filtercCityButton);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.cityFilterCheckBox);
            this.Controls.Add(this.ageSecondNumeric);
            this.Controls.Add(this.labelAge2);
            this.Controls.Add(this.labelAge1);
            this.Controls.Add(this.ageFirstNumeric);
            this.Controls.Add(this.ageFilterCheckBox);
            this.Controls.Add(this.womanCheckBox);
            this.Controls.Add(this.manCheckBox);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.noElementsWarningLabel);
            this.Controls.Add(this.deleteElementButton);
            this.Controls.Add(this.editElementButton);
            this.Controls.Add(this.newElementButton);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = " Бюро знакомств";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFirstNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageSecondNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button newElementButton;
        private System.Windows.Forms.Button deleteElementButton;
        private System.Windows.Forms.Label noElementsWarningLabel;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.CheckBox manCheckBox;
        private System.Windows.Forms.CheckBox womanCheckBox;
        private System.Windows.Forms.CheckBox ageFilterCheckBox;
        private System.Windows.Forms.NumericUpDown ageFirstNumeric;
        private System.Windows.Forms.Label labelAge1;
        private System.Windows.Forms.Label labelAge2;
        private System.Windows.Forms.NumericUpDown ageSecondNumeric;
        private System.Windows.Forms.CheckBox cityFilterCheckBox;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button filtercCityButton;
        private System.Windows.Forms.Button openArchiveButton;
        private System.Windows.Forms.Button editElementButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

