using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorExemplo
{
    internal class Eletronicos
    {
        //extração dos atributos
        public string capacitor;
        public string indutor;
        public string flyback;
        public string resistor;
        public string relay;
        public string fiodecobre;
        public string transformador;
        public string fusivel;
        public string pcb;
        public string ferrodesolda;
        public string botao;
        public string plugue;
        public string led;
        public string comentario;

        public Eletronicos(string tipoCapacitor,string tipoIndutor, string tipoFlyback, string tipoResitor,string tipoRelay,string tipoFiodecobre,string tipoTransformador, string tipoFusivel, string tipoPCB, string tipoFerrosolda, string tipoBotao, string tipoPlugue, string tipoLed, string tipoComentario)
        {
            capacitor = tipoCapacitor;
            indutor = tipoIndutor;
            flyback = tipoFlyback;
            resistor = tipoResitor;
            relay = tipoRelay;
            fiodecobre = tipoFiodecobre;
            transformador = tipoTransformador;
            fusivel = tipoFusivel;
            pcb = tipoPCB;
            ferrodesolda = tipoFerrosolda;
            botao = tipoBotao;
            plugue = tipoPlugue;
            led = tipoLed;
            comentario = tipoComentario;
        }
    }

}
