namespace DatabaseCourse2ORM
{
    partial class Exercise3ORM
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
            label4 = new Label();
            btnCalculate = new Button();
            label3 = new Label();
            txtQ = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtProfession = new TextBox();
            dataGridViewEx3SQL = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEx3SQL).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(69, 44);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 15;
            label4.Text = "ORM-подход";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(540, 573);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 14;
            btnCalculate.Text = "Вычислить";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(592, 451);
            label3.Name = "label3";
            label3.Size = new Size(617, 25);
            label3.TabIndex = 13;
            label3.Text = "Этот рабочий при выполнении этой операции никогда не допускал брак.";
            // 
            // txtQ
            // 
            txtQ.Location = new Point(418, 448);
            txtQ.Name = "txtQ";
            txtQ.Size = new Size(150, 31);
            txtQ.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 451);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 11;
            label2.Text = "и квалификацией ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 403);
            label1.Name = "label1";
            label1.Size = new Size(1072, 25);
            label1.TabIndex = 10;
            label1.Text = "Имеется операция по сборке некоторой детали с временем штучным > 10, которую должен выполнить рабочий с профессией ";
            // 
            // txtProfession
            // 
            txtProfession.Location = new Point(88, 445);
            txtProfession.Name = "txtProfession";
            txtProfession.Size = new Size(150, 31);
            txtProfession.TabIndex = 9;
            txtProfession.TextChanged += txtProfession_TextChanged;
            // 
            // dataGridViewEx3SQL
            // 
            dataGridViewEx3SQL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEx3SQL.Location = new Point(234, 86);
            dataGridViewEx3SQL.Name = "dataGridViewEx3SQL";
            dataGridViewEx3SQL.RowHeadersWidth = 62;
            dataGridViewEx3SQL.Size = new Size(796, 287);
            dataGridViewEx3SQL.TabIndex = 8;
            // 
            // Exercise3ORM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 636);
            Controls.Add(label4);
            Controls.Add(btnCalculate);
            Controls.Add(label3);
            Controls.Add(txtQ);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProfession);
            Controls.Add(dataGridViewEx3SQL);
            Name = "Exercise3ORM";
            Text = "Exercise3ORM";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEx3SQL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnCalculate;
        private Label label3;
        private TextBox txtQ;
        private Label label2;
        private Label label1;
        private TextBox txtProfession;
        private DataGridView dataGridViewEx3SQL;
    }
}