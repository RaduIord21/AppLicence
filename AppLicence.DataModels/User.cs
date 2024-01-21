using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppLicence.DataModels;

public partial class User
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Prenume { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool IsAdmin { get; set; }
}
