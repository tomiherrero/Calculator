using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator.ClassCode
{
    public partial class Calculator : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public void ObligatoryField()
        {
            if (txtNumber1.Text == "" || txtNumber2.Text == "")
            {
                lblNumberObligatory1.Visible = true;
                lblNumberObligatory2.Visible = true;
            }
        }
        public void calculator()
        {
            decimal number1 = 0;
            decimal number2 = 0;

            number1 = int.Parse(txtNumber1.Text);
            number2 = int.Parse(txtNumber2.Text);
            if (rdoSum.Checked == true)
            {

                lblResult.Text = (number1 + number2).ToString();
                var bill = number1.ToString() + " + " + number2.ToString() + " = " + lblResult.Text.ToString();
                Session.Add("Record", bill + " " + Session["Record"]);
            }
            if (rdoSubtraction.Checked == true)
            {
                lblResult.Text = (number1 - number2).ToString();
                var bill = number1.ToString() + " - " + number2.ToString() + " = " + lblResult.Text.ToString();
                Session.Add("Record", bill + " " + Session["Record"]);
            }
            if (rdoMultiply.Checked == true)
            {
                lblResult.Text = (number1 * number2).ToString();
                var bill = number1.ToString() + " * " + number2.ToString() + " = " + lblResult.Text.ToString();
                Session.Add("Record", bill + " " + Session["Record"]);

            }
            if (rdoDivide.Checked == true)
            {
                lblResult.Text = (number1 / number2).ToString();
                var bill = number1.ToString() + " / " + number2.ToString() + " = " + lblResult.Text.ToString();
                Session.Add("Record", bill + " " + Session["Record"]);
            }
        }

        
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
             if (txtNumber1.Text == "" && txtNumber2.Text == "")
            {
                lblNumberObligatory1.Visible = true;
                lblNumberObligatory2.Visible = true;
            }
            if (txtNumber1.Text == "")
            {
                lblNumberObligatory1.Visible = true;
          
            } else if (txtNumber2.Text == "")
            {
               lblNumberObligatory2.Visible = true;
            }
           
            else
            {
                calculator();
            }
        
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = string.Empty;
            txtNumber2.Text = string.Empty;
            lblResult.Text = string.Empty;
            lblNumberObligatory1.Visible = false;
            lblNumberObligatory2.Visible = false;
        }

        protected void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtNumber2_TextChanged(object sender, EventArgs e)
        {
        }

        protected void txtMostrar_Click(object sender, EventArgs e)
        {

        }

        protected void txtResult_Click(object sender, EventArgs e)
        {
            Response.Redirect("record.aspx");
        }
    }
}