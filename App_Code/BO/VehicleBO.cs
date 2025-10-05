using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for VehicleBO
/// </summary>
public class VehicleBO
{
	public VehicleBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _Name;

    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }
	
    private string _VehicleID;

    public string VehicleID
    {
        get { return _VehicleID; }
        set { _VehicleID = value; }
    }
    private string _VenderID;

    public string VenderID
    {
        get { return _VenderID; }
        set { _VenderID = value; }
    }
    private string _DriverID;

    public string DriverID
    {
        get { return _DriverID; }
        set { _DriverID = value; }
    }
    private string _VehicleType;

    public string VehicleType
    {
        get { return _VehicleType; }
        set { _VehicleType = value; }
    }
    private string _RegistorNo;

    public string RegistorNo
    {
        get { return _RegistorNo; }
        set { _RegistorNo = value; }
    }

    private string _RateKm;

    public string RateKm
    {
        get { return _RateKm; }
        set { _RateKm = value; }
    }
    private string _Capacity;

    public string Capacity
    {
        get { return _Capacity; }
        set { _Capacity = value; }
    }
    private string _RouteID;

    public string RouteID
    {
        get { return _RouteID; }
        set { _RouteID = value; }
    }
    private string _ImagePath;

    public string ImagePath 
    {
        get { return _ImagePath; }
        set { _ImagePath = value; }
    }



    public int InsertVehile()
    {
       // throw new Exception("The method or operation is not implemented.");
        return VehicleDAL.InsertVehicle(Name,VenderID, DriverID, VehicleType, RegistorNo, RateKm, Capacity, RouteID);
    }

    public int UpDateVehile()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleDAL.Updatevehicle(VehicleID,Name,VenderID, DriverID, VehicleType, RegistorNo, RateKm, Capacity, RouteID);
    }

    public DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleDAL.GetData();

    }

    public int DeleteVehicle()
    {
       // throw new Exception("The method or operation is not implemented.");
        return VehicleDAL.DeleteVehicle(VehicleID);

    }

    public DataSet SelectVehicle()
    {
       // throw new Exception("The method or operation is not implemented.");
        return VehicleDAL.SelectVehicle(VehicleID);
    }

    public DataSet SearchVehicle()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleDAL.SearchVehicle(VehicleID);
    }
}
