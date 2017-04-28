import { Component, OnInit } from '@angular/core';
import { InspectorModel } from '../../models/inspector.model';
import { DataService } from '../../services/data.service';

@Component({
    templateUrl: './inspector-list.component.html',
    styleUrls: ['./inspector-list.component.css']
})
export class InspectorListComponent implements OnInit {
    title = 'Inspectors List';
    inspectors: InspectorModel[];

    constructor(private dataService: DataService) {}

    ngOnInit(): void {
        console.log('ngOnInit()');

        this.dataService.getInspectors()
            .subscribe(
                data => this.inspectors = data,
                err => console.error('error: ', err)
            );
    }
}
