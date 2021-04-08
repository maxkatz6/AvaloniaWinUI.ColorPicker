using System;

using Avalonia;
using Avalonia.Media;

namespace AvaloniaWinUI.ColorPicker
{
    public partial class ColorPicker
    {
        //
        // Summary:
        //     Gets or sets the previous color.
        //
        // Returns:
        //     The previous color. The default is **null**.
        public Color? PreviousColor
        {
            get => GetValue(PreviousColorProperty);
            set => SetValue(PreviousColorProperty, value);
        }
        //
        // Summary:
        //     Gets or sets the minimum Value value in the range 0-100.
        //
        // Returns:
        //     The minimum Value value in the range 0-100. The default is 100.
        public int MinValue
        {
            get => GetValue(MinValueProperty);
            set => SetValue(MinValueProperty, value);
        }
        //
        // Summary:
        //     Gets or sets the minimum Saturation value in the range 0-100.
        //
        // Returns:
        //     The minimum Saturation value in the range 0-100. The default is 100.
        public int MinSaturation
        {
            get => GetValue(MinSaturationProperty);
            set => SetValue(MinSaturationProperty, value);
        }
        //
        // Summary:
        //     Gets or sets the minimum Hue value in the range 0-359.
        //
        // Returns:
        //     The minimum Hue value in the range 0-359. The default is 0.
        public int MinHue
        {
            get => GetValue(MinHueProperty);
            set => SetValue(MinHueProperty, value);
        }
        //
        // Summary:
        //     Gets or sets the maximum Value value in the range 0-100.
        //
        // Returns:
        //     The maximum Value value in the range 0-100. The default is 100.
        public int MaxValue
        {
            get => GetValue(MaxValueProperty);
            set => SetValue(MaxValueProperty, value);
        }
        //
        // Summary:
        //     Gets or sets the maximum Saturation value in the range 0-100.
        //
        // Returns:
        //     The maximum Saturation value in the range 0-100. The default is 100.
        public int MaxSaturation
        {
            get => GetValue(MaxSaturationProperty);
            set => SetValue(MaxSaturationProperty, value);
        }
        //
        // Summary:
        //     Gets or sets the maximum Hue value in the range 0-359.
        //
        // Returns:
        //     The maximum Hue value in the range 0-359. The default is 359.
        public int MaxHue
        {
            get => GetValue(MaxHueProperty);
            set => SetValue(MaxHueProperty, value);
        }
        //
        // Summary:
        //     Gets or sets a value that indicates whether the 'more' button is shown.
        //
        // Returns:
        //     **true** if the 'more' button is shown; otherwise, **false**. The default is
        //     **false**.
        public bool IsMoreButtonVisible
        {
            get => GetValue(IsMoreButtonVisibleProperty);
            set => SetValue(IsMoreButtonVisibleProperty, value);
        }
        //
        // Summary:
        //     Gets or sets a value that indicates whether the text input box for a HEX color
        //     value is shown.
        //
        // Returns:
        //     **true** if the HEX color text input box is shown; otherwise, **false**. The
        //     default is **true**.
        public bool IsHexInputVisible
        {
            get => GetValue(IsHexInputVisibleProperty);
            set => SetValue(IsHexInputVisibleProperty, value);
        }
        //
        // Summary:
        //     Gets or sets a value that indicates whether the color spectrum control is shown.
        //
        // Returns:
        //     **true** if the color spectrum is shown; otherwise, **false**. The default is
        //     **true**.
        public bool IsColorSpectrumVisible
        {
            get => GetValue(IsColorSpectrumVisibleProperty);
            set => SetValue(IsColorSpectrumVisibleProperty, value);
        }
        //
        // Summary:
        //     Gets or sets a value that indicates whether the slider control for the color
        //     value is shown.
        //
        // Returns:
        //     **true** if the color slider is shown; otherwise, **false**. The default is **true**.
        public bool IsColorSliderVisible
        {
            get => GetValue(IsColorSliderVisibleProperty);
            set => SetValue(IsColorSliderVisibleProperty, value);
        }
        //
        // Summary:
        //     Gets or sets a value that indicates whether the color preview bar is shown.
        //
        // Returns:
        //     **true** if the color preview bar is shown; otherwise, **false**. The default
        //     is **true**.
        public bool IsColorPreviewVisible
        {
            get => GetValue(IsColorPreviewVisibleProperty);
            set => SetValue(IsColorPreviewVisibleProperty, value);
        }
        //
        // Summary:
        //     Gets or sets a value that indicates whether the text input boxes for the color
        //     channels are shown.
        //
        // Returns:
        //     **true** if the color channel text input boxes are shown; otherwise, **false**.
        //     The default is **true**.
        public bool IsColorChannelTextInputVisible
        {
            get => GetValue(IsColorChannelTextInputVisibleProperty);
            set => SetValue(IsColorChannelTextInputVisibleProperty, value);
        }
        //
        // Summary:
        //     Gets or sets a value that indicates whether the text input box for the alpha
        //     channel is shown.
        //
        // Returns:
        //     **true** if the alpha channel text input box is shown; otherwise, **false**.
        //     The default is **true**.
        public bool IsAlphaTextInputVisible
        {
            get => GetValue(IsAlphaTextInputVisibleProperty);
            set => SetValue(IsAlphaTextInputVisibleProperty, value);
        }
        //
        // Summary:
        //     Gets or sets a value that indicates whether the slider control for the alpha
        //     channel is shown.
        //
        // Returns:
        //     **true** if the alpha channel slider is shown; otherwise, **false**. The default
        //     is **true**.
        public bool IsAlphaSliderVisible
        {
            get => GetValue(IsAlphaSliderVisibleProperty);
            set => SetValue(IsAlphaSliderVisibleProperty, value);
        }
        //
        // Summary:
        //     Gets or sets a value that indicates whether the alpha channel can be modified.
        //
        // Returns:
        //     **true** if the alpha channel is enabled; otherwise, **false**. The default is
        //     **false**.
        public bool IsAlphaEnabled
        {
            get => GetValue(IsAlphaEnabledProperty);
            set => SetValue(IsAlphaEnabledProperty, value);
        }
        //
        // Summary:
        //     Gets or sets a value that indicates whether the ColorSpectrum is shown as a square
        //     or a circle.
        //
        // Returns:
        //     A value of the enumeration. The default is **Box**, which shows the spectrum
        //     as a square.
        public ColorSpectrumShape ColorSpectrumShape
        {
            get => GetValue(ColorSpectrumShapeProperty);
            set => SetValue(ColorSpectrumShapeProperty, value);
        }
        //
        // Summary:
        //     Gets or sets a value that indicates how the Hue-Saturation-Value (HSV) color
        //     components are mapped onto the ColorSpectrum.
        //
        // Returns:
        //     A value of the enumeration. The default is **HueSaturation**.
        public ColorSpectrumComponents ColorSpectrumComponents
        {
            get => GetValue(ColorSpectrumComponentsProperty);
            set => SetValue(ColorSpectrumComponentsProperty, value);
        }
        //
        // Summary:
        //     Gets or sets the current color value.
        //
        // Returns:
        //     The current color value.
        public Color Color
        {
            get => GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }

        internal Hsv CurrentHsv { get; set; }

        //
        // Summary:
        //     Identifies the Color dependency property.
        //
        // Returns:
        //     The identifier for the Color dependency property.
        public static readonly StyledProperty<Color> ColorProperty =
            AvaloniaProperty.Register<ColorPicker, Color>(nameof(Color), Colors.White, defaultBindingMode: Avalonia.Data.BindingMode.TwoWay);
        //
        // Summary:
        //     Identifies the ColorSpectrumComponents dependency property.
        //
        // Returns:
        //     The identifier for the ColorSpectrumComponents dependency property.
        public static readonly StyledProperty<ColorSpectrumComponents> ColorSpectrumComponentsProperty =
             AvaloniaProperty.Register<ColorPicker, ColorSpectrumComponents>(nameof(ColorSpectrumComponents), ColorSpectrumComponents.HueSaturation);
        //
        // Summary:
        //     Identifies the ColorSpectrumShape dependency property.
        //
        // Returns:
        //     The identifier for the ColorSpectrumShape dependency property.
        public static readonly StyledProperty<ColorSpectrumShape> ColorSpectrumShapeProperty =
             AvaloniaProperty.Register<ColorPicker, ColorSpectrumShape>(nameof(ColorSpectrumShape), ColorSpectrumShape.Box);
        //
        // Summary:
        //     Identifies the IsAlphaEnabled dependency property.
        //
        // Returns:
        //     The identifier for the IsAlphaEnabled dependency property.
        public static readonly StyledProperty<bool> IsAlphaEnabledProperty =
             AvaloniaProperty.Register<ColorPicker, bool>(nameof(IsAlphaEnabled), false);
        //
        // Summary:
        //     Identifies the IsAlphaSliderVisible dependency property.
        //
        // Returns:
        //     The identifier for the IsAlphaSliderVisible dependency property.
        public static readonly StyledProperty<bool> IsAlphaSliderVisibleProperty =
             AvaloniaProperty.Register<ColorPicker, bool>(nameof(IsAlphaSliderVisible), true);
        //
        // Summary:
        //     Identifies the IsAlphaTextInputVisible dependency property.
        //
        // Returns:
        //     The identifier for the IsAlphaTextInputVisible dependency property.
        public static readonly StyledProperty<bool> IsAlphaTextInputVisibleProperty =
             AvaloniaProperty.Register<ColorPicker, bool>(nameof(IsAlphaTextInputVisible), true);
        //
        // Summary:
        //     Identifies the IsColorChannelTextInputVisible dependency property.
        //
        // Returns:
        //     The identifier for the IsColorChannelTextInputVisible dependency property.
        public static readonly StyledProperty<bool> IsColorChannelTextInputVisibleProperty =
             AvaloniaProperty.Register<ColorPicker, bool>(nameof(IsColorChannelTextInputVisible), true);
        //
        // Summary:
        //     Identifies the IsColorPreviewVisible dependency property.
        //
        // Returns:
        //     The identifier for the IsColorPreviewVisible dependency property.
        public static readonly StyledProperty<bool> IsColorPreviewVisibleProperty =
             AvaloniaProperty.Register<ColorPicker, bool>(nameof(IsColorPreviewVisible), true);
        //
        // Summary:
        //     Identifies the IsColorSliderVisible dependency property.
        //
        // Returns:
        //     The identifier for the IsColorSliderVisible dependency property.
        public static readonly StyledProperty<bool> IsColorSliderVisibleProperty =
             AvaloniaProperty.Register<ColorPicker, bool>(nameof(IsColorSliderVisible), true);
        //
        // Summary:
        //     Identifies the IsColorSpectrumVisible dependency property.
        //
        // Returns:
        //     The identifier for the IsColorSpectrumVisible dependency property.
        public static readonly StyledProperty<bool> IsColorSpectrumVisibleProperty =
             AvaloniaProperty.Register<ColorPicker, bool>(nameof(IsColorSpectrumVisible), true);
        //
        // Summary:
        //     Identifies the IsHexInputVisible dependency property.
        //
        // Returns:
        //     The identifier for the IsHexInputVisible dependency property.
        public static readonly StyledProperty<bool> IsHexInputVisibleProperty =
             AvaloniaProperty.Register<ColorPicker, bool>(nameof(IsHexInputVisible), true);
        //
        // Summary:
        //     Identifies the IsMoreButtonVisible dependency property.
        //
        // Returns:
        //     The identifier for the IsMoreButtonVisible dependency property.
        public static readonly StyledProperty<bool> IsMoreButtonVisibleProperty =
             AvaloniaProperty.Register<ColorPicker, bool>(nameof(IsMoreButtonVisible), false);
        //
        // Summary:
        //     Identifies the MaxHue dependency property.
        //
        // Returns:
        //     The identifier for the MaxHue dependency property.
        public static readonly StyledProperty<int> MaxHueProperty =
             AvaloniaProperty.Register<ColorPicker, int>(nameof(MaxHue), 359, validate: value => value >= 0 && value <= 359);
        //
        // Summary:
        //     Identifies the MaxSaturation dependency property.
        //
        // Returns:
        //     The identifier for the MaxSaturation dependency property.
        public static readonly StyledProperty<int> MaxSaturationProperty =
             AvaloniaProperty.Register<ColorPicker, int>(nameof(MaxSaturation), 100, validate: value => value >= 0 && value <= 100);
        //
        // Summary:
        //     Identifies the MaxValue dependency property.
        //
        // Returns:
        //     The identifier for the MaxValue dependency property.
        public static readonly StyledProperty<int> MaxValueProperty =
             AvaloniaProperty.Register<ColorPicker, int>(nameof(MaxValue), 100, validate: value => value >= 0 && value <= 100);
        //
        // Summary:
        //     Identifies the MinHue dependency property.
        //
        // Returns:
        //     The identifier for the MinHue dependency property.
        public static readonly StyledProperty<int> MinHueProperty =
             AvaloniaProperty.Register<ColorPicker, int>(nameof(MinHue), 0, validate: value => value >= 0 && value <= 359);
        //
        // Summary:
        //     Identifies the MinSaturation dependency property.
        //
        // Returns:
        //     The identifier for the MinSaturation dependency property.
        public static readonly StyledProperty<int> MinSaturationProperty =
             AvaloniaProperty.Register<ColorPicker, int>(nameof(MinSaturation), 0, validate: value => value >= 0 && value <= 100);
        //
        // Summary:
        //     Identifies the MinValue dependency property.
        //
        // Returns:
        //     The identifier for the MinValue dependency property.
        public static readonly StyledProperty<int> MinValueProperty =
             AvaloniaProperty.Register<ColorPicker, int>(nameof(MinValue), 0, validate: value => value >= 0 && value <= 100);
        //
        // Summary:
        //     Identifies the PreviousColor dependency property.
        //
        // Returns:
        //     The identifier for the PreviousColor dependency property.
        public static readonly StyledProperty<Color?> PreviousColorProperty =
             AvaloniaProperty.Register<ColorPicker, Color?>(nameof(PreviousColor));

        //
        // Summary:
        //     Occurs when the Color property has changed.
        public event EventHandler<ColorChangedEventArgs>? ColorChanged;
    }
}
