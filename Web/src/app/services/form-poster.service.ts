import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { InspectionModel } from '../models/inspection.model';

@Injectable()
export class FormPoster {
    constructor(private http: Http) {

    }

    postInspectionForm(inspection: InspectionModel){
        console.log('posting inspection', inspection);
    }
}