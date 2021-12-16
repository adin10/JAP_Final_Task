import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { MyUser } from "app/shared/models/myUser.model";
import { environment } from "environments/environment";

@Injectable({providedIn:'root'})
export class MyUserService{
    endPoint:string='Users';
constructor(public http:HttpClient){}

public getUsers(userId?:number){
     let params=new HttpParams()
     .set("UserID",userId != null ? userId.toString() : '')
     return this.http.get<MyUser[]>(`${environment.apiUrl}${this.endPoint}`,{
         params:params
     }).toPromise();
 }
}