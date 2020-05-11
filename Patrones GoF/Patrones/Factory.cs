using Patrones_GoF.Clases_apoyo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_GoF.Patrones
{/// <summary>
/// clase que se encarga de crear los objetos de las clases embriagantes
/// </summary>
    public class Factory
    {
        public const int VINO_TINTO = 1;
        public const int CERVEZA = 2;

        public static BebidaEmbriagante Creador (int tipo)
        {
            switch (tipo)
            {
                case VINO_TINTO:
                    return new VinoTinto();
                case CERVEZA:
                    return 
                        new Cerveza();
                default:
                    return null;
            }
        }
    }

}
