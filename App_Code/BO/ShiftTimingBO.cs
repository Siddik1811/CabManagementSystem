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
/// Summary description for ShiftTimingBO
/// </summary>
public class ShiftTimingBO
{
	public ShiftTimingBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _ShiftID;

    public string ShiftID
    {
        get { return _ShiftID; }
        set { _ShiftID = value; }
    }
    private string _ShiftName;

    public string ShiftName
    {
        get { return _ShiftName; }
        set { _ShiftName = value; }
    }
    private string _StartingTime;

    public string StartingTime
    {
        get { return _StartingTime; }
        set { _StartingTime = value; }
    }
    private string _DispatchTime;

    public string DispatchTime
    {
        get { return _DispatchTime; }
        set { _DispatchTime = value; }
    }
    private string _NoBatches;

    public string NoBatches
    {
        get { return _NoBatches; }
        set { _NoBatches = value; }
    }


    public int InsertShiftTime()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ShiftTimingDAL.InsertShifttime(ShiftName, StartingTime, DispatchTime, NoBatches);
    }

    public DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ShiftTimingDAL.GetData();
    }

    public int DeleteShiftDet()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ShiftTimingDAL.DeleteShift(ShiftID);
    }

    public int UpdateShiftDetails()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ShiftTimingDAL.Updateshiftdetails(ShiftID,ShiftName, StartingTime, DispatchTime, NoBatches);

    }

    public DataSet SelectShiftDetail()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ShiftTimingDAL.selectShift(ShiftID);
    }
}
