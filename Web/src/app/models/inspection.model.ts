export class InspectionModel {
    inspectionDate: string;
    inspectionStreetAddress: string;
    inspectionCity: string;
    inspectionState: string;
    inspectionZip: string;
    inspectionTimeIn: string;
    inspectionTimeOut: string;
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

    toString(): string {
        return this.inspectionStreetAddress + ', ' + this.inspectionDate + ', ' +
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
