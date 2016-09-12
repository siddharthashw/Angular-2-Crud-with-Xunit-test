using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular2Crud.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}