import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Recipe } from "app/shared/entities/recipe.model";
import { RecipeInsertRequest } from "app/shared/requests/recipeInsertRequest.model";
@Injectable({providedIn:'root'})
export class RecipeService{
    constructor(public http:HttpClient){}
    
    getRecipe(searchTerm:string,categoryId:number,number:number ):Promise<Recipe[]>{
        let params=new HttpParams()
        .set("SearchTerm",searchTerm)
        .set("categoryId",categoryId)
        .set("number",number);
        return this.http.get<Recipe[]>('https://localhost:5001/api/Recipes',{
            params:params
        }).toPromise();
    }
    getById(id){
        return this.http.get<Recipe>('https://localhost:5001/api/Recipes/'+id);
    }
    addRecipe(recipe:RecipeInsertRequest){
        return this.http.post('https://localhost:5001/api/Recipes',recipe);
    }
    recipeDetails(id){
        return this.http.get<Recipe>('https://localhost:5001/api/Recipes/RecipeDetails/' +id);
    }

    
}