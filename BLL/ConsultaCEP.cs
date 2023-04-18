using System;

namespace CEPBLL
{
    public class ConsultaCEP
    {
        public CEP Consultar(string CepConsulta)
        {
            CEP cepRetorno = new CEP();
            cepRetorno.Bairro = "Boqueirao";
            cepRetorno.Logradouro = "Rua Osvaldo Cruz";
            cepRetorno.Complemento = "lado par";
            cepRetorno.Ddd = "13";
            cepRetorno.Localidade = "Santos";
            cepRetorno.Cep = "11045-140";
            cepRetorno.Uf = "SP";


            return cepRetorno;
        }
    }
}
