namespace CodingEvents.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public int Id { get; }
        private static int nextId = 1;
        public string Location { get; set; }  
        public double Attendees { get; set; }



        public Event(string name, string description, string contactEmail, string location, double attendees) : this()
        {
            Name = name;
            Description = description;
            ContactEmail = contactEmail;
            Id = nextId;
            nextId++;
            Location = location;
            Attendees = attendees;
        }

        public Event()
        {
            Id = nextId;
            nextId++;
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
