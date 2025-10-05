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
/// Summary description for VendorBO
/// </summary>
public class VendorBO
{
	public VendorBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _VenderID;

    public string VenderID
    {
        get { return _VenderID; }
        set { _VenderID = value; }
    }
    private string _VenderName;

    public string VenderName
    {
        get { return _VenderName; }
        set { _VenderName = value; }
    }
    private string _Address;

    public string Address
    {
        get { return _Address; }
        set { _Address = value; }
    }
    private string _PhoneNo;

    public string PhoneNo
    {
        get { return _PhoneNo; }
        set { _PhoneNo = value; }
    }
    private string _EmailID;

    public string EmailID
    {
        get { return _EmailID; }
        set { _EmailID = value; }
    }
    private string _Remarks;

    public string Remarks
    {
        get { return _Remarks; }
        set { _Remarks = value; }
    }
    private string _ImagePath;

    public string ImagePath
    {
        get { return _ImagePath; }
        set { _ImagePath = value; }
    }



    public int InsertVenDorDetails()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VendorDAL.InsertVerdor(VenderName, Address, PhoneNo, EmailID, Remarks, ImagePath);
    }

    public DataSet GetData()
    {
       //throw new Exception("The method or operation is not implemented.");
        return VendorDAL.GetData();
    }

    public DataSet SelectVendor()
    {
       // throw new Exception("The method or operation is not implemented.");
        return VendorDAL.SelectVendor(VenderID);
    }

    public int UpdateVenDorDetails()
    {
        //throw new Exception("The method or operation is not implemented.");
        return VendorDAL.UpdateVendorDetails(VenderID,VenderName, Address, PhoneNo, EmailID, Remarks, ImagePath);
    }

    public int DeleteVendor()
    {
       // throw new Exception("The method or operation is not implemented.");
        return VendorDAL.DeleteVendor(VenderID);
    }

    public DataSet GEtDataa()
    {
        throw new Exception("The method or operation is not implemented.");
    }
}
