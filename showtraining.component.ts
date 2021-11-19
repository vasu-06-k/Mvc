import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { training } from 'src/Logginm/training';
import { RoutingService } from '../routing.service';
training

@Component({
  selector: 'app-showtraining',
  templateUrl: './showtraining.component.html',
  styleUrls: ['./showtraining.component.css']
})
export class ShowtrainingComponent implements OnInit {
  trainlist:Array<training>=[];

  constructor(private p:RoutingService,private r:Router) { }

  ngOnInit(): void {
    this.p.showtraining().subscribe(data => {
      this.trainlist = data;
  });
  }
  inserttraining()
  {
    this.r.navigate(['/addtraining'])
  }

}
