using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_Celular_dio.Models
{
    public class Iphone : Smartfone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        public override void InstalarAplicativos(string nomeApp) 
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone");
        }
    }
}