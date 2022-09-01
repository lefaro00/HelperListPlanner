using System.ComponentModel.DataAnnotations;
using BackendLogic.Data.Entities;

namespace HelperListPlanner.Models
{
    public class CreateEventModel
    {
        [Required]
        [StringLength(64, ErrorMessage = "Name is too long.")]
        public string EventName{ get; set; }

        [Required]
        public BackendLogic.Data.Entities.Host EventHost { get; set; }

        [Required]
        public string Description { get; set; } = String.Empty;

        [Required]
        public DateTime StartTime { get; set; } = DateTime.Now;

        [Required]       
        public DateTime EndTime { get; set; } = new DateTime();

        [Required]
        public List<Shift> Shifts { get; set; } = new List<Shift>();

        [Required]
        public Location Location { get; set; }
    }
}
