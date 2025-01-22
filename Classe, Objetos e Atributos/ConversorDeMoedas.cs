using System;
using System.Collections.Generic;


namespace Course
{
     class ConversoDeMoedas
    {
        public static double IOF = 0.06;
       
        public static double Conversor(double dolar, double cotacao)
        {
            double Total = dolar * cotacao;
            return Total + Total * IOF;
        }

    }
}
