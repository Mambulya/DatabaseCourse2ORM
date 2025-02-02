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
            btnFill = new Button();
            lblQuilification = new Label();
            textBoxQuilification = new TextBox();
            menuStrip1 = new MenuStrip();
            exercise1ToolStripMenuItem = new ToolStripMenuItem();
            sQLImplementationToolStripMenuItem = new ToolStripMenuItem();
            oRMImplementationToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewORM).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewORM
            // 
            dataGridViewORM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewORM.Location = new Point(47, 69);
            dataGridViewORM.Name = "dataGridViewORM";
            dataGridViewORM.RowHeadersWidth = 62;
            dataGridViewORM.Size = new Size(1094, 226);
            dataGridViewORM.TabIndex = 0;
            // 
            // btnPN
            // 
            btnPN.Location = new Point(47, 349);
            btnPN.Name = "btnPN";
            btnPN.Size = new Size(112, 34);
            btnPN.TabIndex = 1;
            btnPN.Text = "production_normas";
            btnPN.UseVisualStyleBackColor = true;
            btnPN.Click += btnPN_Click;
            // 
            // btnWE
            // 
            btnWE.Location = new Point(541, 349);
            btnWE.Name = "btnWE";
            btnWE.Size = new Size(112, 34);
            btnWE.TabIndex = 2;
            btnWE.Text = "worker_experience";
            btnWE.UseVisualStyleBackColor = true;
            btnWE.Click += btnWE_Click;
            // 
            // btnWI
            // 
            btnWI.Location = new Point(1029, 349);
            btnWI.Name = "btnWI";
            btnWI.Size = new Size(112, 34);
            btnWI.TabIndex = 3;
            btnWI.Text = "worker_info";
            btnWI.UseVisualStyleBackColor = true;
            btnWI.Click += btnWI_Click;
            // 
            // btnFill
            // 
            btnFill.ForeColor = Color.DarkGoldenrod;
            btnFill.Location = new Point(598, 504);
            btnFill.Name = "btnFill";
            btnFill.Size = new Size(112, 34);
            btnFill.TabIndex = 4;
            btnFill.Text = "Вычислить";
            btnFill.UseVisualStyleBackColor = true;
            btnFill.Click += btnFill_Click;
            // 
            // lblQuilification
            // 
            lblQuilification.AutoSize = true;
            lblQuilification.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblQuilification.Location = new Point(69, 509);
            lblQuilification.Name = "lblQuilification";
            lblQuilification.Size = new Size(260, 25);
            lblQuilification.TabIndex = 5;
            lblQuilification.Text = "Квалификация сотрудника: ";
            // 
            // textBoxQuilification
            // 
            textBoxQuilification.Location = new Point(346, 509);
            textBoxQuilification.Name = "textBoxQuilification";
            textBoxQuilification.Size = new Size(194, 31);
            textBoxQuilification.TabIndex = 6;
            textBoxQuilification.Text = "0";
            textBoxQuilification.TextAlign = HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exercise1ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1200, 33);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // exercise1ToolStripMenuItem
            // 
            exercise1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sQLImplementationToolStripMenuItem, oRMImplementationToolStripMenuItem });
            exercise1ToolStripMenuItem.Name = "exercise1ToolStripMenuItem";
            exercise1ToolStripMenuItem.Size = new Size(99, 29);
            exercise1ToolStripMenuItem.Text = "Exercise1";
            // 
            // sQLImplementationToolStripMenuItem
            // 
            sQLImplementationToolStripMenuItem.Name = "sQLImplementationToolStripMenuItem";
            sQLImplementationToolStripMenuItem.Size = new Size(281, 34);
            sQLImplementationToolStripMenuItem.Text = "SQLImplementation";
            sQLImplementationToolStripMenuItem.Click += sQLImplementationToolStripMenuItem_Click;
            // 
            // oRMImplementationToolStripMenuItem
            // 
            oRMImplementationToolStripMenuItem.Name = "oRMImplementationToolStripMenuItem";
            oRMImplementationToolStripMenuItem.Size = new Size(281, 34);
            oRMImplementationToolStripMenuItem.Text = "ORMImplementation";
            oRMImplementationToolStripMenuItem.Click += oRMImplementationToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 692);
            Controls.Add(textBoxQuilification);
            Controls.Add(lblQuilification);
            Controls.Add(btnFill);
            Controls.Add(btnWI);
            Controls.Add(btnWE);
            Controls.Add(btnPN);
            Controls.Add(dataGridViewORM);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "ORM";
            ((System.ComponentModel.ISupportInitialize)dataGridViewORM).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewORM;
        private Button btnPN;
        private Button btnWE;
        private Button btnWI;
        private Button btnFill;
        private Label lblQuilification;
        private TextBox textBoxQuilification;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exercise1ToolStripMenuItem;
        private ToolStripMenuItem sQLImplementationToolStripMenuItem;
        private ToolStripMenuItem oRMImplementationToolStripMenuItem;
    }
}
