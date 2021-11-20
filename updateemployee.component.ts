import { CompileShallowModuleMetadata, parseHostBindings } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { empdetails } from 'src/Logginm/employee';
import { RoutingService } from '../routing.service';
empdetails

@Component({
  selector: 'app-updateemployee',
  templateUrl: './updateemployee.component.html',
  styleUrls: ['./updateemployee.component.css']
})
export class UpdateemployeeComponent implements OnInit {
  emplist:Array<empdetails>=[];

  constructor(private p:RoutingService) { }
  adde:empdetails={
    EmployeeID:0,
    EmployeeName:"",
    
    
       DateOfBirth:new Date(),
       Gender:"",
       EmpStatus:"current",
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
    
    
  };
  passid(id:number){
    this.p.updateemployeedetails(id).subscribe((data:any) => {
      this.adde= data;
      console.log(this.adde);
      this.showall(this.adde);


    

    });
    
    
  }
  showall(ar:empdetails)
    {
      this.adde.EmployeeID=ar.EmployeeID;
      this.adde.EmployeeName=ar.EmployeeName;
      
      
        this.adde.DateOfBirth=ar.DateOfBirth;
        this.adde.Gender=ar.Gender;
        this.adde.EmpStatus=ar.EmpStatus;
        this.adde.Designation=ar.Designation;
        this.adde.DeptNo =ar.DeptNo;
        this.adde.Address=ar.Address;
         this.adde.Nationality=ar.Nationality;
         this.adde.PhoneNo =ar.PhoneNo;
         this.adde.WorkLoc=ar.WorkLoc;
         this.adde.Joiningdate=ar.Joiningdate;
         this.adde.ManagerId=ar.ManagerId;

    }
    loginstatus:number=0;
    updateemployee(arr:empdetails):number
    
    {
      this.loginstatus=this.p.updateemptodb(arr);
    alert("Employee updated  succesfully");
    return this.loginstatus;
    

    }

 
  


}
