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
/// Summary description for VehicleDAL
/// </summary>
public class VehicleDAL
{
	public VehicleDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
    internal static int InsertVehicle(string Name, string VenderID, string DriverID, string VehicleType, string RegistorNo, string RateKm, string Capacity, string RouteID)
    {
       // throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_VehicleDetails",cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Name", Name);
        cmd.Parameters.AddWithValue("@VenderID",VenderID);
        cmd.Parameters.AddWithValue("@DriverID",DriverID);
        cmd.Parameters.AddWithValue("@VehicleType",VehicleType);
        cmd.Parameters.AddWithValue("@RegistorNo", RegistorNo);
        cmd.Parameters.AddWithValue("@RateKm",RateKm);
        cmd.Parameters.AddWithValue("@Capacity",Capacity);
        cmd.Parameters.AddWithValue("@RouteID", RouteID);
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

    internal static int Updatevehicle(string VehicleID,string Name,string VenderID, string DriverID, string VehicleType, string RegistorNo, string RateKm, string Capacity, string RouteID)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_VehicleDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
        cmd.Parameters.AddWithValue("@Name", Name);
        cmd.Parameters.AddWithValue("@VenderID", VenderID);
        cmd.Parameters.AddWithValue("@DriverID", DriverID);
        cmd.Parameters.AddWithValue("@VehicleType", VehicleType);
        cmd.Parameters.AddWithValue("@RegistorNo", RegistorNo);
        cmd.Parameters.AddWithValue("@RateKm", RateKm);
        cmd.Parameters.AddWithValue("@Capacity", Capacity);
        cmd.Parameters.AddWithValue("@RouteID", RouteID);
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
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_VehicleDetails",cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@Type", "s");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    internal static int DeleteVehicle(string VehicleID)
    {
        //throw new Exception("The method or operation is not implemented.");
        cn.Close();
        cn.Open();
        SqlCommand cmd = new SqlCommand("sp_Tbl_VehicleDetails", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
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

    internal static DataSet SelectVehicle(string VehicleID)
    {
        //throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_VehicleDetails", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@VehicleID", VehicleID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "ss");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;


    }

    internal static DataSet SearchVehicle(string VehicleID)
    {
       // throw new Exception("The method or operation is not implemented.");
        SqlDataAdapter da = new SqlDataAdapter("sp_Tbl_VehicleDetails", cn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@VehicleID", VehicleID);
        da.SelectCommand.Parameters.AddWithValue("@Type", "svd");
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
}
