using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Threading;
using System.Configuration;
using System.IO;

namespace WHF.OA.WebUI
{
    public class BasePage : Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            try
            {
                //string m_rootPath = HttpContext.Current.Request.PhysicalApplicationPath;
                //ConfigManager _cm = new ConfigManager(Path.Combine(m_rootPath, ConfigurationSettings.AppSettings["PalauGlobalConfig"]));
                //Thread.GetDomain().SetData("ConfigManager", _cm);
                return;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}