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
/// Summary description for DriverBO
/// </summary>
public class DriverBO
{
	public DriverBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _ImagePath;

    public string ImagePath
    {
        get { return _ImagePath; }
        set { _ImagePath = value; }
    }
	
    private string _DriverID;

    public string DriverID
    {
        get { return _DriverID; }
        set { _DriverID = value; }
    }
    private string _Name;

    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
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
  
    private DateTime _DOB;

    public DateTime DOB
    {
        get { return _DOB; }
        set { _DOB = value; }
    }
    private DateTime _DOJ;

    public DateTime DOJ
    {
        get { return _DOJ; }
        set { _DOJ = value; }
    }
    private string _Experience;

    public string Experience
    {
        get { return _Experience; }
        set { _Experience = value; }
    }
    private string _LicenceNo;

    public string LicenceNo
    {
        get { return _LicenceNo; }
        set { _LicenceNo = value; }
    }
    private string _NoOfAccident;

    public string NoOfAccident
    {
        get { return _NoOfAccident; }
        set { _NoOfAccident = value; }
    }
	



    public int InsertDriverDetails()

    {
       // throw new Exception("The method or operation is not implemented.");
        return DriverDAL.InsertDriverDetails(Name, Address, PhoneNo, DOB, DOJ, Experience, LicenceNo, ImagePath, NoOfAccident);

    }

    public DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        return DriverDAL.Getaata();
    }

    public int DeleteDriverDetails()
    {
        //throw new Exception("The method or operation is not implemented.");
        return DriverDAL.DeletDriverDetails(DriverID);
    }

    public int UpDateDriverDetails()
    {
        //throw new Exception("The method or operation is not implemented.");
        return DriverDAL.UpdateDriverDetails(DriverID, Name, Address, PhoneNo, DOB, DOJ, Experience, LicenceNo, ImagePath, NoOfAccident);
    }

    public DataSet SelectDriverDetails()
    {
       // throw new Exception("The method or operation is not implemented.");
        return DriverDAL.SelectDriverDetails(DriverID);
    }
}
