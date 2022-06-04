﻿using LenovoLegionToolkit.Lib;
using LenovoLegionToolkit.Lib.Listeners;
using LenovoLegionToolkit.WPF.Utils;
using WPFUI.Common;

namespace LenovoLegionToolkit.WPF.Controls.Dashboard
{
    public class PowerModeControl : AbstractComboBoxCardControl<PowerModeState>
    {
        private readonly PowerModeListener _listener = Container.Resolve<PowerModeListener>();

        public PowerModeControl()
        {
            Icon = SymbolRegular.Gauge24;
            Title = "Power Mode";
            Subtitle = "Choose the mode you want to use.\nYou can switch mode using shortcut Fn+Q.";

            _listener.Changed += Listener_Changed;
        }

        private void Listener_Changed(object? sender, PowerModeState e) => Dispatcher.Invoke(async () =>
        {
            if (IsLoaded && IsVisible)
                await RefreshAsync();
        });
    }
}