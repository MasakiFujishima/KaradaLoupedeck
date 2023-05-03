namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Find_usages_for_symbol_at_cursor_C++ : PluginDynamicCommand
    {
        public Find_usages_for_symbol_at_cursor_C++()
        : base(displayName: "Find usages for symbol at cursor C++", description: "Find usages for symbol at cursor C++", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Find usages for symbol at cursor C++", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyU, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
