import { Component, OnInit } from '@angular/core';
import { RecipeCategoriesService } from 'app/core/_services/recipeCategories.service';
import { RecipeCategory } from 'app/shared/entities/recipeCategories.model';

import{first} from 'rxjs/operators';

@Component({
  selector: 'app-recipe-categories',
  templateUrl: './recipe-categories.component.html',
  styleUrls: ['./recipe-categories.component.css']
})
export class RecipeCategoriesComponent implements OnInit {

  constructor(public service:RecipeCategoriesService) { }

  recipesCategoryList:RecipeCategory[]=[];
  number:number=10;

  public async ngOnInit(): Promise<void> {
    this.loadRecipeCategories();
  }

  public async loadRecipeCategories(){
    this.recipesCategoryList = await this.service.getRecipeCategories(this.number);
    this.number += 10;
  }

  deleteCategory(item){
    this.service.deleteCategory(item).subscribe(data=>{
      this.loadRecipeCategories();
    })
  }
}


