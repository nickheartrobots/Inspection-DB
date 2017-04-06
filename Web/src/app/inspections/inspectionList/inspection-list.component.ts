import { Component, OnInit } from '@angular/core';

@Component({
    templateUrl: `./inspection-list.component.html`,
    styleUrls: ['./inspection-list.component.css']
})
export class InspectionsComponent implements OnInit {
    title: string = 'Inspection List';
    listFilter: string = 'Ford';

    ngOnInit(): void {
        console.log('OnInit()')
    }
}
