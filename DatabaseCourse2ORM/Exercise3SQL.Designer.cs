namespace DatabaseCourse2ORM
{
    partial class Exercise3SQL
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
            dataGridViewEx3SQL = new DataGridView();
            txtProfession = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtQ = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEx3SQL).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEx3SQL
            // 
            dataGridViewEx3SQL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEx3SQL.Location = new Point(231, 87);
            dataGridViewEx3SQL.Name = "dataGridViewEx3SQL";
            dataGridViewEx3SQL.RowHeadersWidth = 62;
            dataGridViewEx3SQL.Size = new Size(796, 287);
            dataGridViewEx3SQL.TabIndex = 0;
            dataGridViewEx3SQL.CellContentClick += this.dataGridViewEx3SQL_CellContentClick;
            // 
            // txtProfession
            // 
            txtProfession.Location = new Point(105, 447);
            txtProfession.Name = "txtProfession";
            txtProfession.Size = new Size(150, 31);
            txtProfession.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 405);
            label1.Name = "label1";
            label1.Size = new Size(1072, 25);
            label1.TabIndex = 2;
            label1.Text = "Имеется операция по сборке некоторой детали с временем штучным > 10, которую должен выполнить рабочий с профессией ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 453);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 3;
            label2.Text = "и квалификацией ";
            // 
            // txtQ
            // 
            txtQ.Location = new Point(435, 450);
            txtQ.Name = "txtQ";
            txtQ.Size = new Size(150, 31);
            txtQ.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(609, 453);
            label3.Name = "label3";
            label3.Size = new Size(617, 25);
            label3.TabIndex = 5;
            label3.Text = "Этот рабочий при выполнении этой операции никогда не допускал брак.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(55, 21);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 7;
            label4.Text = "SQL-подход";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(557, 575);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Вычислить";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += this.btnCalculate_Click_1;
            // 
            // Exercise3SQL
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 744);
            Controls.Add(label4);
            Controls.Add(btnCalculate);
            Controls.Add(label3);
            Controls.Add(txtQ);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProfession);
            Controls.Add(dataGridViewEx3SQL);
            Name = "Exercise3SQL";
            Text = "Exercise3";
            Load += Exercise3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEx3SQL).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEx3SQL;
        private TextBox txtProfession;
        private Label label1;
        private Label label2;
        private TextBox txtQ;
        private Label label3;
        private Label label4;
        private Button btnCalculate;
    }
}