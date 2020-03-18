using Ssseion2.XUnitTest.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTestProject
{
    
   public class Coll
    {

        public Calculator uot = new Calculator();

    }
    [CollectionDefinition("SED")]
    public class CollectionCal : ICollectionFixture<Coll>
    {


    }

    [Collection("SED")]
    public class UnitTest13
    {

        private readonly Calculator _calculator;

        private readonly Coll _coll;

        private readonly ITestOutputHelper _testOutputHelper;
        public UnitTest13(ITestOutputHelper testOutputHelper, Coll coll)
        {
            _testOutputHelper = testOutputHelper;
            _coll = coll;
            _calculator = coll.uot;
        }


        
        [Trait("a", "1")]
        [Fact]
        public void shuld_Retuen3_when_1and322()
        {
            _testOutputHelper.WriteLine("newwwww");
            _calculator.Add(1, 2);
            Assert.Equal(3, _calculator.Reuslt);
        }
    }
}
