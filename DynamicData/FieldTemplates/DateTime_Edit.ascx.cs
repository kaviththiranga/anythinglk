using System;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Web.DynamicData;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DateTime_EditField : System.Web.DynamicData.FieldTemplateUserControl {
    private static DataTypeAttribute DefaultDateAttribute = new DataTypeAttribute(DataType.DateTime);
    protected void Page_Load(object sender, EventArgs e) {
        TextBox1.ToolTip = Column.Description;
     
    }

    protected void DateValidator_ServerValidate(object source, ServerValidateEventArgs args) {
        DateTime dummyResult;
        args.IsValid = DateTime.TryParse(args.Value, out dummyResult);
    }

    protected override void ExtractValues(IOrderedDictionary dictionary) {
        if (TextBox2.Text != "")
        {
            string formatString = "dd/MM/yyyy HH:mm:ss";
            DateTime val = DateTime.ParseExact(TextBox2.Text, formatString, null);

            dictionary[Column.Name] = val;
        }
        else 
        {
            dictionary[Column.Name] = ConvertEditedValue(TextBox1.Text);
        }
        
    }

    public override Control DataControl {
        get {
            return TextBox1;
        }
    }

}
