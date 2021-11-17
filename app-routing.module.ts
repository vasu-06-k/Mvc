import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddemployeeComponent } from './addemployee/addemployee.component';
import { EmployeeComponent } from './employee/employee.component';
import { HomeComponent } from './home/home.component';
import { LoginmComponent } from './loginm/loginm.component';
import { UpdateemployeeComponent } from './updateemployee/updateemployee.component';
LoginmComponent

const routes: Routes = [ {path:'LoginPage',component:LoginmComponent},
{path:'employee',component:EmployeeComponent},
{path:'home',component:HomeComponent},
{path:'addemployee',component:AddemployeeComponent},
{path:'updateemployee',component:UpdateemployeeComponent}
];
export default routes;

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
