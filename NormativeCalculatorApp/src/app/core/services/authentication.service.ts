import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { AuthenticationResult } from "app/shared/models/authenticationResult.model";
import { LoginInsertRequest } from "app/shared/requests/loginInsertRequest.model";
import { environment } from "environments/environment";


@Injectable({providedIn:'root'})

export class AuthenticationService{
    endpoint: string = 'Authentication'
    public isAuthenticated = false;
    public myUserId = null;
constructor(public http:HttpClient,public router:Router){
    this.isAuthenticated = localStorage.getItem('token') != null 
    && localStorage.getItem('token') != undefined && localStorage.getItem('token') != "";
};

    login(request:LoginInsertRequest){
        return this.http.post<AuthenticationResult>(`${environment.apiUrl}${this.endpoint+'/login'}`,request);
    }

    LogOut(){
        localStorage.removeItem('token');
        this.router.navigate(['/auth']);
    }

}