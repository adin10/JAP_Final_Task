import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from 'app/core/_services/authentication.service';
import { IngredientsService } from 'app/core/_services/ingredients.service';
import { Ingredient } from 'app/shared/entities/ingredients.model';
import { Pagination } from 'app/shared/entities/pagination.model';
import { UnitMeasure } from 'app/shared/requests/unitMeasure.enum';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-ingredients',
  templateUrl: './ingredients.component.html',
  styleUrls: ['./ingredients.component.css']
})
export class IngredientsComponent implements OnInit {

  ingredientsList:Ingredient[]=[];
  pagination:Pagination;
  pageNumber=1;
  pageSize=5;
  Name:"";
  Quantity:number;
  UnitMeasure:UnitMeasure
  constructor(public service:IngredientsService, private toastr:ToastrService, public authService:AuthenticationService) { }

  ngOnInit(): void {
    this.loadIngredients(this.Name,this.Quantity,this.UnitMeasure);
  }
  loadIngredients(Name:string,Quantity:number, UnitMeasure:UnitMeasure){
    this.service.getIngredients().subscribe(data=>{
      console.log(data);
      this.ingredientsList=data.result;
      this.pagination=data.pagiation;
    })
  }
  pageChanged(event:any){
    this.pageNumber=event.page;
    this.loadIngredients(this.Name,this.Quantity,this.UnitMeasure);
  }

  deleteIngredient(item){
    if(confirm("Are you sure you want to delele object")){
    this.service.deleteIngredient(item).subscribe(data=>{
      this.toastr.success("Successfully deleted");
      this.loadIngredients(this.Name,this.Quantity,this.UnitMeasure);
    })
  }
  }
  Search(){
    this.loadIngredients(this.Name,this.Quantity,this.UnitMeasure);
  }
}
