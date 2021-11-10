import { Injectable } from "@angular/core";
import { CanActivate, Router } from "@angular/router";
import { AuthenticationService } from "../_services/authentication.service";

@Injectable()
export class AuthGuardGuard implements CanActivate {
  constructor(public auth: AuthenticationService, public router: Router) { }
  canActivate(): boolean {    
    // auth guard u angularu sprijecava otvaranje ruta koje nisu autorizovane
    if (!this.auth.isAuthenticated) {
      this.router.navigate(['auth']);
      return false;
    }
    return true;
  }
} 