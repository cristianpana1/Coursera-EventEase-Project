using System.ComponentModel.DataAnnotations;

namespace BlazorProject.Models
{
    public class Event
    {
        [Required]
        public string EventName { get; set; } = "";

        [Required]
        public string EventDate { get; set; } = "";

        [Required]
        public string Location { get; set; } = "";
    }
}