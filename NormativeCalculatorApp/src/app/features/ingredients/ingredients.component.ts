import { Component, OnInit } from '@angular/core';
import { IngredientsService } from 'app/core/_services/ingredients.service';
import { Ingredient } from 'app/shared/entities/ingredients.model';
import { Pagination } from 'app/shared/entities/pagination.model';


@Component({
  selector: 'app-ingredients',
  templateUrl: './ingredients.component.html',
  styleUrls: ['./ingredients.component.css']
})
export class IngredientsComponent implements OnInit {

  ingredientsList:Ingredient[]=[];
  pagination:Pagination;
  pageNumber=1;
  pageSize=10;
  constructor(public service:IngredientsService) { }

  ngOnInit(): void {
    this.loadIngredients();
  }
  loadIngredients(){
    this.service.getIngredients(this.pageNumber,this.pageSize).subscribe(data=>{
      console.log(data);
      this.ingredientsList=data.result;
      this.pagination=data.pagiation;
    })
  }
  pageChanged(event:any){
    this.pageNumber=event.page;
    this.loadIngredients();
  }
}
