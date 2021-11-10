import { Component, OnInit } from '@angular/core';
import { RecipeService } from '../_services/recipe.service';
import { Recipe } from '../_shared/recipe.model';

@Component({
  selector: 'app-recipe',
  templateUrl: './recipe.component.html',
  styleUrls: ['./recipe.component.css']
})
export class RecipeComponent implements OnInit {

  recipeList:Recipe[]=[];
  RecipeName:string="";
  constructor(public service:RecipeService) { }

  ngOnInit(): void {
    this.loadRecipes(this.RecipeName);
  }

  loadRecipes(RecipeName:string){
    this.service.getRecipe(RecipeName).subscribe(data=>{
      this.recipeList=data;
    })
  }

}
