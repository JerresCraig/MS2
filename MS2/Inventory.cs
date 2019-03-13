using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS2
{
    //Jerres Craig
    //This is my own work
    class Inventory
    {
        private string ProductID;
        private string ProductName;
        private double Quantity;
        private string Flavor;
        private double PricePerOunce;
        //get
        public string getProductID()
        {
            return ProductID;
        }
        //set
        public void setProductID(string ID)
        {
            ProductID = ID;
        }

        public void addQuantity(double Quantity)
        {
            Quantity = Quantity + 1;
        }

        public void subQuantity(double Quantity)
        {
            Quantity = Quantity - 1;
        }

        public string getProductName()
        {
            return ProductName;
        }

        public void setProductName(string Name)
        {
            ProductName = Name;
        }

        public string getFlavor()
        {
            return Flavor;
        }

        public void setFlavor(string Flv)
        {
            Flavor = Flv;
        }

        public double getPricePerOunce()
        {
            return PricePerOunce;
        }

        public void setPricePerOunce(double Price)
        {
            PricePerOunce = Price;
        }
    }
}
