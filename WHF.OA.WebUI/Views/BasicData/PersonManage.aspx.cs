﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using WHF.OA.BasicData.Entity;
using WHF.OA.BasicData.BLL;
//using Whf.TuoPu.Controller;

namespace WHF.OA.WebUI.Views.BasicData
{
    public partial class PersonManage : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //this.BindGrid(1);
                this.GetPerson();
            }
        }

        protected override void OnInit(EventArgs e)
        {
            //this.Navigator.Paging += new Web.Controls.Navigator.PagingEventHandler(Navigator_Paging);
            //base.OnInit(e);
        }

        //private void Navigator_Paging(object sender, Controls.Navigator.PagingEventArgs e)
        //{
        //    this.BindGrid(e.NewPage);
        //}

        //private void BindGrid(int pageIndex)
        //{
        //    PersonController controller = new PersonController();
        //    int rowCount = 0;
        //    DataSet dst = controller.QueryPersons(pageIndex, 2, out rowCount);
        //    this.Navigator.TotalCount = rowCount;
        //    this.gvTest.DataSource = dst.Tables[0];
        //    this.gvTest.DataBind();
        //}

        private void GetPerson()
        {
            string personID = "04F4E255-BE6A-464B-AB2C-7D3FE6981DC2";
            TBLPERSONEntity entity = new PersonBLL().GetPerson(personID);
            txtEmpName.Text = entity.personaccount;
        }
    }
}