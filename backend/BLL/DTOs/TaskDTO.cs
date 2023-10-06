using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    internal class TaskDTO
    {
        public string TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string TaskPriority { get; set; }
        public string DateTime { get; set; }
        public string TaskStatus { get; set; }
    }
}
