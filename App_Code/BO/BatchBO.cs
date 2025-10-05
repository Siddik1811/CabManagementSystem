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
/// Summary description for BatchBO
/// </summary>
public class BatchBO
{
	public BatchBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _BatchID;

    public string BatchID
    {
        get { return _BatchID; }
        set { _BatchID = value; }
    }
    private string _TotalNoOfEmployees;

    public string TotalNoOfEmployees
    {
        get { return _TotalNoOfEmployees; }
        set { _TotalNoOfEmployees = value; }
    }
    private string _ShiftID;

    public string ShiftID
    {
        get { return _ShiftID; }
        set { _ShiftID = value; }
    }



    public int Insertbatch()
    {
       // throw new Exception("The method or operation is not implemented.");
        return BatchDAL.InsertBatch(TotalNoOfEmployees, ShiftID);
    }

    public int DeleteBatchID()
    {
        //throw new Exception("The method or operation is not implemented.");
        return BatchDAL.DeleteBatchID(BatchID);
    }

    public DataSet GetData()
    {
        //throw new Exception("The method or operation is not implemented.");
        return BatchDAL.Getadata();
    }

    public int Update()
    {
        //throw new Exception("The method or operation is not implemented.");
        return BatchDAL.UpdateBatch(BatchID, TotalNoOfEmployees, ShiftID);
    }

    public DataSet SelectBatch()
    {
        //throw new Exception("The method or operation is not implemented.");
        return BatchDAL.SelectBatch(BatchID);
    }
}
