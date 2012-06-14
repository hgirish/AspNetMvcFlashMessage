using System.Web.Mvc;

namespace FlashMessageRailStyle.Helpers
{
  public static class FlashHelpers
  {

    public static void FlashInfo(this Controller controller, string message)
    {
      controller.TempData["info"] = message;
    }
    public static void FlashWarning(this Controller controller, string message)
    {
      controller.TempData["warning"] = message;
    }
    public static void FlashError(this Controller controller, string message)
    {
      controller.TempData["error"] = message;
    }
  }
}