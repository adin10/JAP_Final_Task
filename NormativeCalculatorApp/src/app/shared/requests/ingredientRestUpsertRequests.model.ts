import { UnitMeasure } from "./unitMeasure.enum";

export class IngredientRestUpsertRequest{
    constructor(public Name:string,
                public UnitMeasure:UnitMeasure,
                public Price:number,
                public UnitQuantity:number){}
}


// public string Name { get; set; }
// //public float UnitPrice { get; set; }
// public UnitMeasure UnitMeasure { get; set; }
// public float Price { get; set; }
// public float UnitQuantity { get; set; }