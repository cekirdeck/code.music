namespace AdressBook.Models
{
    public class Email
    {
        public int Id { get; set;}
        public string? EmailAdress { get; set;}
        public string? Description { get; set;}
        public virtual ICollection<Person_N_Email> Person_N_Emails { get;} = new  List<Person_N_Email>();
        //public virtual Person_N_Email? Person_N_Emails { get; set; }
    }
}