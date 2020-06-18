using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContarVocales;

namespace PruebasContarVocales
{
    [TestClass]
    public class PruebasContar
    {

        //CAJA NEGRA
        [TestMethod]
        public void CadenaConNumeros_ResultMenosCuatro()
        {
            //preparacion
            string cadena = "ad12asdasd";            
            int resEsperado = -4; //resultado previsto para cuando hay numeros

            //accion
            int resObtebnido = Contarvocales.gestionVocales(cadena);

            //comprobación
            Assert.AreEqual(resEsperado, resObtebnido);
        }

        [TestMethod]
        public void CadenaCorrecta_ResultUno()
        {
            //preparacion
            string cadena = "Murcielago";
            int resEsperado = 1; //resultado previsto para cuando todo va bien

            //accion
            int resObtebnido = Contarvocales.gestionVocales(cadena);

            //comprobación
            Assert.AreEqual(resEsperado, resObtebnido);
        }

        [TestMethod]
        public void CadenaMas50caracResultMenosDos()
        {
            //preparacion
            string cadena = "MurcielagoAladoComiaManjaresEnCasaDelHerreroCuchilloDePaloQuienMuchoAbarcaPocoAprieta";
            int resEsperado = -2; //resultado previsto para cuando la cadena es superior a 50 caracteres

            //accion
            int resObtebnido = Contarvocales.gestionVocales(cadena);

            //comprobación
            Assert.AreEqual(resEsperado, resObtebnido);
        }


        //CAJA BLANCA
        [TestMethod]
        public void CadenaConAcentosEsModificadaACadenaSin()
        {
            //preparacion
            string cadena = "ánìmö";
            string cadenaEsperada= "animo"; //resultado previsto del método interno que cambia la cadena con acentos, a sin acentos


            //accion
            string resObtebnido = Contarvocales.metodReplace(cadena);

            //comprobación
            Assert.AreEqual(cadenaEsperada, resObtebnido);
        }


    }
}
