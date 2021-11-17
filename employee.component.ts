import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { empdetails } from 'src/Logginm/employee';
import { AddemployeeComponent } from '../addemployee/addemployee.component';

import { RoutingService } from '../routing.service';
empdetails
RoutingService
@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

emplist:Array<empdetails>=[];
  constructor(private p:RoutingService,private r:Router) { }

  ngOnInit(): void {
    this.p.getEvents().subscribe(data => {
      this.emplist = data;
  });
  
    
}
addemp(){
  this.r.navigate(['/addemployee'])
}
updateemp(){
  this.r.navigate(['/updateemployee'])
}

}



