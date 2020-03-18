using Ssseion2.XUnitTest.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTest.Calculator1.Collection
{
    public class FixCollection
    {

        public Calculator uot = new Calculator();

    }
    [CollectionDefinition("Ok Ok")]
    public class collection : ICollectionFixture<FixCollection>
    {

    }


}
