import { Component, OnInit } from '@angular/core';
import { RecipeCategoriesService } from '../_services/recipeCategories.service';
import { RecipeCategory } from '../_shared/recipeCategories.model';
import{first} from 'rxjs/operators';

@Component({
  selector: 'app-recipe-categories',
  templateUrl: './recipe-categories.component.html',
  styleUrls: ['./recipe-categories.component.css']
})
export class RecipeCategoriesComponent implements OnInit {

  constructor(public service:RecipeCategoriesService) { }

  recipesCategoryList:RecipeCategory[]=[];
  number:number=2;

  public async ngOnInit(): Promise<void> {
    this.loadRecipeCategories();
  }

  public async loadRecipeCategories(){
    this.recipesCategoryList = await this.service.getRecipeCategories(this.number);
    this.number += this.number;
  }
}


// pipe(first()).
