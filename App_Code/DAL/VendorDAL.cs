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
/// Summary description for VendorDAL
/// </summary>
public class VendorDAL
{
	public VendorDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
   

    internal static int InsertVerdor(string VenderName, string Address, string PhoneNo, string EmailID, string Remarks, string ImagePath)
    {
        //throw new Exception("The method or operation is not implemented.");
          cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_VenderDetails",cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@VenderName",VenderName);
        cmd.Parameters.AddWithValue("@Address",Address);
        cmd.Parameters.AddWithValue("@PhoneNo",PhoneNo);
        cmd.Parameters.AddWithValue("@EmailID",EmailID);
        cmd.Parameters.AddWithValue("@Remarks", Remarks);
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

    internal static DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_VenderDetails", cn);
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

    internal static DataSet SelectVendor(string VenderID)
    {
       // throw new Exception("The method or operation is not implemented.");
        try
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_VenderDetails", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@VenderID", VenderID);
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

    internal static int UpdateVendorDetails(string VenderID, string VenderName, string Address, string PhoneNo, string EmailID, string Remarks, string ImagePath)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_VenderDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@VenderID", VenderID);
        cmd.Parameters.AddWithValue("@VenderName", VenderName);
        cmd.Parameters.AddWithValue("@Address", Address);
        cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
        cmd.Parameters.AddWithValue("@EmailID", EmailID);
        cmd.Parameters.AddWithValue("@Remarks", Remarks);
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

    internal static int DeleteVendor(string VenderID)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_VenderDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@VenderID", VenderID);
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
}
