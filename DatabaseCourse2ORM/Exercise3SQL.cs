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
    public partial class Exercise3SQL : Form
    {
        UniServerm1Context db = new UniServerm1Context();
        public Exercise3SQL()
        {
            InitializeComponent();
        }

        private void Exercise3_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                int p_parametr = int.Parse(txtProfession.Text);
                int q_parametr = int.Parse(txtQ.Text);

                /*
                SELECT p.id_component, p.id_operation
                FROM production_normas p
                WHERE p.item_time > 10
                AND p.code_worker_profession = @p
                AND p.worker_quilification = @q
                AND NOT EXISTS (SELECT *
                                FROM worker_experience we
                                WHERE we.id_component = p.id_component
                                AND we.id_operation = p.id_operation
                                AND we.num_bad_components > 0);
                */
 
                var result = from p in db.ProductionNormas
                             where p.ItemTime > 10
                             && p.CodeWorkerProfession == p_parametr
                             && p.WorkerQuilification == q_parametr
                             && !db.WorkerExperiences.Any(we => we.IdComponent == p.IdComponent && we.IdOperation == p.IdOperation && we.NumBadComponents > 0)
                             select new
                             {
                                 p.IdComponent,
                                 p.IdOperation
                             };
                var data = result.ToList();
                dataGridViewEx3SQL.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите корректные данные!");
            }
        }

        private void dataGridViewEx3SQL_CellContentClick(object sender, EventArgs e)
        {

        }
    }
}
