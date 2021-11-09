using System;

namespace _04_ExercicioIMC
{
    class Pessoa
    {
        public double peso;
        public double altura;

        public double CalcularImc()
        {
            double retorno = 0;

            if(altura == 0)
            {
                return retorno;
            }

            retorno = peso / (altura * altura);

            return Math.Round(retorno, 2);
        }

        public string Situacao(double imc)
        {
            string retorno = "";

            if (imc < 18.5)
            {
                retorno = "Abaixo do peso";
            } 
            else if(imc < 25)
            {
                retorno = "Peso normal";
            }
            else if(imc < 30)
            {
                retorno = "Acima do peso";
            }
            else if(imc < 35)
            {
                retorno = "Obesidade I";
            }
            else if (imc < 40)
            {
                retorno = "Obesidade II";
            }
            else if(imc >= 40)
            {
                retorno = "Obesidade III";
            }
            else
            {
                retorno = "IMC não encontrado";
            }

            return retorno;
        }

        public void Mensagem()
        {
            double obterImc = CalcularImc();
            string obterSituacao = Situacao(obterImc);

            Console.WriteLine("Seu peso é " + peso + " com altura " + altura + " resultando em um ICM de " + obterImc + "(" + obterSituacao + ")");
        }
    }
}
