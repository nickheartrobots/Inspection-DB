import { Component, OnInit } from '@angular/core';
import { InspectionModel } from '../../models/inspection.model';

@Component({
    templateUrl: `./inspection-list.component.html`,
    styleUrls: ['./inspection-list.component.css']
})
export class InspectionListComponent implements OnInit {
    title: string = 'Inspection List';
    inspections: InspectionModel[] = [
        {
            id: 1,
            date: '01/01/2017',
            streetAddress: '3412 Woodbine Ln',
            city: 'Brooklyn Center',
            state: 'MN',
            zip: '55429',
            timeIn: '12:15PM',
            timeOut: '12:45PM'
        }
    ];

    constructor() {}

    ngOnInit(): void {
        console.log('ngOnInit()')
    }
}
