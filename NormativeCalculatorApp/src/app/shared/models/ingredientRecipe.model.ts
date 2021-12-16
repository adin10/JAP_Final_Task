import { Ingredient} from "./ingredients.model";
import { Recipe } from "./recipe.model";

export class IngredientRecipe{
    constructor(public id:number,
                public ingredientId:number,
                public recipeId:number,
                public price:number,
                public ingredientCost:number,
                public quantity:number,
                public ingredient:Ingredient,
                public recipe:Recipe            
            ){}
}
