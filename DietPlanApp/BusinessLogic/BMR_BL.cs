using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace DietPlanApp.BusinessLogic
{
    public class BMR_BL
    {

        public int CalculateBMR(int Weight, int Height, int Age)
        {
            if (Sex == man)
            {
                 int bmr = (10 * Weight) + (6.25 * Height) - (5 * Age) +5;
                return bmr;
            }
            else
            {
                var bmr = (10 * Weight) + (6.25 * Height) - (5 * Age) - 161;
                return bmr;
            }
            

        }
        


    }
}