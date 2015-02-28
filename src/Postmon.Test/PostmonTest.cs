using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Postmon.Test
{
    [TestClass]
    public class PostmonTest
    {
        [TestMethod]
        public void CEPs_Validos_Devem_Retornar_Endereco()
        {
            Assert.IsNotNull(Postmon.PostmonClient.ConsultarCEP("29010190"));
            Assert.IsNotNull(Postmon.PostmonClient.ConsultarCEP("29050265"));
        }

        [TestMethod]
        public void CEPs_Invalidos_Devem_Retornar_Nulo()
        {
            Assert.IsNull(Postmon.PostmonClient.ConsultarCEP("9999999"));
            Assert.IsNull(Postmon.PostmonClient.ConsultarCEP("fdfsfs"));
        }

        [TestMethod]
        public void CEP_Valido_Deve_Retornar_Endereco_Correto()
        {
            Endereco endereco = Postmon.PostmonClient.ConsultarCEP("29050265");
            Assert.IsNotNull(endereco);
            Assert.IsTrue(endereco.CEP == "29050265");
            Assert.IsTrue(endereco.Cidade.Nome == "Vitória");
            Assert.IsTrue(endereco.Cidade.Estado.Sigla == "ES");
        }


        [TestMethod]
        public void UF_Valida_Deve_Retornar_Estado()
        {
            Assert.IsNotNull(Postmon.PostmonClient.ConsultarEstado("es"));
            Assert.IsNotNull(Postmon.PostmonClient.ConsultarEstado("ES"));
            Assert.IsNotNull(Postmon.PostmonClient.ConsultarEstado("Es"));
        }

        [TestMethod]
        public void UF_Invalida_Deve_Retornar_Nulo()
        {
            Assert.IsNull(Postmon.PostmonClient.ConsultarEstado("xx"));
            Assert.IsNull(Postmon.PostmonClient.ConsultarEstado("xyz"));
        }

        [TestMethod]
        public void UF_Deve_Estar_Relacionada_a_Estado()
        {
            Estado es = Postmon.PostmonClient.ConsultarEstado("ES");
            Assert.IsTrue(es.Nome == "Espírito Santo");
        }



    }
}
