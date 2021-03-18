using System;

namespace Store
{
    public class Instrument
    {
        public int Id { get; }

        public string VendorCode { get; }

        public string Manufacturer { get; }

        public string Title { get; }

        public Instrument(int id, string vendorCode, string manufacturer, string title)
        {
            Id = id;
            VendorCode = vendorCode;
            Manufacturer = manufacturer;
            Title = title;
        }


    }
}
