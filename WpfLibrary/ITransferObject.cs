

using System.ServiceModel;
using System.Threading.Tasks;
using WcfContract;

namespace WcfContract
{
    //установить библиотеку System.ServiceModel
    [ServiceContract]
    public interface ITransferObject
    {
        //прописываем методы к которым должен быть доступен wcf
        [OperationContract]
        Task<string> SentUser(UserDTO user);
        [OperationContract]
        Task<object> FindUser(UserDTO user);
        //[OperationContract]
        //Task<string> SentCompany(CompanyDTO user);
        //[OperationContract]
        //Task<CompanyDTO> FindCompany(CompanyDTO user);
    }
}