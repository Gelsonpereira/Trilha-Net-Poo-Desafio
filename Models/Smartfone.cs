using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Projeto_de_Celular_dio.Models
{
     public abstract class Smartfone
    {
        public string Numero { get; set; }
        public string Modelo { get; private set; }
        public string Imei { get; private set; }
        public int Memoria { get; private set; }

        public Smartfone()
        {

        }
        public Smartfone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
             Console.WriteLine("Ligando... ");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void  InstalarAplicativos(string nomeApp);
    }
}