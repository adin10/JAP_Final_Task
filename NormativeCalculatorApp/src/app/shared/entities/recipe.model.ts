import { IngredientRecipe } from "./ingredientRecipe.model";
import { MyUser } from "./myUser.model";
import { RecipeCategory } from "./recipeCategories.model";


export class Recipe{
    constructor(public id:number,public name:string,
                public description:string,public totalCost:number,public myUserId:number,public createdDate:Date,
                    public recipeCategoryId:number,public ingredientRecipes:IngredientRecipe[],
                public myUser:MyUser,public recipeCategory:RecipeCategory){}
}
