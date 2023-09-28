using System;
using Calendar.Abstract;
using Calendar.Common;

namespace Calendar.Entities
{
    internal class ToDo : Event, INotification
    {
        public string Importance { get; set; }

        public void GetNotification()
        {
            Console.WriteLine($"Time to make this To-Do: {Title}");
        }
    }
}