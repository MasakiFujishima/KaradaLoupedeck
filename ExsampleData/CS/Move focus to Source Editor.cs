namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Move_focus_to_Source_Editor : PluginDynamicCommand
    {
        public Move_focus_to_Source_Editor()
        : base(displayName: "Move focus to Source Editor", description: "Move focus to Source Editor", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Move focus to Source Editor", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad1, ModifierKey.Ctrl);
        }
    }
}
