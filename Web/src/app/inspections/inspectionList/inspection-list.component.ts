import { Component, OnInit } from '@angular/core';
import { InspectionModel } from '../../models/inspection.model';
import { InspectionService } from '../../services/inspection.service';

@Component({
    templateUrl: `./inspection-list.component.html`,
    styleUrls: ['./inspection-list.component.css']
})
export class InspectionListComponent implements OnInit {
    title: string = 'Inspection List';
    inspections: InspectionModel[];

    constructor(private inspectionService: InspectionService) {}

    ngOnInit(): void {
        console.log('ngOnInit()');

        this.inspectionService.getInspections()
            .subscribe(
                data => this.inspections = data,
                err => console.error('error: ', err)
            );
    }
}
