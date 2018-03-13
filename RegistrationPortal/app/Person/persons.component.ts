import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { PersonService } from './personservice.component'


@Component({
    selector: 'ip-person',
    templateUrl: 'app/Person/person.component.html',
    providers: [PersonService]
})

export class PeopleComponent implements OnInit {
    public persons: any[];

    constructor(private personService: PersonService) { }

    ngOnInit() {
        this.personService.getPerson()
            .subscribe((personData) => {
                this.persons = personData;
            });
    }
}