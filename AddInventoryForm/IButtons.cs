using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddInventoryForm
{
    public interface IButtons
    {
        void SubscribeEdit(Action<bool> Method);

        void SubscribeRemove(Action<bool> Method);

        void ClearAsterisks();
        bool DataLoss();
        bool SaveRecord();
        void ClearFields();
        void EditRecord();
        void RemoveRecord();
        void EnableFields(bool val);     
        void SampleInput();
    }
}
