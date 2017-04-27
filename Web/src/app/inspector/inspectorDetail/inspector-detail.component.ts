import { Component } from '@angular/core';
import { InspectorService } from '../../services/inspector.service';
import { InspectorModel } from '../../models/inspector.model';
import { NgForm } from '@angular/forms';

@Component({
    templateUrl: './inspector-detail.component.html',
    styleUrls: ['./inspector-detail.component.css']
})
export class InspectorDetailComponent {
    title = 'Inspector Detail';
    model: InspectorModel;
    formSubmitClicked: boolean;
    searchParam: string;

    constructor(private inspectorServices: InspectorService){
        this.model = new InspectorModel();
        this.formSubmitClicked = false;
    }

    search(): void {
        console.log('search()');
    }

    onSubmit(form: NgForm) {
        console.log('onSubmit()', this.model);
        if (!this.formSubmitClicked) {
            this.formSubmitClicked = true;
        }

        if (form.invalid){
            return;
        }

        this.inspectorServices.postInspectorForm(this.model)
            .subscribe(
                data => console.log('success: ', data),
                err => console.log('error: ', err)
            );
    }
}
