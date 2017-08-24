using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace sidekick.Models.Request
{
    public class ToDoRequest
    {
        public int Id { get; set; }
        [Required]
        public string Task { get; set; }
        [Required]
        public string Priority { get; set; }
        public bool Deleted { get; set; }
    }
}