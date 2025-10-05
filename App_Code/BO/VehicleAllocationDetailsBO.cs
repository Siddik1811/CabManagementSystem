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
/// Summary description for VehicleAllocationDetailsBO
/// </summary>
public class VehicleAllocationDetailsBO
{
	public VehicleAllocationDetailsBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _VehicleAllocationID;

    public string VehicleAllocationID
    {
        get { return _VehicleAllocationID; }
        set { _VehicleAllocationID = value; }
    }
    private string _VehicleID;

    public string VehicleID
    {
        get { return _VehicleID; }
        set { _VehicleID = value; }
    }
    private string _EmployeeID;

    public string EmployeeID
    {
        get { return _EmployeeID; }
        set { _EmployeeID = value; }
    }
    private string _DriverID;

    public string DriverID
    {
        get { return _DriverID; }
        set { _DriverID = value; }
    }
    private string _PickupDrop;

    public string PickupDrop
    {
        get { return _PickupDrop; }
        set { _PickupDrop = value; }
    }
    private string _RouteID;

    public string RouteID
    {
        get { return _RouteID; }
        set { _RouteID = value; }
    }
    private string _VDate;

    public string VDate
    {
        get { return _VDate; }
        set { _VDate = value; }
    }


    public int InsertVehicleAllocation()
    {
       // throw new Exception("The method or operation is not implemented.");
        return VehicleAllocationDetailsDAL.InsertVehicle(VehicleID, EmployeeID, DriverID, PickupDrop, RouteID, VDate);
    }

    public int UpadteVehicleAllocation()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleAllocationDetailsDAL.UpdateVehicleAllocation(VehicleAllocationID, VehicleID, EmployeeID, DriverID, PickupDrop, RouteID, VDate);
    }

    public DataSet GetadatVehicleAllocation()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleAllocationDetailsDAL.GetData();
    }

    public int DeleteVehicleAlloction()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleAllocationDetailsDAL.Delete(VehicleAllocationID);

    }

    public DataSet Select()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleAllocationDetailsDAL.Select(VehicleAllocationID);
    }
}   
