using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCourse2ORM.Models
{
    internal class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Finished { get; set; }
    }

}
