using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

/// <summary>
/// Summary description for BasePage
/// </summary>
public class BasePage : System.Web.UI.Page
{
	public BasePage()
	{
        //InitializeCulture();
	}

    protected override void InitializeCulture()
    {
        String language;
        String currLanguage = UICulture;
        System.Web.SessionState.HttpSessionState session = HttpContext.Current.Session;

        if ( session != null)
        {
            language = (String)session["UICulture"];

            if (language != null)
            {

                if (!currLanguage.Equals(language))
                {
                    UICulture = language;
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
                }
            }
        }
        base.InitializeCulture();

    }
}