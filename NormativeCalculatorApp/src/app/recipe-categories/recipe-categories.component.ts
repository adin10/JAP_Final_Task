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

  ngOnInit(): void {
    this.loadRecipeCategories();
  }

  loadRecipeCategories(){
    this.service.getRecipeCategories(this.number).subscribe(data=>{
      this.recipesCategoryList=data;
      this.number += this.number;
    })
  }
}


// pipe(first()).
