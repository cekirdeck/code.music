import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from 'rxjs';
import { PersonData } from './app-addressbook-list/person-data';
const httpOptions = {
  // eslint-disable-next-line @typescript-eslint/naming-convention
  headers: new HttpHeaders({ "content-type": "application/json" }),
};
@Injectable({
  providedIn: 'root'
})
export class AddressBookService {
  apiUrl = "http://localhost:4200";
  private corsHeaders: HttpHeaders;
  constructor(private http: HttpClient) {
    this.corsHeaders = new HttpHeaders({
      'Content-Type': 'application/json',
      'Accept': 'application/json',
    });
  }

  setApiUrl(apiUrl: string): void {
    this.apiUrl = apiUrl;
  }

  getPersons(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/addressbook`);
  }
  addPerson(person: PersonData): Observable<any> {
    return this.http
      .post<PersonData>(`${this.apiUrl}/addressbook`, {
        address: person.address,
        company: person.company,
        email: person.email,
        name: person.name,
        phone: person.phone,
        surname: person.surname
      }, {
        headers: this.corsHeaders
      });
  }
}
