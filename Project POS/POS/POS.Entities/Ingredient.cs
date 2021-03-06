// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace POS.Entities
{

    // Ingredient
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class Ingredient
    {
        public string IgdId { get; set; } // igd_id (Primary key) (length: 10)
        public string WarehouseId { get; set; } // warehouse_id (length: 10)
        public string Name { get; set; } // name (length: 100)
        public string Info { get; set; } // info (length: 300)
        public byte Usefor { get; set; } // usefor
        public string IgdType { get; set; } // igd_type (length: 100)
        public string UnitBuy { get; set; } // unit_buy (length: 100)
        public decimal StandardPrice { get; set; } // standard_price
        public int Deleted { get; set; } // deleted

        // Reverse navigation

        /// <summary>
        /// Child ProductDetails where [ProductDetails].[igd_id] point to this entity (FK_dbo.ProductDetails_dbo.Ingredient_igd_id)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ProductDetail> ProductDetails { get; set; } // ProductDetails.FK_dbo.ProductDetails_dbo.Ingredient_igd_id
        /// <summary>
        /// Child ReceiptNoteDetails where [ReceiptNoteDetails].[igd_id] point to this entity (FK_dbo.ReceiptNoteDetails_dbo.Ingredient_igd_id)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ReceiptNoteDetail> ReceiptNoteDetails { get; set; } // ReceiptNoteDetails.FK_dbo.ReceiptNoteDetails_dbo.Ingredient_igd_id

        // Foreign keys

        /// <summary>
        /// Parent WareHouse pointed by [Ingredient].([WarehouseId]) (FK_dbo.Ingredient_dbo.WareHouse_warehouse_id)
        /// </summary>
        public virtual WareHouse WareHouse { get; set; } // FK_dbo.Ingredient_dbo.WareHouse_warehouse_id

        public Ingredient()
        {
            ProductDetails = new System.Collections.Generic.List<ProductDetail>();
            ReceiptNoteDetails = new System.Collections.Generic.List<ReceiptNoteDetail>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
