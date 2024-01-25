using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataForm_Customization
{
    public class DataFormItemManagerExt:DataFormItemManager
    {
        public override void InitializeDataEditor(DataFormItem dataFormItem, View editor)
        {
            if(editor is Entry entry)
            {
                entry.FontAttributes = FontAttributes.Bold;
                entry.FontSize = 19;
            }
            base.InitializeDataEditor(dataFormItem, editor);
        }
    }
}
