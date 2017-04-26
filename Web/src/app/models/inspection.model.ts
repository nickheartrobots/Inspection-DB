import { InspectorModel } from './inspector.model';
import { AddressModel } from './address.model';

export class InspectionModel {
    id: number;
    date: string;
    timeIn: string;
    timeOut: string;
    inspector: InspectorModel;
    address: AddressModel;

    constructor() {
        this.inspector = new InspectorModel();
        this.address = new AddressModel();
    }

    // vehicleMake: string;
    // vehicleYear: number;
    // vehicleVin: string;
    // vehicleUnitNumber: string;
    // vehicleOdometer: number;
    // vehicleLicense: string;
    // vehicleLicenseState: string;
    // vehicleDecalNumber: string;
    // ownerLastName: string;
    // ownerFirstName: string;
    // ownerStreetAddress: string;
    // ownerCity: string;
    // ownerState: string;
    // ownerZip: string;
    // ownerUsdotNumber: string;
    // carrierLastName: string;
    // carrierFirstName: string;
    // carrierStreetAddress: string;
    // carrierCity: string;
    // carrierState: string;
    // carrierZip: string;
    // carrierUsdotNumber: string;
}
