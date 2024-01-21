using System;
using System.Collections.Generic;

namespace AppLicence.DataModels;

public partial class Goal
{
    public long Id { get; set; }

    public int UserId { get; set; }

    public string GoalName { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string Status { get; set; } = null!;

    public long? Percentage { get; set; }

    public string Description { get; set; } = null!;

    public long Category { get; set; }

    public string Type { get; set; } = null!;

    public short Frequency { get; set; }

    public string GoalCode { get; set; } = null!;
}
