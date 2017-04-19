import { Component } from '@angular/core';
import { InspectionModel } from '../../models/inspection.model';
import { FormPoster } from '../../services/form-poster.service';
import { NgForm } from '@angular/forms';

@Component({
    templateUrl: './inspection-form.component.html',
    styleUrls: ['./inspection-form.component.css']
})
export class InspectionFormComponent {
    title: string = 'Inspection Form';
    states: string[] = ['AL', 'AK', 'AZ', 'AR', 'CA', 'CO', 'CT', 'DE', 'FL', 'GA',
                        'HI', 'ID', 'IL', 'IN', 'IA', 'KS', 'KY', 'LA', 'ME', 'MD',
                        'MA', 'MI', 'MN', 'MS', 'MO', 'MT', 'NE', 'NV', 'NH', 'NJ',
                        'NM', 'NY', 'NC', 'ND', 'OH', 'OK', 'OR', 'PA', 'RI', 'SC',
                        'SD', 'TN', 'TX', 'UT', 'VT', 'VA', 'WA', 'WV', 'WI', 'WY'];

    model = new InspectionModel();
    formSubmitClicked: boolean = false;
    isInspectionStateValid: boolean = false;

    constructor(private formPoster: FormPoster){

    }

    validateInspectionState(event): void {
        if (this.model.inspectionState === 'default') {
            this.isInspectionStateValid = true;
        } else {
            this.isInspectionStateValid = false;
        }
    }

    onSubmit(form: NgForm) {
        console.log('onSubmit()', this.model);
        if (!this.formSubmitClicked) {
            this.formSubmitClicked = true;
        }
        if (form.invalid) {
            return;
        }
        this.formPoster.postInspectionForm(this.model)
            .subscribe(
                data => console.log('success: ', data),
                err => console.log('error: ', err)
            );
    }
}
