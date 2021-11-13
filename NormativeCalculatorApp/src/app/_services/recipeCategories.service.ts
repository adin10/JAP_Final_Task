import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { RecipeCategory } from "../_shared/recipeCategories.model";

@Injectable({providedIn:'root'})
export class RecipeCategoriesService{
    constructor(public http:HttpClient){}

    getRecipeCategories(number:number){
        let params=new HttpParams().set("number",number)
        return this.http.get<RecipeCategory[]>('https://localhost:5001/api/RecipeCategory',{
            params:params
        });
    }
    getRecipeCategorieById(id){
        return this.http.get<RecipeCategory[]>('https://localhost:5001/api/RecipeCategory/'+id);
    }
}