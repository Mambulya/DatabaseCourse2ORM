using System;
using System.Collections.Generic;

namespace DatabaseCourse2ORM.Models;

public partial class ProductionNorma
{
    public int IdComponent { get; set; }

    public int IdOperation { get; set; }

    public int CodeWorkerProfession { get; set; }

    public int WorkerQuilification { get; set; }

    public int TariffCodeWorker { get; set; }

    public decimal? CompleteTime { get; set; }

    public decimal? ItemTime { get; set; }

    public virtual ICollection<WorkerExperience> WorkerExperiences { get; set; } = new List<WorkerExperience>();
}
