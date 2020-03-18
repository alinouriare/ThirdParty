using System;
using Xunit;
using Sssesion2.XunitTest.Model;
using Ssseion2.XUnitTest.Model;
using Xunit.Abstractions;

namespace Sssesion2.XunitTest.Model.Test
{
    public class calFix
    {
        public Calculator uot = new Calculator();

    }

    [CollectionDefinition("Free Name")]
    public class CalculatorCollection : ICollectionFixture<calFix>
    {



    }





    [Collection("Free Name")]
    public class CalculatorTest/*:IClassFixture<calFix>*/

    {

       
        private readonly ITestOutputHelper _outputHelper;

        private readonly calFix calFix;
        private Calculator uot;
        public CalculatorTest(ITestOutputHelper outputHelper, calFix calFix)
        {
            _outputHelper = outputHelper;
            uot = calFix.uot;
        }
        //[Fact(Skip ="دلیل اسکیپ")]
        [Fact]
        [Trait("GroupTittle", "Group1")]
        public void Shuld_Retuen3_When_Add2and1()
        {
            _outputHelper.WriteLine(DateTime.Now.ToString());

            uot.Add(1, 2);
            _outputHelper.WriteLine("Outputeee");
            Assert.Equal(3, uot.Reuslt);
        }
        [Fact]
        [Trait("GroupTittle", "Group2")]
        public void shuld_Throw_Exception()
        {
            _outputHelper.WriteLine(DateTime.Now.ToString());
            //uot.men(2, 2);
            Assert.Throws<Exception>(() => uot.men(2, 2));

            //Assert.Equal(0, uot.Reuslt);
        }
    }
}
