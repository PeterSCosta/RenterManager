using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RenterManager.Application.Enums
{
    public enum ProductType : byte
    {
        [Display(Name = "Menu")]
        [Description(@"Menu")]
        Menu,

        [Display(Name = "Funcionário")]
        [Description(@"Funcionário")]
        Staff,

        [Display(Name = "Locação")]
        [Description(@"Locação")]
        UnitRented,

        [Display(Name = "Bebida Consignada")]
        [Description(@"Bebida Consignada")]
        ConsignedDrink,
    }
}