namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Stage_Unstage_Git : PluginDynamicCommand
    {
        public Stage_Unstage_Git()
        : base(displayName: "Stage Unstage Git", description: "Stage Unstage Git", groupName: "Git/SVN")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Git/SVN.png")));
                bitmapBuilder.DrawText("Stage Unstage Git", color: new BitmapColor(181,56,34));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Spacebar, );
        }
    }
}
