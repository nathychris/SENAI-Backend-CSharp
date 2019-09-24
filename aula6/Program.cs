using System;

namespace aula6 {
    class Program {
        static void Main (string[] args) {

            // Chamamos nossa primeira função
            Console.WriteLine (BomDia ());

            // chamamos a função do tipo VOID (sem retorno)
            imprimeDataHora ();

            //Chamamos nossa função que calcula a média
            double[] numeros = { 2, 5, 2, 8, 9, 5 };
            Console.WriteLine (CalculaMedia (numeros));
        }

        /// <summary>
        /// Função que escreve Bom Dia para o usuario
        /// </summary>
        /// <returns>Retorna Ola! Bom Dia!</returns>
        static string BomDia () {
            return "Olá! Bom Dia!";
        }

        /// <summary>
        /// Função que mostra uma saudação de acordo com o horario atual
        /// </summary>
        /// <param name="saudacao">um texto qualquer (sobrecarga de metodo)</param>
        /// <returns>Saudação de acordo com o horário</returns>
        static string BomDia (string saudacao) {
            int hora = DateTime.Now.Hour;

            if (hora <= 12 && hora >= 6) {
                saudacao = "Bom Dia";
            } else if (hora > 12 && hora <= 18) {
                saudacao = "Boa Tarde";
            } else {
                saudacao = "Boa Noite";
            }
            return saudacao;
        }

        /// <summary>
        /// Retorna um numero -  Teste de sobrecarga
        /// </summary>
        /// <param name="numero">Um numero inteiro qualquer</param>
        /// <returns>Número passado como parâmetro</returns>
        static int BomDia (int numero) {
            return numero;
        }

        /// <summary>
        ///  Retorna Data e Hora atuais
        /// </summary>
        static void imprimeDataHora () {
            Console.WriteLine (DateTime.Now.ToShortDateString ());
            Console.WriteLine (DateTime.Now.Hour);
        }

        /// <summary>
        /// Função que calcula a média de um vetor
        /// </summary>
        /// <param name="valores">vetor com valores</param>
        /// <returns>Média dos valores</returns>
        static double CalculaMedia (double[] valores) {
            double resultado = 0;
            for (int i = 0; i < valores.Length; i++) {
                resultado = resultado + valores[i];
            }

            resultado = resultado / valores.Length;

            return resultado;
        }

        /// <summary>
        /// Calcula a soma de um vetor
        /// </summary>
        /// <param name="valores">vetor com valores</param>
        /// <returns>A soma dos Valores</returns>
        static double CalculaSoma (double[] valores) {
            double resultado = 0;
            for (int i = 0; i < valores.Length; i++) {
                resultado = resultado + valores[i];
            }

            return resultado;
        }

    }
}