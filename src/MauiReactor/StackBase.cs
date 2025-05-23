// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using MauiReactor.Animations;
using MauiReactor.Shapes;
using MauiReactor.Internals;

#nullable enable
namespace MauiReactor;
public partial interface IStackBase : ILayout
{
}

public abstract partial class StackBase<T> : Layout<T>, IStackBase where T : Microsoft.Maui.Controls.StackBase, new()
{
    protected StackBase(Action<T?>? componentRefAction = null) : base(componentRefAction)
    {
        StackBaseStyles.Default?.Invoke(this);
    }

    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && StackBaseStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }

    partial void Migrated(VisualNode newNode);
    protected override void OnMigrated(VisualNode newNode)
    {
        Migrated(newNode);
        base.OnMigrated(newNode);
    }
}

public static partial class StackBaseExtensions
{
    public static T Spacing<T>(this T stackBase, double spacing, RxDoubleAnimation? customAnimation = null)
        where T : IStackBase
    {
        //stackBase.Spacing = spacing;
        stackBase.SetProperty(Microsoft.Maui.Controls.StackBase.SpacingProperty, spacing);
        stackBase.AppendAnimatable(Microsoft.Maui.Controls.StackBase.SpacingProperty, customAnimation ?? new RxDoubleAnimation(spacing));
        return stackBase;
    }

    public static T Spacing<T>(this T stackBase, Func<double> spacingFunc)
        where T : IStackBase
    {
        //stackBase.Spacing = new PropertyValue<double>(spacingFunc);
        stackBase.SetProperty(Microsoft.Maui.Controls.StackBase.SpacingProperty, new PropertyValue<double>(spacingFunc));
        return stackBase;
    }
}

public static partial class StackBaseStyles
{
    public static Action<IStackBase>? Default { get; set; }
    public static Dictionary<string, Action<IStackBase>> Themes { get; } = [];
}