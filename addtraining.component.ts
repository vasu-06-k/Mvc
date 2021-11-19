import { Component, OnInit } from '@angular/core';
import { training } from 'src/Logginm/training';
import { RoutingService } from '../routing.service';

@Component({
  selector: 'app-addtraining',
  templateUrl: './addtraining.component.html',
  styleUrls: ['./addtraining.component.css']
})
export class AddtrainingComponent implements OnInit {
  addtraining:training={
    Empid:0,
        Batchno:0,
         Batchname:"",
         courses :"",
         TraineerId:"",
         MangerId :0,
     startdate:new Date(),
         enddate:new Date(), 
         Status:"" 
  }

  constructor(private p:RoutingService) { }

  ngOnInit(): void {
  }
  loginstatus:number=0;
  addTrainee(addt:training):number
  {
    this.loginstatus=this.p.addTrainee(addt);
    alert("Trainee added  succesfully");
    return this.loginstatus;
    
  }

}
