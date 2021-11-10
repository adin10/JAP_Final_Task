import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Recipe } from "../_shared/recipe.model";
@Injectable({providedIn:'root'})
export class RecipeService{
    constructor(public http:HttpClient){}

    getRecipe(recipeName:string){
        let params=new HttpParams()
        .set("RecipeName",recipeName);
        return this.http.get<Recipe[]>('https://localhost:5001/api/Recipe',{
            params:params
        });
    }
}