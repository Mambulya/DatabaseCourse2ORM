using DatabaseCourse2ORM.Models;

namespace DatabaseCourse2ORM
{
    public partial class Form1 : Form
    {
        UniServerm1Context db = new UniServerm1Context();

        public Form1()
        {
            InitializeComponent();
            dataGridViewORM.AutoGenerateColumns = true;
        }

        private void btnPN_Click(object sender, EventArgs e)
        {
            dataGridViewORM.DataSource = db.ProductionNormas.ToList();
        }

        private void btnWE_Click(object sender, EventArgs e)
        {
            dataGridViewORM.DataSource = db.WorkerExperiences.ToList();
        }

        private void btnWI_Click(object sender, EventArgs e)
        {
            dataGridViewORM.DataSource = db.WorkerInfos.ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
