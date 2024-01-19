namespace DatingProgram.Forms
{
    partial class Archive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archive));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.emptyTableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(46, 54);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(770, 335);
            this.dataGridView.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(290, 392);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(278, 77);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Выйти из Архива";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(368, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Архив";
            // 
            // emptyTableLabel
            // 
            this.emptyTableLabel.AutoSize = true;
            this.emptyTableLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.emptyTableLabel.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emptyTableLabel.ForeColor = System.Drawing.Color.Violet;
            this.emptyTableLabel.Location = new System.Drawing.Point(50, 113);
            this.emptyTableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emptyTableLabel.Name = "emptyTableLabel";
            this.emptyTableLabel.Size = new System.Drawing.Size(277, 32);
            this.emptyTableLabel.TabIndex = 6;
            this.emptyTableLabel.Text = "Нет записей в архиве";
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(845, 480);
            this.Controls.Add(this.emptyTableLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Archive";
            this.Text = "Архив";
            this.Load += new System.EventHandler(this.ArchiveWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emptyTableLabel;
    }
}