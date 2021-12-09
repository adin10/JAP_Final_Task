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

const routes: Routes = [
  // canActivate:[AuthGuardGuard]
  { path: '', component: HomeComponent, pathMatch: 'full' },
  {path:'auth',component:AuthComponent},
  {path:'ingredient',component:IngredientsComponent,canActivate:[AuthGuardGuard]},
  {path:'recipeCategory',component:RecipeCategoriesComponent,canActivate:[AuthGuardGuard]},
  {path:'recipes/:id',component:RecipeComponent}, // preuzimanje svih recepata za odabraniu kategoriju
  {path:'addRecipe/:categoryId',component:AddRecipeComponent,canActivate:[AuthGuardGuard]},
  // {path:'recipes/:categoryId/:recipeId',component:RecipeDetailsComponent},
  {path:'recipeDetails/:id',component:RecipeDetailsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
