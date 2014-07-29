using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WHF.OA.BasicData.Entity;
using WHF.OA.Base;

namespace WHF.OA.BasicData.BLL
{
    public class PersonBLL : BussinessLogicBase
    {
        public TBLPERSONEntity GetPerson(string id)
        {
            return base.GetObject<TBLPERSONEntity>(id);
        }
    }
}
