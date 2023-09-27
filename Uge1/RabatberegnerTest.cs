using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace Uge1
{
    public class RabatBeregnerTest
    {

        [Fact]
        public void En_vare_skal_ikke_give_rabat()
        {
            Rabatberegner beregner = new Rabatberegner();
            double pris = beregner.GetPrisEfterRabat(1, 100);
            Assert.Equal(100, pris);
        }

        [Fact]
        public void Femten_varer_giver_rabat()
        {
            Rabatberegner beregner = new Rabatberegner();
            double pris = beregner.GetPrisEfterRabat(15, 10);
            // Normalpris er 15 x 10 = 150
            // 2% rabat er 3
            // Forventet pris efter rabat er 147
            Assert.Equal(147.00, pris);
        }

        [Fact]
        public void Stor_ordre_giver_rabat()
        {
            Rabatberegner beregner = new Rabatberegner();
            double pris = beregner.GetPrisEfterRabat(1, 10000);
            // Normalpris er 1 x 10000
            // 3% rabat er 300
            // Forventetpris efter rabat er 9700
            Assert.Equal(9700, pris);
        }

        [Fact]
        public void Mange_varer_og_stor_ordrer_giver_stor_rabat()
        {
           Rabatberegner rabatberegner = new Rabatberegner();
            double pris = rabatberegner.GetPrisEfterRabat(15, 500);
            // 15 * 500 = 7500 kr.  
            // 7500 * 0.05 = 375 kr. i rabat
            // 7500 - 375 = 7125 kr. i pris
            Assert.Equal(7125, pris);
           
        }

    }
}
