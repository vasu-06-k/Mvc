import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { perfom } from 'src/Logginm/perfomance';
import { RoutingService } from '../routing.service';

@Component({
  selector: 'app-showperformance',
  templateUrl: './showperformance.component.html',
  styleUrls: ['./showperformance.component.css']
})
export class ShowperformanceComponent implements OnInit {
  perflist:Array<perfom>=[];
  constructor(private p:RoutingService,private r:Router) { }

  ngOnInit(): void {
    this.p.showperformance().subscribe(data => {
      this.perflist = data;
  });
}
insertperformance(){
  this.r.navigate(['/addperformance'])
}
}
