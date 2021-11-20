import { Component, OnInit } from '@angular/core';
import { payroll } from 'src/Logginm/Payroll';
import { RoutingService } from '../routing.service';

@Component({
  selector: 'app-payrollemp',
  templateUrl: './payrollemp.component.html',
  styleUrls: ['./payrollemp.component.css']
})
export class PayrollempComponent implements OnInit {

  payrollist:Array<payroll>=[];

  constructor(private p:RoutingService) { }
  pay:payroll={
    Empid:0, 
    BankaccountNo:0,
   Basicpay:0,
     HRA:0,
   Medicalallowance:0, 
   Tax:0,
 Bonus:0,
     Noofworkdays:0, 
     Grosspay:0,
   Pfno:0
  }
  ngOnInit(): void {
    
    
  };
  passid(id:number){
    this.p.getpayrollid(id).subscribe((data:any) => {
      this.pay= data;
      console.log(this.pay);
      this.showall(this.pay);


    

    });
    
    
  }
  showall(ar:payroll)
    {
      this.pay.Empid=ar.Empid;
      this.pay.BankaccountNo=ar.BankaccountNo;
      
      
        this.pay.BankaccountNo=ar.BankaccountNo;
        this.pay.Basicpay=ar.Basicpay;
        this.pay.HRA=ar.HRA;
        this.pay.Medicalallowance=ar.Medicalallowance;
        this.pay.Tax =ar.Tax;
        this.pay.Bonus=ar.Bonus;
         this.pay.Noofworkdays=ar.Noofworkdays;
         this.pay.Grosspay =ar.Grosspay;
         this.pay.Pfno=ar.Pfno;
         
         

    }
    loginstatus:number=0;
   updatepayroll(arr:payroll):number
    
    {
      this.loginstatus=this.p.updatepayrolltodb(arr);
    alert("Bank Account details succesfully");
    return this.loginstatus;
    

    }
  }