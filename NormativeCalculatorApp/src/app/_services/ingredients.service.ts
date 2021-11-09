import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Ingredients } from "../_shared/ingredients.model";

@Injectable({providedIn:'root'})
export class IngredientsService{
    constructor(public http:HttpClient){}

    getIngredients(){
        return this.http.get<Ingredients[]>('https://localhost:5001/api/Ingredient');
    }
}