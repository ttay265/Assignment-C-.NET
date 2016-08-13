using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSQLManagement
{
    public partial class TComboBox : ComboBox
    {
        public TComboBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void TComboBox_TextChanged(object sender, EventArgs e)
        {
            if (this.Focused)
            {
                if (Regex.IsMatch(this.Text, @"^\d+$"))
                {
                    if (this.Text.Count() > 1)
                    {
                        int MatchedCustomerID = int.Parse(this.Text);
                        foreach (string id in (List<string>)this.DataSource)
                        {
                            if (id.Contains(this.Text))
                            {
                                this.SelectedItem = MatchedCustomerID;
                                this.ForeColor = Color.Black;
                                this.DroppedDown = true;
                                return;
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                this.DroppedDown = false;
                this.ForeColor = Color.Red;
            }
        }
    }
}
