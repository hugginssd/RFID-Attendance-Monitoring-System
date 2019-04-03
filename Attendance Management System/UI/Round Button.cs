using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System
{
    public class Round_Button : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(10, 10, 40, 40);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
