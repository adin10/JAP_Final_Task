import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RecipeService } from '../_services/recipe.service';
import { IngredientRecipe } from '../_shared/ingredientRecipe.model';
import { Recipe } from '../_shared/recipe.model';

@Component({
  selector: 'app-recipe-details',
  templateUrl: './recipe-details.component.html',
  styleUrls: ['./recipe-details.component.css']
})
export class RecipeDetailsComponent implements OnInit {

  ingredientRecipeList:IngredientRecipe[]=[];
  recipe:Recipe = {} as Recipe;
  recipeId:number;
 
  constructor(public service:RecipeService,public route:ActivatedRoute) { }

  async ngOnInit(): Promise<void> {
    this.recipeId=Number(this.route.snapshot.params.id);
    this.recipe = await this.loadIngredientRecipeList();
    console.log(this.recipe);
  }

  async loadIngredientRecipeList():Promise<Recipe>{
  
    return await this.service.recipeDetails(this.recipeId).toPromise();
    
  }

}


