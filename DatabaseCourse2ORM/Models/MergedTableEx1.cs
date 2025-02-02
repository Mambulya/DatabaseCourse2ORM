using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCourse2ORM.Models
{
    public class MergedTableEx1
    {
        public int IdFactory { get; set; }
        public decimal DefectProportion { get; set; }
        public int IdWorker { get; set; }

        public int IdDepartment { get; set; }

        public string Fio { get; set; } = null!;

        public DateOnly FinishedWorkDate { get; set; }

        public int? NumBadComponents { get; set; }
    }
}
