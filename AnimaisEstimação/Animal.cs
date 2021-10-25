using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimaisEstimação
{
    public class animal
    {
        private string nome;
        private string tipo;

        public string nomeAnimal
        {
            //metodo de leitura
            get { return nome; }
            //metodo de escrita
            set { nome = value; }
        }

        public string tipoAnimal
        {
            get { return tipo; }
            set
            {
                //se atenter as condições, retorna um valor,senão retorna um peixe
                if (value == "cachorro" || value == "gato" || value == "peixe")
                {
                    tipo = value;
                }
                else
                {
                    tipo = "peixe";
                }
            }
        }

    }
}

 
