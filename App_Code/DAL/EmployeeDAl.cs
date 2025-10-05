using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// Summary description for EmployeeDAl
/// </summary>
public class EmployeeDAl
{
	public EmployeeDAl()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    internal static int InsertEmpDetails(string EmpName, string PAddress, string CAddess, string Qulification, DateTime DOB, string VehicleReqire, string Gender, string PhoneNo, string Designation, string Department, DateTime DOJ, string Status, string Age, string TimeSpan, string ImagePath)
    {
        cn.Close();
        //throw new Exception("The method or operation is not implemented.");
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_EmployeeDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@EmpName", EmpName);
        cmd.Parameters.AddWithValue("@PAddress", PAddress);
        cmd.Parameters.AddWithValue("@CAddess", CAddess);
        cmd.Parameters.AddWithValue("@Qulification", Qulification);
        cmd.Parameters.AddWithValue("@DOB", DOB);
        cmd.Parameters.AddWithValue("@VehicleReqire", VehicleReqire);
        cmd.Parameters.AddWithValue("@Gender", Gender);
        cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
        cmd.Parameters.AddWithValue("@Designation", Designation);
        cmd.Parameters.AddWithValue("@Department", Department);
        cmd.Parameters.AddWithValue("@DOJ", DOJ);
        cmd.Parameters.AddWithValue("@Status", Status);
        cmd.Parameters.AddWithValue("@Age", Age);
        cmd.Parameters.AddWithValue("@TimeSpan", TimeSpan);
        cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
        cmd.Parameters.AddWithValue("@Type", "i");
     
        try
        {
            return cmd.ExecuteNonQuery();
        }
        catch
        {
            throw;
        }
        finally
        {
            cn.Close();
            cmd.Dispose();
        }

    }

    internal static DataSet GetDataEmp()
    {
        try
        {
            // throw new Exception("The method or operation is not implemented.");
            SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_EmployeeDetails", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Type", "s");
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        catch
        {
            throw;
        }
       

    }

    internal static int DeleteEmp(string EmpID)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_EmployeeDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@EmpID", EmpID);
        cmd.Parameters.AddWithValue("@Type", "d");
        try
        {
            return cmd.ExecuteNonQuery();

        }
        catch
        {
            throw;
        }
        finally
        {
            cn.Close();
            cmd.Dispose();
        }
    }

    internal static DataSet SeleteEp(string EmpID)
    {
        //throw new Exception("The method or operation is not implemented.");
        try
        {
            // throw new Exception("The method or operation is not implemented.");
            SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_EmployeeDetails", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@EmpID", EmpID);
            da.SelectCommand.Parameters.AddWithValue("@Type", "se");
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        catch
        {
            throw;
        }
    }

    internal static int UpdateEmp(string EmpID, string EmpName, string PAddress, string CAddess, string Qulification, DateTime DOB, string VehicleReqire, string Gender, string PhoneNo, string Designation, string Department, DateTime DOJ, string Status, string Age, string TimeSpan, string ImagePath)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        //throw new Exception("The method or operation is not implemented.");
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_EmployeeDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@EmpID", EmpID);
        cmd.Parameters.AddWithValue("@EmpName", EmpName);
        cmd.Parameters.AddWithValue("@PAddress", PAddress);
        cmd.Parameters.AddWithValue("@CAddess", CAddess);
        cmd.Parameters.AddWithValue("@Qulification", Qulification);
        cmd.Parameters.AddWithValue("@DOB", DOB);
        cmd.Parameters.AddWithValue("@VehicleReqire", VehicleReqire);
        cmd.Parameters.AddWithValue("@Gender", Gender);
        cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
        cmd.Parameters.AddWithValue("@Designation", Designation);
        cmd.Parameters.AddWithValue("@Department", Department);
        cmd.Parameters.AddWithValue("@DOJ", DOJ);
        cmd.Parameters.AddWithValue("@Status", Status);
        cmd.Parameters.AddWithValue("@Age", Age);
        cmd.Parameters.AddWithValue("@TimeSpan", TimeSpan);
        cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
        cmd.Parameters.AddWithValue("@Type", "u");

        try
        {
            return cmd.ExecuteNonQuery();
        }
        catch
        {
            throw;
        }
        finally
        {
            cn.Close();
            cmd.Dispose();
        }

    }
}
