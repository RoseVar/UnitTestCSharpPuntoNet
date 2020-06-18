using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContarVocales
{
    public class Contarvocales
    {
        static int a = 0, e = 0, i = 0, o = 0, u = 0;
        static void Main(string[] args)
        {
            string palabra = "murcielagoáìö";
            Console.WriteLine("La palabra es: " + palabra);
            int resultado = gestionVocales(palabra);
            switch (resultado)
            {
                case -1:
                    Console.WriteLine("No ha introducido cadena de texto (es null)");
                    break;
                case -2:
                    Console.WriteLine("La longitud es superior a 50");
                    break;
                case -3:
                    Console.WriteLine("Has puesto una frase vacía");
                    break;
                case -4:
                    Console.WriteLine("Hay contenido que no son letras (por ejemplo: espacios, números...)");
                    break;
                case 1:
                    Console.WriteLine("Se ha podido contar todas las vocales correctamente");
                    break;
                default:
                    Console.WriteLine("Ha habido algún problema con el programa");
                    break;
            }
            Console.ReadLine();
        }
        

        public static int gestionVocales(string v)
        {
            int result = 0;
            //VERIFICAR datos de entrada
            //que no sea null
            if (v != null) { 
                //que no tenga mas de 50 caracteres
                if (v.Length<50) { 
                    //que no esté vacío
                    if(!"".Equals(v)) {
                        //que todos los carácteres sean letras
                        if (v.All(char.IsLetter)) {
                            //REALIZAR el método
                            //pasar a minusculas toda la cadena e ignorar espacios
                            v = v.ToLower();
                            //cambiar todas las vocales con acentos o diéresis a vocal sencilla
                            v = metodReplace(v);
                            //contar                            
                            foreach (char c in v)
                            {
                                switch (c)
                                {
                                    case 'a':
                                        a++;
                                        break;
                                    case 'e':
                                        e++;
                                        break;
                                    case 'i':
                                        i++;
                                        break;
                                    case 'o':
                                        o++;
                                        break;
                                    case 'u':
                                        u++;
                                        break;
                                    default:
                                        break;
                                }
                            }
                            Console.WriteLine("La palabra contiene " + a + " veces la vocal a");
                            Console.WriteLine("La palabra contiene " + e + " veces la vocal e");
                            Console.WriteLine("La palabra contiene " + i + " veces la vocal i");
                            Console.WriteLine("La palabra contiene " + o + " veces la vocal o");
                            Console.WriteLine("La palabra contiene " + u + " veces la vocal u");
                            result = 1;

                        } else
                        {
                            result = -4;
                        }

                        } else {
                            result = -3;
                        }
                        

                } else {
                    result = -2;
                }

            } else {
                result = -1;
            }
            return result;
        }

        public static string metodReplace(string v)
        {

            char[] aes = { 'á', 'à', 'ä' };
            char[] ees = { 'é', 'è', 'ë' };
            char[] ies = { 'í', 'ì', 'ï' };
            char[] oes = { 'ó', 'ò', 'ö' };
            char[] ues = { 'ú', 'ù', 'ü' };
            String result = v.ToLower();
            foreach (char c in result)
            {
                if (aes.Contains(c))
                {
                    result= result.Replace(c, 'a');
                }
                if (ees.Contains(c))
                {
                    result = result.Replace(c, 'e');
                }
                if (ies.Contains(c))
                {
                    result = result.Replace(c, 'i');
                }
                if (oes.Contains(c))
                {
                    result = result.Replace(c, 'o');
                }
                if (ues.Contains(c))
                {
                    result = result.Replace(c, 'u');
                }
            }
            return result;
        }
    }
}
