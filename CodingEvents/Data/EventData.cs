﻿using CodingEvents.Models;

namespace CodingEvents.Data
{
    public class EventData
    {
        // store events
        private static Dictionary<int, Event> Events = new Dictionary<int, Event>();

        // retrieve the events
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        // add events
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }

        // remove events
        public static void Remove(int Id)
        {
            Events.Remove(Id);
        }
        // retrieve a single event
        public static Event GetById(int Id)
        {
            return Events[Id];
        }

    
    }
}
