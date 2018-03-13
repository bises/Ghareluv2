import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
    template: `<h1>Hello {{name}}</h1>
                <ip-person></ip-person>`,
})
export class AppComponent  {
    name = 'Angular v 5';
}
