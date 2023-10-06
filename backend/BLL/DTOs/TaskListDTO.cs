using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TaskListDTO
    {
        public string TaskListId { get; set; }
        public string TaskListName { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
