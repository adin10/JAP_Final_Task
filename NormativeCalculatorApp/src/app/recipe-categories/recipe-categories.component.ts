import { Component, OnInit } from '@angular/core';
import { RecipeCategoriesService } from '../_services/recipeCategories.service';
import { RecipeCategory } from '../_shared/recipeCategories.model';

@Component({
  selector: 'app-recipe-categories',
  templateUrl: './recipe-categories.component.html',
  styleUrls: ['./recipe-categories.component.css']
})
export class RecipeCategoriesComponent implements OnInit {

  constructor(public service:RecipeCategoriesService) { }

  recipesCategoryList:RecipeCategory[]=[];

  ngOnInit(): void {
    this.loadRecipeCategories();
  }

  loadRecipeCategories(){
    this.service.getRecipeCategories().subscribe(data=>{
      this.recipesCategoryList=data;
    })
  }

}
