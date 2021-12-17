import { NgModule} from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import{FormsModule,ReactiveFormsModule} from '@angular/forms';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RecipeCategoriesComponent } from './features/recipe-categories/recipe-categories.component';
import { IngredientsComponent } from './features/ingredients/ingredients.component';
import { NavMenuComponent } from './shared/nav-menu/nav-menu.component';
import { TokenInterceptorInterceptor } from './core/interceptor/token-interceptor.interceptor';
import { MyUserComponent } from './features/my-user/my-user.component';
import{HomeComponent} from './features/home/home.component';
import { RecipeComponent } from './features/recipe/recipe.component';
import { AddRecipeComponent } from './features/add-recipe/add-recipe.component';
import { RecipeDetailsComponent } from './features/recipe-details/recipe-details.component';
import{PaginationModule} from 'ngx-bootstrap/pagination';
import { AddIngredientComponent } from './features/add-ingredient/add-ingredient.component';
import { UpdateIngredientComponent } from './features/update-ingredient/update-ingredient.component';
import { AddCategoryComponent } from './features/add-category/add-category.component';
import { UpdateCategoryComponent } from './features/update-category/update-category.component';
import {ToastrModule} from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import{MatSliderModule} from '@angular/material/slider';
import { NgxBootstrapConfirmModule } from 'ngx-bootstrap-confirm';
import { UpdateRecipeComponent } from './features/update-recipe/update-recipe.component';
import { AuthGuardGuard } from './core/guards/auth-guard.guard';
import { FeaturesModule } from './features/features.module';
import { CoreModule } from './core/core.module';
import { SharedModule } from './shared/shared.module';

@NgModule({
  declarations: [
    AppComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FeaturesModule,
    CoreModule,
    SharedModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatSliderModule,
    NgxBootstrapConfirmModule,
    PaginationModule.forRoot(),
    ToastrModule.forRoot({
      positionClass:'toast-top-right'
    })
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
