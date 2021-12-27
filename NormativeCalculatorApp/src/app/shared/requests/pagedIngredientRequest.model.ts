import { IngredientSearchRequest } from "../models/ingredients.model";

export class PagedIngredientRequest{
    constructor(public Page:number, public PageSize:number,public Search:IngredientSearchRequest, public SortBy:string){}
}


// public int Page { get; set; }
// public int PageSize { get; set; }
// public IngredientSearchRequest Search { get;set; }
// public string SortBy { get; set; }
// public SortOrder SortOrder { get; set; }