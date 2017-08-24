using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sidekick.Models.Domain
{
    public class toDo
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public string Priority { get; set; }
        public DateTime Created { get; set; }
        public bool Deleted { get; set; }
    }
}