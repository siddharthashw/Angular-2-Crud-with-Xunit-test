using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular2Crud.Models
{
    public class Blog
    {
        /// <summary>
        /// Primary Key Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the blog
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of blog
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Date of Creation
        /// </summary>
        public DateTime Date { get; set; }
    }
}