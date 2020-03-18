using Session03.Mock.Sample;
using System;
using Moq;
using Xunit;
using Moq.Protected;

namespace Session03.MockSample.Test
{
    public class GetDiscountValueServiceTest
    {
        [Fact]
        public void When_CutomerIsTypeUsualGet1000()
        {
            Mock<ICustomerRepository> mockCutomerRepository = new Mock<ICustomerRepository>();
            mockCutomerRepository.Setup(c => c.Get(It.IsAny<int>())).Returns(new Customer {
            CustomerType=CustomerType.Usual
            }) ;
            GetDiscountValueService service = new GetDiscountValueService(mockCutomerRepository.Object);

           var result= service.Execute(1);

            Assert.Equal(1000, result);

        }



        public void When_CutomerIsTypeUsualGet1000Strict()
        {
            Mock<ICustomerRepository> mockCutomerRepository = new Mock<ICustomerRepository>(MockBehavior.Strict);

            //mockCutomerRepository.Setup(c => c.Get(It.IsAny<int>())).Returns(new Customer { CustomerType = CustomerType.Usual });


            GetDiscountValueService service = new GetDiscountValueService(mockCutomerRepository.Object);

           var result= service.Execute(1);

            Assert.Equal(1000, result);
        }



        [Fact]
        public void Output_Parametr()
        {
            Mock<ICustomerRepository> mockCutomerRepository = new Mock<ICustomerRepository>(MockBehavior.Strict);
            bool result = true;
            mockCutomerRepository.Setup(c => c.IsValidCustomer(out result));
            GetDiscountValueService service = new GetDiscountValueService(mockCutomerRepository.Object);
            service.IsValidCustomer(1);
            Assert.True(result);

        }

        [Fact]
        public void TestProperty()
        {
            Mock<ICustomerRepository> mockCutomerRepository = new Mock<ICustomerRepository>();

            mockCutomerRepository.Setup(c => c.CutomerId).Returns(1);

            GetDiscountValueService service = new GetDiscountValueService(mockCutomerRepository.Object);
            


        }


        [Fact]
        public void TestProperty2And2()
        {
            //Mock understand chain propert
            
            //Mock<IPropertHolder> mockPropertyHolder = new Mock<IPropertHolder>();

            //mockPropertyHolder.Setup(c => c.CutomerId).Returns(1);

            //Mock<IPropertyProxy> mockPropertProxcy = new Mock<IPropertyProxy>();
            //mockPropertProxcy.Setup(c => c.IProperyProxy).Returns(mockPropertyHolder.Object);

            Mock<ICustomerRepository> mockCutomerRepository = new Mock<ICustomerRepository>();
            mockCutomerRepository.Setup(c => c.IPropertProxy.IProperyProxy.CutomerId).Returns(1);

            GetDiscountValueService service = new GetDiscountValueService(mockCutomerRepository.Object);



        }


        [Fact]
        public void CheckStateMangment()
        {


            Mock<ICustomerRepository> mock = new Mock<ICustomerRepository>();
            mock.SetupProperty(c => c.UseCount);
            //mock.SetupAllProperties();
            mock.Setup(c => c.Get(It.IsAny<int>())).Returns(new Customer { CustomerType = CustomerType.Usual });

            GetDiscountValueService service = new GetDiscountValueService(mock.Object);

            var result = service.Execute(1);

            Assert.Equal(1000, result);
            Assert.Equal(1, mock.Object.UseCount);
        }

        [Fact]
        public void CheckDbEngin()
        {
            Mock<ICustomerRepository> mock = new Mock<ICustomerRepository>();
            GetDiscountValueService service = new GetDiscountValueService(mock.Object);

            var result = service.GetCustomer(1, DbEngin.Mongo);

            mock.Verify(c => c.GetFromMongoDB(It.IsAny<int>()),"My Message");


            mock.Verify(c => c.GetFromSqlServer(It.IsAny<int>()),Times.Never());

           // mock.VerifySet(c => c.IPropertProxy.IProperyProxy.CutomerId = 1);

          
        }

        [Fact]
        public void CheckException()
        {
            Mock<ICustomerRepository> mock = new Mock<ICustomerRepository>();
            mock.Setup(c => c.Get(25522552)).Throws<Exception>();

            GetDiscountValueService service = new GetDiscountValueService(mock.Object);

            //var result = service.GetCustomer(1, DbEngin.Mongo);

            //mock.Verify(c => c.GetFromMongoDB(It.IsAny<int>()), "My Message");


            //mock.Verify(c => c.GetFromSqlServer(It.IsAny<int>()), Times.Never());

            // mock.VerifySet(c => c.IPropertProxy.IProperyProxy.CutomerId = 1);


        }





        [Fact]
        public void CheckSeq()
        {
            Mock<ICustomerRepository> mock = new Mock<ICustomerRepository>();
            mock.SetupSequence(c => c.IsValidCustomer(1)).Returns(true).Returns(false);

            GetDiscountValueService service = new GetDiscountValueService(mock.Object);

        


        }



        [Fact]
        public void CheckProtected()
        {
            Mock<TestProtected> mock = new Mock<TestProtected>();

            mock.Protected().Setup("GetInt");
            




        }

    }
}
