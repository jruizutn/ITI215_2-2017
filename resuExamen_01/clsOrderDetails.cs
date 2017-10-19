using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resuExa_01
{
    [Serializable]
    class clsOrderDetails{
        //propiedades requeridas
        int orderID;
        short productID;
        float unitPrice;
        short cuantity;
        float discount;

        //constructor por defecto
        public clsOrderDetails() { }

        //constructor parametrizado
        public clsOrderDetails(int orderID, short productID, float unitPrice, short cuantity, float discount)
        {
            this.orderID = orderID;
            this.productID = productID;
            this.unitPrice = unitPrice;
            this.cuantity = cuantity;
            this.discount = discount;
        }

        //Properties encapsulando métodos get/set
        public int OrderID { get => orderID; set => orderID = value; }
        public short ProductID { get => productID; set => productID = value; }
        public float UnitPrice { get => unitPrice; set => unitPrice = value; }
        public short Cuantity { get => cuantity; set => cuantity = value; }
        public float Discount { get => discount; set => discount = value; }
    }
}