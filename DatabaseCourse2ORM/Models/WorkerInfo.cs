using System;
using System.Collections.Generic;

namespace DatabaseCourse2ORM.Models;

public partial class WorkerInfo
{
    public int IdWorker { get; set; }

    public int IdFactory { get; set; }

    public int IdDepartment { get; set; }

    public int CodeWorkerProfession { get; set; }

    public string? WorkerQuilification { get; set; }

    public string? Married { get; set; }

    public string Fio { get; set; } = null!;

    public virtual WorkerExperience? WorkerExperience { get; set; }
}
