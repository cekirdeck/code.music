namespace AdressBook.Models
{
    public partial class Company
    {
        public int Id { get; set;}
        public string? Name { get; set;}
        public string? Description { get; set;}
        public virtual ICollection<Person_N_Company> Person_N_Companies { get;} = new  List<Person_N_Company>();
    }
}