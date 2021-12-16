import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from 'app/core/services/authentication.service';
import { IngredientsService } from 'app/core/services/ingredients.service';
import { Ingredient, IngredientSearchRequest } from 'app/shared/models/ingredients.model';
import { Pagination } from 'app/shared/models/pagination.model';
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
  number=5;
  request:IngredientSearchRequest=new IngredientSearchRequest('',null,null);
  pageNumber=1;
  pageSize=5;
  orderBy='';

  constructor(public service:IngredientsService, private toastr:ToastrService, public authService:AuthenticationService) { }

  ngOnInit(): void {
    this.loadIngredients(this.number,this.pageNumber,this.pageSize,this.request,this.orderBy);
  }
  Search(){
    this.loadIngredients(this.number,this.pageNumber,this.pageSize,this.request,this.orderBy);
    console.log( this.loadIngredients(this.number,this.pageNumber,this.pageSize,this.request,this.orderBy));

  }
  loadIngredients(number:number,pageNumber:number, pageSize:number, request:IngredientSearchRequest,orderBy:string){
    this.service.getIngredients(number,pageNumber,pageSize=number,request,orderBy).subscribe(data=>{
      this.ingredientsList=data.result;
      this.pagination=data.pagiation;
    })
  }
  pageChanged(event:any){
    this.pageNumber=event.page;
    this.loadIngredients(this.number,this.pageNumber,this.pageSize,this.request,this.orderBy);
  }

  deleteIngredient(item){
    if(confirm("Do you want to delete a ingredient from the list?")){
    this.service.deleteIngredient(item).subscribe(data=>{
      this.toastr.success("Successfully deleted");
      this.loadIngredients(this.number,this.pageNumber,this.pageSize,this.request,this.orderBy);
    })
  }
  }
 
}
