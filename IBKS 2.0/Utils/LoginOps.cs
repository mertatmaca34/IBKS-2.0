using Business.Abstract;
using IBKS_2._0.Forms;

namespace IBKS_2._0.Utils
{
    public static class LoginOps
    {
        public static bool Login(IAuthService authManager)
        {
            bool result = false;

            using (var form = new LoginForm(authManager))
            {
                form.ShowDialog();
                result = form.ReturnValue;
            }

            return result;
        }
    }
}
