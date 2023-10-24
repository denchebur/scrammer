using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public partial class User
{   
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserId { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string UserRole { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public virtual ICollection<Board> Boards { get; set; } = new List<Board>();
}
