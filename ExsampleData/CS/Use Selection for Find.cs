namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Use_Selection_for_Find : PluginDynamicCommand
    {
        public Use_Selection_for_Find()
        : base(displayName: "Use Selection for Find", description: "Use Selection for Find", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Use Selection for Find", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F3, ModifierKey.Ctrl);
        }
    }
}
