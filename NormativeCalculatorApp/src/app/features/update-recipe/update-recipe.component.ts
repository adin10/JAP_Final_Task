import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { IngredientRecipeService } from 'app/core/services/ingredientRecipe.service';
import { IngredientsService } from 'app/core/services/ingredients.service';
import { MyUserService } from 'app/core/services/myUser.service';
import { RecipeService } from 'app/core/services/recipe.service';
import { RecipeCategoriesService } from 'app/core/services/recipeCategories.service';
import { Ingredient, IngredientSearchRequest } from 'app/shared/models/ingredients.model';
import { MyUser } from 'app/shared/models/myUser.model';
import { Recipe, RecipeUpdateRequest } from 'app/shared/models/recipe.model';
import { RecipeCategory } from 'app/shared/models/recipeCategories.model';
import { UnitMeasure } from 'app/shared/requests/unitMeasure.enum';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-update-recipe',
  templateUrl: './update-recipe.component.html',
  styleUrls: ['./update-recipe.component.css']
})
export class UpdateRecipeComponent implements OnInit {
  @Input() categoryId: number;
  forma: FormGroup;
  recipe:Recipe;
  n: number = 10;

  ingredientsList:Ingredient[]=[];
  public recipeList: Recipe[] = [];
  public categories: RecipeCategory[] = [];
  public users: MyUser[] = [];
  public unitMeasures: any[] = [
    {
      name: "kg",
      value: UnitMeasure.kg
    },
    {
      name: "g",
      value: UnitMeasure.g
    },
    {
      name: "kom",
      value: UnitMeasure.kom
    },
    {
      name: "l",
      value: UnitMeasure.l
    },
    {
      name: "ml",
      value: UnitMeasure.ml
    }
  ]
  constructor(private toastr:ToastrService, public router: Router, public service: RecipeService, public fb: FormBuilder,
    public categoryService: RecipeCategoriesService, public userService: MyUserService,
    private route: ActivatedRoute, public ingredientRecipeService: IngredientRecipeService,
    public ingredientService: IngredientsService) {
      this.forma = this.fb.group({
        recipeName: [""],
        description: [""],
        recommendedPrice:[""],
      
      });
     }

  ngOnInit(): void {
    this.route.params.subscribe(
      (params: Params) => {

        this.categoryId = +params['categoryId'];
      }
    );
    this.loadIngredients();
  }
  loadIngredients(){
    this.ingredientService.getIngredients(100,1,100).subscribe(data=>{
      this.ingredientsList=data.result;
      console.log(this.ingredientsList);
    })

    this.service.getById(this.route.snapshot.params.id).subscribe((data)=>{
      this.recipe=data;
      console.log(this.recipe);
      console.log(data);
      this.forma=new FormGroup({
        recipeName:new FormControl(data['name']),
        description:new FormControl(data['description']),
        recommendedPrice:new FormControl(data['recommendedPrice'])
      })
    })
  }
  public save(){
    // console.log(this.forma.get('ingredients').value);
    let dataParams=new RecipeUpdateRequest(this.forma.get('recipeName').value,
    this.forma.get('description').value,
    this.categoryId,this.forma.get('recommendedPrice').value);        
      this.service.updateRecipe(this.route.snapshot.params.id,dataParams).subscribe(data=>{
        this.toastr.success("Successfully updated")
        this.router.navigate(["/recipeCategory"]);
      },
      (error)=>{
        this.toastr.error("Something went wrong");
      })
  }

}
