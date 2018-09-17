using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackerModule.Models
{
    public class user
    {
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public int projectNumber { get; set; }
        public virtual List< project> project { get; set; }
    }
}