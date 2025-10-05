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
/// Summary description for DriverShiftdtBO
/// </summary>
public class DriverShiftdtBO
{
	public DriverShiftdtBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _DriverShiftID;

    public string DriverShiftID
    {
        get { return _DriverShiftID; }
        set { _DriverShiftID = value; }
    }
    private string _Name;

    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }
    private string _DriverID;

    public string DriverID
    {
        get { return _DriverID; }
        set { _DriverID = value; }
    }
    private string _ShiftID;

    public string ShiftID
    {
        get { return _ShiftID; }
        set { _ShiftID = value; }
    }
    private string _ShiftDate;

    public string ShiftDate
    {
        get { return _ShiftDate; }
        set { _ShiftDate = value; }
    }
    private string _Shifting;

    public string Shifting
    {
        get { return _Shifting; }
        set { _Shifting = value; }
    }

    public int InsertDriverShift()
    {
       // throw new Exception("The method or operation is not implemented.");
        return DriverShiftDAL.InsertDriverShift(DriverID, Name, ShiftID, ShiftDate, Shifting);
    }

    public int UpadteDriverShift()
    {
        //throw new Exception("The method or operation is not implemented.");
        return DriverShiftDAL.UpdateDriverShift(DriverShiftID,DriverID, Name, ShiftID, ShiftDate, Shifting);
    }

    public DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        return DriverShiftDAL.GetData();
    }

    public int DeletedriverShift()
    {
        //throw new Exception("The method or operation is not implemented.");
        return DriverShiftDAL.DeleteDriverShift(DriverShiftID);
    }

    public DataSet Slerecord()
    {
        //throw new Exception("The method or operation is not implemented.");
        return DriverShiftDAL.Selectrecords(DriverShiftID);
    }
}
