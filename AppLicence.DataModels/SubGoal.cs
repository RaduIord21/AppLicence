using System;
using System.Collections.Generic;

namespace AppLicence.DataModels;

public partial class SubGoal
{
    public long Id { get; set; }

    public long GoalId { get; set; }

    public long Name { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? EndDate { get; set; }

    public long Priority { get; set; }
}
