import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RecipeService } from 'app/core/_services/recipe.service';
import { IngredientRecipe } from 'app/shared/entities/ingredientRecipe.model';
import { Recipe } from 'app/shared/entities/recipe.model';


@Component({
  selector: 'app-recipe-details',
  templateUrl: './recipe-details.component.html',
  styleUrls: ['./recipe-details.component.css']
})
export class RecipeDetailsComponent implements OnInit {

  ingredientRecipeList:IngredientRecipe[]=[];
  recipe:Recipe = {} as Recipe;
  Recipeid:number;
 
  constructor(public service:RecipeService,public route:ActivatedRoute) { }

  async ngOnInit(): Promise<void> {
    this.Recipeid=Number(this.route.snapshot.params.id);
    this.recipe = await this.loadIngredientRecipeList();
    console.log(this.recipe);
  }

  async loadIngredientRecipeList(){
  
    return await this.service.recipeDetails(this.Recipeid).toPromise();
    
  }

}


