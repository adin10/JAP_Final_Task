import { UnitMeasure } from "../requests/unitMeasure.enum";
import { IngredientRecipe } from "./ingredientRecipe.model";

export class Ingredient{
    constructor(public id:number,
                public name:string,
                public unitMeasure:UnitMeasure, 
                public price:number,
                public unitQuantity:number,
                public unitPrice:number,
                public ingredientRecipe:IngredientRecipe[]
        ){}
}
