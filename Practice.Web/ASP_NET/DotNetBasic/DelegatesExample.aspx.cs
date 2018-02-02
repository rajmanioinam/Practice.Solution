using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practice.Web.ASP_NET.DotNetBasic
{
    public partial class DelegatesExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            MathCls mathObj = new MathCls();
            int result = mathObj.GetFunction(Convert.ToInt32(ddlOperation.SelectedValue)).Invoke(Convert.ToInt32(Num1.Text), Convert.ToInt32(Num2.Text));
            lblResult.Text = result.ToString();
        }
    }

    public class MathCls
    {
        public delegate int MathFunction(int x, int y);

        public MathFunction GetFunction(int operation)
        {
            MathFunction mathFunction = null;
            switch (operation)
            {
                case 1:
                    mathFunction = Add;
                    break;
                case 2:
                    mathFunction = Sub;
                    break;
                case 3:
                    mathFunction = Mul;
                    break;
                default:
                    break;
            }

            return mathFunction;
        }

        //Functions
        private int Add(int x, int y)
        {
            return x + y;
        }
        private int Sub(int x, int y)
        {
            return x - y;
        }
        private int Mul(int x, int y)
        {
            return x * y;
        }
    }
}