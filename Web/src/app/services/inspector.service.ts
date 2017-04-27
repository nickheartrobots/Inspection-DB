import { Injectable } from '@angular/core';
import { InspectorModel } from '../models/inspector.model';
import { Http, Response, Headers, RequestOptions } from '@angular/http';
import 'rxjs/Rx';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class InspectorService {
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

    postInspectorForm(inspector: InspectorModel): Observable<any>{
        const body = JSON.stringify(inspector);
        const headers = new Headers({ 'Content-Type': 'application/json' });
        const options = new RequestOptions({ headers: headers });

        console.log('FormPoster.postInspectionForm()', body);

        return this.http.post('http://localhost:57893/api/Inspector', body, options)
            .map(this.extractData)
            .catch(this.handleError);
    }

    getInspectors(): Observable<InspectorModel[]> {
        const headers = new Headers({ 'Content-Type': 'application/json' });
        const options = new RequestOptions({ headers: headers });

        return this.http.get('http://localhost:57893/api/Inspector')
            .map(this.extractData)
            .catch(this.handleError);
    }
}
