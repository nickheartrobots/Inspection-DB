import { Component, OnInit } from '@angular/core';
import { InspectionModel } from '../../models/inspection.model';
import { InspectorModel } from '../../models/inspector.model';
import { InspectionService } from '../../services/inspection.service';
import { NgForm } from '@angular/forms';

@Component({
    templateUrl: './inspection-form.component.html',
    styleUrls: ['./inspection-form.component.css']
})
export class InspectionFormComponent {
    states: string[] = ['AL', 'AK', 'AZ', 'AR', 'CA', 'CO', 'CT', 'DE', 'FL', 'GA',
                        'HI', 'ID', 'IL', 'IN', 'IA', 'KS', 'KY', 'LA', 'ME', 'MD',
                        'MA', 'MI', 'MN', 'MS', 'MO', 'MT', 'NE', 'NV', 'NH', 'NJ',
                        'NM', 'NY', 'NC', 'ND', 'OH', 'OK', 'OR', 'PA', 'RI', 'SC',
                        'SD', 'TN', 'TX', 'UT', 'VT', 'VA', 'WA', 'WV', 'WI', 'WY'];
    inspectionModel: InspectionModel = new InspectionModel();
    public formSubmitClicked: boolean = false;
    public isInspectionStateValid: boolean = false;
    public title: string = 'Inspection Form';

    constructor(private inspectionService: InspectionService){
        this.inspectionModel.address.state = 'default';
    }

    onSubmit(form: NgForm) {
        console.log('onSubmit()', this.inspectionModel);
        if (!this.formSubmitClicked) {
            this.formSubmitClicked = true;
        }
        if (form.invalid) {
            return;
        }
        this.inspectionService.postInspectionForm(this.inspectionModel)
            .subscribe(
                data => console.log('success: ', data),
                err => console.log('error: ', err)
            );
    }
}
