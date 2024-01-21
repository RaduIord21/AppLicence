using System;
using System.Collections.Generic;

namespace AppLicence.DataModels;

public partial class UserGoal
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public long GoalId { get; set; }
}
