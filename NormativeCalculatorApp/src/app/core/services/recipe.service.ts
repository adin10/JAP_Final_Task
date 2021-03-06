import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Recipe, RecipeUpdateRequest } from "app/shared/models/recipe.model";
import { RecipeInsertRequest } from "app/shared/requests/recipeInsertRequest.model";
import { environment } from "environments/environment";
@Injectable({providedIn:'root'})
export class RecipeService{
    endpoint: string = 'Recipes';

    constructor(public http:HttpClient){}
    
    getRecipe(searchTerm:string,categoryId:number,number:number ):Promise<Recipe[]>{
        let params=new HttpParams()
        .set("SearchTerm",searchTerm)
        .set("categoryId",categoryId)
        .set("number",number);
        return this.http.get<Recipe[]>(`${environment.apiUrl}${this.endpoint}`,{
            params:params
        }).toPromise();
    }
    getById(id){
        return this.http.get<Recipe>(`${environment.apiUrl}${this.endpoint}/${id}`);
    }
    addRecipe(recipe:RecipeInsertRequest){
        return this.http.post('https://localhost:5001/api/Recipes',recipe);
    }
    recipeDetails(id){
        return this.http.get<Recipe>(`${environment.apiUrl}${this.endpoint+'/recipeDetails'}/${id}`);
    }
    public deleteRecipe(id){
        return this.http.delete<Recipe>(`${environment.apiUrl}${this.endpoint}/${id}`);
    }
    updateRecipe(id:number,request:RecipeUpdateRequest){
        return this.http.put(`${environment.apiUrl}${this.endpoint}/${id}`,request);
    }

    
}