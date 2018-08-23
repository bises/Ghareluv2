import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';

@Injectable()
export class PersonService {

    constructor(private http: Http) { }

    getPerson(): Observable<any[]> {
        return this.http.get('http://localhost:62865/api/People')
            .map((response: Response) => <any[]>response.json());;
    }

    getAllCities(): Observable<any[]> {
        return this.http.get('http://localhost:62865/api/Address/Cities')
            .map((response: Response) => <any[]>response.json());;
    }

    getAllCountries(): Observable<any[]> {
        return this.http.get('http://localhost:62865/api/Address/Countries')
            .map((response: Response) => <any[]>response.json());;
    } 
}
