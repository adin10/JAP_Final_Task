import { HttpClient, HttpClientModule } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { IngredientRecipe } from "app/shared/entities/ingredientRecipe.model";
@Injectable({providedIn:'root'})
export class IngredientRecipeService{
    constructor(public http:HttpClient){}

    getIngredientRecipe(){
        return this.http.get<IngredientRecipe[]>('https://localhost:5001/api/ingredientRecipes')
    }
}