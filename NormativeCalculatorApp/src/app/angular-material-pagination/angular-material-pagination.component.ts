import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { IngredientsService } from 'app/core/services/ingredients.service';
import { Ingredient, IngredientSearchRequest } from 'app/shared/models/ingredients.model';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ModalService } from 'app/core/services/modal.service';
import { AddIngredientComponent } from 'app/features/add-ingredient/add-ingredient.component';
@Component({
  selector: 'app-angular-material-pagination',
  templateUrl: './angular-material-pagination.component.html',
  styleUrls: ['./angular-material-pagination.component.css']
})
export class AngularMaterialPaginationComponent implements OnInit {

  ingredientList:Ingredient[]=[];
  searchRequest:IngredientSearchRequest=new IngredientSearchRequest('',null,null);
  displayedColumns: string[] = ['name', 'unitMeasure', 'price', 'unitQuantity','unitPrice'];
  dataSource:MatTableDataSource<Ingredient>;

  constructor(public ingredintService:IngredientsService,public modalService:NgbModal) { }

  ngOnInit(): void {
    this.getPagedIngredients(this.searchRequest);
  }
  getPagedIngredients(searchRequest:IngredientSearchRequest){
    this.ingredintService.getAngularMaterialPagination(this.searchRequest).subscribe(data=>{
      this.ingredientList=data;
      this.dataSource=new MatTableDataSource(this.ingredientList);
      console.log(data);
    })
  }
  open() {
    const modalRef = this.modalService.open(AddIngredientComponent,{
      scrollable: true,
    });

    modalRef.result.then(
      (result) => {
        this.ingredientList.push(result);
      },
      (reason) => {}
    );
  }
    Search(){
      this.getPagedIngredients(this.searchRequest);
    }
  
}
