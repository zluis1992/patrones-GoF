using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_GoF.Clases_apoyo
{
    public class Cerveza:BebidaEmbriagante
    {
        public override int CuantoMeEmbriagaPorHora()
        {
            return 5;
        }
    }
}
