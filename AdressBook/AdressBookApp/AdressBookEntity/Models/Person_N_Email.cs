namespace AdressBook.Models
{
    public class Person_N_Email
    {
        public int Id { get; set;}
        public int IdPerson { get; set;}
        public int IdEmail { get; set;}
        public virtual Person? IdPersonNavigation { get; set; }
        public virtual Email? IdEmailNavigation { get; set; }
    }
}