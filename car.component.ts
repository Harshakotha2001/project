import { Component } from '@angular/core';
import { CarService } from 'src/app/services/car.service';

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css']
})
export class CarComponent {
  constructor(private carservice:CarService){}

  public cars:any=[];
  
    ngOnInit(){
      this.carservice.getAllCars()
      .subscribe(data=>{
        this.cars=data;
      })
    }
  
    deletingOrder(id:number){
   this.carservice.deleteCar(id)
   .subscribe({
    next:(res=>{
  
     window.location.reload();
    })
   })
    }
}
