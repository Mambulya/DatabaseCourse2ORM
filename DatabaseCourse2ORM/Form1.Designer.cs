namespace DatabaseCourse2ORM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewORM = new DataGridView();
            btnPN = new Button();
            btnWE = new Button();
            btnWI = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewORM).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewORM
            // 
            dataGridViewORM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewORM.Location = new Point(69, 66);
            dataGridViewORM.Name = "dataGridViewORM";
            dataGridViewORM.RowHeadersWidth = 62;
            dataGridViewORM.Size = new Size(1040, 282);
            dataGridViewORM.TabIndex = 0;
            // 
            // btnPN
            // 
            btnPN.Location = new Point(121, 483);
            btnPN.Name = "btnPN";
            btnPN.Size = new Size(112, 34);
            btnPN.TabIndex = 1;
            btnPN.Text = "production_normas";
            btnPN.UseVisualStyleBackColor = true;
            btnPN.Click += btnPN_Click;
            // 
            // btnWE
            // 
            btnWE.Location = new Point(546, 483);
            btnWE.Name = "btnWE";
            btnWE.Size = new Size(112, 34);
            btnWE.TabIndex = 2;
            btnWE.Text = "worker_experience";
            btnWE.UseVisualStyleBackColor = true;
            btnWE.Click += btnWE_Click;
            // 
            // btnWI
            // 
            btnWI.Location = new Point(964, 483);
            btnWI.Name = "btnWI";
            btnWI.Size = new Size(112, 34);
            btnWI.TabIndex = 3;
            btnWI.Text = "worker_info";
            btnWI.UseVisualStyleBackColor = true;
            btnWI.Click += btnWI_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(546, 596);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 4;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 692);
            Controls.Add(btnClose);
            Controls.Add(btnWI);
            Controls.Add(btnWE);
            Controls.Add(btnPN);
            Controls.Add(dataGridViewORM);
            Name = "Form1";
            Text = "ORM";
            ((System.ComponentModel.ISupportInitialize)dataGridViewORM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewORM;
        private Button btnPN;
        private Button btnWE;
        private Button btnWI;
        private Button btnClose;
    }
}
