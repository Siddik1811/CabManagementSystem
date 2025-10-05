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
/// Summary description for TripBO
/// </summary>
public class TripBO
{
	public TripBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _TripSheetID;

    public string TripSheetID
    {
        get { return _TripSheetID; }
        set { _TripSheetID = value; }
    }
    private string _AllocationID;

    public string AllocationID
    {
        get { return _AllocationID; }
        set { _AllocationID = value; }
    }
    private string _VehicleID;

    public string VehicleID
    {
        get { return _VehicleID; }
        set { _VehicleID = value; }
    }
    private string _RateKM;

    public string RateKM
    {
        get { return _RateKM; }
        set { _RateKM = value; }
    }
    private string _KM;

    public string KM
    {
        get { return _KM; }
        set { _KM = value; }
    }
    private int _TotalAmount;

    public int TotalAmount
    {
        get { return _TotalAmount; }
        set { _TotalAmount = value; }
    }
    private string _Remark;

    public string Remark
    {
        get { return _Remark; }
        set { _Remark = value; }
    }



    public int Insert()
    {
      //  throw new Exception("The method or operation is not implemented.");
        return TripSheetDAL.Insert(AllocationID, VehicleID, RateKM, KM, TotalAmount, Remark);
    }

    public int UpDate()
    {
       // throw new Exception("The method or operation is not implemented.");
        return TripSheetDAL.Upadate(TripSheetID, AllocationID, VehicleID, RateKM, KM, TotalAmount, Remark);
    }

    public DataSet Getdata()
    {
        //throw new Exception("The method or operation is not implemented.");
        return TripSheetDAL.GetData();
    }

    public int DeleteTrip()
    {
       // throw new Exception("The method or operation is not implemented.");
        return TripSheetDAL.delete(TripSheetID);
    }

    public DataSet Select()
    {
       // throw new Exception("The method or operation is not implemented.");
        return TripSheetDAL.Selete(TripSheetID);
    }
}
