using System;
using System.Linq;

namespace Store.Memory
{
    public class InstrumentRepository : IInstrumentRepository
    {
        private readonly Instrument[] instruments = new[]
        {
            new Instrument(1, "99931840", "Veston", "Veston D-45 SP/BKS"),
            new Instrument(2, "99923489", "Veston", "Veston F-38/BK"),
            new Instrument(3, "99923490", "Veston", "Veston F-38/NT"),
        };


        public Instrument[] GetAllByTitle(string titlePart)
        {
            return instruments.Where(instrument => instrument.Title.Contains(titlePart))
                              .ToArray();
        }
    }
}
