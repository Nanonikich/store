using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Store.Tests
{
    public class InstrumentServiceTests
    {
        [Fact]
        public void GetAllByQuery_WithVendorCode_CallsGetAllByVendorCode()
        {
            var instrumentRepositoryStub = new Mock<IInstrumentRepository>();
            instrumentRepositoryStub.Setup(x => x.GetAllByVendorCode(It.IsAny<string>()))
                                    .Returns(new[] { new Instrument(1, "", "", "") });
            instrumentRepositoryStub.Setup(x => x.GetAllByTitleOrManufacturer(It.IsAny<string>()))
                                    .Returns(new[] { new Instrument(2, "", "", "") });

            var instrumentService = new InstrumentService(instrumentRepositoryStub.Object);
            var validVendorCode = "96532147";
            var actual = instrumentService.GetAllByQuery(validVendorCode);

            Assert.Collection(actual, instrument => Assert.Equal(1, instrument.Id));
        }

        [Fact]
        public void GetAllByQuery_WithManufacturer_CallsGetAllByTitleOrManufacturer()
        {
            var instrumentRepositoryStub = new Mock<IInstrumentRepository>();
            instrumentRepositoryStub.Setup(x => x.GetAllByVendorCode(It.IsAny<string>()))
                                    .Returns(new[] { new Instrument(1, "", "", "") });

            instrumentRepositoryStub.Setup(x => x.GetAllByTitleOrManufacturer(It.IsAny<string>()))
                                    .Returns(new[] { new Instrument(2, "", "", "") });

            var instrumentService = new InstrumentService(instrumentRepositoryStub.Object);
            
            var invalidVendorCode = "123456789";
            
            var actual = instrumentService.GetAllByQuery(invalidVendorCode);

            Assert.Collection(actual, instrument => Assert.Equal(2, instrument.Id));
        }
    }
}
