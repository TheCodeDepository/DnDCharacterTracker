using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddInventoryForm
{
    interface IButtons
    {

        void SubscribeEdit(Action<bool> Method);
        void SubscribeSave(Action<bool> Method);
        void SubscribeAdd(Action<bool> Method);
        void SubscribeRemove(Action<bool> Method);
        void ClearFields();
        void EditRecord();
        bool DataLoss();
        void RemoveRecord();
        void EnableFields(bool val);
        bool SaveRecord();
        void SampleInput();
    }
}
