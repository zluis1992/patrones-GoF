using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_GoF.Clases_apoyo
{
    public class EstrategiasDelBorrachoContexto
    {
        private IBorracho oBorracho;
        public enum Comportamiento
        {
            HacerOjitos, InvitarCerveza
        }
        public void Conquistar(Comportamiento opcion)
        {
            switch (opcion)
            {
                case Comportamiento.HacerOjitos:
                    this.oBorracho = new EstrategiaOjitos();
                    break;
                case Comportamiento.InvitarCerveza:
                    this.oBorracho = new EstrategiaInvitarCerveza();
                    break;
            }
            this.oBorracho.Conquistar();
        }
    }
}
