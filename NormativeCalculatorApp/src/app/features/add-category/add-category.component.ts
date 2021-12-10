import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { RecipeCategoriesService } from 'app/core/_services/recipeCategories.service';
import { RecipeCategory } from 'app/shared/entities/recipeCategories.model';
import { RecipeCategoryUpsertRequest } from 'app/shared/requests/categoryUpsertRequest.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrls: ['./add-category.component.css']
})
export class AddCategoryComponent implements OnInit {
  form:FormGroup;

  constructor(public categoryService:RecipeCategoriesService,public fb:FormBuilder,public router:Router, private toastr:ToastrService) {
    this.form=this.fb.group({
      Name:["",Validators.required],
      Description:[""],
    })
   }

  ngOnInit(): void {
  }

  onSubmit(){
    let podaci=new RecipeCategoryUpsertRequest(this.form.get('Name').value,this.form.get('Description').value);
    this.categoryService.addCategory(podaci).subscribe(data=>{
      this.toastr.success("Successfully added")
      this.router.navigate(["/recipeCategory"]);
    },
    (error)=>{
      this.toastr.error("Something went wrong");
    }
    )
  }

}
