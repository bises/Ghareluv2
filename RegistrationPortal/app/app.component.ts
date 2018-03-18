import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
    template: `<h1>Hello {{name}}</h1>
                <ip-list-person></ip-list-person>
                <ip-create-person></ip-create-person>`,
})
export class AppComponent  {
    name = 'Angular v 5';
}
