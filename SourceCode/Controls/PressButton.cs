using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVGIS.Controls
{
    public class PressButton:Button
    {
        public Color FocusedColor
        {
            get; set;
        } = Color.FromArgb(255, 150, 150, 150);

        public Color NotFocusedColor
        {
            get; set;
        } = Color.FromArgb(255,220, 220, 220);

        public Color MouseOverColor
        {
            get; set;
        } = Color.Orange;
        public PressButton() : base()
        {
            //this.FlatAppearance.BorderSize = 0;
            //this.FlatAppearance.MouseDownBackColor = Color.DarkOrange;
            //this.FlatAppearance.MouseOverBackColor = MouseOverColor;
            //this.MouseOverColor = MouseOverColor;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.BackColor = NotFocusedColor;
            this.FlatStyle = FlatStyle.Standard;
            this.Refresh();
            
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = FocusedColor;
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.FlatStyle = FlatStyle.Standard;
            this.BackColor = NotFocusedColor;
        }
    }
}
