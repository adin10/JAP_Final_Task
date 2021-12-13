import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { RecipeService } from 'app/core/_services/recipe.service';
import { Recipe } from 'app/shared/entities/recipe.model';


@Component({
  selector: 'app-recipe',
  templateUrl: './recipe.component.html',
  styleUrls: ['./recipe.component.css']
})
export class RecipeComponent implements OnInit {
  number:number=100;
  recipeList:Recipe[]=[];
  SearchTerm:string="";
  categoryId:number;
  

  constructor(public service:RecipeService,private router:Router,private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.categoryId=Number(this.route.snapshot.paramMap.get('id'));
    this.loadRecipes(this.SearchTerm,this.categoryId);
  }

  async loadRecipes(SearchTerm:string,categoryId:number){
    this.recipeList = await this.service.getRecipe(SearchTerm,this.categoryId,this.number);
    this.number+=10;
  }
  Search(){
    this.loadRecipes(this.SearchTerm,this.categoryId);
    console.log(this.loadRecipes(this.SearchTerm,this.categoryId));
  }



}
