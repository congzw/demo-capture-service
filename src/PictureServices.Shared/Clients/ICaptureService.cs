namespace PictureServices.Clients
{
    public interface ICaptureService
    {
        //todo create capture
        CaptureConfig DefaultConfig { get; set; }
        CaptureResult Capture(CaptureConfig config);
    }

    public class CaptureResult
    {
    }

    public class CaptureConfig
    {

    }
}
