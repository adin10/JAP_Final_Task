import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthGuardGuard } from './guards/auth-guard.guard';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { TokenInterceptorInterceptor } from './interceptor/token-interceptor.interceptor';

@NgModule({
  declarations: [
  ],
  imports: [
    CommonModule,
    HttpClientModule,
  ],
  providers: [
    AuthGuardGuard,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: TokenInterceptorInterceptor,
      multi: true
    }
  ],
})
export class CoreModule { }
