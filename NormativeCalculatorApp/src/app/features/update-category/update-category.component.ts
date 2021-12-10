import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { RecipeCategoriesService } from 'app/core/_services/recipeCategories.service';
import { RecipeCategory } from 'app/shared/entities/recipeCategories.model';
import { RecipeCategoryUpsertRequest } from 'app/shared/requests/categoryUpsertRequest.model';

@Component({
  selector: 'app-update-category',
  templateUrl: './update-category.component.html',
  styleUrls: ['./update-category.component.css']
})
export class UpdateCategoryComponent implements OnInit {
  form:FormGroup;
  category:RecipeCategory;
  constructor(public router:Router, public service:RecipeCategoriesService,public fb:FormBuilder,public route:ActivatedRoute) { 
    this.form=this.fb.group({
      Name:["",Validators.required],
      Description:[""],
  })
}

  ngOnInit():void{
    this.service.getRecipeCategorieById(this.route.snapshot.params.id).subscribe((data)=>{
      this.category=data;
      this.form=new FormGroup({
        Name:new FormControl(data['name']),
        Description:new FormControl(data['description'])
      })
    })

  }
  onSubmit(){
    let podaci=new RecipeCategoryUpsertRequest(this.form.get('Name').value,this.form.get('Description').value);
    this.service.updateCategory(this.route.snapshot.params.id,podaci).subscribe(data=>{
      this.router.navigate(["/recipeCategory"]);

    })
  }

}
