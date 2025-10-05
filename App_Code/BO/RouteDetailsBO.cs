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
/// Summary description for RouteDetailsBO
/// </summary>
public class RouteDetailsBO
{
	public RouteDetailsBO()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _RouteID;

    public string RouteID
    {
        get { return _RouteID; }
        set { _RouteID = value; }
    }
    private string _RouteName;

    public string RouteName
    {
        get { return _RouteName; }
        set { _RouteName = value; }
    }
    private string _RouteDescription;

    public string RouteDescription
    {
        get { return _RouteDescription; }
        set { _RouteDescription = value; }
    }
    private string _Source;

    public string Source
    {
        get { return _Source; }
        set { _Source = value; }
    }
    private string _Destination;

    public string Destination
    {
        get { return _Destination; }
        set { _Destination = value; }
    }



    public int insertRoute()
    {
        //throw new Exception("The method or operation is not implemented.");
        return RouteDetailDAL.insertRoute(RouteDescription, Source, Destination);
    }

    public int UpdateRoute()
    {
        //throw new Exception("The method or operation is not implemented.");
        return RouteDetailDAL.UpdateRoute(RouteID, RouteDescription, Source, Destination);
    }

    public DataSet GetData()
    {
       // throw new Exception("The method or operation is not implemented.");
        return RouteDetailDAL.GetData();
    }

    public int DeleteRoute()
    {
       // throw new Exception("The method or operation is not implemented.");
        return RouteDetailDAL.DeleteRoute(RouteID);
    }

    public DataSet SelectData()
    {
        //throw new Exception("The method or operation is not implemented.");
        return RouteDetailDAL.SelectData(RouteID);
    }

    public DataSet SeacrhRoute()
    {
       // throw new Exception("The method or operation is not implemented.");
        return RouteDetailDAL.SearchRoute(RouteID);
    }
}
