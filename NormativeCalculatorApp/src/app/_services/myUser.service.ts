import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { MyUser } from "../_shared/myUser.model";

@Injectable({providedIn:'root'})
export class MyUserService{
constructor(public http:HttpClient){}

public getUsers(userId?:number){
     let params=new HttpParams()
     .set("UserID",userId != null ? userId.toString() : '')
     return this.http.get<MyUser[]>('https://localhost:5001/api/Users',{
         params:params
     }).toPromise();
 }
}