import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { MaterialModule } from '@angular/material';
import { RouterModule } from '@angular/router';
import { FormPoster } from './services/form-poster.service';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { InspectionFormComponent } from './inspections/inspectionForm/inspection-form.component';
import { VehiclesComponent } from './vehicles/vehicleList/vehicle-list.component';
import { VehicleDetailComponent } from './vehicles/vehicleDetail/vehicle-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    InspectionFormComponent,
    VehiclesComponent,
    VehicleDetailComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    MaterialModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent},
      { path: 'inspection', component: InspectionFormComponent},
      { path: 'vehicles', component: VehiclesComponent },
      { path: 'vehicle/:id', component: VehicleDetailComponent},
      { path: '**', redirectTo: '', pathMatch: 'full'}
    ])
  ],
  providers: [FormPoster],
  bootstrap: [AppComponent]
})
export class AppModule { }
