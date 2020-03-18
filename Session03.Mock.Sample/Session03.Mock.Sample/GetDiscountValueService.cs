using System;
using System.Collections.Generic;
using System.Text;

namespace Session03.Mock.Sample
{
    
    public enum DbEngin
    {
        Mongo,
        Sql
    }
   public class GetDiscountValueService
    {
        private readonly ICustomerRepository _customerRepository;
        public GetDiscountValueService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public int Execute(int cutomerId)
        {

            var cutomer = _customerRepository.Get(cutomerId);
            _customerRepository.UseCount = +1;
            switch (cutomer.CustomerType)
            {
                case CustomerType.Usual:
                    return 1000;
                case CustomerType.Silver:
                    return 2000;

                case CustomerType.Gold:
                    return 10000;
          
            }
            return 0;
        }

        public Customer GetCustomer(int customerId, DbEngin dbEngin)
        {
            Customer customer = new Customer();
            switch (dbEngin)
            {
                case DbEngin.Mongo:
                    customer = _customerRepository.GetFromMongoDB(customerId);
                    break;
                case DbEngin.Sql:
                    customer = _customerRepository.GetFromSqlServer(customerId);
                    break;
                default:
                    break;
            }
            return customer;
        }

       public bool IsValidCustomer(int customerId)
        {
            _customerRepository.IsValidCustomer(out bool temp);
            return temp;
        }
    }
}
