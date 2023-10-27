using AddressBookData.DTOs;
using AddressBookService.Abstract;
using AdressBook.Models;
using AdressBookData.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookService.Service
{
    public class PersonService : IPersonService
    {
        private readonly AppDbContext appDbContext;
        public PersonService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public List<PersonData> GetAllPersons()
        {
            var persons = (from p in appDbContext.PERSONs
                           join pnc in appDbContext.PERSON_N_COMPANies on p.Id equals pnc.IdPerson
                           join c in appDbContext.COMPANies on pnc.IdCompany equals c.Id
                        
                           join pne in appDbContext.PERSON_N_EMAILs on p.Id equals pne.IdPerson
                           join e in appDbContext.EMAILs on pne.IdEmail equals e.Id

                           join pnl in appDbContext.PERSON_N_LOCATIONs on p.Id equals pnl.IdPerson
                           join l in appDbContext.LOCATIONs on pnl.IdLocation equals l.Id

                           join pnh in appDbContext.PERSON_N_PHONEs on p.Id equals pnh.IdPerson
                           join ph in appDbContext.PHONEs on pnh.IdPhone equals ph.Id

                           select new PersonData
                           {
                               Id = p.Id,
                               Company = c.Name,
                               Email = e.EmailAdress,
                               Address = l.Address,
                               Phone = ph.PhoneNumber,
                               Name = p.Name,
                               Surname = p.SurName
                           }
                ).AsNoTracking().ToList();
            return persons;
        }
        public bool AddPersonService(PersonData data)
        {
            var person = new Person
            {
                Name = data.Name,
                SurName = data.Surname
            };
            var email = new Email
            {
                Description = data.Email,
                EmailAdress = data.Email
            };
            var company = new Company
            {
                Name = data.Company,
                Description = data.Company
            };
            var location = new Location
            {
                Address = data.Address,
                Description = data.Address
            };
            var phone = new Phone
            {
                Description = data.Phone,
                PhoneNumber = data.Phone
            };
            appDbContext.PERSONs.Add(person);
            appDbContext.EMAILs.Add(email);
            appDbContext.COMPANies.Add(company);
            appDbContext.LOCATIONs.Add(location);
            appDbContext.PHONEs.Add(phone);
            appDbContext.SaveChanges();
            appDbContext.PERSON_N_EMAILs.Add(new Person_N_Email
            {
                IdEmail = email.Id,
                IdPerson = person.Id
            });
            appDbContext.PERSON_N_COMPANies.Add(new Person_N_Company
            {
                IdCompany = company.Id,
                IdPerson = person.Id
            });
            appDbContext.PERSON_N_LOCATIONs.Add(new Person_N_Location
            {
                IdLocation = location.Id,
                IdPerson = person.Id
            });
            appDbContext.PERSON_N_PHONEs.Add(new Person_N_Phone
            {
                IdPhone = phone.Id,
                IdPerson = person.Id
            });
            appDbContext.SaveChanges();

            return true;
        }

        public bool RemovePersonService(int idPerson)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePersonService(PersonData data)
        {
            throw new NotImplementedException();
        }
    }
}
