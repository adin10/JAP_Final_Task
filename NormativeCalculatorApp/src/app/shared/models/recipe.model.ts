import { IngredientRecipe } from "./ingredientRecipe.model";
import { MyUser } from "./myUser.model";
import { RecipeCategory } from "./recipeCategories.model";


export class Recipe{
    constructor(public id:number,
                public name:string,
                public description:string,
                public totalCost:number,
                public myUserId:number,
                public createdDate:Date,
                public recipeCategoryId:number,
                public recommendedPrice:number,
                public ingredientRecipes:IngredientRecipe[],
                public myUser:MyUser,
                public recipeCategory:RecipeCategory
                ){}
}
export class RecipeUpdateRequest{
    constructor(public Name:string,
                public Description:string,
                public RecipeCategoryId:number,
                public RecommendedPrice:number
                 ){}
}