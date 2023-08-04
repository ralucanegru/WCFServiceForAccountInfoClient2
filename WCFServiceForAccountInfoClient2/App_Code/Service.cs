using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}

    public InquireAccountInfosByIdentifiersResponse GetAccountInfoByIdentifiers()
    {
        var accountInfos = new AccountInfos();

        var accountInfo1 = SetAccountInfo();
        var accountInfo2 = SetAccountInfo();

        accountInfos.Add(accountInfo1);
        accountInfos.Add(accountInfo2);

        return new InquireAccountInfosByIdentifiersResponse
        {
            AccountInfos = accountInfos
        };
    }

    private AccountInfo SetAccountInfo()
    {
        var bankIdentifier = new BankIdentifier("string", BankIdentifierType.BIC);
        var accountIdentifierField = new AccountIdentifier("string", "string", "string", bankIdentifier, "string");
        var contractTypeField = ContractType.Loan;
        var parentAccountIdentifierField = new AccountIdentifier("string", "string", "string", bankIdentifier, "string");
        var language = new Language("ro", "ro", "romania");
        var multiLanguageText = new MultiLanguageText(language, "buna");
        var multiLanguageProductNameField = new List<MultiLanguageText> { multiLanguageText };
        var accountStatusField = ContractStatus.New;
        var accountStickersField = new AccountSticker(multiLanguageProductNameField, AccountRestriction.Information, multiLanguageProductNameField);
        var listAccountStickersField = new List<AccountSticker> { accountStickersField };
        var currency = new Currency("string");
        var currencyAmount = new CurrencyAmount(12, currency);
        var accountAmount = new AccountAmount(currencyAmount, AmountType.AccruedPositiveInterest);
        var accountAmountsField = new List<AccountAmount> { accountAmount };
        var maskedPANField = "string";
        var contractHolderIdentifierField = "string";

        var accountInfo = new AccountInfo(accountIdentifierField, contractTypeField, parentAccountIdentifierField, multiLanguageProductNameField, accountStatusField, listAccountStickersField, accountAmountsField, maskedPANField, contractHolderIdentifierField);

        return accountInfo;
    }
}


