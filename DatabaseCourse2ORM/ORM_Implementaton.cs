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
            dataGridViewExercise1.AutoGenerateColumns = true;
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
                List<MergedTableEx1> result = new List<MergedTableEx1>();

                var WEs = db.WorkerExperiences.ToList();
                var WIs = db.WorkerInfos.ToList();

                foreach (var exp in WEs)
                {
                    if (normal_defect >= exp.DefectProportion)
                    {
                        foreach (var inf in WIs)
                        {
                            if (inf.IdWorker == exp.IdWorker)
                            {
                                MergedTableEx1 m = new MergedTableEx1();
                                m.IdFactory = inf.IdFactory;
                                m.DefectProportion = exp.DefectProportion;
                                m.IdDepartment = inf.IdDepartment;
                                m.Fio = inf.Fio;
                                m.FinishedWorkDate = exp.FinishedWorkDate;
                                m.NumBadComponents = exp.NumBadComponents;
                                result.Add(m);
                            }
                        }
                    }
                }
                dataGridViewExercise1.DataSource = result;  

            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите другой тип данных");
            }
        }
    }
}
