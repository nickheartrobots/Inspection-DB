import { Component } from '@angular/core';
import { VehicleModel } from '../../models/vehicle.model';

@Component({
    templateUrl: './vehicle-detail.component.html'
})
export class VehicleDetailComponent {
    title: string = 'Vehicle Detail';
    model: VehicleModel = new VehicleModel();
}