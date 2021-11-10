import { IdentityUser } from "./identityUser.model";

export class MyUser{
    constructor(public myUserId:number,public firstName:string,public lastName:string,public user:IdentityUser){}
}

// public int MyUserId { get; set; }
//         public string FirstName { get; set; }
//         public string LastName { get; set; }
//         public int UserId { get; set; }
//         public IdentityUser<int> User { get; set; }