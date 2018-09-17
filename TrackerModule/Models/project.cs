using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrackerModule.Models
{
    public class project
    {
        [Key]
        public int projectId{ get; set; }
        public string projectName { get; set; }
        public virtual List <user> users { get; set; }
    }
}