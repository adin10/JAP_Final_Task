import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthComponent } from './core/auth/auth.component';
import { AddRecipeComponent } from './features/add-recipe/add-recipe.component';
import { IngredientsComponent } from './features/ingredients/ingredients.component';
import { RecipeCategoriesComponent } from './features/recipe-categories/recipe-categories.component';
import { RecipeDetailsComponent } from './features/recipe-details/recipe-details.component';
import { RecipeComponent } from './features/recipe/recipe.component';
import { HomeComponent } from './features/home/home.component';
import { AuthGuardGuard } from './core/_guards/auth-guard.guard';
import { AddIngredientComponent } from './features/add-ingredient/add-ingredient.component';
import { UpdateIngredientComponent } from './features/update-ingredient/update-ingredient.component';
import { AddCategoryComponent } from './features/add-category/add-category.component';
import { UpdateCategoryComponent } from './features/update-category/update-category.component';

const routes: Routes = [
  // canActivate:[AuthGuardGuard]
  { path: '', component: HomeComponent, pathMatch: 'full' },
  {path:'auth',component:AuthComponent},
  {path:'ingredient',component:IngredientsComponent},
  {path:'recipeCategory',component:RecipeCategoriesComponent},
  {path:'recipes/:id',component:RecipeComponent}, // preuzimanje svih recepata za odabraniu kategoriju
  {path:'addRecipe/:categoryId',component:AddRecipeComponent,canActivate:[AuthGuardGuard]},
  {path:'recipeDetails/:id',component:RecipeDetailsComponent},
  {path:"addIngredients",component:AddIngredientComponent},
  {path:"updateIngredient/:id",component:UpdateIngredientComponent,canActivate:[AuthGuardGuard]},
  {path:"addRecipeCategory",component:AddCategoryComponent,canActivate:[AuthGuardGuard]},
  {path:"updateCategory/:id",component:UpdateCategoryComponent,canActivate:[AuthGuardGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
