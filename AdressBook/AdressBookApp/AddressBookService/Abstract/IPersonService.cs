using AddressBookData.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookService.Abstract
{
    public interface IPersonService
    {
        bool AddPersonService(PersonData data);

        bool RemovePersonService(int idPerson);

        bool UpdatePersonService(PersonData data);

        List<PersonData> GetAllPersons();
    }
}
