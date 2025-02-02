namespace DatabaseCourse2ORM
{
    partial class ORM_Implementaton
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
            btnFill = new Button();
            textBoxEx1 = new TextBox();
            labelEx1 = new Label();
            dataGridViewExercise1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExercise1).BeginInit();
            SuspendLayout();
            // 
            // btnFill
            // 
            btnFill.Location = new Point(822, 429);
            btnFill.Name = "btnFill";
            btnFill.Size = new Size(112, 34);
            btnFill.TabIndex = 7;
            btnFill.Text = "Вычислить";
            btnFill.UseVisualStyleBackColor = true;
            btnFill.Click += btnFill_Click;
            // 
            // textBoxEx1
            // 
            textBoxEx1.ForeColor = SystemColors.ScrollBar;
            textBoxEx1.Location = new Point(418, 429);
            textBoxEx1.Name = "textBoxEx1";
            textBoxEx1.RightToLeft = RightToLeft.No;
            textBoxEx1.Size = new Size(243, 31);
            textBoxEx1.TabIndex = 6;
            textBoxEx1.Text = "ваш параметр";
            textBoxEx1.TextAlign = HorizontalAlignment.Center;
            textBoxEx1.TextChanged += textBoxEx1_TextChanged;
            // 
            // labelEx1
            // 
            labelEx1.AutoSize = true;
            labelEx1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelEx1.Location = new Point(69, 429);
            labelEx1.Name = "labelEx1";
            labelEx1.Size = new Size(235, 25);
            labelEx1.TabIndex = 5;
            labelEx1.Text = "Допустимый % дефекта: ";
            labelEx1.Click += labelEx1_Click;
            // 
            // dataGridViewExercise1
            // 
            dataGridViewExercise1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExercise1.Location = new Point(69, 103);
            dataGridViewExercise1.Name = "dataGridViewExercise1";
            dataGridViewExercise1.RowHeadersWidth = 62;
            dataGridViewExercise1.Size = new Size(919, 217);
            dataGridViewExercise1.TabIndex = 4;
            dataGridViewExercise1.CellContentClick += dataGridViewExercise1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(69, 36);
            label1.Name = "label1";
            label1.Size = new Size(191, 38);
            label1.TabIndex = 8;
            label1.Text = "ORM подход";
            // 
            // ORM_Implementaton
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 576);
            Controls.Add(label1);
            Controls.Add(btnFill);
            Controls.Add(textBoxEx1);
            Controls.Add(labelEx1);
            Controls.Add(dataGridViewExercise1);
            Name = "ORM_Implementaton";
            Text = "ORM_Implementaton";
            ((System.ComponentModel.ISupportInitialize)dataGridViewExercise1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFill;
        private TextBox textBoxEx1;
        private Label labelEx1;
        private DataGridView dataGridViewExercise1;
        private Label label1;
    }
}