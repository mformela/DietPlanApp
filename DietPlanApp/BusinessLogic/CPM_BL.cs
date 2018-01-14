﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DietPlanApp.BusinessLogic
{
    public class CPM_BL
    {


        public int CalculateCPM(int Weight, int Height, int Age, int PhysicalActivity)
        {

           
            if (Sex == man)
            {
                var cpm = 66.47 + (13.75 * Weight) + (5.00 * Height) - (6.75 * Age);
                return cpm;
            }
            else
            {
                var cpm = 665.09 + (9.56 * Weight) + (1.85 * Height) - (4.67 * Age);
                return cpm;
            }

            if(PhysicalActivity == 1)
            {
                var cpm_total = cpm * 1.2;
                return cpm_total;

            }
            if (PhysicalActivity == 2)
            {
                var cpm_total = cpm * 1.4;
                return cpm_total;

            }
            if (PhysicalActivity == 3)
            {
                var cpm_total = cpm * 1.6;
                return cpm_total;

            }
            if (PhysicalActivity == 4)
            {
                var cpm_total = cpm * 1.75;
                return cpm_total;

            }
            if (PhysicalActivity == 5)
            {
                var cpm_total = cpm * 2;
                return cpm_total;
                d
            }
            if (PhysicalActivity == 6)
            {
                var cpm_total = cpm * 2.2;
                return cpm_total;

            }



            Następnie otrzymaną liczbę mnoży się przez współczynnik aktywności ruchowej.W tym wypadku wybiera się jedną z poniższych możliwości:

– 1,2 - 1,3->dla osoby chorej leżącej w łóżku;

– 1,4->dla niskiej aktywności fizycznej;

– 1,6->dla umiarkowanej aktywności fizycznej;

– 1,75->aktywny tryb życia;

– 2,0->bardzo aktywny tryb życia

– 2,2 - 2,4->wyczynowe uprawianie sportu.








        }


        






    }
}