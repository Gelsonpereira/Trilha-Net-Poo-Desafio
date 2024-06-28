using System;

namespace Projeto_de_Celular_dio.Models
{
    public class Nokia : Smartfone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
         public override void InstalarAplicativos(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }
    }
}