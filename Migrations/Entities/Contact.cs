namespace Entities
{
    public class Contact
    {

        public int ContactId { get; set; }

        public string AddressLine { get; set; }

        public int PersonId { get; set; }

        public Person person { get; set; }
    }
}
