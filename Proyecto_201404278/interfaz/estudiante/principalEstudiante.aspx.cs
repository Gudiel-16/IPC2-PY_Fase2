using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Proyecto_201404278.interfaz
{
    public partial class principalEstudiante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCarnet.Text = Session["Login"].ToString();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(Calendar1.SelectedDate.Date.ToString("yyyy-MM-dd"));
        }
    }
}