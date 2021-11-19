import { Component, OnInit } from '@angular/core';
import { perfom } from 'src/Logginm/perfomance';
import { RoutingService } from '../routing.service';

@Component({
  selector: 'app-addperformance',
  templateUrl: './addperformance.component.html',
  styleUrls: ['./addperformance.component.css']
})
export class AddperformanceComponent implements OnInit {
  constructor(private p:RoutingService) { }

  addper:perfom={
    Empid:0,
    Division:"",
    workgroup:"",
    Evaluationdate:new Date(),
    EvaluatorId:0,
    Evaluationperiod:0
  }
  ngOnInit(): void {
    //this.p.addemployeedetails(addemployee);
  }
 
  loginstatus:number=0;
  addperformance(addper:perfom):number
  {
    this.loginstatus=this.p.addperformance(addper);
    alert("performance added  succesfully");
    return this.loginstatus;
    
  }

}
