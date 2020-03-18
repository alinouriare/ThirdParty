using System;
using System.Collections.Generic;
using System.Text;

namespace Session03.Mock.Sample
{
    public class TestProtected
    {

        protected virtual int GetInt()
        {
            return 1;
        }
    }

    public interface IPropertHolder
    {
        int CutomerId { get; set; }

    }

    public interface IPropertyProxy
    {
        IPropertHolder IProperyProxy { get; set; }

    }

  public  interface ICustomerRepository
    {

        Customer Get(int id);

        Customer GetFromMongoDB(int id);

        Customer GetFromSqlServer(int id);
        void IsValidCustomer(out bool result);

        bool IsValidCustomer(int id);
        int CutomerId { get; set; }

        IPropertyProxy IPropertProxy { get; set; }


        int UseCount { get; set; }
    }
}
