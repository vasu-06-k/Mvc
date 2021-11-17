import { Injectable } from '@angular/core';
import { loginhr } from 'src/Logginm/Login1';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { empdetails } from 'src/Logginm/employee';


@Injectable({
  providedIn: 'root'
})
export class RoutingService {
  public api='https://localhost:44381/api/VTRouting/Admin/';
public getapi='https://localhost:44381/api/';

  constructor(private http:HttpClient,private r:Router) { }
  mystatus:number=0;
    postlogin(logindata:loginhr):number
    {
      let endpoints="VTRouting/Admin";

     this.http.post(this.getapi+endpoints,logindata).subscribe((data:any)=>{console.log(data); this.mystatus=data.status;
    console.log(data.status);
      if(data.status==200)
      {this.r.navigate(['/home']);}
      else{
        this.r.navigate(['/wrong-user']);
      }});
     
     
     return this.mystatus
}
getEvents():Observable<Array<empdetails>>{
  let endpoints="Logind/showall"
  return this.http.get<Array<empdetails>>(this.getapi+endpoints);
}
addemployeedetails(val:any)
{
  let endpoints="VTRouting/insert";
    this.http.post(this.getapi+endpoints,val).subscribe((data:any)=>{this.mystatus=data.status})
    return this.mystatus
}
updateemployeedetails(val:any)
{
  let endpoints="VTRouting/";
   this.http.post(this.getapi+endpoints,val).subscribe((data:any)=>{this.mystatus=data.status})
  return this.mystatus
}
Findemployee(val:any)
{
  let endpoints="VTRouting/";
  return this.http.put(this.getapi+endpoints,val)

}

}
