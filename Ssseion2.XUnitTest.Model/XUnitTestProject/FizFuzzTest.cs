using System;
using System.Collections.Generic;
using Ssseion2.XUnitTest.Model;
using System.Text;
using Xunit;

namespace XUnitTestProject
{
    public class FizFuzzTest
    {
        [Fact]
        public void Return1()
        {

            var fizFuzz = new FizFuzz();
            String result = fizFuzz.excute(1);
            Assert.Equal("1", result);
        }
        [Fact]
        public void Return12()
        {

            var fizFuzz = new FizFuzz();
            String result = fizFuzz.excute(2);
            Assert.Equal("1,2", result);

        }

         [Fact]
        public void Return123()
        {

            var fizFuzz = new FizFuzz();
            String result = fizFuzz.excute(3);
            Assert.Equal("1,2,fizz", result);
        }

        [Fact]
        public void Return4()
        {

            var fizFuzz = new FizFuzz();
            String result = fizFuzz.excute(4);
            Assert.Equal("1,2,fizz,4", result);
        }
       [Fact]
        public void Return5()
        {

            var fizFuzz = new FizFuzz();
            String result = fizFuzz.excute(5);
            Assert.Equal("1,2,fizz,4,fuzz", result);
        }

        [Fact]
        public void Return6()
        {

            var fizFuzz = new FizFuzz();
            String result = fizFuzz.excute(6);
            Assert.Equal("1,2,fizz,4,fuzz,fizz", result);
        }


        [Fact]
        public void Return10()
        {

            var fizFuzz = new FizFuzz();
            String result = fizFuzz.excute(10);
            Assert.Equal("1,2,fizz,4,fuzz,fizz,7,8,fizz,fuzz", result);
        }


        [Fact]
        public void Return15()
        {

            var fizFuzz = new FizFuzz();
            String result = fizFuzz.excute(15);
            Assert.Equal("1,2,fizz,4,fuzz,fizz,7,8,fizz,fuzz,11,fizz,13,14,fizzfuzz", result);
        }


        [Fact]
        public void Return30()
        {

            var fizFuzz = new FizFuzz();
            String result = fizFuzz.excute(30z);
            Assert.Equal("1,2,fizz,4,fuzz,fizz,7,8,fizz,fuzz,11,fizz,13,14,fizzfuzz," +
                "16,17,fizz,19,fuzz,fizz,22,23,fizz,fuzz,26,fizz,28,29,fizzfuzz", result);
        }
    }
}
