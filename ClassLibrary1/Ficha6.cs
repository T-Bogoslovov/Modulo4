using System;

namespace Modulo4
{
    public class Ficha6Solucao
    {
        #region Ex.1
        //Write name and greet! Input 
        public static void Exercicio1() 
        {
            Console.WriteLine("Qual é o nome?");
            var nome = Console.ReadLine();
            OlaNome(nome);
        }

        #region OlaNome
        //Output OlaNome
        /// <summary>
        ///  <--- /// Comment
        /// </summary>
        /// <param name="nome"></param>
        private static void OlaNome(string nome) 
        {
            Console.WriteLine("Olá " + nome);
        }
        #endregion
        #endregion

        #region Ex.2
        public static void Exercicio2()
        {
            Console.WriteLine("Num1?");
            var num1 = Console.ReadLine();
            Console.WriteLine("Num2?");
            var num2 = Console.ReadLine();
            var num1Conv = ConverterStringParaNumero(num1);
            var num2Conv = ConverterStringParaNumero(num2);
            ApresentarSoma(num1Conv, num2Conv);
        }

        public static int ConverterStringParaNumero(string num)
        {
            var parseOk = int.TryParse(num, out int parsedNum);
            return parsedNum;
        }
        public static void ApresentarSoma(int numA, int numB)
        {
            Console.WriteLine(numA + " + " + numB + " = " + (numA + numB));
        }

        #endregion

        #region Ex.3
        public static int LerNumEConverter()
        {
            Console.WriteLine("Numero?");
            var num = Console.ReadLine();
            return ConverterStringParaNumero(num);

        }
        public static void Exercicio3()
        {
            var acumulador = LerNumEConverter();
            acumulador += LerNumEConverter();
            acumulador += LerNumEConverter();
            acumulador += LerNumEConverter();
            acumulador += LerNumEConverter();
            acumulador += LerNumEConverter();
            acumulador += LerNumEConverter();
            acumulador += LerNumEConverter();
            acumulador += LerNumEConverter();
            acumulador += LerNumEConverter();
            Console.WriteLine(acumulador);
        }
        #endregion

        #region Ex.4
        public static void Exercicio4()
        {
            Console.WriteLine("Qual é o valor de a?");
            var a = Console.ReadLine();
            Console.WriteLine("Qual é o valor de b?");
            var b = Console.ReadLine();
            Console.WriteLine("A = " + b + " e " + "B = " + a);
        }
        #endregion 

        #region Ex.4-Fab
        //Solicitar 2 Numeros, Trocar as possicoes e apresentar a troca
        public static void Exercicio4_0()
        {
            Console.WriteLine("Primeiro numero?");
            int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Segundo numero?");
            int.TryParse(Console.ReadLine(), out int num2);
            var aux = 0;
            aux = num1;
            num1 = num2;
            num2 = aux;
            Console.WriteLine("Primeiro numero " + num1 + "\nSegundo numero " + num2);
        }
        #endregion

        #region Ex.5
        public static void Exercicio5A()
        {
            Console.WriteLine("Primeiro numero?");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo numero?");
            var num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Terceiro numero?");
            var num3 = int.Parse(Console.ReadLine());
            CalcNum(num1, num2, num3);
        }
        private static void CalcNum(int n1, int n2, int n3)
        {
            var r = n1 + n2 * n3;
            Console.WriteLine("O resultado e:" + r);
        }
        #endregion

        #region Ex.5B
        public static void Exercicio5b()
        {
            Console.WriteLine("Numero:");
            var num1 = ConverterStringParaNumero(Console.ReadLine());
            Console.WriteLine("Numero:");
            var num2 = ConverterStringParaNumero(Console.ReadLine());
            Console.WriteLine("Numero:");
            var num3 = ConverterStringParaNumero(Console.ReadLine());
            var calc = (num1 + num2) % num3;
            Console.WriteLine("(" + num1 + "+" + num2 + ")%" + num3 + "=" + calc);

        }
        public static void Exercicio5bOptimized()
        {
            var num1 = LerNumEConverter();
            var num2 = LerNumEConverter();
            var num3 = LerNumEConverter();
            var calc = (num1 + num2) % num3;
            Console.WriteLine("(" + num1 + "+" + num2 + ")%" + num3 + "=" + calc);

        }
        public static void Exercicio5bOptimizedFabio()
        {
            var num1 = LerNumEConverter();
            var num2 = LerNumEConverter();
            var num3 = LerNumEConverter();
            CalcNum2(num1, num2, num3);
        }
        private static void CalcNum2(int n1, int n2, int n3)
        {
            var r = n1 + n2 * n3;
            Console.WriteLine("O resultado e" + r);
        }
        #endregion

        #region Ex.5C
        public static void Exercicio5c()
        {
            var num1 = LerNumEConverter();
            var num2 = LerNumEConverter();
            var num3 = LerNumEConverter();
            var num4 = LerNumEConverter();

            CalcNumC(num1, num2, num3, num4);
        }
        private static void CalcNumC(int num1, int num2, int num3, int num4)
        {
            var r = num1 - num2 * num3 / num4;
            Console.WriteLine("O resultado e:" + r);
        }
        #endregion

        #region Ex.5D
        public static void Exercicio5D()
        {
            Console.WriteLine("Digite o primeiro numero");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            var num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero");
            var num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto numero");
            var num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quinto numero");
            var num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seixto numero");
            var num6 = int.Parse(Console.ReadLine());
            CalcNumD(num1, num2, num3, num4, num5, num6);
        }
        public static void CalcNumD(int a, int b, int c, int d, int e, int f)
        {
            var res = a + (b / c * d) - (e % f);
            Console.WriteLine("Resultado e:" + res);
        }
        #endregion

        #region Ex.5DOptimized
        public static void Exercicio5DOptimized()
        {
            var num1 = LerNumEConverter();
            var num2 = LerNumEConverter();
            var num3 = LerNumEConverter();
            var num4 = LerNumEConverter();
            var num5 = LerNumEConverter();
            var num6 = LerNumEConverter();

            CalcNumD2(num1, num2, num3, num4, num5, num6);
        }
        public static void CalcNumD2(double a, double b, double c, double d, double e, double f)
        {
            var res = a + (b / c * d) - (e % f);
            Console.WriteLine("Resultado e:" + res);
        }
        #endregion

        #region Exercicio6
        public static void Exercicio6()
        {
            Console.Write("Digite um numero: ");
            var num = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\n" + num * 1);
            Console.WriteLine(num * 2);
            Console.WriteLine(num * 3);
            Console.WriteLine(num * 4);
            Console.WriteLine(num * 5);
            Console.WriteLine(num * 6);
            Console.WriteLine(num * 7);
            Console.WriteLine(num * 8);
            Console.WriteLine(num * 9);
            Console.WriteLine(num * 10);

        }
        #endregion

        #region Ex7
        public static void Exercicio7()
        {
            Console.WriteLine("Digite um numero?");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite segundo numero?");
            var b = int.Parse(Console.ReadLine());
            var med = CalcMed(a, b);
            Console.WriteLine(med);
        }
        public static double CalcMed(int a, int b)
        {
            double med = (a + b) / 2;
            return med;
        }
        #endregion

        #region Ex8
                public static void Exercicio8()
                {
                    Console.WriteLine("Digite primeiro numero?");
                    var a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite segundo numero?");
                    var b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite terceiro numero?");
                    var c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite quarto numero?");
                    var d = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite quinto numero?");
                    var e = int.Parse(Console.ReadLine());
                    double med2 = CalcMed2(a, b, c, d, e);
                    Console.WriteLine(med2);
                }
                public static double CalcMed2(double a, double b, double c, double d, double e)
                {
                    double med2 = (a + b + c + d + e) / 2;
                    return med2;
                }
        #endregion

        #region Ex9
        public static void Exercicio9()
        {
            var n1 = LerNumEConverter();
            var n2 = LerNumEConverter();
            var n3 = LerNumEConverter();
            var n4 = LerNumEConverter();
            var n5 = LerNumEConverter();
            var n6 = LerNumEConverter();
            var n7 = LerNumEConverter();
            var n8 = LerNumEConverter();
            var n9 = LerNumEConverter();
            var n10 = LerNumEConverter();
            var med3 = CalcMed3(n1, n2, n3, n4, n5, n6, n7, n8, n9, n10);
            Console.WriteLine(med3);
        }
        public static double CalcMed3(int a,int  b,int  c,int  d,int  e,int  f,int  g,int  h,int  i,int  j)
        {
            double med3 = (a + b + c + d + e + f + g + h + i + j) / 2;
            return med3;
        }
        #endregion

        #region Exercicio 10
        public static void Exercicio10()
        {
            Console.WriteLine("digite um caracter");
            var c = Console.ReadLine();
            Console.WriteLine(c + c + c);
            Console.WriteLine(c + c + c);
            Console.WriteLine(c + c + c);
        }
        #endregion

        #region Ex11 
        public static void Exercicio11()
        {
           

            var totalGlobal = productTotal();
            totalGlobal = totalGlobal + productTotal();
            totalGlobal = totalGlobal + productTotal();
            Console.WriteLine("O total global é :" + totalGlobal);
        }
        public static double productTotal()
        {
            Console.WriteLine("Introduz o nome do produto");
            var p = Console.ReadLine();
            Console.WriteLine("Introduz o preco do produto");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduz a quantidade do produto");
            var q = int.Parse(Console.ReadLine());
            double total = s * q;
            Console.WriteLine("O resultado é : " + total);
            return total;
        }

        #endregion

        #region Ex12
        public static void Exercicio12()
        {
            Console.WriteLine("Diz-me algo que não saiba");
            var x = Console.ReadLine();
            Console.WriteLine("Eu ja sabia que " + x);

        }
        #endregion

        #region Ex13
        public static void Exercicio13()
        {
            Console.WriteLine("Introduz dois números");
            int fstNum = int.Parse(Console.ReadLine());
            int sndNum = int.Parse(Console.ReadLine());
            Console.WriteLine("O primeiro numéro é: " + fstNum + " e o segundo numéro é: " + sndNum);
        }
        #endregion

        #region Ex14
        public static void Exercicio14()
        {
            Console.WriteLine("Introduz a temperatura");
            var t = double.Parse(Console.ReadLine());
            double tf = t * 9 / 5 + 32;
            double tk = t + 273.15;
            Console.WriteLine("A temp em Celsio é: " + t + "\nA temp em Kelvin é: " + tk + "\nA temp em Fahrenheit é: " + tf);

        }
        #endregion

        #region Ex.15
        public static void Exercicio15()
        {
            Console.WriteLine("Quantas horas?");
            double horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos minutos?");
            var minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas segundos?");
            var segundos = int.Parse(Console.ReadLine());
            var total = (horas * 3600) + (minutos * 60) + segundos;
            Console.WriteLine("O total de segundos é: " + total);
        }
        #endregion

        #region Exercicio.16
        public static void Exercicio16()
        {
            Console.WriteLine("Qual e o raio?");
            var raio = int.Parse(Console.ReadLine());
            var perimetro = CalcPerimetro(raio);
            var area = CalcArea(raio);
            Console.WriteLine("Raio e: " + raio + "\nPerimetro e: " + perimetro);
        }
        public static double CalcPerimetro(int raio)
        {
            double perimetro = raio * 2 * 3.14;
            return perimetro;
        }
        public static double CalcArea(int raio)
        {
            var area = raio * raio * 3.14;
            return area;
        }
        #endregion

        #region ExemploConcatenação
        public static void Exemplo()
        {
            Console.WriteLine("Introduza o valor");
            var val = Console.ReadLine();
            Console.WriteLine("Introduza o caracter");
            var cha = Console.Read();
            Console.WriteLine("Introduza a tecla");
            var tec = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Valor" + val + "\nCaracter" + cha + "\nTecla" + tec.Key);
            Console.WriteLine($"\nValor {val} \nCaracter {cha}\nTecla {tec.Key}");
            Console.WriteLine(@"Valor {0} Caracter {1} Tecla {2}", val, cha, tec.Key);
            if (tec.Key == ConsoleKey.UpArrow) Console.WriteLine("Para cimaaaa");
            if (tec.Key == ConsoleKey.DownArrow) Console.WriteLine("Para baixooo");

        }
        #endregion

    }
}