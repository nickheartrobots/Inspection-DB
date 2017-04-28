import { Component, OnInit } from '@angular/core';
import { VehicleModel } from '../../models/vehicle.model';
import { DataService } from '../../services/data.service';

@Component({
    templateUrl: `./vehicle-list.component.html`,
    styleUrls: ['./vehicle-list.component.css']
})
export class VehiclesComponent implements OnInit {
    title: string = 'Vehicle List';
    vehicles: VehicleModel[];

    constructor(private dataService: DataService) {}

    ngOnInit(): void {
        console.log("OnInit()")

        this.dataService.getVehicles()
            .subscribe(
                data => this.vehicles = data,
                err => console.error('error: ', err)
            );
    }
}
