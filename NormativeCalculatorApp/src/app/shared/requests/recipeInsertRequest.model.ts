import { IngredientRecipeInsertRequest } from "./ingredientRecipeInsertRequest.model";

export class RecipeInsertRequest{
    constructor(public Name:string,public Description:string,
            public RecipeCategoryId:number,public Ingredients:IngredientRecipeInsertRequest[]){}
}




