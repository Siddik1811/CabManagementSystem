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
/// Summary description for DriverDAL
/// </summary>
public class DriverDAL
{
	public DriverDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    internal static int InsertDriverDetails(string Name, string Address, string PhoneNo, DateTime DOB, DateTime DOJ, string Experience, string LicenceNo, string ImagePath, string NoOfAccident)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_DriverDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Name",Name);
        cmd.Parameters.AddWithValue("@Address",Address);
        cmd.Parameters.AddWithValue("@PhoneNo",PhoneNo);
        cmd.Parameters.AddWithValue("@DOB",DOB);
        cmd.Parameters.AddWithValue("@DOJ",DOJ);
        cmd.Parameters.AddWithValue("@Experience",Experience);
        cmd.Parameters.AddWithValue("@LicenceNo", LicenceNo);
        cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
        cmd.Parameters.AddWithValue("@NoOfAccident", NoOfAccident);
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

    internal static DataSet Getaata()
    {
       //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_DriverDetails", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Type", "s");
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

    internal static int DeletDriverDetails(string DriverID)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_DriverDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@DriverID", DriverID);
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

    internal static int UpdateDriverDetails(string DriverID, string Name, string Address, string PhoneNo, DateTime DOB, DateTime DOJ, string Experience, string LicenceNo, string ImagePath, string NoOfAccident)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_DriverDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@DriverID", DriverID);
        cmd.Parameters.AddWithValue("@Name", Name);
        cmd.Parameters.AddWithValue("@Address", Address);
        cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
        cmd.Parameters.AddWithValue("@DOB", DOB);
        cmd.Parameters.AddWithValue("@DOJ", DOJ);
        cmd.Parameters.AddWithValue("@Experience", Experience);
        cmd.Parameters.AddWithValue("@LicenceNo", LicenceNo);
        cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
        cmd.Parameters.AddWithValue("@NoOfAccident", NoOfAccident);
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

    internal static DataSet SelectDriverDetails(string DriverID)
    {
       // throw new Exception("The method or operation is not implemented.");
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_DriverDetails", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@DriverID", DriverID);
            da.SelectCommand.Parameters.AddWithValue("@Type", "ss");
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        catch
        {
            throw;
        }

    }
}
