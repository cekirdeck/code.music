namespace AdressBook.Models
{
    public class Person_N_Phone
    { 
        public int Id { get; set;}
        public int IdPerson { get; set;}
        public int IdPhone { get; set;}
        public virtual Person? IdPersonNavigation { get; set; }
        public virtual Phone? IdPhoneNavigation { get; set; }
    }
}