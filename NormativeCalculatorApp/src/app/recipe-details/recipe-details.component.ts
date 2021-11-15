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

  ingredientRecipeList:Recipe[]=[];
  constructor(public service:RecipeService,public route:ActivatedRoute) { }

  ngOnInit(): void {
    this.loadIngredientRecipeList();
  }

  loadIngredientRecipeList(){
    this.service.recipeDetails(this.route.snapshot.params.id).subscribe(data=>{
      this.ingredientRecipeList=data;
    })
  }

}


