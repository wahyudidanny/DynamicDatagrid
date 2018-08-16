using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DataGridview_Add_Dynamic
{

    public partial class index : System.Web.UI.Page
    {

        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            int rows = Gridview1.Rows.Count;

            if (rows == 0)
            {
                dt.Columns.Add("ID_Row", typeof(System.Int64));
                dt.Columns.Add("Name", typeof(String));
                dt.Columns.Add("Gender", typeof(String));
                dt.Columns.Add("Country", typeof(String));

            }
            else
                dt = (DataTable)ViewState["viewstate"];

            DataRow datarow = dt.NewRow();
            datarow["ID_Row"] = (rows + 1);
            datarow["Name"] = txtName.Text.ToString();
            datarow["Gender"] = txtGender.Text.ToString();
            datarow["Country"] = txtCountry.Text.ToString();

            dt.Rows.Add(datarow);


            ViewState["viewstate"] = dt;
            Gridview1.DataSource = dt;
            Gridview1.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)ViewState["viewstate"];
         
            String id  = (Gridview1.Rows[e.RowIndex].Cells[0].Text.ToString());
          

            for (int i = 0; i < dt.Rows.Count ; i++)
            {
                if (id == (dt.Rows[i][0].ToString())) {
                    dt.Rows.RemoveAt(i);
                    break;
                }
            }

            ViewState["viewstate"] = dt;
            Gridview1.DataSource = dt;
            Gridview1.DataBind();

           
        // int ID = Int32.Parse(Gridview1.Rows); //''
        //'  dtgDetail.Rows[RowIndex].Cells[BoundFieldIndex].Text;
        //if(e.c)

        //int ID  = Int32.Parse(Gridview1.
    }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)ViewState["viewstate"];

            if (e.CommandName == "Delete")
            {
                //int index = Convert.ToInt32(e.CommandArgument);
                //GridViewRow row = this.GridView1.Rows[index];
                //string cellValue = r.Cells[0].Text;
            }


        }


    }
        
}

