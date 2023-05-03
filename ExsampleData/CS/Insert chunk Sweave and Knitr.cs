namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Insert_chunk_Sweave_and_Knitr : PluginDynamicCommand
    {
        public Insert_chunk_Sweave_and_Knitr()
        : base(displayName: "Insert chunk Sweave and Knitr", description: "Insert chunk Sweave and Knitr", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Insert chunk Sweave and Knitr", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyI, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
