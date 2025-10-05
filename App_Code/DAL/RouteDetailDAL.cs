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
/// Summary description for RouteDetailDAL
/// </summary>
public class RouteDetailDAL
{
	public RouteDetailDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    internal static int insertRoute(string RouteDescription, string Source, string Destination)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_RouteDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@RouteDescription",RouteDescription);
        cmd.Parameters.AddWithValue("@Source",Source);
        cmd.Parameters.AddWithValue("@Destination",Destination);
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

    internal static int UpdateRoute(string RouteID, string RouteDescription, string Source, string Destination)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_RouteDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@RouteID", RouteID);
        cmd.Parameters.AddWithValue("@RouteDescription", RouteDescription);
        cmd.Parameters.AddWithValue("@Source", Source);
        cmd.Parameters.AddWithValue("@Destination", Destination);
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
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_RouteDetails", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Type", "s");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;



    }

    internal static int DeleteRoute(string RouteID)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_RouteDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@RouteID", RouteID);
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

    internal static DataSet SelectData(string RouteID)
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_RouteDetails", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@RouteID", RouteID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "ss");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;


    }

    internal static DataSet SearchRoute(string RouteID)
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_RouteDetails", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@RouteID", RouteID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "srt");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
}
