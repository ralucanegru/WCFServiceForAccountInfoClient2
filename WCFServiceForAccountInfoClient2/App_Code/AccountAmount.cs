using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Linq;

/// <summary>
/// Summary description for AccountAmount
/// </summary>
/// 
[DataContract(Name = "AccountAmount")]
[KnownType(typeof(AmountType))]
public class AccountAmount
{
    private CurrencyAmount currencyAmountField;
    private AmountType amountTypeField;

    public AccountAmount(CurrencyAmount currencyAmount, AmountType amountType)
    {
        CurrencyAmount = currencyAmount;
        AmountType = amountType;
    }

    [DataMember(Name = "CurrencyAmount", IsRequired = false, Order = 0)]
    public CurrencyAmount CurrencyAmount
    {
        get
        {
            return currencyAmountField;
        }
        set
        {
            currencyAmountField = value;
        }
    }

    [DataMember(Name = "AmountType", IsRequired = false, Order = 1)]
    public AmountType AmountType
    {
        get
        {
            return amountTypeField;
        }
        set
        {
            amountTypeField = value;
        }
    }
}