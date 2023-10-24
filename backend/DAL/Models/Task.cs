using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models;

public partial class Task
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TaskId { get; set; }

    public string TaskName { get; set; } = null!;

    public string TaskDescription { get; set; } = null!;

    public string TaskPriority { get; set; } = null!;

    public string TaskAddingDate { get; set; } = null!;

    public string TaskStatus { get; set; } = null!;

    public int TaskListId { get; set; }

    public virtual TaskList TaskList { get; set; } = null!;
}
