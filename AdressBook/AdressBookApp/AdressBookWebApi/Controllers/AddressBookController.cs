using AddressBookData.DTOs;
using AddressBookService.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AdressBookWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressBookController : ControllerBase
    {
        private readonly IPersonService personService;
        public AddressBookController(IPersonService personService)
        {
            this.personService = personService;   
        }
        [HttpGet]
        public List<PersonData> GetPersons() 
        {
            return personService.GetAllPersons();
        }
        [HttpPost]
        public bool AddPerson([FromBody] PersonData data)
        {
            return personService.AddPersonService(data);
        }
        [HttpDelete]
        public bool RemovePerson([FromQuery] int idPerson)
        {
            return personService.RemovePersonService(idPerson);
        }
        [HttpPut]
        public bool UpdatePerson([FromBody] PersonData data)
        {
            return personService.UpdatePersonService(data);
        }


    }
}
