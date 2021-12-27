import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MyUserComponent } from './my-user/my-user.component';
import { HomeComponent } from './home/home.component';
import { RecipeComponent } from './recipe/recipe.component';
import { AddRecipeComponent } from './add-recipe/add-recipe.component';
import { RecipeDetailsComponent } from './recipe-details/recipe-details.component';
import { AddIngredientComponent } from './add-ingredient/add-ingredient.component';
import { UpdateIngredientComponent } from './update-ingredient/update-ingredient.component';
import { AddCategoryComponent } from './add-category/add-category.component';
import { UpdateCategoryComponent } from './update-category/update-category.component';
import { UpdateRecipeComponent } from './update-recipe/update-recipe.component';
import { RecipeCategoriesComponent } from './recipe-categories/recipe-categories.component';
import { IngredientsComponent } from './ingredients/ingredients.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from 'app/app-routing.module';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { AuthComponent } from './auth/auth.component';
import {MatTableModule} from '@angular/material/table';
import { PagedIngredientsComponent } from './paged-ingredients/paged-ingredients.component';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import{MatInputModule} from "@angular/material/input";
import{MatProgressSpinnerModule} from "@angular/material/progress-spinner";
 


@NgModule({
  declarations: [
    MyUserComponent,
    HomeComponent,
    RecipeComponent,
    AddRecipeComponent,
    RecipeDetailsComponent,
    AddIngredientComponent,
    UpdateIngredientComponent,
    AddCategoryComponent,
    UpdateCategoryComponent,
    UpdateRecipeComponent,
    RecipeCategoriesComponent,
    IngredientsComponent,
    AuthComponent,
    PagedIngredientsComponent
  ],
  imports: [
    CommonModule,
    AppRoutingModule,
    FormsModule,
    MatTableModule,
    MatInputModule,
    MatPaginatorModule,
    MatProgressSpinnerModule,
    MatSortModule,
    ReactiveFormsModule,
    PaginationModule.forRoot(),
  ]
})
export class FeaturesModule { }
