import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddemployeeComponent } from './addemployee/addemployee.component';
import { AddperformanceComponent } from './addperformance/addperformance.component';
import { AddtrainingComponent } from './addtraining/addtraining.component';
import { EmployeeComponent } from './employee/employee.component';
import { HomeComponent } from './home/home.component';
import { LoginmComponent } from './loginm/loginm.component';
import { ShowperformanceComponent } from './showperformance/showperformance.component';
import { ShowtrainingComponent } from './showtraining/showtraining.component';
//import { UpdatedetailsComponent } from './updatedetails/updatedetails.component';
import { UpdateemployeeComponent } from './updateemployee/updateemployee.component';
LoginmComponent

const routes: Routes = [ {path:'LoginPage',component:LoginmComponent},
{path:'employee',component:EmployeeComponent},
{path:'home',component:HomeComponent},
{path:'addemployee',component:AddemployeeComponent},
{path:'updateemployee',component:UpdateemployeeComponent},
{path:'showperformance',component:ShowperformanceComponent},
{path:'addperformance',component:AddperformanceComponent},
{path:'showtraining',component:ShowtrainingComponent},
{path:'addtraining',component:AddtrainingComponent}


//{path:'updatedetails',component:UpdatedetailsComponent}
];
export default routes;

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
