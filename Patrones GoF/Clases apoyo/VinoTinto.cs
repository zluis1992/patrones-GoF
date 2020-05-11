using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_GoF.Clases_apoyo
{
    class VinoTinto : BebidaEmbriagante
    {
        public override int CuantoMeEmbriagaPorHora()
        {
            return 20;
        }
    }
}
