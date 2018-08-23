import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { ListPersonComponent } from './Person/list/list-person.component';
import { EditPersonComponent } from './Person/edit/edit-person.component';
import { CreatePersonComponent } from './Person/create/create-person.component';

@NgModule({
    imports: [BrowserModule, HttpModule],
    declarations: [AppComponent, ListPersonComponent, EditPersonComponent, CreatePersonComponent],
    bootstrap:    [ AppComponent ]
})
export class AppModule { }
