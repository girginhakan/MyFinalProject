using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //Giriş Tokenı üretecek yer.
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
