import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Recipe } from "../_shared/recipe.model";
import { RecipeInsertRequest } from "../_shared/requests/recipeInsertRequest.model";
@Injectable({providedIn:'root'})
export class RecipeService{
    constructor(public http:HttpClient){}

    getRecipe(searchTerm:string,categoryId:number ){
        let params=new HttpParams()
        .set("SearchTerm",searchTerm)
        .set("categoryId",categoryId);
        return this.http.get<Recipe[]>('https://localhost:5001/api/Recipe',{
            params:params
        });
    }
    getById(id){
        return this.http.get<Recipe>('https://localhost:5001/api/Recipe/'+id);
    }
    addRecipe(recipe:RecipeInsertRequest){
        return this.http.post('https://localhost:5001/api/Recipe',recipe);
    }
}