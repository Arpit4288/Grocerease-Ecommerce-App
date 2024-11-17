using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment.Models
{
    public class BookReadingEventModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required(ErrorMessage ="Date time is required!!!")]
        public DateTime Date { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int StartTime { get; set; }
        public string Type { get; set; } = "public";
        [Range(0, 4)]
        public int? Duration { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        [MaxLength(500)]
        public string OtherDetails { get; set; }
        public string InviteByEmail { get; set; }
        public string CreatedBy { get; set; }
    }
}
