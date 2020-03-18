using Ssseion2.XUnitTest.Model;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit;
using Xunit.Sdk;

namespace XUnitTestProject
{

    public class MyDataDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            List<object[]> data = new List<object[]>() { new object[] { true, 1 } , new object[] { false, 2 } };
         
         
            return data;
        }
    }


    public static class DataProvider
    {
        public static List<object[]> MyData()
        {
            List<object[]> data = new List<object[]>();
            data.Add(new object[] { true, 1 });

            data.Add(new object[] { false, 2 });
            return data;
        }
    }
   public class BoolTest
    {

        [Fact]
        public void shuldRetuen1()
        {
            BooleanOutPut put = new BooleanOutPut();

          var result=   put.BooleanToInt(true);

            Assert.Equal(1, result);
        }


        [Fact]
        public void shuldRetuen2()
        {
            BooleanOutPut put = new BooleanOutPut();

            var result = put.BooleanToInt(false);

            Assert.Equal(2, result);
        }

        [Theory]
        [InlineData(true,1)]
        [InlineData(false,2)]
        public void shareData(bool input,int output)
        {
            BooleanOutPut put = new BooleanOutPut();

            var result = put.BooleanToInt(input);

            Assert.Equal(output, result);
        }
        [Theory]
        [MemberData(nameof(DataProvider.MyData), MemberType =typeof(DataProvider))]
        public void ShareDatav02(bool input, int output)
        {
            BooleanOutPut put = new BooleanOutPut();

            var result = put.BooleanToInt(input);

            Assert.Equal(output, result);
        }

        [Theory]

        [MyDataData]
        public void ShareDatav03(bool input, int output)
        {
            BooleanOutPut put = new BooleanOutPut();

            var result = put.BooleanToInt(input);

            Assert.Equal(output, result);
        }
    }
}
