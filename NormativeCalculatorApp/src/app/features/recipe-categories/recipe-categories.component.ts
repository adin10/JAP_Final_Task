import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from 'app/core/_services/authentication.service';
import { RecipeCategoriesService } from 'app/core/_services/recipeCategories.service';
import { RecipeCategory } from 'app/shared/entities/recipeCategories.model';
import { ToastrService } from 'ngx-toastr';
import { NgxBootstrapConfirmService } from 'ngx-bootstrap-confirm';
import{first} from 'rxjs/operators';

@Component({
  selector: 'app-recipe-categories',
  templateUrl: './recipe-categories.component.html',
  styleUrls: ['./recipe-categories.component.css']
})
export class RecipeCategoriesComponent implements OnInit {

  constructor(public service:RecipeCategoriesService, private toastr:ToastrService, 
    private ngxBootstrapConfirmService: NgxBootstrapConfirmService,public authService:AuthenticationService) { }

  recipesCategoryList:RecipeCategory[]=[];
  number:number=10;

  public async ngOnInit(): Promise<void> {
    this.loadRecipeCategories();
  }

  public async loadRecipeCategories(){
    this.recipesCategoryList = await this.service.getRecipeCategories(this.number);
    this.number += 10;
  }

  deleteCategory(item){
    let options ={
      title: 'Do you want to delete a category from the list??',
      confirmLabel: 'Yes',
      declineLabel: 'No'
    }
    this.ngxBootstrapConfirmService.confirm(options).then((res: boolean) => {
      if (res) {
        this.service.deleteCategory(item).subscribe(data=>{
          this.toastr.success("Successfully deleted");
          this.loadRecipeCategories();
        })
      }
    });
  }
}


// if(confirm("Do yoz want to delete a category from the list?")){
// }

