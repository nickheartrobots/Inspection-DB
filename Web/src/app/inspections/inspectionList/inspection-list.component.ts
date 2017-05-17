import { Component, OnInit } from '@angular/core';
import { InspectionModel } from '../../models/inspection.model';
import { DataService } from '../../services/data.service';

@Component({
    templateUrl: `./inspection-list.component.html`,
    styleUrls: ['./inspection-list.component.css']
})
export class InspectionListComponent implements OnInit {
    title: string = 'Inspection List';
    inspections: InspectionModel[];

    constructor(private dataService: DataService) {}

    ngOnInit(): void {
        console.log('ngOnInit()');

        this.dataService.getInspections()
            .subscribe(
                data => this.inspections = data,
                err => console.error('error: ', err)
            );
    }
}
