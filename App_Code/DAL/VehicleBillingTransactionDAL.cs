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
/// Summary description for VehicleBillingTransactionDAL
/// </summary>
public class VehicleBillingTransactionDAL
{
	public VehicleBillingTransactionDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    internal static int Insert(string VehicleID, string Amount, string DateOfBilling, string VenderID, string Deduction, int NetAmount)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_VehicleBillingTransction", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@VehicleID",VehicleID);
        cmd.Parameters.AddWithValue("@Amount",Amount);
        cmd.Parameters.AddWithValue("@DateOfBilling",DateOfBilling);
        cmd.Parameters.AddWithValue("@VenderID",VenderID);
        cmd.Parameters.AddWithValue("@Deduction",Deduction);
        cmd.Parameters.AddWithValue("@NetAmount",NetAmount);
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

    internal static int Upadte(string BillNo, string VehicleID, string Amount, string DateOfBilling, string VenderID, string Deduction, int NetAmount)
    {
       // throw new Exception("The method or operation is not implemented.");

        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_VehicleBillingTransction", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@BillNo", BillNo);
        cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
        cmd.Parameters.AddWithValue("@Amount", Amount);
        cmd.Parameters.AddWithValue("@DateOfBilling", DateOfBilling);
        cmd.Parameters.AddWithValue("@VenderID", VenderID);
        cmd.Parameters.AddWithValue("@Deduction", Deduction);
        cmd.Parameters.AddWithValue("@NetAmount", NetAmount);
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

    internal static DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_VehicleBillingTransction",cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Type","s");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    internal static int Delete(string BillNo)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_VehicleBillingTransction", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@BillNo", BillNo);
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

    internal static DataSet Select(string BillNo)
    {
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_VehicleBillingTransction", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@BillNo", BillNo);
        da.SelectCommand.Parameters.AddWithValue("@Type", "ss");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    internal static DataSet VendorData(string VenderID)
    {
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_VehicleBillingTransction", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@VenderID", VenderID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "v");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }

    internal static int InsertFeedBack(string EmpID, string VehicleID, string VenderID, string Remarks)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_FeedBackFrom", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@EmpID", EmpID);
        cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
        cmd.Parameters.AddWithValue("@DriverID", VenderID);
        cmd.Parameters.AddWithValue("@Remarks", Remarks);
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

    internal static DataSet GetDataFeedBack()
    {
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_FeedBackFrom", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
      //  da.SelectCommand.Parameters.AddWithValue("@VenderID", VenderID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "s");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;


    }

    internal static int DeleteFeedBck(string FeedBackID)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_FeedBackFrom", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@FeedBackID", FeedBackID);
      
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

    internal static int InsertAccident(string VehicleID, string ADate, string ATime, string Remarks)
    {
       //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("Sp_Tbl_AccidentDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
        cmd.Parameters.AddWithValue("@ADate", ADate);
        cmd.Parameters.AddWithValue("@ATime", ATime);
        cmd.Parameters.AddWithValue("@Remarks", Remarks);
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

    internal static DataSet GetAccidentDetail()
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("Sp_Tbl_AccidentDetails", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //  da.SelectCommand.Parameters.AddWithValue("@VenderID", VenderID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "s");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }

    internal static int DeleteAccident(string AccidentID)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("Sp_Tbl_AccidentDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@AccidentID", AccidentID);
      
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

    internal static DataSet VehicleData(string VehicleID)
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_VehicleBillingTransction", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@VehicleID", VehicleID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "a");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;

    }
}
