using System;
using System.Collections.Generic;

namespace Course
{
     class Alunos
    {
        public double AV1, AV2, AV3;
        public string Nome;

        public double NotaFinal()
        {
            return AV1 + AV2 + AV3;
        }

        public bool Media()
        {
            if(NotaFinal() >= 60)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public double AprovOrReprov()
        {
            if (Media())
            {
                return 0.0;
            }else
            {
                return 60 - NotaFinal();
            }
        }
    }
}