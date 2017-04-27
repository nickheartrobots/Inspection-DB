import { Component, OnInit } from '@angular/core';
import { InspectorModel } from '../../models/inspector.model';
import { InspectorService } from '../../services/inspector.service';

@Component({
    templateUrl: `./inspector-list.component.html`,
    styleUrls: [`./inspector-list.component.css`]
})
export class InspectorListComponent implements OnInit {
    title = 'Inspectors List';
    inspectors: InspectorModel[];

    constructor(private inspectorService: InspectorService) {}

    ngOnInit(): void {
        console.log('ngOnInit()');

        this.inspectorService.getInspectors()
            .subscribe(
                data => this.inspectors = data,
                err => console.error('error: ', err)
            );
    }
}
