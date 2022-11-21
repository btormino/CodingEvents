namespace CodingEvents.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public int Id { get; set; }

        public string Location { get; set; }
        public int Attendees { get; set; }
        public EventCategory Category { get; set; }
        public int CategoryId { get; set; }


        public Event(string name, string description, string contactEmail, string location, int attendees)
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
            Location = location;
            Attendees = attendees;
        }

        public Event()

        {
        }


        public override string ToString()
        {
            return Name;
        }


        public override bool Equals(object obj)

        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
