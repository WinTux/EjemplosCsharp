using System;
using System.Collections.Generic;
using System.Text;

namespace super_interfaces
{
    public interface ICualquiera
    {
        public string RetornarSaludo(string nombre);
        public void DecirAlgo();
    }

    public interface IFiguraGeometrica {
        public float RetornarArea();
        public float RetornarAltura();
        public void DecirMiTipo();
    }

    public class Rectangulo : IFiguraGeometrica
    {
        float ancho, alto;
        public Rectangulo(float ancho, float alto) {
            this.ancho = ancho;
            this.alto = alto;
        }

        public void DecirMiTipo()
        {
            Console.WriteLine("Soy un rectangulo");
        }

        public float RetornarAltura()
        {
            return alto;
        }

        public float RetornarArea()
        {
            return ancho * alto;
        }
    }

    public class Circulo : IFiguraGeometrica
    {
        float radio;
        public Circulo(float radio) {
            this.radio = radio;
        }


        public float RetornarAltura()
        {
            return 2 * radio;
        }

        public float RetornarArea()
        {
            return (float)(Math.Pow(radio,2) * Math.PI);
        }
        public void DecirMiTipo()
        {
            Console.WriteLine("Soy un círculo");
        }
    }

    public class Triangulo : IFiguraGeometrica
    {
        float basse, altura;
        public Triangulo(float basse, float altura)
        {
            this.basse = basse;
            this.altura = altura;
        }

        public float RetornarAltura()
        {
            return altura;
        }

        public float RetornarArea()
        {
            return basse * altura / 2f;
        }
        public void DecirMiTipo()
        {
            Console.WriteLine("Soy un triangulo");
        }
    }
}
