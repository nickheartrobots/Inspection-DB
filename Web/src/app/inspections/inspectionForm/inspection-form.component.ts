import { Component } from '@angular/core';
import { InspectionModel } from '../../models/inspection.model';

@Component({
    templateUrl: './inspection-form.component.html',
    styleUrls: ['./inspection-form.component.css']
})
export class InspectionFormComponent {
    title: string = 'Inspection Form';
    states: string[] = ['', 'AL', 'AK', 'AZ', 'AR', 'CA', 'CO', 'CT', 'DE', 'FL', 'GA',
                            'HI', 'ID', 'IL', 'IN', 'IA', 'KS', 'KY', 'LA', 'ME', 'MD',
                            'MA', 'MI', 'MN', 'MS', 'MO', 'MT', 'NE', 'NV', 'NH', 'NJ',
                            'NM', 'NY', 'NC', 'ND', 'OH', 'OK', 'OR', 'PA', 'RI', 'SC',
                            'SD', 'TN', 'TX', 'UT', 'VT', 'VA', 'WA', 'WV', 'WI', 'WY'];
    model = new InspectionModel();
    isError = true;

    onFormChange(): void {
        console.log(this.model.toString());
    }
}