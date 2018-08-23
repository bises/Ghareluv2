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
var personservice_component_1 = require("./personservice.component");
var PeopleComponent = /** @class */ (function () {
    function PeopleComponent(personService) {
        this.personService = personService;
    }
    PeopleComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.personService.getPerson()
            .subscribe(function (personData) {
            _this.persons = personData;
        });
    };
    PeopleComponent = __decorate([
        core_1.Component({
            selector: 'ip-person',
            templateUrl: 'app/Person/person.component.html',
            providers: [personservice_component_1.PersonService]
        }),
        __metadata("design:paramtypes", [personservice_component_1.PersonService])
    ], PeopleComponent);
    return PeopleComponent;
}());
exports.PeopleComponent = PeopleComponent;
//# sourceMappingURL=persons.component.js.map