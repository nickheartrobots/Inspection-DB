import { Injectable } from '@angular/core';
import { InspectionModel } from '../models/inspection.model';
import { InspectorModel } from '../models/inspector.model';
import { VehicleModel } from '../models/vehicle.model';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import 'rxjs/Rx';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class DataService {
    constructor(private http: Http) {

    }

    private extractData(res: Response) {
        const body = res.json();
        console.log('response: ', body);
        return body || [];
    }

    private handleError(error: any) {
        console.error('post error: ', error);
        return Observable.throw(error.statusText);
    }

    getObject(path: string){
        // const headers = new Headers({
        //     'Content-Type': 'application/json',
        //     'Accept': 'application/json',
        //     'Cache-Control': 'no-cache, no-store, must-revalidate',
        //     'Pragma': 'no-cache',
        //     'Expires': 0
        // });
        const headers = new Headers({ 'Content-Type': 'application/json' });
        const options = new RequestOptions({ headers: headers });

        return this.http.get(path)
            .map(this.extractData)
            .catch(this.handleError);
    }

    postObject(obj: Object, path: string): Observable<any>{
        const body = JSON.stringify(obj);
        const headers = new Headers({ 'Content-Type': 'application/json' });
        const options = new RequestOptions({ headers: headers });


        return this.http.post(path, body, options)
            .map(this.extractData)
            .catch(this.handleError);
    }

    getInspections(): Observable<InspectionModel[]> {
        return this.getObject('http://localhost:57893/api/Inspection');
    }

    postInspectionForm(inspection: InspectionModel): Observable<any>{
        return this.postObject(inspection, 'http://localhost:57893/api/Inspection');
    }

    getInspectors(): Observable<InspectorModel[]> {
        return this.getObject('http://localhost:57893/api/Inspector');
    }

    postInspectorForm(inspector: InspectorModel): Observable<any>{
        return this.postObject(inspector, 'http://localhost:57893/api/Inspector');
    }

    getVehicles(): Observable<VehicleModel[]> {
        return this.getObject('http://localhost:57893/api/Vehicle');
    }

    postVehicleForm(vehicle: VehicleModel): Observable<any>{
        return this.postObject(vehicle, 'http://localhost:57893/api/Vehicle');
    }
 }
