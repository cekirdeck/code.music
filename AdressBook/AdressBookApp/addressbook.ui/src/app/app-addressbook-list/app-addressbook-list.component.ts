import { Component } from '@angular/core';
import { AddressBookService } from '../address-book.service';
import { PersonData } from './person-data';

@Component({
  selector: 'app-addressbook-list',
  templateUrl: './app-addressbook-list.component.html',
  styleUrls: ['./app-addressbook-list.component.css']
})
export class AppAddressbookListComponent {
  persons: PersonData[] = [];
  constructor(private adrService: AddressBookService) {
    this.getPersons();
  }
  getPersons() {
    this.adrService.getPersons().subscribe({
      next: (data: PersonData[]) => {
        this.persons = [];
        if (data !== undefined) {
          data.forEach((item: PersonData) => {
            this.persons.push({
              address: item.address,
              company: item.company,
              email: item.email,
              id: item.id,
              name: item.name,
              phone: item.phone,
              surname: item.surname
            })
          });
        }
      }, // success path
      error: (error: any) => console.error("Response Error: " + error),
    });
  }
}
