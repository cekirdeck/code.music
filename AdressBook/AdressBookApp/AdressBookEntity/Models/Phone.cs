namespace AdressBook.Models
{
    public class Phone
    {
        public int Id { get; set;}
        public string? PhoneNumber { get; set;}
        public string? Description { get; set;}
        public virtual ICollection<Person_N_Phone> Person_N_Phones { get;} = new  List<Person_N_Phone>();  
    }
}