import { UnitMeasure } from "./unitMeasure.enum";

export class IngredientRecipeInsertRequest{
    constructor(public IngredientId:number,
                public Quantity:number,
                public UnitMeasure:UnitMeasure
                ){}
}