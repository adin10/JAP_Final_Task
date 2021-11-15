import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { MyUserService } from '../_services/myUser.service';
import { RecipeService } from '../_services/recipe.service';
import { RecipeCategoriesService } from '../_services/recipeCategories.service';
import { MyUser } from '../_shared/myUser.model';
import { Recipe } from '../_shared/recipe.model';
import { RecipeCategory } from '../_shared/recipeCategories.model';
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
  categories:RecipeCategory[]=[];
  users:MyUser[]=[];
  constructor(public router:Router,public service:RecipeService,public fb:FormBuilder,
    public categoryService:RecipeCategoriesService,public userService:MyUserService, private route : ActivatedRoute) { }

  ngOnInit(): void {
    this.getCategories();
    this.getUsers();

    this.route.params.subscribe(
      (params : Params) => {

        this.categoryId = +params['categoryId'];
      

        if(!Number.isNaN(this.categoryId)  &&  this.categoryId != 0 ){
          this.service.getRecipe("",this.categoryId).subscribe(
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
    this.forma.get('description').value,this.forma.get('totalCost').value,
    this.categoryId);
    this.service.addRecipe(recipe).subscribe(data=>{
      // this.loadRecipes("");
    });
    this.forma.reset();
    this.router.navigate(["/recipe"]);
  }

  loadRecipes(RecipeName:string){
    this.service.getRecipe(RecipeName,null).subscribe(data=>{
      this.recipeList=data;
    })
  }
}
