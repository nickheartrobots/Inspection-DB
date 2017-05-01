import { Component } from '@angular/core';
import { VehicleModel } from '../../models/vehicle.model';
import { DataService } from '../../services/data.service';
import { NgForm } from '@angular/forms';

@Component({
    templateUrl: './vehicle-detail.component.html'
})
export class VehicleDetailComponent {
    states: string[] = ['AL', 'AK', 'AZ', 'AR', 'CA', 'CO', 'CT', 'DE', 'FL', 'GA',
                        'HI', 'ID', 'IL', 'IN', 'IA', 'KS', 'KY', 'LA', 'ME', 'MD',
                        'MA', 'MI', 'MN', 'MS', 'MO', 'MT', 'NE', 'NV', 'NH', 'NJ',
                        'NM', 'NY', 'NC', 'ND', 'OH', 'OK', 'OR', 'PA', 'RI', 'SC',
                        'SD', 'TN', 'TX', 'UT', 'VT', 'VA', 'WA', 'WV', 'WI', 'WY'];
    title: string = 'Vehicle Detail';
    model: VehicleModel = new VehicleModel();
    formSubmitClicked: boolean = false;

    constructor(private dataService: DataService){}

    onSubmit(form: NgForm) {
        console.log('onSubmit()', this.model);
        if (!this.formSubmitClicked) {
            this.formSubmitClicked = true;
        }
        if (form.invalid) {
            return;
        }
        this.dataService.postVehicleForm(this.model)
            .subscribe(
                data => console.log('success: ', data),
                err => console.log('error: ', err)
            );
    }
}