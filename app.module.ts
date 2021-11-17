import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import routes,{ AppRoutingModule } from './app-routing.module';
import { RoutingService } from './routing.service';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { LoginmComponent } from './loginm/loginm.component';

import { FormsModule } from '@angular/forms';
import { EmployeeComponent } from './employee/employee.component';
import { AddemployeeComponent } from './addemployee/addemployee.component';
import { UpdateemployeeComponent } from './updateemployee/updateemployee.component';
import { DeleteemployeeComponent } from './deleteemployee/deleteemployee.component';
import { HomeComponent } from './home/home.component';





@NgModule({
  declarations: [
    AppComponent,
    LoginmComponent,
    EmployeeComponent,
    AddemployeeComponent,
    UpdateemployeeComponent,
    DeleteemployeeComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    
    HttpClientModule,
    AppRoutingModule,
    RouterModule.forRoot(routes),
    FormsModule
  ],
  providers: [RoutingService],
  bootstrap: [AppComponent]
})
export class AppModule { }
