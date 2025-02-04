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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPN_Click(object sender, EventArgs e)
        {
            dataGridViewORM.DataSource = db.ProductionNormas
                .Select(p => new
                {
                    p.IdComponent,
                    p.IdOperation,
                    p.CodeWorkerProfession,
                    p.WorkerQuilification,
                    p.TariffCodeWorker,
                    p.CompleteTime,
                    p.ItemTime
                })
                .ToList();
        }

        private void btnWE_Click(object sender, EventArgs e)
        {
            dataGridViewORM.DataSource = db.WorkerExperiences.
                Select(we => new
                {
                    we.IdWorker,
                    we.FinishedWorkDate,
                    we.IdComponent,
                    we.IdOperation,
                    we.NumGoodComponents,
                    we.NumBadComponents,
                    we.DefectProportion
                })
                .ToList();
        }

        private void btnWI_Click(object sender, EventArgs e)
        {
            dataGridViewORM.DataSource = db.WorkerInfos.
                Select(wi => new
                {
                    wi.IdWorker,
                    wi.IdFactory,
                    wi.IdDepartment,
                    wi.CodeWorkerProfession,
                    wi.WorkerQuilification,
                    wi.Married,
                    wi.Fio
                })
                .ToList();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {


            try
            {
                var quilification = int.Parse(textBoxQuilification.Text);
                dataGridViewORM.DataSource = db.ProductionNormas.Where(q => q.WorkerQuilification > quilification)
                                    .Select(p => new
                                    {
                                        p.IdComponent,
                                        p.IdOperation,
                                        p.CodeWorkerProfession,
                                        p.WorkerQuilification,
                                        p.TariffCodeWorker,
                                        p.CompleteTime,
                                        p.ItemTime
                                    }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("¬ведите корректный тип данных!");
            }
        }

        private void oRMImplementationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ORM_Implementaton f2 = new ORM_Implementaton();
            f2.ShowDialog();
        }

        private void sQLImplementationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercise1 f1 = new Exercise1();
            f1.ShowDialog();
        }

        private void exercise2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercise2 f2 = new Exercise2();
            f2.ShowDialog();
        }


        //private void sQLImplementationToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    Exercise3 f3 = new Exercise3();
        //    f3.ShowDialog();
        //}

        private void oRMImplementationToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exercise1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sQLImplementationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Exercise3SQL f3 = new Exercise3SQL();
            f3.ShowDialog();
        }

        private void oRMImplementationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Exercise3ORM f3 = new Exercise3ORM();
            f3.ShowDialog();
        }
    }
}
