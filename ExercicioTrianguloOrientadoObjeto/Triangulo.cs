using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTrianguloOrientadoObjeto
{
    internal class Triangulo
    {
        public int valorXis, valorYpsolon, valorZeh;
        public string tipoTriangulo;

        public string DesenharTriangulo()
        {
            
            if (tipoTriangulo == "Escaleno")
            {
                return ("\n   ESCALENO    " +
                        "\n   |\\          " +
                        "\n   | \\         " +
                        "\n   |  \\        " +
                        "\n   |   \\       " +
                        "\n   |    \\      " +
                        "\n   |     \\     " +
                        "\n   |      \\    " +
                        "\n   |_______\\   ");

            }
            else if (tipoTriangulo == "Isósceles")
            {
                return ("\n       ISÓSCELES       " +
                        "\n         /|\\         " +
                        "\n        / | \\        " +
                        "\n       /  |  \\       " +
                        "\n      /   |   \\      " +
                        "\n     /    |    \\     " +
                        "\n    /     |     \\    " +
                        "\n   /______|______\\   ");
            }
            else if (tipoTriangulo == "Equilátero")
            {
                return ("\n      EQUILÁTERO        " +
                        "\n           .          " +
                        "\n          / \\          " +
                        "\n         /   \\         " +
                        "\n        /     \\        " +
                        "\n       /       \\       " +
                        "\n      /         \\      " +
                        "\n     /           \\     " +
                        "\n    /             \\    " +
                        "\n   /               \\   " +
                        "\n  /_________________\\  ");
            }
            else
            {
                return ("Não há um desenho para esse triângulo!");
            }
        }
        public string VerificarTriangulo()
        {   
            
            if (valorXis == valorYpsolon && valorXis == valorZeh)
            {
                tipoTriangulo = "Equilátero";
                return ($"É um triângulo equilátero! Todos os lados são iguais!{DesenharTriangulo()}");
            }
            else if (
                   valorXis == valorYpsolon && valorXis != valorZeh
                || valorXis == valorZeh && valorXis != valorYpsolon
                || valorZeh == valorYpsolon && valorZeh != valorXis)
            {
                tipoTriangulo = "Isósceles";
                return ($"É um triângulo isósceles! Dois lados iguais e uma base diferente!{DesenharTriangulo()}");
            }

            if (valorXis != valorYpsolon && valorYpsolon != valorZeh && valorZeh != valorXis)
            {
                tipoTriangulo = "Escaleno";
                return ($"É um triângulo escaleto! Todos os lados são diferentes!{DesenharTriangulo()}");
            }
            else
            {
                return ("Valores inválidos!");
            }


        }
    }
}
