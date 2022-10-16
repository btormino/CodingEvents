﻿using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50,MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a descripton for your event.")]
        [StringLength(500, ErrorMessage = "Description is too long!")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage ="Location information is required.")]
        public string Location { get; set; }

        [Range(0, 100000, ErrorMessage ="Number of attendees must be between 0 and 100,000")]
        public double Attendees { get; set; }

    }

}