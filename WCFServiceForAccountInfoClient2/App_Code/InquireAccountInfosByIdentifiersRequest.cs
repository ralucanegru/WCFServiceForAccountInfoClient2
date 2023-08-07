using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Summary description for InquireAccountInfosByIdentifiersRequest
/// </summary>
/// 
public class InquireAccountInfosByIdentifiersRequest
{
    [MessageBodyMember( Order = 0)]
    public AccessContract AccessContract;

    [MessageBodyMember( Order = 1)]
    public AccountIdentifiers AccountIdentifiers;

    [MessageBodyMember(Order = 2)]
    public Language Language;
    public InquireAccountInfosByIdentifiersRequest()
    {
    }

    public InquireAccountInfosByIdentifiersRequest(AccessContract AccessContract, AccountIdentifiers AccountIdentifiers, Language Language)
    {
        this.AccessContract = AccessContract;
        this.AccountIdentifiers = AccountIdentifiers;
        this.Language = Language;
    }
}