using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order
/// </summary>
public partial class Order
{
    public bool isExpired {
        get {
            if (DateTime.Compare(DateTime.Now, ExpiresOn)<=0) {
                return false;
            }

            return true;
        }
    }
	
}