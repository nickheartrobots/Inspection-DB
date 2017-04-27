import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { MaterialModule } from '@angular/material';
import { RouterModule } from '@angular/router';
import { InspectionService } from './services/inspection.service';
import { InspectorService } from './services/inspector.service';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { InspectionFormComponent } from './inspections/inspectionForm/inspection-form.component';
import { InspectionListComponent } from './inspections/inspectionList/inspection-list.component';
import { InspectorDetailComponent } from './inspector/inspectorDetail/inspector-detail.component';
import { InspectorListComponent } from './inspector/inspectorList/inspector-list.component';
import { VehiclesComponent } from './vehicles/vehicleList/vehicle-list.component';
import { VehicleDetailComponent } from './vehicles/vehicleDetail/vehicle-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    InspectionFormComponent,
    InspectionListComponent,
    InspectorDetailComponent,
    InspectorListComponent,
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
      { path: 'new-inspection', component: InspectionFormComponent},
      { path: 'inspection-list', component: InspectionListComponent},
      { path: 'inspector-detail', component: InspectorDetailComponent},
      { path: 'inspector-detail/:id', component: InspectorDetailComponent},
      { path: 'inspector-list', component: InspectorListComponent},
      { path: 'vehicles', component: VehiclesComponent },
      { path: 'vehicle/:id', component: VehicleDetailComponent},
      { path: '**', redirectTo: '', pathMatch: 'full'}
    ])
  ],
  providers: [InspectionService, InspectorService],
  bootstrap: [AppComponent]
})
export class AppModule { }
