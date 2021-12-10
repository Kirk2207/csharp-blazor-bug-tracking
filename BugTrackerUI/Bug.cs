namespace BugTrackerUI {
    using System.ComponentModel.DataAnnotations;

    public class Bug {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [MinLength(10)]
        public string Description { get; set; }

        [Required]
        [Range(1, 5)]
        public string Priority { get; set; }
    }
}