using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace naracka_na_kafe
{
    class Cafe
    {
        //Default Constructor
        public Cafe()
        {
            newmacchiato_Coff = 0;
            newespres_Coff = 0;
            newcapp_Coff = 0;
            newnes = 0;
            newice = 0;
            newice = 0;
            newfreddo = 0;
            newhot = 0;


            newcream_c = 0;
            newchocolate = 0;
            newcoffee_cake = 0;
            newnestle_c = 0;
            newnutella_c = 0;
            newvanilla_c = 0;
            newstarw = 0;
            newrum_c = 0;

        
        }

        //overlodad construcotr

        public Cafe(double macchiato_Coff, double espres_Coff, double capp_Coff, double nescafe ,double ice, double irish_Coff, double freddo ,double hot,
        double cream_c, double chocolate, double coffee_cake, double nestle_c, double nutella_c,double vanilla_c,double starw, double rum_c)
        {
            //coffee
            newmacchiato_Coff = macchiato_Coff;
            newespres_Coff = espres_Coff;
            newcapp_Coff = capp_Coff;
            newnes = nescafe;
            newice = ice;
            newirish_Coff = irish_Coff;
            newfreddo = freddo;
            newhot = hot;

            //cakes
            newcream_c = cream_c;
            newchocolate = chocolate;
            newcoffee_cake = coffee_cake;
            newnestle_c = nestle_c;
            newnutella_c = nutella_c;
            newvanilla_c = vanilla_c;
            newstarw = starw;
            newrum_c = rum_c;


 
        }

        //accessor function

        public double getmacchiato_Coff()
        {
            return newmacchiato_Coff;
        }
        public double getespres_Coff()
        {
            return newespres_Coff;
        }
        public double getcapp_Coff()
        {
            return newcapp_Coff;
        }
        public double getnes()
        {
            return newnes;
        }
        public double getice()
        {
            return newice;
        }
        public double getirish_Coff()
        {
            return newirish_Coff;
        }
        public double getfreddo()
        {
            return newfreddo;
        }

        public double gethot()
        {
            return newhot;
        }

        public double getcream_c()
        {
            return newcream_c;
        }
        public double getchocolate()
        {
            return newchocolate;
        }
        public double getcoffee_cake()
        {
            return newcoffee_cake;

        }
        public double getnestle_c()
        {
            return newnestle_c;
        }

        public double getnutella_c()
        {
            return newnutella_c;
        }
        public double getvanilla_c()
        {
            return newvanilla_c;
        }
        public double getstarw()
        {
            return newstarw;
        }
        public double getrum_c()
        {
            return newrum_c;
        }



        // memeber variables declared for coffee
        private double newmacchiato_Coff;
        private double newespres_Coff;
        private double newcapp_Coff;
        private double newnes;
        private double newice;
        private double newirish_Coff;
        private double newfreddo;
        private double newhot;

        //memeber variables declared for cakes
       private double newcream_c;
       private double newchocolate; 
       private double newcoffee_cake; 
       private double newnestle_c;
       private double newnutella_c; 
       private double newvanilla_c; 
       private double newstarw; 
       private double newrum_c; 
    }
}

    

