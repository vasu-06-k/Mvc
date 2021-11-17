import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeComponent } from './employee/employee.component';
import { LoginmComponent } from './loginm/loginm.component';
LoginmComponent

const routes: Routes = [ {path:'LoginPage',component:LoginmComponent},
{path:'employee',component:EmployeeComponent}
];
export default routes;

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
