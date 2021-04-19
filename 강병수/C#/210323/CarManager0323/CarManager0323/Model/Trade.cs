using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Trade
    {
        string date;
        Customer customer;
        Car car;
        Seller seller;

        public Trade(string date, Customer customer, Car car, Seller seller)
        {
            this.date = date;
            this.customer = customer;
            this.car = car;
            this.seller = seller;
        }

        public string Date { get => date; set => date = value; }
        internal Customer Customer { get => customer; set => customer = value; }
        internal Car Car { get => car; set => car = value; }
        internal Seller Seller { get => seller; set => seller = value; }
    }
}
