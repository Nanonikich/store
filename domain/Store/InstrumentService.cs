using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class InstrumentService
    {
        private readonly IInstrumentRepository instrumentRepository;

        public InstrumentService(IInstrumentRepository instrumentRepository)
        {
            this.instrumentRepository = instrumentRepository;
        }

        public Instrument[] GetAllByQuery(string query)
        {
            if (Instrument.IsVendorCode(query))
                return instrumentRepository.GetAllByVendorCode(query);

            return instrumentRepository.GetAllByTitleOrManufacturer(query);
        }
    }
}
