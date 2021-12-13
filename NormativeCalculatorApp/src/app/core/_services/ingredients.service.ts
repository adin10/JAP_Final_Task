import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Ingredient, IngredientSearchRequest } from "app/shared/entities/ingredients.model";
import { PaginatedResult } from "app/shared/entities/pagination.model";
import { IngredientRestUpsertRequest } from "app/shared/requests/ingredientRestUpsertRequests.model";
import { UnitMeasure } from "app/shared/requests/unitMeasure.enum";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";

@Injectable({providedIn:'root'})

export class IngredientsService{
    paginatedResult:PaginatedResult<Ingredient[]> = new PaginatedResult<Ingredient[]>();

    constructor(public http:HttpClient){}

    getIngredients(searchRequest?:IngredientSearchRequest, page?:number, itemsPerPage?:number){
        let params=new HttpParams()
        .set('pageNumber',page.toString())
        .set('pageSize',itemsPerPage.toString())
        .set("Name",searchRequest.name)
        .set("Quantity",searchRequest.quantity)
        .set("UnitMeasure",searchRequest.unitMeasure)
        return this.http.get<Ingredient[]>('https://localhost:5001/api/Ingredients',
        {observe:'response',params}).pipe(map(response=>{
            this.paginatedResult.result=response.body;
            if(response.headers.get('Pagination')!==null){
                this.paginatedResult.pagiation=JSON.parse(response.headers.get('Pagination'));
            }
            return this.paginatedResult;
        }));
    }

    getById(id:number){
        return this.http.get<Ingredient>('https://localhost:5001/api/Ingredients/'+id);
    }
    addIngredient(ingredient:IngredientRestUpsertRequest){
        return this.http.post('https://localhost:5001/api/Ingredients',ingredient);
    }

    deleteIngredient(id:number){
        return this.http.delete<Ingredient>('https://localhost:5001/api/Ingredients/'+id);
    }

    updateIngredient(id,ingredeint:IngredientRestUpsertRequest){
        return this.http.put('https://localhost:5001/api/Ingredients/'+id,ingredeint);
    }
}


