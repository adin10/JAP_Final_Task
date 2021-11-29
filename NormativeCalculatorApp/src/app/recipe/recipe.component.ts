import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { RecipeService } from '../_services/recipe.service';
import { Recipe } from '../_shared/recipe.model';

@Component({
  selector: 'app-recipe',
  templateUrl: './recipe.component.html',
  styleUrls: ['./recipe.component.css']
})
export class RecipeComponent implements OnInit {

  recipeList:Recipe[]=[];
  SearchTerm:string="";
  categoryId:number;
  number:number=5;

  constructor(public service:RecipeService,private router:Router,private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.categoryId=Number(this.route.snapshot.paramMap.get('id'));
    this.loadRecipes(this.SearchTerm,this.categoryId);
   
  }

  async loadRecipes(SearchTerm:string,categoryId:number){
    this.recipeList = await this.service.getRecipe(SearchTerm,this.categoryId);
  }
  Search(){
    this.loadRecipes(this.SearchTerm,this.categoryId);
  }



}
