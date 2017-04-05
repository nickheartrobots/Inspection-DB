import { Component } from '@angular/core';

@Component({
    selector: 'app-root',
    template: `
	<div>
		<h1>{{title}}</h1>
		<app-vehicles></app-vehicles>
	</div>
  `
})
export class AppComponent {
    title = 'MNDOT Inspection DB';
}
