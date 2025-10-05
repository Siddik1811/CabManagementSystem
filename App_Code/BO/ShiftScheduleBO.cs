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
/// Summary description for ShiftScheduleBO
/// </summary>
public class ShiftScheduleBO
{
	public ShiftScheduleBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _ShiftSchduleID;

    public string ShiftSchduleID
    {
        get { return _ShiftSchduleID; }
        set { _ShiftSchduleID = value; }
    }
    private string _EmpID;

    public string EmpID
    {
        get { return _EmpID; }
        set { _EmpID = value; }
    }
    private string _Department;

    public string Department
    {
        get { return _Department; }
        set { _Department = value; }
    }

    private string _BatchID;

    public string BatchID
    {
        get { return _BatchID; }
        set { _BatchID = value; }
    }
    private string _EmpName;

    public string EmpName
    {
        get { return _EmpName; }
        set { _EmpName = value; }
    }
    private string _ShiftID;

    public string ShiftID
    {
        get { return _ShiftID; }
        set { _ShiftID = value; }
    }

    private string _RouteID;

    public string RouteID
    {
        get { return _RouteID; }
        set { _RouteID = value; }
    }


    public int InsertShiftSchdule()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ShiftScheduleDAL.InsertShiftSchdule(EmpID, Department, BatchID, EmpName, ShiftID, RouteID);
    }

    public DataSet Getdata()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ShiftScheduleDAL.GetData();

    }

    public int DeleteShiftSchedul()
    {
       // throw new Exception("The method or operation is not implemented.");
        return ShiftScheduleDAL.DeleteShiftSchedule(ShiftSchduleID);
    }

    public int UpDateShiftSchdule()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ShiftScheduleDAL.UpDateShiftschedule(ShiftSchduleID, EmpID, Department, BatchID, EmpName, ShiftID, RouteID);
    }

    public DataSet SearchShiftID()
    {
        //throw new Exception("The method or operation is not implemented.");
        return ShiftTimingDAL.SearchShiftID(ShiftID);
    }

    public DataSet SelectEmp()
    {
       // throw new Exception("The method or operation is not implemented.");
        return ShiftScheduleDAL.Select(ShiftSchduleID);
    }
}
