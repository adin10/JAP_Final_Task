import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Ingredient } from "app/shared/entities/ingredients.model";
import { PaginatedResult } from "app/shared/entities/pagination.model";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";

@Injectable({providedIn:'root'})

export class IngredientsService{
    paginatedResult:PaginatedResult<Ingredient[]> = new PaginatedResult<Ingredient[]>();

    constructor(public http:HttpClient){}

    getIngredients(page?:number, itemsPerPage?:number){
        let params=new HttpParams();
        if(page!==null && itemsPerPage!==null){
            params=params.append('pageNumber',page.toString());
            params=params.append('pageSize',itemsPerPage.toString());
        }
        return this.http.get<Ingredient[]>('https://localhost:5001/api/Ingredients',
        {observe:'response',params}).pipe(map(response=>{
            this.paginatedResult.result=response.body;
            if(response.headers.get('Pagination')!==null){
                this.paginatedResult.pagiation=JSON.parse(response.headers.get('Pagination'));
            }
            return this.paginatedResult;
        }));
    }
}