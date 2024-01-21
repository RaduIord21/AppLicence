using System;
using System.Collections.Generic;

namespace AppLicence.DataModels;

public partial class UserAchivement
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public long AchivementId { get; set; }
}
