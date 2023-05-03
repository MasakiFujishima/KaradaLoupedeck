namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Insert_Roxygen_Skeleton : PluginDynamicCommand
    {
        public Insert_Roxygen_Skeleton()
        : base(displayName: "Insert Roxygen Skeleton", description: "Insert Roxygen Skeleton", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Insert Roxygen Skeleton", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyR, ModifierKey.Ctrl | ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
