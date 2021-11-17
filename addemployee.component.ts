import { Component, OnInit } from '@angular/core';
import { empdetails } from 'src/Logginm/employee';
import { RoutingService } from '../routing.service';

@Component({
  selector: 'app-addemployee',
  templateUrl: './addemployee.component.html',
  styleUrls: ['./addemployee.component.css']
})
export class AddemployeeComponent implements OnInit {

  constructor(private p:RoutingService) { }

adde:empdetails={
  EmployeeID:0,
  EmployeeName:"",
  
  
     DateOfBirth:new Date(),
     Gender:"",
     EmpStatus:"",
     Designation:"",
     DeptNo :0,
     Address:"",
     Nationality:"", 
     PhoneNo :0,
     WorkLoc:"",
     Joiningdate:new Date(),
     ManagerId:0


}
  ngOnInit(): void {
    //this.p.addemployeedetails(addemployee);
  }
  loginstatus:number=0;
  addemp(addemp1:empdetails):number
  {
    this.loginstatus=this.p.addemployeedetails(addemp1);
    alert("Employee Added succesfully");
    return this.loginstatus;
    
  }

}
