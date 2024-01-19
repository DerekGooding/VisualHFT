namespace VisualHFT.Commons.Model;

public partial class Execution : OpenExecution
{

    public Execution(OpenExecution exec, string symbol)
    {
        if (exec == null)
            return;
        ClOrdId = exec.ClOrdId;
        ExecID = exec.ExecID;
        ExecutionID = exec.ExecutionID;
        IsOpen = exec.IsOpen;
        LocalTimeStamp = exec.LocalTimeStamp;
        PositionID = exec.PositionID;
        Price = exec.Price;
        ProviderID = exec.ProviderID;
        QtyFilled = exec.QtyFilled;
        ServerTimeStamp = exec.ServerTimeStamp;
        Side = (ePOSITIONSIDE)exec.Side;
        Status = (ePOSITIONSTATUS)exec.Status;
        Symbol = symbol;
    }
    public Execution(CloseExecution exec, string symbol)
    {
        if (exec == null)
            return;
        ClOrdId = exec.ClOrdId;
        ExecID = exec.ExecID;
        ExecutionID = exec.ExecutionID;
        IsOpen = exec.IsOpen;
        LocalTimeStamp = exec.LocalTimeStamp;
        PositionID = exec.PositionID;
        Price = exec.Price;
        ProviderID = exec.ProviderID;
        QtyFilled = exec.QtyFilled;
        ServerTimeStamp = exec.ServerTimeStamp;
        Side = (ePOSITIONSIDE)exec.Side;
        Status = (ePOSITIONSTATUS)exec.Status;
        Symbol = symbol;
    }
    public string ProviderName { get; set; }
    public string Symbol { get; set; }
    public double LatencyInMiliseconds
    {
        get { return LocalTimeStamp.Subtract(ServerTimeStamp).TotalMilliseconds; }
    }
    public new ePOSITIONSIDE Side
    {
        get { return base.Side == null ? ePOSITIONSIDE.None : (ePOSITIONSIDE)base.Side; }
        set { base.Side = (int)value; }
    }
    public new ePOSITIONSTATUS Status
    {
        get { return base.Status == null ? ePOSITIONSTATUS.NONE : (ePOSITIONSTATUS)base.Status; }
        set { base.Status = (int)value; }
    }
}
