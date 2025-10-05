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
/// Summary description for SparePartBO
/// </summary>
public class SparePartBO
{
	public SparePartBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _SparerPartID;

    public string SparerPartID
    {
        get { return _SparerPartID; }
        set { _SparerPartID = value; }
    }
    private string _DealerName;

    public string DealerName
    {
        get { return _DealerName; }
        set { _DealerName = value; }
    }
    private string _SparePartType;

    public string SparePartType
    {
        get { return _SparePartType; }
        set { _SparePartType = value; }
    }

    private string _Quantity;

    public string Quantity
    {
        get { return _Quantity; }
        set { _Quantity = value; }
    }
    private string _SparePart;

    public string SparePart
    {
        get { return _SparePart; }
        set { _SparePart = value; }
    }
    private string _DateOfPurchase;

    public string DateOfPurchase
    {
        get { return _DateOfPurchase; }
        set { _DateOfPurchase = value; }
    }
    private string _Price;

    public string Price
    {
        get { return _Price; }
        set { _Price = value; }
    }
    private string _AmountPaid;

    public string AmountPaid
    {
        get { return _AmountPaid; }
        set { _AmountPaid = value; }
    }


    public int InsertSparePart()
    {
        //throw new Exception("The method or operation is not implemented.");
        return SparePartDAL.InsertSparePart(DealerName, SparePartType, Quantity, SparePart, DateOfPurchase, Price, AmountPaid);
    }

    public int UpDateSparePart()
    {
        //throw new Exception("The method or operation is not implemented.");
        return SparePartDAL.UpdateSparePart(SparerPartID, DealerName, SparePartType, Quantity, SparePart, DateOfPurchase, Price, AmountPaid);
    }

    public DataSet SeleSparePart()
    {
       // throw new Exception("The method or operation is not implemented.");
        return SparePartDAL.SelectSparePart(SparerPartID);
    }

    public DataSet GetData()
    {
       // throw new Exception("The method or operation is not implemented.");
        return SparePartDAL.GetData();

    }

    public int DeleteSparePart()
    {
        //throw new Exception("The method or operation is not implemented.");
        return SparePartDAL.DeleteSparePart(SparerPartID);
    }

    public DataSet SpareparttypeDetails()
    {
       // throw new Exception("The method or operation is not implemented.");
        return SparePartDAL.SparepartTypeDetails(SparePartType);
    }
}
