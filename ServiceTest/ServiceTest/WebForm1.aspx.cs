using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceTest.AuthenticationRef;

namespace ServiceTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AuthenticationWebServiceSoapClient _asc = new AuthenticationWebServiceSoapClient();
            //_asc.

            string strTest = _asc.AuthenticateUser("17F742F6-1ACF-452A-A114-55116BA1CAB3", "diego", "diego");

           string test = _asc.AuthenticateToken("17F742F6-1ACF-452A-A114-55116BA1CAB3", strTest);

            
            
        }
    }
}