import { HttpClient, HttpClientModule } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { IngredientRecipe } from "app/shared/models/ingredientRecipe.model";
import { environment } from "environments/environment";
@Injectable({providedIn:'root'})
export class IngredientRecipeService{
    endPoint:string='ingredientRecipes';
    constructor(public http:HttpClient){}

    getIngredientRecipe(){
        return this.http.get<IngredientRecipe[]>(`${environment.apiUrl}${this.endPoint}`)
    }
}