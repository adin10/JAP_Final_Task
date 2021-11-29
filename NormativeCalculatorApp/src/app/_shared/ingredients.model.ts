import { IngredientRecipe } from "./ingredientRecipe.model";
import { UnitMeasure } from "./requests/unitMeasure.enum";

export class Ingredient{
    constructor(public id:number,
                public name:string,
                // public measureUnit:string,
                public unitMeasure:UnitMeasure,
                public unitPrice:number,
                public unitQuantity:number,
                public ingredientRecipe:IngredientRecipe[]
        ){}
}
