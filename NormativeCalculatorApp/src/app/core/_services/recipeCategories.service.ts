import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { RecipeCategory } from "app/shared/entities/recipeCategories.model";

@Injectable({providedIn:'root'})
export class RecipeCategoriesService{
    constructor(public http:HttpClient){}

    public getRecipeCategories(number:number) :Promise<RecipeCategory[]> {
        let params=new HttpParams().set("number",number)
        return this.http.get<RecipeCategory[]>('https://localhost:5001/api/RecipeCategories',{
            params:params
        }).toPromise();
    }
    public getRecipeCategorieById(id){
        return this.http.get<RecipeCategory[]>('https://localhost:5001/api/RecipeCategories/'+id);
    }
}