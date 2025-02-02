namespace DatabaseCourse2ORM
{
    partial class Exercise1
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
            dataGridViewExercise1 = new DataGridView();
            labelEx1 = new Label();
            textBoxEx1 = new TextBox();
            btnFill = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExercise1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewExercise1
            // 
            dataGridViewExercise1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExercise1.Location = new Point(79, 58);
            dataGridViewExercise1.Name = "dataGridViewExercise1";
            dataGridViewExercise1.RowHeadersWidth = 62;
            dataGridViewExercise1.Size = new Size(919, 217);
            dataGridViewExercise1.TabIndex = 0;
            dataGridViewExercise1.CellContentClick += dataGridViewExercise1_CellContentClick;
            // 
            // labelEx1
            // 
            labelEx1.AutoSize = true;
            labelEx1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelEx1.Location = new Point(79, 409);
            labelEx1.Name = "labelEx1";
            labelEx1.Size = new Size(235, 25);
            labelEx1.TabIndex = 1;
            labelEx1.Text = "Допустимый % дефекта: ";
            labelEx1.Click += labelEx1_Click;
            // 
            // textBoxEx1
            // 
            textBoxEx1.ForeColor = SystemColors.ScrollBar;
            textBoxEx1.Location = new Point(320, 407);
            textBoxEx1.Name = "textBoxEx1";
            textBoxEx1.RightToLeft = RightToLeft.No;
            textBoxEx1.Size = new Size(243, 31);
            textBoxEx1.TabIndex = 2;
            textBoxEx1.Text = "ваш параметр";
            textBoxEx1.TextAlign = HorizontalAlignment.Center;
            textBoxEx1.TextChanged += textBoxEx1_TextChanged;
            // 
            // btnFill
            // 
            btnFill.Location = new Point(593, 407);
            btnFill.Name = "btnFill";
            btnFill.Size = new Size(112, 34);
            btnFill.TabIndex = 3;
            btnFill.Text = "Вычислить";
            btnFill.UseVisualStyleBackColor = true;
            btnFill.Click += btnFill_Click;
            // 
            // Exercise1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 612);
            Controls.Add(btnFill);
            Controls.Add(textBoxEx1);
            Controls.Add(labelEx1);
            Controls.Add(dataGridViewExercise1);
            Name = "Exercise1";
            Text = "Exercise1";
            Load += Exercise1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewExercise1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewExercise1;
        private Label labelEx1;
        private TextBox textBoxEx1;
        private Button btnFill;
    }
}