import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { IngredientsService } from 'app/core/_services/ingredients.service';
import { Ingredient } from 'app/shared/entities/ingredients.model';
import { IngredientRestUpsertRequest } from 'app/shared/requests/ingredientRestUpsertRequests.model';
import { UnitMeasure } from 'app/shared/requests/unitMeasure.enum';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-add-ingredient',
  templateUrl: './add-ingredient.component.html',
  styleUrls: ['./add-ingredient.component.css']
})
export class AddIngredientComponent implements OnInit {

  form:FormGroup;
  ingredients:Ingredient[]=[];
  
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
  constructor(private toastr:ToastrService, public ingredientService:IngredientsService, public fb:FormBuilder,public router:Router) { 
    this.form=this.fb.group({
      Name:["",[Validators.required]],
      Quantity:["",[Validators.required]],
      Price:["",[Validators.required]],
      UnitMeasure:["",[Validators.required]]
    })
  }

  ngOnInit(): void {
  }

  onSubmit(){
    let dataParams=new IngredientRestUpsertRequest(this.form.get('Name').value,
                                              this.form.get('UnitMeasure').value,
                                              this.form.get('Price').value,
                                              this.form.get('Quantity').value);
        this.ingredientService.addIngredient(dataParams).subscribe(data=>{
          this.toastr.success("Successfully added");
          this.router.navigate(["/ingredient"]);
        },
        (error)=>{
          this.toastr.error("Something went wrong");
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
