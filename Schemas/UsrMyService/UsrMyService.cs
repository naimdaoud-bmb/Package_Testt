namespace Terrasoft.Configuration.UsrMyService
{
    using Terrasoft.Web.Http.Abstractions;  // Use instead of System.Web
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Terrasoft.Core;
	using Terrasoft.Web.Common;
	

    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class UsrMyService
    {
        // Service method.
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
        ResponseFormat = WebMessageFormat.Json)]
        public string SomeMethod() {
          	return "My Answer message - OK - internal!";
        }
    }
}