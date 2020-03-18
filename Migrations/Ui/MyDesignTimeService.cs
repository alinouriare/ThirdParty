using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ui
{
    public class MyDesignTimeService : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection serviceCollection)
        {
            throw new NotImplementedException();
        }
    }

  public class MyPUlizer : IPluralizer
    {

    }
}
