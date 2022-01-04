import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Ingredient, IngredientSearchRequest } from "app/shared/models/ingredients.model";
import { PaginatedResult } from "app/shared/models/pagination.model";
import { IngredientRestUpsertRequest } from "app/shared/requests/ingredientRestUpsertRequests.model";
import { PagedIngredientRequest } from "app/shared/requests/pagedIngredientRequest.model";
import { environment } from "environments/environment";
import { map } from "rxjs/operators";

@Injectable({providedIn:'root'})

export class IngredientsService{
    endpoint: string = 'Ingredients'
    paginatedResult:PaginatedResult<Ingredient[]> = new PaginatedResult<Ingredient[]>();

    constructor(public http:HttpClient){}

    getIngredients(number?:number,page?:number, itemsPerPage?:number,
        searchRequest?:IngredientSearchRequest,orderBy?:string){
        let params=new HttpParams()
        .set("Name",searchRequest?.name??'')
        .set("Quantity",searchRequest?.quantity??'')
        .set("UnitMeasure",searchRequest?.unitMeasure??'')
        .set("number",number??'')
        .set("OrderBy",orderBy??'')
        // .set('pageNumber',page.toString())
        // .set('pageSize',itemsPerPage.toString())
        if(page!==null && itemsPerPage!==null){
            params=params.append('pageNumber',page.toString()),
         params=params.append('pageSize',itemsPerPage.toString())
         }
    
        return this.http.get<Ingredient[]>(`${environment.apiUrl}${this.endpoint}`,
        {observe:'response',params})
        .pipe(map(response=>{
            this.paginatedResult.result=response.body;
            if(response.headers.get('Pagination')!==null){
                this.paginatedResult.pagiation=JSON.parse(response.headers.get('Pagination'));
            }
            return this.paginatedResult;
        }));
    }

 
    getPaginateIngredients(request:PagedIngredientRequest){
         let params=new HttpParams()
        .set("Page",request.Page)
        .set("PageSize",request.PageSize)
        .set("Name",request.Search.name)
        .set("Quantity",request.Search.quantity??'')
        .set("UnitMeasure",request.Search.unitMeasure??'')
        return this.http.get<Ingredient[]>(`${environment.apiUrl}${this.endpoint+ '/getPagedIngredients'}`,{
            params:params
        });
    }


    getAngularMaterialPagination(searchRequest:IngredientSearchRequest){
        let params=new HttpParams()
        .set("Name",searchRequest.name)
        .set("Quantity",searchRequest.quantity??'')
        .set("UnitMeasure",searchRequest.unitMeasure??'')
        return this.http.get<Ingredient[]>(`${environment.apiUrl}${this.endpoint+ '/getAngularMaterialPagination'}`,{
            params:params
        });
    }

    getById(id:number){
        return this.http.get<Ingredient>(`${environment.apiUrl}${this.endpoint}/${id}`);
    }
    addIngredient(ingredient:IngredientRestUpsertRequest){
        return this.http.post(`${environment.apiUrl}${this.endpoint}`,ingredient);
    }

    deleteIngredient(id:number){
        return this.http.delete<Ingredient>(`${environment.apiUrl}${this.endpoint}/${id}`);
    }

    updateIngredient(id,ingredeint:IngredientRestUpsertRequest){
        return this.http.put(`${environment.apiUrl}${this.endpoint}/${id}`,ingredeint);
    }
}