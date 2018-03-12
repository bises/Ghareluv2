import { Component } from '@angular/core'
import { Http } from '@angular/http';


@Component({
    selector: 'ip-person',
    template: `<h2>Hello from the person {{name}}component</h2>`
})

export class PeopleComponent {
    //constructor(private http: Http) { }
    //http.get("http://localhost:62865/api/People/")
    name: string = "ip-person";
}