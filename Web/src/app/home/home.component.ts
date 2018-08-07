import { Component } from '@angular/core';

@Component({
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
})

export class HomeComponent {
    title: string = 'Home';
    jumboTitle: string = 'USDOT Home';
    jumboText: string = 'This app is for connecting to the USDOT Inspection Database and for creating new entries in the Database';
}