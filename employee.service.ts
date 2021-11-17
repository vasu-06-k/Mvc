import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { empdetails} from 'src/Logginm/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  public api='https://localhost:44381/api/Logind/showall';
public getapi='https://localhost:44381/api/';


  
  constructor(private http:HttpClient) { }

  getEvents():Observable<Array<empdetails>>{
    return this.http.get<Array<empdetails>>(this.api);

}
}
