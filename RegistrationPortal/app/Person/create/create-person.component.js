"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var person_service_1 = require("../person.service");
var CreatePersonComponent = /** @class */ (function () {
    function CreatePersonComponent(personService) {
        this.personService = personService;
    }
    CreatePersonComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.personService.getAllCities()
            .subscribe(function (cityData) {
            _this.cities = cityData;
        });
        this.personService.getAllCountries()
            .subscribe(function (countryData) {
            _this.countries = countryData;
        });
    };
    CreatePersonComponent = __decorate([
        core_1.Component({
            selector: "ip-create-person",
            templateUrl: "app/Person/create/create-person.component.html",
            providers: [person_service_1.PersonService]
        }),
        __metadata("design:paramtypes", [person_service_1.PersonService])
    ], CreatePersonComponent);
    return CreatePersonComponent;
}());
exports.CreatePersonComponent = CreatePersonComponent;
//# sourceMappingURL=create-person.component.js.map