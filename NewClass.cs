using System;


namespace Toll_collecting_app
{
    public class New_Class
    {
        public int Amount (int vehicleTypefare, int numberOfTrips)
        {
            int totalAmount = vehicleTypefare * numberOfTrips;
            return totalAmount;
        }

        public double discount(int totalAmount)
        {
            double Final_discount = totalAmount * 0.7;
            
            return Final_discount;
        }
    }

}
