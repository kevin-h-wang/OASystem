using System;

namespace WHF.OA.WebUI.Views.Portal
{
    public partial class Top : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.InitPage();
            }
        }

        public void InitPage()
        {
            //this.lblCurrentUser.Text = AppCenter.CurrentPersonName;
            //this.lblDateTime.Text = DateTime.Now.ToLongDateString().ToString();
        }
    }
}