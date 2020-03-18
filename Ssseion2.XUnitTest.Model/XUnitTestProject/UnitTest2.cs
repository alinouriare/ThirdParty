using Ssseion2.XUnitTest.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTestProject
{
    [Collection("SED")]
    public class UnitTest2
    {

        private readonly Calculator _calculator;

        private readonly Coll _coll;

        private readonly ITestOutputHelper _testOutputHelper;
        public UnitTest2(ITestOutputHelper testOutputHelper, Coll coll)
        {
            _testOutputHelper = testOutputHelper;
            _coll = coll;
            _calculator = coll.uot;
        }
        [Fact]
        [Trait("a", "2")]
        public void shuld_Retuen3_when_1and3()
        {
            _testOutputHelper.WriteLine("newwwww");
            _calculator.Add(1, 2);
            Assert.Equal(3, _calculator.Reuslt);
        }
    }
}
