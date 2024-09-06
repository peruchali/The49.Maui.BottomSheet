namespace The49.Maui.BottomSheet;

internal partial class BottomSheetManager
{
    static partial void PlatformShow(Window window, BottomSheet sheet, bool animated)
    {
        var controller = new BottomSheetController(window.Handler.MauiContext, sheet, showNextToAppBarLayout: false);
        sheet.Controller = controller;
        controller.Show(animated);
    }

    static partial void PlatformShow(Page page, BottomSheet sheet, bool animated)
    {
        // For pages, add the bottomsheet next to the AppBarLayout.
        // This ensures that the bottomsheet shows "within" the page.
        var controller = new BottomSheetController(page.Handler.MauiContext, sheet, showNextToAppBarLayout: true);
        sheet.Controller = controller;
        controller.Show(animated);
    }
}