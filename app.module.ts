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
import { EmployeeService } from './employee.service';
EmployeeService




@NgModule({
  declarations: [
    AppComponent,
    LoginmComponent,
    EmployeeComponent
  ],
  imports: [
    BrowserModule,
    
    HttpClientModule,
    AppRoutingModule,
    RouterModule.forRoot(routes),
    FormsModule
  ],
  providers: [EmployeeService],
  bootstrap: [EmployeeComponent]
})
export class AppModule { }
