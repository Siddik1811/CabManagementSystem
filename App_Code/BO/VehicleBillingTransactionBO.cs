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
/// Summary description for VehicleBillingTransactionBO
/// </summary>
public class VehicleBillingTransactionBO
{
	public VehicleBillingTransactionBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _AccidentID;

    public string AccidentID
    {
        get { return _AccidentID; }
        set { _AccidentID = value; }
    }
	
    private string _ADate;

    public string ADate
    {
        get { return _ADate; }
        set { _ADate = value; }
    }
    private string _ATime;

    public string ATime
    {
        get { return _ATime; }
        set { _ATime = value; }
    }
	
    private string _DriverID;

    public string DriverID
    {
        get { return _DriverID; }
        set { _DriverID = value; }
    }
	
    private string _FeedBackID;

    public string FeedBackID
    {
        get { return _FeedBackID; }
        set { _FeedBackID = value; }
    }
    private string _EmpID;

    public string EmpID
    {
        get { return _EmpID; }
        set { _EmpID = value; }
    }
    private string _Remarks;

    public string Remarks
    {
        get { return _Remarks; }
        set { _Remarks = value; }
    }
	
	
    private string _BillNo;

    public string BillNo
    {
        get { return _BillNo; }
        set { _BillNo = value; }
    }
    private string _VehicleID;

    public string VehicleID
    {
        get { return _VehicleID; }
        set { _VehicleID = value; }
    }
    private string _Amount;

    public string Amount
    {
        get { return _Amount; }
        set { _Amount = value; }
    }
    private string _DateOfBilling;

    public string DateOfBilling
    {
        get { return _DateOfBilling; }
        set { _DateOfBilling = value; }
    }
    private string _VenderID;

    public string VenderID
    {
        get { return _VenderID; }
        set { _VenderID = value; }
    }
    private string _Deduction;

    public string Deduction
    {
        get { return _Deduction; }
        set { _Deduction = value; }
    }
    private int _NetAmount;

    public int NetAmount
    {
        get { return _NetAmount; }
        set { _NetAmount = value; }
    }


    public int Insert()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleBillingTransactionDAL.Insert(VehicleID, Amount, DateOfBilling, VenderID, Deduction, NetAmount);
    }

    public int Update()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleBillingTransactionDAL.Upadte(BillNo, VehicleID, Amount, DateOfBilling, VenderID, Deduction, NetAmount);
    }

    public DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleBillingTransactionDAL.GetData();
    }

    public int Delete()
    {
       // throw new Exception("The method or operation is not implemented.");
        return VehicleBillingTransactionDAL.Delete(BillNo);
    }

    public DataSet Select()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleBillingTransactionDAL.Select(BillNo);
    }

    public DataSet VendorData()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleBillingTransactionDAL.VendorData(VenderID);
    }

    public int insertFeedBack()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleBillingTransactionDAL.InsertFeedBack(EmpID, VehicleID, VenderID, Remarks);
    }

    public DataSet GetDataFeedBack()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleBillingTransactionDAL.GetDataFeedBack();
    }

    public int DeleteFeedBack()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleBillingTransactionDAL.DeleteFeedBck(FeedBackID);
    }

    public int InsertAccident()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleBillingTransactionDAL.InsertAccident(VehicleID, ADate, ATime, Remarks);
    }

    public DataSet GetAccidentDetail()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VehicleBillingTransactionDAL.GetAccidentDetail();
    }

    public int DeleteAccdent()
    {
       // throw new Exception("The method or operation is not implemented.");
        return VehicleBillingTransactionDAL.DeleteAccident(AccidentID);
    }

    public DataSet Vehicledata()
    {
       // throw new Exception("The method or operation is not implemented.");
        return VehicleBillingTransactionDAL.VehicleData(VehicleID);
    }
}
