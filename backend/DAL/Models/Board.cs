using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public partial class Board
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BoardId { get; set; }

    public string BoardName { get; set; } = null!;

    public int UserId { get; set; }

    public virtual ICollection<TaskList> TaskLists { get; set; } = new List<TaskList>();

    public virtual User User { get; set; } = null!;
}
