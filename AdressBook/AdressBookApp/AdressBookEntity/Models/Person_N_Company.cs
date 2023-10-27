namespace AdressBook.Models
{
    public class Person_N_Company
    {
        public int Id { get; set;}
        public int IdPerson { get; set;}
        public int IdCompany { get; set;}
        public virtual Person? IdPersonNavigation { get; set; }
        public virtual Company? IdCompanyNavigation { get; set; }
    }
}