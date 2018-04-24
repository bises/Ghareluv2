import { Component, OnInit } from "@angular/core";
import { PersonService } from "../person.service";

@Component({
    selector: "ip-create-person",
    templateUrl: "app/Person/create/create-person.component.html",
    providers: [PersonService]
})

export class CreatePersonComponent implements OnInit {
    private cities: any[];
    private countries: any[];
    constructor(private personService: PersonService) { }

    ngOnInit() {
        this.personService.getAllCities()
            .subscribe((cityData) => {
                this.cities = cityData;
            });
        this.personService.getAllCountries()
            .subscribe((countryData) => {
                this.countries = countryData;
            });
    }

}