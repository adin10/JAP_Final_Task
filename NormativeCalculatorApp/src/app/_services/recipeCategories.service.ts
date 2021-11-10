import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { RecipeCategory } from "../_shared/recipeCategories.model";

@Injectable({providedIn:'root'})
export class RecipeCategoriesService{
    constructor(public http:HttpClient){}

    getRecipeCategories(){
        return this.http.get<RecipeCategory[]>('https://localhost:5001/api/RecipeCategory');
    }
    getRecipeCategorieById(id){
        return this.http.get<RecipeCategory>('https://localhost:5001/api/RecipeCategory/'+id);
    }
}