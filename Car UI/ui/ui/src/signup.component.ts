import { Component, OnInit } from '@angular/core';
//import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
//import { NgToastService } from 'ng-angular-popup';
import { AuthService } from 'src/app/services/auth.service';
import { FormGroup, FormControl, Validators,FormBuilder, NgForm } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { Login } from 'src/app/models/login.model';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {
  signupForm!:FormGroup;
  constructor(private fb : FormBuilder, private auth: AuthService , private router:Router){}
  

  ngOnInit(): void {
    //throw new Error('Method not implemented.');
    this.signupForm=this.fb.group({
    firstname: ['', Validators.required],
      lastname: ['', Validators.required],
      email: ['', Validators.required],
      password: ['', Validators.required],
    })
  }
  onSignUp()
  {
    if(this.signupForm.valid)
    {
     this.auth.signUp(this.signupForm.value)
     .subscribe({
      next:(res=>{
        alert(res.message);
        this.signupForm.reset();
        this.router.navigate(['login'])
      })
      ,error:(err=>{
        alert(err?.error.message)
      })
     })
    console.log(this.signupForm.value)
    // Send the obj to database

    }
    else{
    console.log("Form is not valid");
    this.validateAllFormFields(this.signupForm);
    alert("form is invalid");
    }

  //  submit(){
  //   console.log("Form Submitted")
  //  }
  }
  private validateAllFormFields(formGroup:FormGroup){
    Object.keys(formGroup.controls).forEach(field=>{
      const control= formGroup.get(field);
      if(control instanceof FormControl)
      {
        control.markAsDirty({onlySelf:true});
      }
      else if(control instanceof FormGroup)
      {
         this.validateAllFormFields(control);
      }
    })
  }
}
  

  

//   ngOnInit():void{
  
    
//   }
//   formData!:Login ;

//   onSignUp(myform:NgForm){
//     //if(this.signupForm.valid){
//      this.auth.signUp(this.formData)
//      .subscribe({
//       next:(res: { message: any; })=>{
//        // alert(res.message);
//        this.toast.success({detail:"SUCCESS",summary:res.message,duration:5000});
//         this.signupForm.reset();
//         this.router.navigate(['login']);
//       },
//       error:()=>{
//         //alert(err?.error.message);
//         this.toast.error({detail:"ERROR",summary:"Something went wrong",duration:5000});
//       }
//      })
//     // }
//     // else{

//     //   this.vaildateAllFormFields(this.signupForm);
//     //   alert("Your form is invalid");
//     // }
//   }

//   // private vaildateAllFormFields(formGroup:FormGroup){
//   //   Object.keys(formGroup.controls).forEach(field=>{
//   //     const control=formGroup.get(field);
//   //     if(control instanceof FormControl){
//   //       control.markAsDirty({onlySelf:true})
//   //     }
//   //     else if(control instanceof FormGroup){
//   //       this.vaildateAllFormFields(control)
//   //     }
//   //   })
//   // }
// }
