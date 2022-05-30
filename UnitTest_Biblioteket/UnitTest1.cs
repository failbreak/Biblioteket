using System;
using Xunit;
using Bibliotek;
namespace UnitTest_Biblioteket
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string test = "test";
            Bibliotek.Bibliotek bibliotek = new(test);

            bibliotek.OpretLaaner(test);
            bibliotek.HentAlleLaanere();
            bibliotek.HentBibliotek();

            Assert.Equal(bibliotek.Laanere[0].Navn, test);
        }
    }
}
