import { IngredientRecipeInsertRequest } from "./ingredientRecipeInsertRequest.model";

export class RecipeInsertRequest{
    constructor(public Name:string,public Description:string,public TotalCost:number,
            public RecipeCategoryId:number,public Ingredientss:IngredientRecipeInsertRequest){}
}




// prijasnje
// export class RecipeInsertRequest{
//     constructor(public RecipeName:string,public Description:string,public TotalCost:number,
//             public RecipeCategoryId:number){}
// }
