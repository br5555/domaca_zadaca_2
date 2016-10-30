using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dz_1zadatak
{
    class TodoItem
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public bool getIsCompleted { get; set; }
        public DateTime DateCompleted { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
