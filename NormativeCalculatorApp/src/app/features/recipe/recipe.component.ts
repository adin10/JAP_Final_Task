import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticationService } from 'app/core/services/authentication.service';
import { RecipeService } from 'app/core/services/recipe.service';
import { Recipe } from 'app/shared/models/recipe.model';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-recipe',
  templateUrl: './recipe.component.html',
  styleUrls: ['./recipe.component.css']
})
export class RecipeComponent implements OnInit {
  number:number=100;
  recipeList:Recipe[]=[];
  SearchTerm:string="";
  categoryId:number;
  

  constructor(public authService:AuthenticationService,private toastr:ToastrService, 
    public service:RecipeService,private router:Router,private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.categoryId=Number(this.route.snapshot.paramMap.get('id'));
    this.loadRecipes(this.SearchTerm,this.categoryId);
  }

  async loadRecipes(SearchTerm:string,categoryId:number){
    this.recipeList = await this.service.getRecipe(SearchTerm,this.categoryId,this.number);
    this.number+=10;
  }
  Search(){
    this.loadRecipes(this.SearchTerm,this.categoryId);
    console.log(this.loadRecipes(this.SearchTerm,this.categoryId));
  }
  deleteRecipe(item){
    if(confirm("Do you want to delete a recipe from the list?")){
      this.service.deleteRecipe(item).subscribe(data=>{
        this.toastr.success("Successfully deleted");
        this.loadRecipes(this.SearchTerm,this.categoryId);
      })
    }
  }



}
