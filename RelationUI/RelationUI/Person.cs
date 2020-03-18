using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelationUI
{

    public class Address
    {

        public string Addresss { get; set; }
    }
    public class Person
    {
        public Address  Address { get; set; }
        public int Id { get; set; }

        //[InverseProperty("Write01")]
        public List<Book> AsWrite01 { get; set; }



    }

    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasOne(c => c.Address).WithOne().IsRequired();

            builder.HasMany(c => c.AsWrite01).WithOne();
            
            throw new System.NotImplementedException();
        }
    }
}
