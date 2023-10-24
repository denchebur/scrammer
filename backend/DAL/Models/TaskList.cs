using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public partial class TaskList
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TaskListId { get; set; }

    public string TaskListName { get; set; } = null!;

    public int BoardId { get; set; }

    public virtual Board Board { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
