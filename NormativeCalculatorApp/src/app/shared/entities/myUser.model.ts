import { IdentityUser } from "./identityUser.model";

export class MyUser{
    constructor(public id:number,public firstName:string,public lastName:string,public user:IdentityUser){}
}

