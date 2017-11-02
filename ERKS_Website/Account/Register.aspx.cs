using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using ERKS_Website;
using ERKS.Framework.BLL.Security;

public partial class Account_Register : Page
{
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        //I don't understand why this page won't recognize the Id's on the front end.
        //It's difficult to find some classes.
        var manager = new UserManager();
        var user = new ApplicationUser() { UserName = UserName.Text };
        IdentityResult result = manager.Create(user, Password.Text);
        if (result.Succeeded)
        {
            IdentityHelper.SignIn(manager, user, isPersistent: false);
            IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
        }
        else
        {
            ErrorMessage.Text = result.Errors.FirstOrDefault();
        }
    }
}