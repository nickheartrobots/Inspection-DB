import { Component, OnInit } from '@angular/core';
import { IVehicle } from '../vehicle';

@Component({
    templateUrl: `./vehicle-list.component.html`,
    styleUrls: ['./vehicle-list.component.css']
})
export class VehiclesComponent implements OnInit {
    title: string = 'Vehicle List';
    listFilter: string = 'Ford';
    vehicles: IVehicle[] =
    [
        {
            'ownerID': '12323425',
            'carrierID': '1',
            'make': 'Ford',
            'year': 2012,
            'vin': '1234G5988754654RB',
            'unitNumber': '',
            'odometer': '79,546',
            'licensePlateNumber': 'ABC-123',
            'state': 'MN',
            'decalNumber': '456354'
        },
        {
            'ownerID': '12323425',
            'carrierID': '2',
            'make': 'Volvo',
            'year': 2015,
            'vin': '1234H598R7546U54RB',
            'unitNumber': '23',
            'odometer': '146,954',
            'licensePlateNumber': 'KBB-777',
            'state': 'ND',
            'decalNumber': '681234'
        }
    ];

    ngOnInit(): void {
        console.log("OnInit()")
    }
}
