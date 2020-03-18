using Ssseion2.XUnitTest.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Sssesion2.XunitTest.Model.Test
{
   public class newTest
    {


        public class FixTest
        {
            public Calculator calculator = new Calculator();
        }

        [CollectionDefinition("Name")]
        public class ICollectionCal : ICollectionFixture<FixTest>
        {

        }


        [Collection("Name")]
        public class Test/*: IClassFixture<FixTest>*/
        {

            private readonly Calculator _calculator;
            private readonly FixTest _fixTest;
            private readonly ITestOutputHelper _testOutputHelper;
            public Test(FixTest fixTest,ITestOutputHelper testOutputHelper)
            {
                _fixTest = fixTest;
                _calculator = fixTest.calculator;

                _testOutputHelper = testOutputHelper;
            }

            [Fact]
            [Trait("Title","New")]
            public void shuld_return3_when_add2NDD()
            {

                _calculator.Add(1, 2);
                _testOutputHelper.WriteLine("TEXT");
                Assert.Equal(3, _calculator.Reuslt);
            }
        }
    }
}
