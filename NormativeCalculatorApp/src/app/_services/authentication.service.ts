import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { AuthenticationResult } from "../_shared/authenticationResult.model";
import { LoginInsertRequest } from "../_shared/requests/loginInsertRequest.model";

@Injectable({providedIn:'root'})
export class AuthenticationService{

    public isAuthenticated = false;
    public myUserId = null;
constructor(public http:HttpClient,public router:Router){
    this.isAuthenticated = localStorage.getItem('token') != null 
    && localStorage.getItem('token') != undefined && localStorage.getItem('token') != "";
};

    login(request:LoginInsertRequest){
        return this.http.post<AuthenticationResult>('https://localhost:5001/api/Authentication/Login',request);
    }

    LogOut(){
        localStorage.removeItem('token');
        this.router.navigate(['/auth']);
    }

}