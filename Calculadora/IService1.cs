using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Calculadora
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        int Soma(int n1, int n2);

        [OperationContract]
        int Subtracao(int n1, int n2);

        [OperationContract]
        int Divisao(int n1, int n2);

        [OperationContract]
        int Multiplicacao(int n1, int n2);
    }

}
