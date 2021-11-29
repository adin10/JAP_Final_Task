import { IngredientRecipeInsertRequest } from "./ingredientRecipeInsertRequest.model";

export class RecipeInsertRequest{
    constructor(public Name:string,public Description:string,
            public RecipeCategoryId:number,public Ingredients:IngredientRecipeInsertRequest[]){}
}




// prijasnje
// export class RecipeInsertRequest{
//     constructor(public RecipeName:string,public Description:string,public TotalCost:number,
//             public RecipeCategoryId:number){}
// }
