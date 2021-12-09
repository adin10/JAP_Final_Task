import { NgModule} from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import{FormsModule,ReactiveFormsModule} from '@angular/forms';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RecipeCategoriesComponent } from './features/recipe-categories/recipe-categories.component';
import { IngredientsComponent } from './features/ingredients/ingredients.component';
import { NavMenuComponent } from './shared/nav-menu/nav-menu.component';
import { AuthComponent } from './core/auth/auth.component';
import { TokenInterceptorInterceptor } from './core/_interceptor/token-interceptor.interceptor';
import { AuthGuardGuard } from './core/_guards/auth-guard.guard';
import { MyUserComponent } from './features/my-user/my-user.component';
import{HomeComponent} from './features/home/home.component';
import { RecipeComponent } from './features/recipe/recipe.component';
import { AddRecipeComponent } from './features/add-recipe/add-recipe.component';
import { RecipeDetailsComponent } from './features/recipe-details/recipe-details.component';
import{PaginationModule} from 'ngx-bootstrap/pagination';

@NgModule({
  declarations: [
    AppComponent,
    RecipeCategoriesComponent,
    IngredientsComponent,
    NavMenuComponent,
    AuthComponent,
    MyUserComponent,
    HomeComponent,
    RecipeComponent,
    AddRecipeComponent,
    RecipeDetailsComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    PaginationModule.forRoot()
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
