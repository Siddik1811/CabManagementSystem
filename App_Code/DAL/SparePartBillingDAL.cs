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
/// Summary description for SparePartBillingDAL
/// </summary>
public class SparePartBillingDAL
{
	public SparePartBillingDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    internal static int InsertSPBilling(string VehicleID, string SpareType, string Quantity, string BillDate, string SparePart, string Price, int TotalAmount)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_SparePartBiiling",cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@VehicleID",VehicleID);
        cmd.Parameters.AddWithValue("@SpareType",SpareType);
        cmd.Parameters.AddWithValue("@Quantity",Quantity);
        cmd.Parameters.AddWithValue("@BillDate",BillDate);
        cmd.Parameters.AddWithValue("@SparePart",SparePart);
        cmd.Parameters.AddWithValue("@Price", Price);
        cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
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

    internal static int UpadteSparePart(string BillNo, string VehicleID, string SpareType, string Quantity, string BillDate, string SparePart, string Price, int TotalAmount)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_SparePartBiiling", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@BillNo", BillNo);
        cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
        cmd.Parameters.AddWithValue("@SpareType", SpareType);
        cmd.Parameters.AddWithValue("@Quantity", Quantity);
        cmd.Parameters.AddWithValue("@BillDate", BillDate);
        cmd.Parameters.AddWithValue("@SparePart", SparePart);
        cmd.Parameters.AddWithValue("@Price", Price);
        cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
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

    internal static DataSet SelectSparepart(string BillNo)
    {
       // throw new Exception("The method or operation is not implemented.");
        try{

        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_SparePartBiiling", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@BillNo", BillNo);
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

    internal static DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        try
        {

            SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_SparePartBiiling", cn);
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

    internal static int DeleteSpare(string BillNo)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_SparePartBiiling", cn);
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
}
