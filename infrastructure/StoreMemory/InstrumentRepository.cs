using System;
using System.Linq;

namespace Store.Memory
{
    public class InstrumentRepository : IInstrumentRepository
    {
        private readonly Instrument[] instruments = new[]
        {
            new Instrument(1, "99931840", "Veston", "Veston D-45 SP/BKS", "Акустическая гитара Veston D-45 SP/BKS имеет полноразмерный корпус формы Дредноут, придающий гитаре сильный насыщенный звук. Сходные по цене недорогие гитары Veston F-38, представленные в трех цветах - натуральном. черном и Sunburst. Они имеют корпус чуть меньшего размера, это так называемые фолк - гитары. Эти инструменты также можно расссмотреть как гитару для начинающих.\n Veston D-45 SP/BKS – полноценная акустическая гитара с металлическими струнами.", 5700m),
            new Instrument(2, "99923489", "Veston", "Veston F-38/BK", "Акустическая гитара в корпусе фолк отличного качества, доступная по демократичной цене. Такая гитара будет отличным выбором для начинающих музыкантов и обучающихся игре на инструменте.", 6400m),
            new Instrument(3, "99923491", "Veston", "Veston F-38/SB", "Акустическая гитара в корпусе фолк отличного качества, доступная по демократичной цене. Такая гитара будет отличным выбором для начинающих музыкантов и обучающихся игре на инструменте.", 6150m),
        };


        public Instrument[] GetAllByTitleOrManufacturer(string query)
        {
            return instruments.Where(instrument => instrument.Manufacturer.Contains(query) 
                                                || instrument.Title.Contains(query))
                              .ToArray();
        }

        public Instrument[] GetAllByVendorCode(string vendorCode)
        {
            return instruments.Where(instrument => instrument.VendorCode == vendorCode)
                              .ToArray();
        }

        public Instrument GetById(int id)
        {
            return instruments.Single(instrument => instrument.Id == id);
        }
    }
}
