import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IngredientsService } from 'app/core/services/ingredients.service';
import { Ingredient } from 'app/shared/models/ingredients.model';
import { IngredientRestUpsertRequest } from 'app/shared/requests/ingredientRestUpsertRequests.model';
import { UnitMeasure } from 'app/shared/requests/unitMeasure.enum';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-update-ingredient',
  templateUrl: './update-ingredient.component.html',
  styleUrls: ['./update-ingredient.component.css']
})
export class UpdateIngredientComponent implements OnInit {
  ingredients:Ingredient[]=[];
  ingredient:Ingredient;
  form:FormGroup;
  public unitMeasures:any[]=[
    {
    name:"kg",
    value:UnitMeasure.kg
    },
    {
      name:"g",
      value:UnitMeasure.g
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
  constructor(public ingredientService:IngredientsService, private toastr:ToastrService,
   public route:ActivatedRoute, public fb:FormBuilder,public router:Router) {}

  ngOnInit(){
    
    this.form=this.fb.group({
      Name:["",Validators.required],
      Quantity:[""],
      Price:[""],
      UnitMeasure:[""]
    })

    this.ingredientService.getById(this.route.snapshot.params.id).subscribe((data)=>{
      this.ingredient=data;
      console.log(this.ingredient);
      console.log(data);
      this.form=new FormGroup({
        Name:new FormControl(data['name']),
        Quantity:new FormControl(data['unitQuantity']),
        Price:new FormControl(data['price']),
        UnitMeasure:new FormControl(UnitMeasure[data['unitMeasure']])
      })
    })
  }

  onSubmit(){
    let dataParams=new IngredientRestUpsertRequest(this.form.get('Name').value,
                                              this.form.get('UnitMeasure').value,
                                              this.form.get('Price').value,
                                              this.form.get('Quantity').value);
        this.ingredientService.updateIngredient(this.route.snapshot.params.id,dataParams).subscribe(data=>{
          this.toastr.success("Data successfully updated")
          this.router.navigate(["/ingredient"]);
        }) 
    }

    getIngredients(){
      this.ingredientService.getIngredients().subscribe(data=>{
        this.ingredients=data.result;
      },
      (error)=>{
        this.toastr.error("Something went wrong");
      }
      )
    }

}
