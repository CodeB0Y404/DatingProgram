namespace DatingProgram.Forms
{
    partial class EditDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDialog));
            this.titleLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.aboutPersonLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contractLabel = new System.Windows.Forms.Label();
            this.aboutTextBox = new System.Windows.Forms.RichTextBox();
            this.issuesTextBox = new System.Windows.Forms.RichTextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Comic Sans MS", 29.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.titleLabel.Location = new System.Drawing.Point(2, 4);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(542, 55);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Редактирование профиля ";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.birthLabel.Location = new System.Drawing.Point(40, 156);
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
            this.nameLabel.Location = new System.Drawing.Point(69, 71);
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
            this.aboutPersonLabel.Location = new System.Drawing.Point(535, 25);
            this.aboutPersonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aboutPersonLabel.Name = "aboutPersonLabel";
            this.aboutPersonLabel.Size = new System.Drawing.Size(105, 34);
            this.aboutPersonLabel.TabIndex = 9;
            this.aboutPersonLabel.Text = "О себе:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(62, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 34);
            this.label1.TabIndex = 10;
            this.label1.Text = "Город";
            // 
            // contractLabel
            // 
            this.contractLabel.AutoSize = true;
            this.contractLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.contractLabel.Location = new System.Drawing.Point(536, 142);
            this.contractLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contractLabel.Name = "contractLabel";
            this.contractLabel.Size = new System.Drawing.Size(304, 34);
            this.contractLabel.TabIndex = 11;
            this.contractLabel.Text = "Требования к партнёру:";
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutTextBox.Location = new System.Drawing.Point(541, 61);
            this.aboutTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aboutTextBox.MaxLength = 150;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.Size = new System.Drawing.Size(381, 79);
            this.aboutTextBox.TabIndex = 13;
            this.aboutTextBox.Text = "";
            // 
            // issuesTextBox
            // 
            this.issuesTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.issuesTextBox.Location = new System.Drawing.Point(542, 183);
            this.issuesTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.issuesTextBox.MaxLength = 150;
            this.issuesTextBox.Name = "issuesTextBox";
            this.issuesTextBox.Size = new System.Drawing.Size(381, 79);
            this.issuesTextBox.TabIndex = 14;
            this.issuesTextBox.Text = "";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(139, 68);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.MaxLength = 28;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(308, 35);
            this.nameTextBox.TabIndex = 15;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityTextBox.Location = new System.Drawing.Point(139, 102);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cityTextBox.MaxLength = 28;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(308, 35);
            this.cityTextBox.TabIndex = 16;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(93, 216);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(363, 46);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(242, 161);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 28);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // EditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(942, 292);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.issuesTextBox);
            this.Controls.Add(this.aboutTextBox);
            this.Controls.Add(this.contractLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboutPersonLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditDialog";
            this.Text = "Редактирование профиля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label aboutPersonLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label contractLabel;
        private System.Windows.Forms.RichTextBox aboutTextBox;
        private System.Windows.Forms.RichTextBox issuesTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}