import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { IngredientRecipeService } from 'app/core/services/ingredientRecipe.service';
import { IngredientsService } from 'app/core/services/ingredients.service';
import { MyUserService } from 'app/core/services/myUser.service';
import { RecipeService } from 'app/core/services/recipe.service';
import { RecipeCategoriesService } from 'app/core/services/recipeCategories.service';
import { Ingredient } from 'app/shared/models/ingredients.model';
import { MyUser } from 'app/shared/models/myUser.model';
import { Recipe } from 'app/shared/models/recipe.model';
import { RecipeCategory } from 'app/shared/models/recipeCategories.model';
import { RecipeInsertRequest } from 'app/shared/requests/recipeInsertRequest.model';
import { UnitMeasure } from 'app/shared/requests/unitMeasure.enum';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';


@Component({
  selector: 'app-add-recipe',
  templateUrl: './add-recipe.component.html',
  styleUrls: ['./add-recipe.component.css']
})
export class AddRecipeComponent implements OnInit {
  @Input() categoryId: number;
  forma: FormGroup;

  n: number = 10;

  public recipeList: Recipe[] = [];
  ingredientsList: Ingredient[] = [];
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
        ingredients: this.fb.array([]),
      
      });
    }

  public async ngOnInit(): Promise<void> {
    await this.getCategories();
    await this.getUsers();
    // this.loadIngredientRecipe();
    await this.loadIngredients();

    this.route.params.subscribe(
      (params: Params) => {

        this.categoryId = +params['categoryId'];
      }
    );
  }

  private async getCategories() {
    this.categories = await this.categoryService.getRecipeCategories(this.n);
  }

  private async getUsers() {
    this.users = await this.userService.getUsers();
  }

  public addIngredients(ingredient) 
  {

    const ingredientId: number = Number(ingredient.target.value);
    const ingredientObj = this.ingredientsList.find(x => x.id == ingredientId);

    (<FormArray>this.forma.get('ingredients')).push(this.fb.group({
        IngredientName: new FormControl({value: ingredientObj.name, disabled: true}),
        IngredientId: [ingredientId, [Validators.required]],
        Quantity:["", [Validators.required]],
      UnitMeasure:["", Validators.required],
    }));
  }

  loadIngredients(){
    this.ingredientService.getIngredients(100,1,100).subscribe(data=>{
      this.ingredientsList=data.result;
      console.log(this.ingredientsList);
    })
  }
  public get ingredientsControls() : AbstractControl[] {
    return (this.forma.get('ingredients') as FormArray)?.controls ?? []; // if(obj!=null){obj.controls}  
  }

  public deleteIngredient(i: number){
    (<FormArray>this.forma.get('ingredients')).removeAt(i);
  }

  public save(){
    // console.log(this.forma.get('ingredients').value);
    let dataParams=new RecipeInsertRequest(this.forma.get('recipeName').value,
    this.forma.get('description').value,
    this.categoryId,this.forma.get('recommendedPrice').value,this.forma.get('ingredients').value);        
      this.service.addRecipe(dataParams).subscribe(data=>{
        this.toastr.success("Successfully added")
        this.router.navigate(["/recipeCategory"]);
      },
      (error)=>{
        this.toastr.error("Something went wrong");
      })
  }
}
