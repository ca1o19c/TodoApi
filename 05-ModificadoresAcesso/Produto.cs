using System;

namespace _05_ModificadoresAcesso
{
    class Produto
    {
        /*
         public      ->    Atributos e métodos visíveis em qualquer classe
         private     ->    Atributos e métodos visíveis apenas na classe onde são criados
         protected   ->    Atributos e métodos visíveis em classes onde são criados ou herdados
        */

        public string nome;
        private double valor;
    }
}
