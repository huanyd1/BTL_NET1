using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public static class NotificationCommon
    {
        public static void Succsess(string msg)
        {
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warning(string msg)
        {
            MessageBox.Show(string.Format("Có lỗi xảy ra {0} {1}", Environment.NewLine, msg), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Error(string msg)
        {
            MessageBox.Show(string.Format("Có lỗi xảy ra {0} {1}", Environment.NewLine, msg), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
