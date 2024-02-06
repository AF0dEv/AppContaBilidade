using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistoDeTempos
{
    internal class FiltroComboBox
    {
        public Dictionary<String, System.Int32> CBFullList = new Dictionary<String, System.Int32>();
        public Dictionary<String, System.Int32> CBFilteredList = new Dictionary<String, System.Int32>();
        public bool ComboBoxBusy = false;

        public void FilterList(bool show, ComboBox cbx)
        {

            if (ComboBoxBusy == false)
            {

                String orgText;

                ComboBoxBusy = true;
                orgText = cbx.Text;

                cbx.DroppedDown = false;

                CBFilteredList.Clear();

                foreach (KeyValuePair<string, Int32> item in CBFullList)
                {
                    if (item.Key.ToUpper().Contains(orgText.ToUpper()))
                        CBFilteredList.Add(item.Key, item.Value);
                }

                if (CBFilteredList.Count < 1)
                    CBFilteredList.Add("None", 0);

                cbx.BeginUpdate();
                cbx.DataSource = new BindingSource(CBFilteredList, null);
                cbx.DisplayMember = "Key";
                cbx.ValueMember = "Value";

                cbx.DroppedDown = show;
                cbx.SelectedIndex = -1;
                cbx.Text = orgText;
                cbx.Select(cbx.Text.Length, 0);
                cbx.EndUpdate();
                Cursor.Current = Cursors.Default;

                ComboBoxBusy = false;
            }
        }
    }
}
