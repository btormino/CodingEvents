using System.ComponentModel.DataAnnotations;

namespace CodingEvents.Models
{
    public class Tag
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]

        [StringLength(50, MinimumLength = 3, ErrorMessage ="Name must be betwenn 3 and 50 characters.")]
        public string Name { get; set; }


        public Tag(string name, string description)
        {
            Name = name;
        }

        public Tag() { }

    }
}
