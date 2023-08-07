using Quipu.Banking.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
[ServiceBehavior(IncludeExceptionDetailInFaults = true)]
public class Service : IService
{
    public string GetData(int value)
    {
        return string.Format("You entered: {0}", value);
    }

    public Quipu.Banking.Client.InquireAccountInfosByIdentifiersResponse InquireAccountInfosByIdentifiers(Quipu.Banking.Client.InquireAccountInfosByIdentifiersRequest request)
    {
        var accountInfos = new Quipu.Banking.Client.AccountInfos();

        var accountInfo1 = SetAccountInfo();
        var accountInfo2 = SetAccountInfo();

        accountInfos.Add(accountInfo1);
        accountInfos.Add(accountInfo2);

        var response = new Quipu.Banking.Client.InquireAccountInfosByIdentifiersResponse
        {
            AccountInfos = accountInfos
        };

        return response;
    }

    public Task<Quipu.Banking.Client.InquireAccountInfosByIdentifiersResponse> InquireAccountInfosByIdentifiersAsync(Quipu.Banking.Client.InquireAccountInfosByIdentifiersRequest request)
    {
        var accountInfos = new Quipu.Banking.Client.AccountInfos();

        var accountInfo1 = SetAccountInfo();
        var accountInfo2 = SetAccountInfo();

        accountInfos.Add(accountInfo1);
        accountInfos.Add(accountInfo2);

        var response = new Quipu.Banking.Client.InquireAccountInfosByIdentifiersResponse
        {
            AccountInfos = accountInfos
        };

        return Task.FromResult(response);
    }

    private Quipu.Banking.DataContracts.AccountInfo SetAccountInfo()
    {
        var bankIdentifier = new Quipu.Banking.DataContracts.BankIdentifier { Code = "string", BankIdentifierType = Quipu.Banking.DataContracts.BankIdentifierType.BIC };
        var accountIdentifierField = new Quipu.Banking.DataContracts.AccountIdentifier { AccountNumber = "string", AccountName = "string", IBAN = "string", BankIdentifier = bankIdentifier, NBAN = "string" };
        var contractTypeField = Quipu.Banking.DataContracts.ContractType.Loan;
        var parentAccountIdentifierField = new Quipu.Banking.DataContracts.AccountIdentifier { AccountNumber = "string", AccountName = "string", IBAN = "string", BankIdentifier = bankIdentifier, NBAN = "string" };
        var language = new Quipu.Banking.DataContracts.Language{ CultureName = "ro", ShortName= "ro", LongName= "romania"};
        var multiLanguageText = new Quipu.Banking.DataContracts.MultiLanguageText { Language= language, Text = "buna" };
        var multiLanguageProductNameField = new List<Quipu.Banking.DataContracts.MultiLanguageText> { multiLanguageText };
        var accountStatusField = Quipu.Banking.DataContracts.ContractStatus.New;
        var accountStickersField = new Quipu.Banking.DataContracts.AccountSticker { RestrictionDescription= multiLanguageProductNameField, AccountRestriction = Quipu.Banking.DataContracts.AccountRestriction.Information, Message = multiLanguageProductNameField };
        var listAccountStickersField = new List<Quipu.Banking.DataContracts.AccountSticker> { accountStickersField };
        var currency = new Quipu.Banking.DataContracts.Currency { IsoCode =  "string" };
        var currencyAmount = new Quipu.Banking.DataContracts.CurrencyAmount { Amount= 12, Currency= currency };
        var accountAmount = new Quipu.Banking.DataContracts.AccountAmount { CurrencyAmount= currencyAmount, AmountType= Quipu.Banking.DataContracts.AmountType.AccruedPositiveInterest };
        var accountAmountsField = new List<Quipu.Banking.DataContracts.AccountAmount> { accountAmount };
        var maskedPANField = "string";
        var contractHolderIdentifierField = "string";

        var accountInfo = new Quipu.Banking.DataContracts.AccountInfo { AccountIdentifier= accountIdentifierField, ContractType= contractTypeField,  ParentAccountIdentifier = parentAccountIdentifierField, MultiLanguageProductName =  multiLanguageProductNameField, AccountStatus= accountStatusField,AccountStickers=  listAccountStickersField, AccountAmounts =  accountAmountsField, MaskedPAN = maskedPANField,  ContractHolderIdentifier =contractHolderIdentifierField };

        return accountInfo;
    }
}


