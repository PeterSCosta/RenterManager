using System.ComponentModel;

namespace RenterManager.Application.Enums
{
    public enum ProductType : byte
    {
        [Description(@"Menu")]
        Menu,

        [Description(@"Funcionário")]
        Staff,

        [Description(@"Locação")]
        UnitRented,

        [Description(@"Bebida Consignada")]
        ConsignedDrink,
    }
}