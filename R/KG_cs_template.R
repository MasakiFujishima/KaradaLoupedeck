# VK_MKがある場合
# If VK_MK is present
VK_MK_vec <- 'namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class {{FUNK_NAME}} : PluginDynamicCommand
    {
        public {{FUNK_NAME}}()
        : base(displayName: "{{DIS_NAME}}", description: "{{DIS_NAME}}", groupName: "{{CATE_NAME}}")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("{{CATE_NAME}}.png")));
                bitmapBuilder.DrawText("{{DIS_NAME}}", color: new BitmapColor({{TEXT_COL}}));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.{{VK}}, {{MK}});
        }
    }
}'

# VKのみ
# VK only
VK_vec <- 'namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class {{FUNK_NAME}} : PluginDynamicCommand
    {
        public {{FUNK_NAME}}()
        : base(displayName: "{{DIS_NAME}}", description: "{{DIS_NAME}}", groupName: "{{CATE_NAME}}")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("{{CATE_NAME}}.png")));
                bitmapBuilder.DrawText("{{DIS_NAME}}", color: new BitmapColor({{TEXT_COL}}));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(VirtualKeyCode.{{VK}});
        }
    }
}'
