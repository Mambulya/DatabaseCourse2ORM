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
    public partial class Exercise3ORM : Form
    {
        UniServerm1Context db = new UniServerm1Context();
        public Exercise3ORM()
        {
            InitializeComponent();
            dataGridViewEx3SQL.AutoGenerateColumns = true;
        }

        private void txtProfession_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
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

                List<Ex3ORM> result = new List<Ex3ORM>();
                var normas = db.ProductionNormas.ToList();
                var exps = db.WorkerExperiences.ToList();
                var infos = db.WorkerInfos.ToList();

                foreach (var p in normas)
                {
                    if (p.ItemTime > 10 && p.CodeWorkerProfession == p_parametr && p.WorkerQuilification == q_parametr) {
                        bool aWE = true;
                        foreach (var ex in exps)
                        {
                            if (ex.IdComponent == p.IdComponent && ex.IdOperation == p.IdOperation && ex.NumBadComponents == 0)
                            {   
                                Ex3ORM m = new Ex3ORM();
                                m.id_operation = p.IdOperation;
                                m.id_component = p.IdComponent; 
                                result.Add(m);
                            }
                        }
                    }
                }
                dataGridViewEx3SQL.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите корректные данные!");
            }
        }
    }
}
