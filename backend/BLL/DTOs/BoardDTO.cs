using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class BoardDTO
    {
        public string BoardId { get; set; }
        public string BoardName { get; set; }
        public List<TaskList> taskLists { get; set; }
    }
}
