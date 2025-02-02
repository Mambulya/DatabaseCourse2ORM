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
    public partial class Exercise2 : Form
    {
        UniServerm1Context db = new UniServerm1Context();
        public Exercise2()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void Exercise2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var query = db.WorkerInfos.Select(wi => new {
                                        wi.Fio,
                                        wi.CodeWorkerProfession,
                                        wi.WorkerQuilification,
                                        sameProfession = db.WorkerInfos
                                                                .Count(wi2 => wi2.CodeWorkerProfession == wi.CodeWorkerProfession &&
                                                                       wi2.IdDepartment == wi.IdDepartment &&
                                                                       wi2.IdFactory == wi.IdFactory),
                                        MaxQualification = db.WorkerInfos.Where(wi2 => wi2.CodeWorkerProfession == wi.CodeWorkerProfession)
                                                            .Max(wi2 => wi2.WorkerQuilification)})
                                        .ToList();

            dataGridView1.DataSource = query;
        }

    }
}
