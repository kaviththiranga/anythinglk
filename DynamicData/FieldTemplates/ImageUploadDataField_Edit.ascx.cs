using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Web.DynamicData;
using AjaxControlToolkit;
using System.Drawing;

public partial class DynamicData_FieldTemplates_ImageUploadDataField_EditField : System.Web.DynamicData.FieldTemplateUserControl {

    private static string[,] images= new string[10,2];
    private static int imgCount = 0;

    protected void Page_Load(object sender, EventArgs e) {
        imgCount = 0;
        TextBoxImages.ViewStateMode = System.Web.UI.ViewStateMode.Disabled;

        SetUpValidator(RequiredFieldValidator1);
        SetUpValidator(RegularExpressionValidator1);
        SetUpValidator(DynamicValidator1);
    }
    
    protected override void ExtractValues(IOrderedDictionary dictionary) {

        string value = "";

        while (imgCount >= 0) {

            value += images[imgCount, 1] ;//+ ";";
            imgCount--;
        }

        if (value != "")
        {
            dictionary[Column.Name] = ConvertEditedValue(value);
        }
        else
        {
            dictionary[Column.Name] = ConvertEditedValue(TextBoxImages.Text);
        }

        images = new string[10, 2];
        imgCount = 0;
    }

    public override Control DataControl {
        get {
            return TextBoxImages;
        }
    }
    protected void AjaxFileUpload1_UploadComplete(object sender, AjaxControlToolkit.AjaxFileUploadEventArgs e)
    {
        string path = "uploadedImgs/" + AdminController.getCurrentAdmin().User.FirstName + e.FileName.ToString();
        AjaxFileUpload1.SaveAs(MapPath("~/" + path));
        images[imgCount, 1] = path;
        imgCount++;
        /*System.Drawing.Image image = System.Drawing.Image.FromFile(MapPath("~/" + path));
        System.Drawing.Image thumb = image.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
        thumb.Save(MapPath("~/"+"uploadedImgs/thumbs/"+AdminController.getCurrentAdmin().User.FirstName + e.FileName.ToString()));*/
    }
}
