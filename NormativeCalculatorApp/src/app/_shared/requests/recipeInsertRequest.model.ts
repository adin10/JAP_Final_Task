export class RecipeInsertRequest{
    constructor(public RecipeName:string,public Description:string,public TotalCost:number,
            public RecipeCategoryId:number){}
}

// public string RecipeName { get; set; }
// public string Description { get; set; }
// public float TotalCost { get; set; }
// public int MyUserId { get; set; }
// public int RecipeCategoryId { get; set; }