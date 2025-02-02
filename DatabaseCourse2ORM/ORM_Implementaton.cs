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
    public partial class ORM_Implementaton : Form
    {
        UniServerm1Context db = new UniServerm1Context();
        public ORM_Implementaton()
        {
            InitializeComponent();
        }

        private void dataGridViewExercise1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            try
            {
                decimal normal_defect = decimal.Parse(textBoxEx1.Text);
                var result = from we in db.WorkerExperiences
                             join wi in db.WorkerInfos on we.IdWorker equals wi.IdWorker
                             where we.DefectProportion <= normal_defect
                             select new
                             {
                                 we.DefectProportion,
                                 wi.IdFactory,
                                 wi.IdDepartment,
                                 wi.Fio,
                                 we.FinishedWorkDate,
                                 we.NumBadComponents
                             };

                var data = result.ToList();
                dataGridViewExercise1.DataSource = data;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите другой тип данных");
            }
        }
    }
}
