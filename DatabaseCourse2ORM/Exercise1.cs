using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseCourse2ORM.Models;

namespace DatabaseCourse2ORM
{
    public partial class Exercise1 : Form
    {
        UniServerm1Context db = new UniServerm1Context();
        public Exercise1()
        {
            InitializeComponent();
            dataGridViewExercise1.AutoGenerateColumns = true;
        }

        private void Exercise1_Load(object sender, EventArgs e)
        {

        }

        private void labelEx1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFill_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewExercise1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
