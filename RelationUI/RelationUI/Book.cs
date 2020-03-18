using System.ComponentModel.DataAnnotations.Schema;

namespace RelationUI
{
    public class Book
    {

        public int BookId { get; set; }
        
        public int Write01Id { get; set; }
        //[ForeignKey("Write01Id")]
        public Person Write01 { get; set; }


        //public int Write02Id { get; set; }

        //public Person Write02 { get; set; }


    }
}
