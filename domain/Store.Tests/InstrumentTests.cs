using System;
using Xunit;

namespace Store.Tests
{
    public class InstrumentTests
    {
        [Fact]
        public void IsVendorCode_WithNull_ReturnFalse()
        {
            bool actual = Instrument.IsVendorCode(null);
            
            Assert.False(actual);
        }

        [Fact]
        public void IsVendorCode_WithBlankString_ReturnFalse()
        {
            bool actual = Instrument.IsVendorCode("     ");
            
            Assert.False(actual);
        }

        [Fact]
        public void IsVendorCode_WithInvalidVendorCode_ReturnFalse()
        {
            bool actual = Instrument.IsVendorCode("123 ");

            Assert.False(actual);
        }

        [Fact]
        public void IsVendorCode_WithIsVendorCode10_ReturnTrue()
        {
            bool actual = Instrument.IsVendorCode("16598508");

            Assert.True(actual);
        }

        [Fact]
        public void IsVendorCode_WithIsVendorCode13_ReturnTrue()
        {
            bool actual = Instrument.IsVendorCode("16598508912");

            Assert.True(actual);
        }

        [Fact]
        public void IsVendorCode_WithTrashStart_ReturnFalse()
        {
            bool actual = Instrument.IsVendorCode("ppp 16598508912 kk");

            Assert.False(actual);
        }

    }
}
