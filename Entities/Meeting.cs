using System;
using Calendar.Abstract;
using Calendar.Common;

namespace Calendar.Entities
{
    internal class Meeting : Event, INotification
    {
        public List<string> Guests { get; set; }

        public void GetNotification()
        {
            foreach (var guest in Guests)
                Console.WriteLine($"Inviting: {guest}");
        }
    }
}
