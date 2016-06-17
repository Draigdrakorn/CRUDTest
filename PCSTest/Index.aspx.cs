using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PCSTest
{
    public partial class Index : System.Web.UI.Page
    {
        EmployeeContext empContext = new EmployeeContext();
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dt = new DataTable("tbl1");
                dt.Columns.Add("QID");
                dt.Columns.Add("Qualification Name");
                dt.Columns.Add("Marks");
                Session["DataTable"] = dt;
                QualificationList qualificationInfo = new QualificationList();
                gdvEmployeeList.DataSource = empContext.usp_SelectEmployee();
                gdvEmployeeList.DataBind();
                empQualificationDropDown.DataSource = empContext.usp_SelectQualificationList();
                empQualificationDropDown.DataTextField = "Q_Name";
                empQualificationDropDown.DataValueField = "Q_Id";
                empQualificationDropDown.DataBind();
            }
            
            //gdvEmployeeQualification.DataSource = empContext.usp_SelectEmpQualification();
            //gdvEmployeeQualification.DataBind();
        }

        protected void btnAddEmpQualification_Click(object sender, EventArgs e)
        {
            //Employee empInfo = new Employee();
            //int EmployeeId = empInfo.Employee_Id;
            string QId = empQualificationDropDown.SelectedItem.Value;
            string QName = empQualificationDropDown.SelectedItem.Text;
            float Marks = float.Parse(txtMarks.Text);
            //empContext.usp_AddEmpQualification(EmployeeId, QId, Marks);
            DataTable t = (DataTable)Session["DataTable"];
            DataRow row1 = t.NewRow();
            row1["QID"] = QId;
            row1["Qualification Name"] = QName;
            row1["Marks"] = Marks;
            t.Rows.Add(row1);
            Session["DataTable"] = t;
            gdvEmployeeQualification.DataSource = t;
            gdvEmployeeQualification.DataBind();
        }
        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Employee empInfo = new Employee();
            string name = txtEmpName.Text;
            string gender = rdoGenderList.SelectedValue;
            DateTime DOB = Convert.ToDateTime(txtDOB.Text);
            int salary = int.Parse(txtSalary.Text);
            DateTime entryDate = DateTime.Now;
            string entryBy = System.Web.HttpContext.Current.User.ToString();
            List<usp_AddEmployee_Result> lstResult = empContext.usp_AddEmployee(name, DOB, gender, salary, entryBy, entryDate).ToList();
            int empId = Decimal.ToInt16(lstResult[0].ReturnValues);
            foreach (GridViewRow gvr in gdvEmployeeQualification.Rows)
            {
                empContext.usp_AddEmpQualification(empId, int.Parse(gvr.Cells[0].Text), double.Parse(gvr.Cells[2].Text));
            }

        }
    }
}