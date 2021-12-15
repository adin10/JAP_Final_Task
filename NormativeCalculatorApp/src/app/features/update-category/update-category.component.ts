import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { RecipeCategoriesService } from 'app/core/_services/recipeCategories.service';
import { RecipeCategory } from 'app/shared/entities/recipeCategories.model';
import { RecipeCategoryUpsertRequest } from 'app/shared/requests/categoryUpsertRequest.model';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-update-category',
  templateUrl: './update-category.component.html',
  styleUrls: ['./update-category.component.css']
})
export class UpdateCategoryComponent implements OnInit {
  form:FormGroup;
  category:RecipeCategory;
  constructor(private toastr:ToastrService, public router:Router, public service:RecipeCategoriesService,public fb:FormBuilder,public route:ActivatedRoute) { 
    this.form=this.fb.group({
      Name:["",Validators.required],
      Description:[""],
  })
}

  ngOnInit():void{
    this.service.getRecipeCategorieById(this.route.snapshot.params.id).subscribe((data)=>{
      console.log(this.category=data);
      console.log(this.category.name);
      this.category=data;
      this.form=new FormGroup({
        Name:new FormControl(data['name']),
        Description:new FormControl(data['description'])
      })
    })
  }
  onSubmit(){
    let dataParams=new RecipeCategoryUpsertRequest(this.form.get('Name').value,this.form.get('Description').value);
    this.service.updateCategory(this.route.snapshot.params.id,dataParams).subscribe(data=>{
      this.toastr.success("Data successfully updated")
      this.router.navigate(["/recipeCategory"]);
    },
    (error)=>{
      this.toastr.error("Something went wrong");
    }
    )
  }

}
