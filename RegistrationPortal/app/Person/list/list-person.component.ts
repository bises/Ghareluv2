import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { PersonService } from '../person.service'


@Component({
    selector: 'ip-list-person',
    templateUrl: 'app/Person/list/list-person.component.html',
    providers: [PersonService]
})

export class ListPersonComponent implements OnInit {
    public persons: any[];

    constructor(private personService: PersonService) { }

    ngOnInit() {
        this.personService.getPerson()
            .subscribe((personData) => {
                this.persons = personData;
            });
    }
}