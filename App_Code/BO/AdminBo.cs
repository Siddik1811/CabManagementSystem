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
/// Summary description for AdminBo
/// </summary>
public class AdminBo
{
    public AdminBo()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    private string _MangerID;

    public string MangerID
    {
        get { return _MangerID; }
        set { _MangerID = value; }
    }
    private string _ManagerName;

    public string ManagerName
    {
        get { return _ManagerName; }
        set { _ManagerName = value; }
    }

    private string _EmailId;

    public string EmailId
    {
        get { return _EmailId; }
        set { _EmailId = value; }
    }

    private string _UserId;

    public string UserId
    {
        get { return _UserId; }
        set { _UserId = value; }
    }
	
    private string _UserName;

    public string UserName
    {
        get { return _UserName; }
        set { _UserName = value; }
    }
    private string  _OldPassword;

    public string  OldPassword
    {
        get { return _OldPassword; }
        set { _OldPassword = value; }
    }
	
    private string _Password;

    public string Password
    {
        get { return _Password; }
        set { _Password = value; }
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

    private string _DOB;

    public string DOB
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
    private string _DOJ;

    public string DOJ
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


    public DataSet AdminLogin()
    {
        // throw new Exception("The method or operation is not implemented.");
        return AdminDAL.AdminLogin(UserId, Password);
    }
    public DataSet AdminLogin(string UserId)
    {
        // throw new Exception("The method or operation is not implemented.");
        return AdminDAL.AdminLogin(UserId);
    }

    public int Insert()
    {
        //throw new Exception("The method or operation is not implemented.");
        return AdminDAL.Insert(EmpName, UserName, Password, PAddress, Qulification, DOB, Gender, PhoneNo, EmailId, Designation, Department, DOJ, Age);
    }

    public DataSet UpdateManger()
    {
        //throw new Exception("The method or operation is not implemented.");
        return AdminDAL.UpdateManger(MangerID, EmpName, PAddress, Qulification, DOB, Gender, PhoneNo, EmailId, Designation, Department, DOJ, Age);
    }

    public DataSet GetDataManger()
    {
        // throw new Exception("The method or operation is not implemented.");
        return AdminDAL.GetDataManger();
    }

    public int DeleteManger()
    {
        // throw new Exception("The method or operation is not implemented.");
        return AdminDAL.DeleteManger(MangerID);
    }

    public DataSet SelectMang()
    {
        // throw new Exception("The method or operation is not implemented.");
        return AdminDAL.SelectMang(MangerID);
    }

    public int UpdateAdminLogin()
    {
        // throw new Exception("The method or operation is not implemented.");
        return AdminDAL.UpdateLogin(UserName, Password);
    }

    public DataSet InsertManagerName()
    {
        //throw new Exception("The method or operation is not implemented.");
        return AdminDAL.InsertManager(ManagerName, PAddress, Qulification, DOB, Gender, PhoneNo, EmailId, Designation, Department, DOJ, Age);
    }

    public DataSet UpdatePassword()
    {
        //throw new Exception("The method or operation is not implemented.");
        return AdminDAL.UpdatePassword(UserId,OldPassword,Password);
    }

    public DataSet GetLoginDetails()
    {
       // throw new Exception("The method or operation is not implemented.");
        return AdminDAL.GetLoginDetails();
    }
}
