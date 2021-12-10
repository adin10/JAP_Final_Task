import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { RecipeCategory } from "app/shared/entities/recipeCategories.model";
import { RecipeCategoryUpsertRequest } from "app/shared/requests/categoryUpsertRequest.model";

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
        return this.http.get<RecipeCategory>('https://localhost:5001/api/RecipeCategories/'+id);
    }

    public addCategory(category:RecipeCategoryUpsertRequest){
        return this.http.post('https://localhost:5001/api/RecipeCategories',category);
    }

    public deleteCategory(id:number){
        return this.http.delete<RecipeCategory>('https://localhost:5001/api/RecipeCategories/'+id);
    }

    public updateCategory(id,category:RecipeCategoryUpsertRequest){
        return this.http.put('https://localhost:5001/api/RecipeCategories/'+id,category);
    }
}