namespace AdressBook.Models
{
    public partial class Location
    {
        public int Id { get; set;}
        public string? Address { get; set;}
        public string? Description { get; set;}
        public virtual ICollection<Person_N_Location> Person_N_Locations { get;} = new  List<Person_N_Location>();
    }
}