using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        
        [Required]
        public string Comment { get; set; }

        public DateTime PostedDate { get; set; }

        public int EventId { get; set; }

        public string CommentedBy { get; set; }


    }
}
