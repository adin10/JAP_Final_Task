import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { IngredientRecipeService } from '../_services/ingredientRecipe.service';
import { IngredientsService } from '../_services/ingredients.service';
import { MyUserService } from '../_services/myUser.service';
import { RecipeService } from '../_services/recipe.service';
import { RecipeCategoriesService } from '../_services/recipeCategories.service';
import { IngredientRecipe } from '../_shared/ingredientRecipe.model';
import { Ingredient } from '../_shared/ingredients.model';
import { MyUser } from '../_shared/myUser.model';
import { Recipe } from '../_shared/recipe.model';
import { RecipeCategory } from '../_shared/recipeCategories.model';
import { IngredientRecipeInsertRequest } from '../_shared/requests/ingredientRecipeInsertRequest.model';
import { RecipeInsertRequest } from '../_shared/requests/recipeInsertRequest.model';

@Component({
  selector: 'app-add-recipe',
  templateUrl: './add-recipe.component.html',
  styleUrls: ['./add-recipe.component.css']
})
export class AddRecipeComponent implements OnInit {
  @Input() categoryId:number;
  forma:FormGroup;
  n:number=10;
  recipeList:Recipe[]=[];
  ingredientRecipeList:IngredientRecipe[]=[];
  ingredientsList:Ingredient[]=[];
  categories:RecipeCategory[]=[];
  users:MyUser[]=[];
  
  selectedIngredients:number[]=[];
  public selectedIngredient:Ingredient[]=[];


  constructor(public router:Router,public service:RecipeService,public fb:FormBuilder,
    public categoryService:RecipeCategoriesService,public userService:MyUserService, 
    private route : ActivatedRoute,public ingredientRecipeService:IngredientRecipeService,
    public ingredientService:IngredientsService) { }

  ngOnInit(): void {
    this.getCategories();
    this.getUsers();
    // this.loadIngredientRecipe();
     this.loadIngredients();

   this.route.params.subscribe(
      (params : Params) => {

        this.categoryId = +params['categoryId'];
      

        if(!Number.isNaN(this.categoryId)  &&  this.categoryId != 0 ){
        this.service.getRecipe("",this.categoryId).then(
            res =>{
              // this. = res.title;
            }
          );
        }
      }
    );
    this.forma=this.fb.group({
      recipeName:[""],
      description:[""],
      totalCost:[""],
      IngredientId:[""],
      Quantity:[""]
      // myUserId:[""],
      // recipeCategoryId:[""]
    })
  }
  getCategories(){
    this.categoryService.getRecipeCategories(this.n).subscribe(data=>{
      this.categories=data;
      })
    }
    
      getUsers(){
        this.userService.getUsers().subscribe(data=>{
          this.users=data;
        })
      }
    
  addRecipe(){
    let recipe=new RecipeInsertRequest(this.forma.get('recipeName').value,
    this.forma.get('description').value,this.forma.get('totalCost').value,this.categoryId,
    new IngredientRecipeInsertRequest(this.forma.get('IngredientId').value,this.forma.get('Quantity').value));
    this.service.addRecipe(recipe).subscribe(data=>{
      // this.loadRecipes("");
    });
    this.forma.reset();
    this.router.navigate(["/recipe"]);
  }

 async loadRecipes(RecipeName:string){
  this.recipeList = await this.service.getRecipe("",this.categoryId);
  }

  loadIngredientRecipe(){
    this.ingredientRecipeService.getIngredientRecipe().subscribe((data)=>{
      this.ingredientRecipeList=data;
    })
  }
  loadIngredients(){
      this.ingredientService.getIngredients().subscribe(data=>{
        this.ingredientsList=data;
      })
  }
  addIngredients(){
    this.selectedIngredients.push(this.forma.get('IngredientId').value);
  }
}
