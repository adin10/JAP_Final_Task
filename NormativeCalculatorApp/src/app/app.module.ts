import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import{FormsModule,ReactiveFormsModule} from '@angular/forms';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RecipeCategoriesComponent } from './recipe-categories/recipe-categories.component';
import { IngredientsComponent } from './ingredients/ingredients.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { AuthComponent } from './auth/auth.component';
import { TokenInterceptorInterceptor } from './_interceptor/token-interceptor.interceptor';
import { AuthGuardGuard } from './_guards/auth-guard.guard';
import { MyUserComponent } from './my-user/my-user.component';
import{HomeComponent} from './home/home.component';
import { RecipeComponent } from './recipe/recipe.component'

@NgModule({
  declarations: [
    AppComponent,
    RecipeCategoriesComponent,
    IngredientsComponent,
    NavMenuComponent,
    AuthComponent,
    MyUserComponent,
    HomeComponent,
    RecipeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
    
  ],
  providers: [
    AuthGuardGuard,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: TokenInterceptorInterceptor,
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
