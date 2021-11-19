import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Ingredient } from "../_shared/ingredients.model";

@Injectable({providedIn:'root'})
export class IngredientsService{
    constructor(public http:HttpClient){}

    getIngredients(){
        return this.http.get<Ingredient[]>('https://localhost:5001/api/Ingredients');
    }
}