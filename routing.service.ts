import { Injectable } from '@angular/core';
import { loginhr } from 'src/Logginm/Login1';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { empdetails } from 'src/Logginm/employee';
import { perfom } from 'src/Logginm/perfomance';
import { training } from 'src/Logginm/training';
import { payroll } from 'src/Logginm/Payroll';


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
  let endpoints="VTRouting/showall"
  return this.http.get<Array<empdetails>>(this.getapi+endpoints);
}
addemployeedetails(val:any)
{
  let endpoints="VTRouting/insert";
    this.http.post(this.getapi+endpoints,val).subscribe((data:any)=>{this.mystatus=data.status})
    return this.mystatus
}
updateemployeedetails(empid:number):Observable<empdetails>{
 let myapi:string="https://localhost:44381/api/Logind/displayupdate?empid=";
  //let endpoints="Logind/displayupdate?empid=";
   return this.http.get<empdetails>(myapi+empid);

  
   
}
getpayrollid(id:number):Observable<payroll>{
  let myapi:string="https://localhost:44381/api/Payroll/displayupdates?id=";
   //let endpoints="Logind/displayupdate?empid=";
    return this.http.get<payroll>(myapi+id);
 
   
    
 }
 //updatepayrolltodb
updateemptodb(val:any)
{let endpoints="VTRouting/update";
this.http.put(this.getapi+endpoints,val).subscribe((data:any)=>{this.mystatus=data.status})
return this.mystatus

}
updatepayrolltodb(val:any)
{let endpoints="Payroll/updates";
this.http.put(this.getapi+endpoints,val).subscribe((data:any)=>{this.mystatus=data.status})
return this.mystatus

}
Findemployee(val:any)
{
  let endpoints="VTRouting/";
  return this.http.put(this.getapi+endpoints,val)

}
addperformance(val:any)
{
  //let endpoints="Perfomance/Postperformance";
    this.http.post("https://localhost:44381/api/Perfomance/Postperfomance",val).subscribe((data:any)=>{this.mystatus=data.status})
    return this.mystatus
}
showperformance():Observable<Array<perfom>>{
  let endpoints="https://localhost:44381/api/Perfomance/showallperfomance";
  console.log("hello");
  return this.http.get<Array<perfom>>(endpoints);
}
showtraining():Observable<Array<training>>{
  let endpoints="https://localhost:44381/api/Training/showall";
  console.log("hello");
  return this.http.get<Array<training>>(endpoints);
}
addTrainee(val:any)
{
  //let endpoints="Perfomance/Postperformance";
    this.http.post("https://localhost:44381/api/Training/addtraining",val).subscribe((data:any)=>{this.mystatus=data.status})
    return this.mystatus
}
}
