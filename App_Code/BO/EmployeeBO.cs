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
/// Summary description for EmployeeBO
/// </summary>
public class EmployeeBO
{
	public EmployeeBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _EmpID;

    public string EmpID
    {
        get { return _EmpID; }
        set { _EmpID = value; }
    }
    private string _EmpName;

    public string EmpName
    {
        get { return _EmpName; }
        set { _EmpName = value; }
    }
    private string _PAddress;

    public string PAddress
    {
        get { return _PAddress; }
        set { _PAddress = value; }
    }
    private string _CAddess;

    public string CAddess
    {
        get { return _CAddess; }
        set { _CAddess = value; }
    }
    private string _Qulification;

    public string Qulification
    {
        get { return _Qulification; }
        set { _Qulification = value; }
    }

    private DateTime _DOB;

    public DateTime DOB
    {
        get { return _DOB; }
        set { _DOB = value; }
    }
    private string _VehicleReqire;

    public string VehicleReqire
    {
        get { return _VehicleReqire; }
        set { _VehicleReqire = value; }
    }

    private string _Gender;

    public string Gender
    {
        get { return _Gender; }
        set { _Gender = value; }
    }
    private string _PhoneNo;

    public string PhoneNo
    {
        get { return _PhoneNo; }
        set { _PhoneNo = value; }
    }

    private string _Designation;

    public string Designation
    {
        get { return _Designation; }
        set { _Designation = value; }
    }

    private string _Department;

    public string Department
    {
        get { return _Department; }
        set { _Department = value; }
    }
    private DateTime _DOJ;

    public DateTime DOJ
    {
        get { return _DOJ; }
        set { _DOJ = value; }
    }
    private string _Status;

    public string Status
    {
        get { return _Status; }
        set { _Status = value; }
    }
    private string _Age;

    public string Age
    {
        get { return _Age; }
        set { _Age = value; }
    }
    private string _TimeSpan;

    public string TimeSpan
    {
        get { return _TimeSpan; }
        set { _TimeSpan = value; }
    }

    private string _ImagePath;

    public string ImagePath
    {
        get { return _ImagePath; }
        set { _ImagePath = value; }
    }
	



    public int InsertEmpDetails()
    {
        //throw new Exception("The method or operation is not implemented.");
        return EmployeeDAl.InsertEmpDetails(EmpName, PAddress, CAddess, Qulification, DOB, VehicleReqire, Gender, PhoneNo, Designation, Department, DOJ, Status, Age, TimeSpan, ImagePath);
    }

    public DataSet GetDataEmp()
    {
        //throw new Exception("The method or operation is not implemented.");
        return EmployeeDAl.GetDataEmp();
    }

    public int DeleteEmp()
    {
        //throw new Exception("The method or operation is not implemented.");
        return EmployeeDAl.DeleteEmp(EmpID);
    }

    public DataSet SelectEmp()
    {
        //throw new Exception("The method or operation is not implemented.");
        return EmployeeDAl.SeleteEp(EmpID);
    }

    public int UpdateEmpDetails()
    {
        //throw new Exception("The method or operation is not implemented.");
        return EmployeeDAl.UpdateEmp(EmpID,EmpName, PAddress, CAddess, Qulification, DOB, VehicleReqire, Gender, PhoneNo, Designation, Department, DOJ, Status, Age, TimeSpan, ImagePath);
    }
}
