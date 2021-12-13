import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { IngredientRecipeService } from 'app/core/_services/ingredientRecipe.service';
import { IngredientsService } from 'app/core/_services/ingredients.service';
import { MyUserService } from 'app/core/_services/myUser.service';
import { RecipeService } from 'app/core/_services/recipe.service';
import { RecipeCategoriesService } from 'app/core/_services/recipeCategories.service';
import { Ingredient } from 'app/shared/entities/ingredients.model';
import { MyUser } from 'app/shared/entities/myUser.model';
import { Recipe } from 'app/shared/entities/recipe.model';
import { RecipeCategory } from 'app/shared/entities/recipeCategories.model';
import { RecipeInsertRequest } from 'app/shared/requests/recipeInsertRequest.model';
import { UnitMeasure } from 'app/shared/requests/unitMeasure.enum';
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

  constructor(public router: Router, public service: RecipeService, public fb: FormBuilder,
    public categoryService: RecipeCategoriesService, public userService: MyUserService,
    private route: ActivatedRoute, public ingredientRecipeService: IngredientRecipeService,
    public ingredientService: IngredientsService) { 
      this.forma = this.fb.group({
        recipeName: [""],
        description: [""],
        ingredients: this.fb.array([])
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

  // private async loadIngredients() {
  //   this.ingredientsList = await this.ingredientService.getIngredients().toPromise();
  // }
  loadIngredients(){
    this.ingredientService.getIngredients().subscribe(data=>{
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
    let podaci=new RecipeInsertRequest(this.forma.get('recipeName').value,
    this.forma.get('description').value,
    this.categoryId,this.forma.get('ingredients').value);
                                      
      this.service.addRecipe(podaci).subscribe(data=>{
        this.router.navigate(["/recipeCategory"]);
      })
  }
}
