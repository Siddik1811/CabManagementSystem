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
/// Summary description for SparePartDAL
/// </summary>
public class SparePartDAL
{
	public SparePartDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    internal static int InsertSparePart(string DealerName, string SparePartType, string Quantity, string SparePart, string DateOfPurchase, string Price, string AmountPaid)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_SparePartsDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@DealerName",DealerName);
        cmd.Parameters.AddWithValue("@SparePartType",SparePartType);
        cmd.Parameters.AddWithValue("@Quantity",Quantity);
        cmd.Parameters.AddWithValue("@SparePart",SparePart);
        cmd.Parameters.AddWithValue("@DateOfPurchase",DateOfPurchase);
        cmd.Parameters.AddWithValue("@Price",Price);
        cmd.Parameters.AddWithValue("@AmountPaid",AmountPaid);
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

    internal static int UpdateSparePart(string SparerPartID, string DealerName, string SparePartType, string Quantity, string SparePart, string DateOfPurchase, string Price, string AmountPaid)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_SparePartsDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@SparerPartID", SparerPartID);
        cmd.Parameters.AddWithValue("@DealerName", DealerName);
        cmd.Parameters.AddWithValue("@SparePartType", SparePartType);
        cmd.Parameters.AddWithValue("@Quantity", Quantity);
        cmd.Parameters.AddWithValue("@SparePart", SparePart);
        cmd.Parameters.AddWithValue("@DateOfPurchase", DateOfPurchase);
        cmd.Parameters.AddWithValue("@Price", Price);
        cmd.Parameters.AddWithValue("@AmountPaid", AmountPaid);
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

    internal static DataSet SelectSparePart(string SparerPartID)
    {
       //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_SparePartsDetails", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@SparerPartID", SparerPartID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "ss");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    internal static DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_SparePartsDetails", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Type", "s");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    internal static int DeleteSparePart(string SparerPartID)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_SparePartsDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@SparerPartID", SparerPartID);
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

    internal static DataSet SparepartTypeDetails(string SparePartType)
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_SparePartsDetails", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@SparePartType", SparePartType);
        da.SelectCommand.Parameters.AddWithValue("@Type", "spt");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
}
