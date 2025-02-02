using System;
using System.Collections.Generic;

namespace DatabaseCourse2ORM.Models;

public partial class WorkerExperience
{
    public int IdWorker { get; set; }

    public DateOnly FinishedWorkDate { get; set; }

    public int IdComponent { get; set; }

    public int IdOperation { get; set; }

    public int? NumGoodComponents { get; set; }

    public int? NumBadComponents { get; set; }

    public decimal? DefectProportion { get; set; }

    public virtual WorkerInfo IdWorkerNavigation { get; set; } = null!;

    public virtual ProductionNorma ProductionNorma { get; set; } = null!;
}
