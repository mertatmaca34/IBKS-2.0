using Business.Abstract;
using ibks.Forms;

namespace ibks.Utils
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
