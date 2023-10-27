namespace AdressBook.Models
{
    public class Person_N_Location
    {
        public int Id { get; set;}
        public int IdPerson { get; set;}
        public int IdLocation { get; set;}
        public virtual Person? IdPersonNavigation { get; set; }
        public virtual Location? IdLocationNavigation { get; set; }
    }
}