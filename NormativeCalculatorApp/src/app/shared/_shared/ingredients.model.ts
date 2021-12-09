import { IngredientRecipe } from "../entities/ingredientRecipe.model";
import { UnitMeasure } from "../requests/unitMeasure.enum";


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
