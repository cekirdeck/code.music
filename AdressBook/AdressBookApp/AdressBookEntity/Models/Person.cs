namespace AdressBook.Models
{
    public partial class Person
    {
        public int Id { get; set;}
        public string? Name { get; set;}
        public string? SurName { get; set;}
        public virtual ICollection<Person_N_Company> Person_N_Companies { get; } = new List<Person_N_Company>();
        public virtual ICollection<Person_N_Email> Person_N_Emails { get; } = new List<Person_N_Email>();
        public virtual ICollection<Person_N_Location> Person_N_Locations { get; } = new List<Person_N_Location>();
        public virtual ICollection<Person_N_Phone> Person_N_Phones { get; } = new List<Person_N_Phone>();
    }
}