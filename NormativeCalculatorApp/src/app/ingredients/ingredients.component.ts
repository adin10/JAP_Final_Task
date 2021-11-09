import { Component, OnInit } from '@angular/core';
import { IngredientsService } from '../_services/ingredients.service';
import { Ingredients } from '../_shared/ingredients.model';

@Component({
  selector: 'app-ingredients',
  templateUrl: './ingredients.component.html',
  styleUrls: ['./ingredients.component.css']
})
export class IngredientsComponent implements OnInit {

  ingredientsList:Ingredients[]=[];
  constructor(public service:IngredientsService) { }

  ngOnInit(): void {
    this.loadIngredients();
  }
  loadIngredients(){
    this.service.getIngredients().subscribe(data=>{
      this.ingredientsList=data;
    })
  }

}
