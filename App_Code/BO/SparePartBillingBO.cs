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
/// Summary description for SparePartBillingBO
/// </summary>
public class SparePartBillingBO
{
	public SparePartBillingBO()
	{
		//
		// TODO: Add constructor logic here
		//
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

    private string _SpareType;

    public string SpareType
    {
        get { return _SpareType; }
        set { _SpareType = value; }
    }
    private string _Quantity;

    public string Quantity
    {
        get { return _Quantity; }
        set { _Quantity = value; }
    }
    private string _BillDate;

    public string BillDate
    {
        get { return _BillDate; }
        set { _BillDate = value; }
    }
    private string _SparePart;

    public string SparePart
    {
        get { return _SparePart; }
        set { _SparePart = value; }
    }
    private string _Price;

    public string Price
    {
        get { return _Price; }
        set { _Price = value; }
    }
    private int _TotalAmount;

    public int TotalAmount
    {
        get { return _TotalAmount; }
        set { _TotalAmount = value; }
    }




    public int InsertSPBilling()
    {
       //throw new Exception("The method or operation is not implemented.");
        return SparePartBillingDAL.InsertSPBilling(VehicleID, SpareType, Quantity, BillDate, SparePart, Price, TotalAmount); 
    }

    public int UpdateSparePartBil()
    {
        //throw new Exception("The method or operation is not implemented.");
        return SparePartBillingDAL.UpadteSparePart(BillNo, VehicleID, SpareType, Quantity, BillDate, SparePart, Price, TotalAmount);
    }

    public DataSet SelectSparepart()
    {
        //throw new Exception("The method or operation is not implemented.");
        return SparePartBillingDAL.SelectSparepart(BillNo);
    }

    public DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        return SparePartBillingDAL.GetData();
    }

    public int DeleteSparePart()
    {
        //throw new Exception("The method or operation is not implemented.");
        return SparePartBillingDAL.DeleteSpare(BillNo); 
    }
}
