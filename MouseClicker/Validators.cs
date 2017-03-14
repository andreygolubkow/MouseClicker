using System.Windows.Forms;

namespace MouseClicker
{
    public class Validators
    {
        public static void IntEnterValidator(KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }
    }
}