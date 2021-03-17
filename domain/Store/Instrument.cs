using System;

namespace Store
{
    public class Instrument
    {
        public int Id { get; }

        public string Title { get; }

        public Instrument(int id, string title)
        {
            Id = id;
            Title = title;
        }


    }
}
