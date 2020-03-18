using System;
using Xunit;
using Ssseion2.XUnitTest.Model;

namespace Sssesion2.XunitTest.Model.Test
{
    public class CalculatorTestG

    {
        [Fact]
        [Trait("GroupTittle", "Group1")]
        public void Shuld_Retuen3_When_Add2and1()
        {
            Calculator uot = new Calculator();

            uot.Add(1, 2);
            Assert.Equal(3, uot.Reuslt);
        }
        [Fact]
        [Trait("GroupTittle", "Group2")]
        public void shuld_Throw_Exception()
        {
            Calculator uot = new Calculator();
            //uot.men(2, 2);
            Assert.Throws<Exception>(() => uot.men(2, 2));

            //Assert.Equal(0, uot.Reuslt);
        }
    }
}
