using System;
using System.Linq;

namespace Store.Memory
{
    public class InstrumentRepository : IInstrumentRepository
    {
        private readonly Instrument[] instruments = new[]
        {
            new Instrument(1, "Piano"),
            new Instrument(2, "Bayan"),
            new Instrument(3, "GGGGG"),
        };


        public Instrument[] GetAllByTitle(string titlePart)
        {
            return instruments.Where(instrument => instrument.Title.Contains(titlePart))
                              .ToArray();
        }
    }
}
