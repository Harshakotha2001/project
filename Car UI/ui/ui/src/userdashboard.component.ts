import { Component, OnInit } from '@angular/core';
import { Package } from 'src/app/models/package.model';
import PackageService from 'src/app/services/package.service';

@Component({
  selector: 'app-userdashboard',
  templateUrl: './userdashboard.component.html',
  styleUrls: ['./userdashboard.component.css']
})
export class  UserdashboardComponent implements OnInit{
  constructor(
   // private toast:NgToastService,
    private productserv:PackageService){}

  public packages:any=[];
  ngOnInit(){
    this.productserv.getPackage()
    .subscribe(res=>{
      this.packages=res;
    });
    
    }
    deletePackage(id:number){
      if(confirm("Are you really want to delete this record ?"))
      {
        this.productserv.deletePackage(id)
        .subscribe({
          next:(res=>{
            //!this.toast.success({detail:"SUCCESS",summary:res.message,duration:5000});
      
            window.location.reload();
          }),
          error:(err=>{
            //this.toast.error({detail:"ERROR",summary:"Something went wrong",duration:5000});
          })
        })
      
      }
      }
      
      populatePackage(selectedPackage:Package){
      this.productserv.product=selectedPackage;
      }
}

