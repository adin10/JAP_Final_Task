import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { IngredientsService } from 'app/core/services/ingredients.service';
import { Ingredient } from 'app/shared/models/ingredients.model';
import { PagedIngredientRequest } from 'app/shared/requests/pagedIngredientRequest.model';


export interface PeriodicElement {
  name: string;
  position: number;
  weight: number;
  symbol: string;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {position: 1, name: 'Hydrogen', weight: 1.0079, symbol: 'H'},
  {position: 2, name: 'Helium', weight: 4.0026, symbol: 'He'},
  {position: 3, name: 'Lithium', weight: 6.941, symbol: 'Li'},
  {position: 4, name: 'Beryllium', weight: 9.0122, symbol: 'Be'},
  {position: 5, name: 'Boron', weight: 10.811, symbol: 'B'},
  {position: 6, name: 'Carbon', weight: 12.0107, symbol: 'C'},
  {position: 7, name: 'Nitrogen', weight: 14.0067, symbol: 'N'},
  {position: 8, name: 'Oxygen', weight: 15.9994, symbol: 'O'},
  {position: 9, name: 'Fluorine', weight: 18.9984, symbol: 'F'},
  {position: 10, name: 'Neon', weight: 20.1797, symbol: 'Ne'},
];

@Component({
  selector: 'app-paged-ingredients',
  templateUrl: './paged-ingredients.component.html',
  styleUrls: ['./paged-ingredients.component.css']
})

export class PagedIngredientsComponent implements OnInit {
    // displayedColumns: string[] = ['name', 'quantity', 'unitMeasure', 'price','unitPrice'];

    displayedColumns: string[] = ['position', 'name', 'weight', 'symbol','unitPrice'];

    @ViewChild(MatPaginator) paginator:MatPaginator;

    dataSource:MatTableDataSource<PeriodicElement>;
    listIngredients:Ingredient[]=[];
    search:PagedIngredientRequest;
  constructor(public ingredintService:IngredientsService) { }

  ngOnInit(): void {
    // this.getPagedIngredients();
    this.dataSource=new MatTableDataSource<PeriodicElement>(ELEMENT_DATA);
  }

  // getPagedIngredients(){
  //   this.ingredintService.getPaginateIngredients(this.search).subscribe(data=>{
  //     this.listIngredients=data;
  //   })
  // }
}
