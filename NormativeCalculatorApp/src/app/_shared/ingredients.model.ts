import { IngredientRecipe } from "./ingredientRecipe.model";

export class Ingredients{
    constructor(public ingredientsID:number,
                public name:string,
                public measureUnit:string,
                public unitPrice:number,
                public unitQuantity:number,
                public ingredientRecipe:IngredientRecipe[]
        ){}
}
