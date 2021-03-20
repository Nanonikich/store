using System;
using System.Text.RegularExpressions;

namespace Store
{
    public class Instrument
    {
        public int Id { get; }

        public string VendorCode { get; }

        public string Manufacturer { get; }

        public string Title { get; }

        public string Description { get; }

        public decimal Price { get; }

        public Instrument(int id, string vendorCode, string manufacturer, string title, string description, decimal price)
        {
            Id = id;
            VendorCode = vendorCode;
            Manufacturer = manufacturer;
            Title = title;
            Description = description;
            Price = price;
        }

        internal static bool IsVendorCode(string s)
        {
            if (s == null)
                return false;

            s = s.Replace("-", "")
                 .Replace(" ", "")
                 .ToUpper();


            return Regex.IsMatch(s, @"^\d{8}(\d{3})?$");
        }
    }
}
