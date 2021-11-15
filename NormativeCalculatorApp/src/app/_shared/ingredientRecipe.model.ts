import { Ingredients } from "./ingredients.model";
import { Recipe } from "./recipe.model";

export class IngredientRecipe{
   constructor(public ingredientRecipeId:number,public ingredientId:number,public recipeId:number,
            public quantity:number,public price:number,public ingredient:Ingredients,public recipe:Recipe            
    ){}
}


// public int IngredientRecipeId { get; set; }
// public int IngredientId { get; set; }
// public Ingredients Ingredient { get; set; }
// public int RecipeId { get; set; }
// public Recipe Recipe { get; set; }
// public float Quantity { get; set; }
// public float Price { get; set; }

// constructor(public recipeId:number,public recipeName:string,public description:string,
//     public ingredientId:number,public ingredientName:string,public measureUnit:string,
//    public unitPrice:number,public unitQuantity:number,public ingredientCost:number,public totalCost:number        
// ){}