using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App.Controller
{
    class ToDoController
    {
        public string Title;
        public string Description;
        public DateTime Date;
        public string Priority;
        
        public ToDoController(string Title,string Description,DateTime Date,string priority)
        {
            this.Title = Title;
            this.Description = Description;
            this.Date =Date;
            this.Priority = priority;
        }
    }
}
