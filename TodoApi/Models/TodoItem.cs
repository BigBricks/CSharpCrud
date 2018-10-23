using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public int id { get; set; }
        public string Title { get; set; }
        public bool Complete { get; set; }
    }
}
