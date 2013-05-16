using System;
using System.Collections.Generic;
using System.Web.DynamicData;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

[MetadataType(typeof(DealMetadata))]
public partial class Deal
{
    public double DiscountedPrice {
        get {
            return this.Value * this.DiscountRate / 100;
        }
    }
}

public class DealMetadata
{
    [UIHint("DescDataField")]
    public object OtherDesc;

    [UIHint("TermsDataField")]
    public object Terms;

    [UIHint("ImageUploadDataField")]
    public object ImageURL;
}