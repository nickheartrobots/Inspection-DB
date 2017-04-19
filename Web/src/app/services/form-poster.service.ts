import { Injectable } from '@angular/core';
import { InspectionModel } from '../models/inspection.model';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import 'rxjs/Rx';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class FormPoster {
    constructor(private http: Http) {

    }

    private extractData(res: Response) {
        const body = res.json();
        return body.fields || {};
    }

    private handleError(error: any) {
        console.error('post error: ', error);
        return Observable.throw(error.statusText);
    }

    postInspectionForm(inspection: InspectionModel):Observable<any>{
        const body = JSON.stringify(inspection);
        const headers = new Headers({ 'Content-Type': 'application/json' });
        const options = new RequestOptions({ headers: headers });

        console.log('FormPoster.postInspectionForm()', inspection);

        return this.http.post('http://localhost:3100/postemployee', body, options)
            .map(this.extractData)
            .catch(this.handleError);
    }
}