﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._RMC14.Admin;

[GenerateTypedNameReferences]
public sealed partial class RMCAdminWindow : DefaultWindow
{
    public RMCAdminWindow()
    {
        RobustXamlLoader.Load(this);

        TabContainer.SetTabTitle(TransformTab, Loc.GetString("rmc-ui-transform-tab"));
        TabContainer.SetTabTitle(MarineTab, Loc.GetString("rmc-ui-marine-tab"));
        TabContainer.SetTabTitle(XenoTab, Loc.GetString("rmc-ui-xeno-tab"));
    }
}
