using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_GoF.Clases_apoyo
{
    class EstrategiaInvitarCerveza : IBorracho
    {
        public void Conquistar()
        {
            Console.WriteLine("La conquisto invitando la una cerveza");
        }
    }
}
