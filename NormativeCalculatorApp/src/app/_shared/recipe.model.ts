import { IngredientRecipe } from "./ingredientRecipe.model";
import { MyUser } from "./myUser.model";
import { RecipeCategory } from "./recipeCategories.model";

export class Recipe{
    constructor(public recipeId:number,public recipeName:string,
                public description:string,public totalCost:number,public myUserId:number,public createdDate:Date,
                    public recipeCategoryId:number,public ingredientRecipe:IngredientRecipe[],
                public myUser:MyUser,public recipeCategory:RecipeCategory){}
}

// public int RecipeId { get; set; }
// public string RecipeName { get; set; }
// public string Description { get; set; }
// public float TotalCost { get; set; }
// public int MyUserId { get; set; }
// public MyUser MyUser { get; set; }
// public int RecipeCategoryId { get; set; }
// public RecipeCategory RecipeCategory { get; set; }
// public ICollection<IngredientRecipe> IngredientRecipe { get; set; }