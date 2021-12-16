import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { RecipeCategory } from "app/shared/models/recipeCategories.model";
import { RecipeCategoryUpsertRequest } from "app/shared/requests/categoryUpsertRequest.model";
import { environment } from "environments/environment";

@Injectable({providedIn:'root'})
export class RecipeCategoriesService{
    endPoint:string="RecipeCategories";
    constructor(public http:HttpClient){}

    public getRecipeCategories(number:number) :Promise<RecipeCategory[]> {
        let params=new HttpParams().set("number",number)
        return this.http.get<RecipeCategory[]>(`${environment.apiUrl}${this.endPoint}`,{
            params:params
        }).toPromise();
    }
    public getRecipeCategorieById(id){
        return this.http.get<RecipeCategory>(`${environment.apiUrl}${this.endPoint}/${id}`);
    }

    public addCategory(category:RecipeCategoryUpsertRequest){
        return this.http.post(`${environment.apiUrl}${this.endPoint}`,category);
    }

    public deleteCategory(id:number){
        return this.http.delete<RecipeCategory>(`${environment.apiUrl}${this.endPoint}/${id}`);
    }

    public updateCategory(id,category:RecipeCategoryUpsertRequest){
        return this.http.put(`${environment.apiUrl}${this.endPoint}/${id}`,category);
    }
}