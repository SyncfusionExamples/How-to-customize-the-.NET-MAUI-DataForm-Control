namespace DataForm_Customization
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void dataForm_GenerateDataFormItem(object sender, Syncfusion.Maui.DataForm.GenerateDataFormItemEventArgs e)
        {
            e.DataFormItem.LabelTextStyle = new Syncfusion.Maui.DataForm.DataFormTextStyle()
            {
                FontSize=19,
                TextColor=Colors.Black,
                FontAttributes=FontAttributes.Bold
            };
            e.DataFormItem.EditorTextStyle = new Syncfusion.Maui.DataForm.DataFormTextStyle()
            {
                FontSize = 19,
                TextColor=Colors.Black,
                FontAttributes = FontAttributes.Italic
            };
            if(e.DataFormItem.FieldName=="FirstName")
            {
                e.DataFormItem.LabelText = "First Name";
                e.DataFormItem.PlaceholderText = "Enter your first name";
            }
            if (e.DataFormItem.FieldName == "MiddleName")
            {
                e.DataFormItem.LabelText = "Middle Name";
                e.DataFormItem.PlaceholderText = "Enter your middle name";
            }
            if (e.DataFormItem.FieldName == "LastName")
            {
                e.DataFormItem.LabelText = "Last Name";
                e.DataFormItem.PlaceholderText = "Enter your last name";
            }
            if (e.DataFormItem.FieldName == "ContactNumber")
            {
                e.DataFormItem.LabelText = "Contact Number";
                e.DataFormItem.PlaceholderText = "Enter your contact number";
                e.DataFormItem.LeadingView = new Label()
                {
                    Text="E",
                    FontFamily="InputLayoutIcons",
                    FontSize=18,
                    VerticalTextAlignment=TextAlignment.Center,
                };
            }
            if (e.DataFormItem.FieldName == "Email")
            {
                e.DataFormItem.LabelText = "Email";
                e.DataFormItem.PlaceholderText = "Enter your email";
            }
            if (e.DataFormItem.FieldName == "Address")
            {
                e.DataFormItem.LabelText = "Address";
                e.DataFormItem.PlaceholderText = "Enter your address";
            }
            if (e.DataFormItem.FieldName == "BirthDate")
            {
                e.DataFormItem.LabelText = "Birth Date";
                e.DataFormItem.PlaceholderText = "Enter your birth date";
            }
        }
    }

}
