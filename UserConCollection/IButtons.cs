using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserConCollection
{
    public interface IButtons
    {
        void ListBox_SelectedIndexChanged(object sender, EventArgs e);
        void ListBox_MouseDoubleClick(object sender, MouseEventArgs e);
        void Panel_Load(object sender, EventArgs e);


        void SubscribeEdit(Action<bool> Method);
        void SubscribeSave(Action<bool> Method);
        void SubscribeAdd(Action<bool> Method);
        void SubscribeRemove(Action<bool> Method);
        void SampleRemove(Action<bool> Method);
        void ClearFields();
        void EditRecord();
        bool DataLoss();
        void RemoveRecord();
        void EnableFields(bool val);
        bool SaveRecord();
        void SampleInput();


    }
}
