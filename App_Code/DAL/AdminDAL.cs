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
/// Summary description for AdminDAL
/// </summary>
public class AdminDAL
{
	public AdminDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}



    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    //internal static DataSet AdminLogin()
    //{
    //   // throw new Exception("The method or operation is not implemented.");
    //    SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_AdminLogin",cn);
    //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
    //    da.SelectCommand.Parameters.AddWithValue("@Type", "s");
    //    DataSet ds = new DataSet();
    //    da.Fill(ds);
    //    return ds;
    //}

    internal static int Insert(string EmpName, string UserName, string password, string PAddress, string Qulification, string DOB, string Gender, string PhoneNo, string EmailId, string Designation, string Department, string DOJ, string Age)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_Manger",cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@EmpName",EmpName);
        cmd.Parameters.AddWithValue("@UserName",UserName);
        cmd.Parameters.AddWithValue("@password",password);
        cmd.Parameters.AddWithValue("@Address", PAddress);
        cmd.Parameters.AddWithValue("@Qulification", Qulification);
        cmd.Parameters.AddWithValue("@DOB",DOB);
        cmd.Parameters.AddWithValue("@Gender", Gender);
        cmd.Parameters.AddWithValue("@PhoneNo",PhoneNo);
        cmd.Parameters.AddWithValue("@EmailID", EmailId);
        cmd.Parameters.AddWithValue("@Designation",Designation);
        cmd.Parameters.AddWithValue("@Department", Department);
        cmd.Parameters.AddWithValue("@DOJ",DOJ);
        cmd.Parameters.AddWithValue("@Age",Age);
        cmd.Parameters.AddWithValue("@Type","i");
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

    internal static DataSet UpdateManger(string MangerID, string EmpName, string PAddress, string Qulification, string DOB, string Gender, string PhoneNo, string EmailId, string Designation, string Department, string DOJ, string Age)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_MangerNew", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@MangerID", MangerID);
        cmd.Parameters.AddWithValue("@EmpName", EmpName);
        cmd.Parameters.AddWithValue("@Address", PAddress);
        cmd.Parameters.AddWithValue("@Qulification", Qulification);
        cmd.Parameters.AddWithValue("@DOB", DOB);
        cmd.Parameters.AddWithValue("@Gender", Gender);
        cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
        cmd.Parameters.AddWithValue("@EmailID", EmailId);
        cmd.Parameters.AddWithValue("@Designation", Designation);
        cmd.Parameters.AddWithValue("@Department", Department);
        cmd.Parameters.AddWithValue("@DOJ", DOJ);
        cmd.Parameters.AddWithValue("@Age", Age);
        cmd.Parameters.AddWithValue("@Type", "u");

        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds=new DataSet();
        da.Fill(ds);

        try
        {
            return ds;
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

    internal static DataSet GetDataManger()
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Manger", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Type", "s");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    internal static int DeleteManger(string MangerID)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_Manger", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@MangerID", MangerID);
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

    internal static DataSet SelectMang(string MangerID)
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_Manger", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@MangerID", MangerID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "ss");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    internal static DataSet AdminLogin(string UserId, string Password)
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_AdminNewLogin", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@UserId", UserId);
        da.SelectCommand.Parameters.AddWithValue("@Password", Password);
        da.SelectCommand.Parameters.AddWithValue("@Type", "S");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;


    }
    internal static DataSet AdminLogin(string UserId)
    {
        // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_AdminNewLogin", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@UserId", UserId);
        da.SelectCommand.Parameters.AddWithValue("@Type", "SP");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;


    }

    internal static int UpdateLogin(string UserName, string Password)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_AdminLogin", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@UserName", UserName);
        cmd.Parameters.AddWithValue("@PassWord", Password);
        cmd.Parameters.AddWithValue("@Type", "ul");
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

    internal static DataSet InsertManager(string ManagerName, string PAddress, string Qulification, string DOB, string Gender, string PhoneNo, string EmailId, string Designation, string Department, string DOJ, string Age)
    {
        //throw new Exception("The method or operation is not implemented.");
       
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_MangerNew",cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@EmpName",ManagerName);
        da.SelectCommand.Parameters.AddWithValue("@Address", PAddress);
        da.SelectCommand.Parameters.AddWithValue("@Qulification", Qulification);
        da.SelectCommand.Parameters.AddWithValue("@DOB", DOB);
        da.SelectCommand.Parameters.AddWithValue("@Gender", Gender);
        da.SelectCommand.Parameters.AddWithValue("@PhoneNo", PhoneNo);
        da.SelectCommand.Parameters.AddWithValue("@EmailID", EmailId);
        da.SelectCommand.Parameters.AddWithValue("@Designation", Designation);
        da.SelectCommand.Parameters.AddWithValue("@Department", Department);
        da.SelectCommand.Parameters.AddWithValue("@DOJ", DOJ);
        da.SelectCommand.Parameters.AddWithValue("@Age", Age);
        da.SelectCommand.Parameters.AddWithValue("@Type", "i");
        DataSet ds = new DataSet();
        da.Fill(ds);
        try
        {
            return ds;
        }
        catch
        {
            throw;
        }
       
    }

    internal static DataSet UpdatePassword(string UserId, string OldPassword, string Password)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Open();
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_AdminNewLogin",cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@UserId",UserId);
        da.SelectCommand.Parameters.AddWithValue("@Password", OldPassword);
        da.SelectCommand.Parameters.AddWithValue("@PasswordNew", Password);
        da.SelectCommand.Parameters.AddWithValue("@Type", "P");
        DataSet ds = new DataSet();
        da.Fill(ds);
        try
        {
            return ds;
        }
        catch
        {
            throw;
        }
        finally
        {
            cn.Close();
        }
    }

    internal static DataSet GetLoginDetails()
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_AdminNewLogin", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
              
        da.SelectCommand.Parameters.AddWithValue("@Type", "sd");
        DataSet ds = new DataSet();
        da.Fill(ds);
        try
        {
            return ds;
        }
        catch
        {
            throw;
        }
        finally
        {
            cn.Close();
        }

    }
}
