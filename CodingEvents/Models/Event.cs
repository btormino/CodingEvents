namespace CodingEvents.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public int Id { get; set; }

        public string Location { get; set; }
        public double Attendees { get; set; }
        public EventCategory Category { get; set; }
        public int CategoryId { get; set; } 


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Event()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }


        public Event(string name, string description, string contactEmail, string location, double attendees)
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
            Location = location;
            Attendees = attendees;
        }


        public override string ToString()
        {
            return Name;
        }

#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override bool Equals(object obj)
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
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
