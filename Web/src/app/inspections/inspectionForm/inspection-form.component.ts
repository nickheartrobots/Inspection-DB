import { Component } from '@angular/core';

@Component({
    templateUrl: './inspection-form.component.html',
    styleUrls: ['./inspection-form.component.css']
})
export class InspectionFormComponent {
    states: string[] = ['', 'AL', 'AK', 'AZ', 'AR', 'CA', 'CO', 'CT', 'DE', 'FL', 'GA',
                            'HI', 'ID', 'IL', 'IN', 'IA', 'KS', 'KY', 'LA', 'ME', 'MD',
                            'MA', 'MI', 'MN', 'MS', 'MO', 'MT', 'NE', 'NV', 'NH', 'NJ',
                            'NM', 'NY', 'NC', 'ND', 'OH', 'OK', 'OR', 'PA', 'RI', 'SC',
                            'SD', 'TN', 'TX', 'UT', 'VT', 'VA', 'WA', 'WV', 'WI', 'WY'];
    title: string = 'Inspection Form';
    inspectionDate: string;
    inspectionTimeIn: string;
    inspectionTimeOut: string;
    inspectionStreetAddress: string;
    inspectionCity: string;
    inspectionState: string;
    inspectionZip: string;
    inspectorLastName: string;
    inspectorFirstName: string;
    inspectorNumber: string;
    vehicleMake: string;
    vehicleYear: number;
    vehicleVin: string;
    vehicleUnitNumber: string;
    vehicleOdometer: number;
    vehicleLicense: string;
    vehicleLicenseState: string;
    vehicleDecalNumber: string;
    ownerLastName: string;
    ownerFirstName: string;
    ownerStreetAddress: string;
    ownerCity: string;
    ownerState: string;
    ownerZip: string;
    ownerUsdotNumber: string;
    carrierLastName: string;
    carrierFirstName: string;
    carrierStreetAddress: string;
    carrierCity: string;
    carrierState: string;
    carrierZip: string;
    carrierUsdotNumber: string;

    onFormChange(): void {
        console.log(this.toString());
    }

    toString(): string {
        return this.inspectionStreetAddress + ', ' + this.inspectionDate + ', ' + this.inspectionDate + ', ' +
               this.inspectionTimeIn + ', ' + this.inspectionTimeOut + ', ' + this.inspectionCity + ', ' +
               this.inspectionState + ', ' + this.inspectionZip + ', ' + this.inspectorLastName + ', ' +
               this.inspectorFirstName + ', ' + this.inspectorNumber + ',' + this.vehicleMake + ', ' +
               this.vehicleYear + ', ' + this.vehicleVin + ', ' + this.vehicleUnitNumber + ', ' +
               this.vehicleOdometer + ', ' + this.vehicleLicense + ', ' + this.vehicleLicenseState + ', ' +
               this.vehicleDecalNumber + ', ' + this.ownerLastName + ', ' + this.ownerFirstName + ', ' +
               this.ownerStreetAddress + ', ' + this.ownerCity + ', ' + this.ownerState + ', ' +
               this.ownerZip + ', ' + this.ownerUsdotNumber + ', ' + this.carrierLastName + ', ' +
               this.carrierFirstName + ', ' + this.carrierStreetAddress + ', ' + this.carrierCity + ', ' +
               this.carrierState + ', ' + this.carrierZip + ', ' + this.carrierUsdotNumber;
    }
}