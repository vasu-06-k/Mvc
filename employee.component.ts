import { Component, OnInit } from '@angular/core';
import { empdetails } from 'src/Logginm/employee';
import { EmployeeService } from '../employee.service';
empdetails
EmployeeService
@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

emplist:Array<empdetails>=[];
  constructor(private p:EmployeeService) { }

  ngOnInit(): void {
    
  }
  showevents(){
    this.p.getEvents().subscribe(data => {
       this.emplist = data;
       // console.log(this.supplierdata);
     });
   }

}
