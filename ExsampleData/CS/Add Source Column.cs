namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Add_Source_Column : PluginDynamicCommand
    {
        public Add_Source_Column()
        : base(displayName: "Add Source Column", description: "Add Source Column", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Add Source Column", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F7, ModifierKey.Ctrl);
        }
    }
}
