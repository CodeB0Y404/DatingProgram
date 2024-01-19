namespace DatingProgram.Forms
{
    partial class CreationDialog
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.manCheckBox = new System.Windows.Forms.CheckBox();
            this.womanCheckBox = new System.Windows.Forms.CheckBox();
            this.birthLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.aboutPersonLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.contractLabel = new System.Windows.Forms.Label();
            this.aboutTextBox = new System.Windows.Forms.RichTextBox();
            this.issuesTextBox = new System.Windows.Forms.RichTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.mainLabel.Location = new System.Drawing.Point(158, -4);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(522, 68);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Заполните профиль";
            this.mainLabel.Click += new System.EventHandler(this.mainLabel_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.ForeColor = System.Drawing.Color.Aquamarine;
            this.labelGender.Location = new System.Drawing.Point(118, 87);
            this.labelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(66, 34);
            this.labelGender.TabIndex = 1;
            this.labelGender.Text = "Пол";
            // 
            // manCheckBox
            // 
            this.manCheckBox.AutoSize = true;
            this.manCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manCheckBox.ForeColor = System.Drawing.Color.Aquamarine;
            this.manCheckBox.Location = new System.Drawing.Point(199, 66);
            this.manCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.manCheckBox.Name = "manCheckBox";
            this.manCheckBox.Size = new System.Drawing.Size(136, 38);
            this.manCheckBox.TabIndex = 4;
            this.manCheckBox.Text = "Мужской";
            this.manCheckBox.UseVisualStyleBackColor = true;
            this.manCheckBox.CheckedChanged += new System.EventHandler(this.manCheckBox_CheckedChanged);
            // 
            // womanCheckBox
            // 
            this.womanCheckBox.AutoSize = true;
            this.womanCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.womanCheckBox.ForeColor = System.Drawing.Color.Aquamarine;
            this.womanCheckBox.Location = new System.Drawing.Point(199, 103);
            this.womanCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.womanCheckBox.Name = "womanCheckBox";
            this.womanCheckBox.Size = new System.Drawing.Size(135, 38);
            this.womanCheckBox.TabIndex = 5;
            this.womanCheckBox.Text = "Женский";
            this.womanCheckBox.UseVisualStyleBackColor = true;
            this.womanCheckBox.CheckedChanged += new System.EventHandler(this.womanCheckBox_CheckedChanged);
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.birthLabel.Location = new System.Drawing.Point(194, 287);
            this.birthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(197, 34);
            this.birthLabel.TabIndex = 6;
            this.birthLabel.Text = "Дата рождения";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.nameLabel.Location = new System.Drawing.Point(396, 67);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 34);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Имя";
            // 
            // aboutPersonLabel
            // 
            this.aboutPersonLabel.AutoSize = true;
            this.aboutPersonLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutPersonLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.aboutPersonLabel.Location = new System.Drawing.Point(13, 152);
            this.aboutPersonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aboutPersonLabel.Name = "aboutPersonLabel";
            this.aboutPersonLabel.Size = new System.Drawing.Size(105, 34);
            this.aboutPersonLabel.TabIndex = 9;
            this.aboutPersonLabel.Text = "О себе:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.cityLabel.Location = new System.Drawing.Point(377, 109);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(81, 34);
            this.cityLabel.TabIndex = 10;
            this.cityLabel.Text = "Город";
            // 
            // contractLabel
            // 
            this.contractLabel.AutoSize = true;
            this.contractLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.contractLabel.Location = new System.Drawing.Point(423, 156);
            this.contractLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contractLabel.Name = "contractLabel";
            this.contractLabel.Size = new System.Drawing.Size(304, 34);
            this.contractLabel.TabIndex = 11;
            this.contractLabel.Text = "Требования к партнёру:";
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutTextBox.Location = new System.Drawing.Point(19, 187);
            this.aboutTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.aboutTextBox.MaxLength = 150;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.Size = new System.Drawing.Size(381, 79);
            this.aboutTextBox.TabIndex = 13;
            this.aboutTextBox.Text = "";
            // 
            // issuesTextBox
            // 
            this.issuesTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.issuesTextBox.Location = new System.Drawing.Point(428, 187);
            this.issuesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.issuesTextBox.MaxLength = 150;
            this.issuesTextBox.Name = "issuesTextBox";
            this.issuesTextBox.Size = new System.Drawing.Size(381, 79);
            this.issuesTextBox.TabIndex = 14;
            this.issuesTextBox.Text = "";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(460, 67);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.MaxLength = 28;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(308, 35);
            this.nameTextBox.TabIndex = 15;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityTextBox.Location = new System.Drawing.Point(460, 106);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityTextBox.MaxLength = 28;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(308, 35);
            this.cityTextBox.TabIndex = 16;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(264, 335);
            this.createButton.Margin = new System.Windows.Forms.Padding(2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(290, 46);
            this.createButton.TabIndex = 17;
            this.createButton.Text = "Создать профиль";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(428, 287);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 30);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // CreationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(835, 407);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.issuesTextBox);
            this.Controls.Add(this.aboutTextBox);
            this.Controls.Add(this.contractLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.aboutPersonLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.womanCheckBox);
            this.Controls.Add(this.manCheckBox);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.mainLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreationDialog";
            this.Text = "Новый пользователь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.CheckBox manCheckBox;
        private System.Windows.Forms.CheckBox womanCheckBox;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label aboutPersonLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label contractLabel;
        private System.Windows.Forms.RichTextBox aboutTextBox;
        private System.Windows.Forms.RichTextBox issuesTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}