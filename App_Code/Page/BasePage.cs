using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI.HtmlControls;

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

    public string getCurrentTheme() {

        string theme = (string)HttpContext.Current.Session["Theme"];

        if (theme != null) {
            return theme;
        }

        return "Cyborg";
    }

    protected override void OnInit(EventArgs e)
    {
        // Define an HtmlLink control.
        HtmlLink myHtmlLink = new HtmlLink();
        myHtmlLink.Href = "bootstrap/css/"+getCurrentTheme()+".css";
        myHtmlLink.Attributes.Add("rel", "stylesheet");
        myHtmlLink.Attributes.Add("type", "text/css");
        Page.Header.Controls.Add(myHtmlLink);

        HtmlLink myHtmlLink2 = new HtmlLink();
        myHtmlLink2.Href = "bootstrap/css/font-awesome.css";
        myHtmlLink2.Attributes.Add("rel", "stylesheet");
        myHtmlLink2.Attributes.Add("type", "text/css");
        Page.Header.Controls.Add(myHtmlLink2);

        HtmlLink myHtmlLink3 = new HtmlLink();
        myHtmlLink3.Href = "bootstrap/css/customoverrides.css";
        myHtmlLink3.Attributes.Add("rel", "stylesheet");
        myHtmlLink3.Attributes.Add("type", "text/css");
        // Add the HtmlLink to the Head section of the page.
        Page.Header.Controls.Add(myHtmlLink3);


    } 
}