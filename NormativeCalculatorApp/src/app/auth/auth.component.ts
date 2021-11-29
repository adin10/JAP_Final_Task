import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthenticationService } from '../_services/authentication.service';
import { LoginInsertRequest } from '../_shared/requests/loginInsertRequest.model';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html',
  styleUrls: ['./auth.component.css']
})
export class AuthComponent implements OnInit {

  constructor(public service:AuthenticationService,public fb:FormBuilder,public route:Router) { }
  forma:FormGroup;
  data:any;

  ngOnInit(): void {
    if(this.service.isAuthenticated){
      this.route.navigate(["/"]);
    }
    this.initForm();
  }

  initForm(){
    this.forma=this.fb.group({
      username:["",[Validators.required]],
      password:["",Validators.required]
    })
  }
  dodaj(){
    if (this.forma.valid) {
      let login = new LoginInsertRequest(this.forma.get('username').value, this.forma.get('password').value);
      this.service.login(login).subscribe(data => {
        localStorage.setItem('token', data.token);
        this.service.myUserId = data.myUser?.id;
        this.service.isAuthenticated=true;
        this.route.navigate(['/']);
      });
      this.forma.reset();
    }
  }
}
