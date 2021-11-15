import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddRecipeComponent } from './add-recipe/add-recipe.component';
import { AuthComponent } from './auth/auth.component';
import { HomeComponent } from './home/home.component';
import { IngredientsComponent } from './ingredients/ingredients.component';
import { RecipeCategoriesComponent } from './recipe-categories/recipe-categories.component';
import { RecipeDetailsComponent } from './recipe-details/recipe-details.component';
import { RecipeComponent } from './recipe/recipe.component';
import { AuthGuardGuard } from './_guards/auth-guard.guard';

const routes: Routes = [
  // canActivate:[AuthGuardGuard]
  { path: '', component: HomeComponent, pathMatch: 'full' },
  {path:'auth',component:AuthComponent},
  {path:'ingredient',component:IngredientsComponent,canActivate:[AuthGuardGuard]},
  {path:'recipeCategory',component:RecipeCategoriesComponent,canActivate:[AuthGuardGuard]},
  {path:'recipes/:id',component:RecipeComponent}, // preuzimanje svih recepata za odabraniu kategoriju
  {path:'addRecipe/:categoryId',component:AddRecipeComponent,canActivate:[AuthGuardGuard]},
  {path:'recipes/:categoryId/:recipeId',component:RecipeDetailsComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
