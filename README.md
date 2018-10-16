# Xamarin.Forms.AnimationsPack
Xamarin.Forms.AnimationsPack is Animation library for Xamarin.Forms.
This library contains [Animations](#animation-list).

# How to Install
Install from NuGet.
```
> Install-Package Xamarin.Forms.AnimationsPack
```
[https://www.nuget.org/packages/Xamarin.Forms.AnimationsPack](https://www.nuget.org/packages/Xamarin.Forms.AnimationsPack)

# Demo Project
Demo project applying this library is located to the following path of this repository.

```
demo/XFAnimationDemo.sln
```

Let's build and run demo application!

# How to Use
## Namespace Declaration
~~~XAML
xmlns:animationsPack="clr-namespace:Xamarin.Forms.AnimationsPack;assembly=Xamarin.Forms.AnimationsPack"
~~~

## Apply Animation
### EventTrigger
Simple code sample for Xamrin.Forms.Entry control.
~~~XAML
<Entry Text="Welcome to Xamarin.Forms!" TextColor="Black" FontSize="20" BackgroundColor="Gray">
	<Entry.Triggers>
		<EventTrigger Event="Focused">
			<animationsPack:EntryTextColorAnimation From="Black" To="Lime" Length="1000" Easing="Linear"/>
			<animationsPack:EntryFontSizeDoubleAnimation To="30" Length="3000"/>
			<animationsPack:BackgroundColorAnimation To="Teal" Easing="CubicInOut"/>
		</EventTrigger>
	</Entry.Triggers>
</Entry>
~~~

This example shows following animation.
- Animation starts when Entry is focused.
  - `TextColor` property : **Black** > **Lime**, **1000** millisecond, **Linear** easing-function
  - `FontSize` property : *20* > **30**, **3000** millisecond, *Linear* easing-function
  - `BackgroundColor` property : *Gray* -> **Teal**, *1000* millisecond, **CubicInOut** easing-function

### DataTrigger
In the DataTrigger sample, we assume that BindingContext is  already set, and that ViewModel contains `bool` type property named `IsAnimationWorking`.

```XAML
<Button Command="{Binding RunAnimation}" Text="RunAnimation"/>
<Entry Text="Welcome to Xamarin.Forms!" TextColor="Black" FontSize="20" BackgroundColor="Gray" VerticalOptions="FillAndExpand">
	<Entry.Triggers>
		<DataTrigger TargetType="Entry" Binding="{Binding Path=IsAnimationWorking,Mode=OneWay,UpdateSourceEventName=PropertyChanged}" Value="true">
			<DataTrigger.EnterActions>
				<animationsPack:EntryTextColorAnimation From="Black" To="Yellow" Length="1000" Easing="BounceIn"/>
				<animationsPack:EntryFontSizeDoubleAnimation To="50" Length="2000"/>
				<animationsPack:BackgroundColorAnimation To="Red" Easing="SinIn"/>
			</DataTrigger.EnterActions>
			<DataTrigger.ExitActions>
				<animationsPack:EntryTextColorAnimation To="Black"/>
				<animationsPack:EntryFontSizeDoubleAnimation To="20"/>
				<animationsPack:BackgroundColorAnimation To="Gray"/>
			</DataTrigger.ExitActions>
		</DataTrigger>
	</Entry.Triggers>
</Entry>
```

This example shows following animation.
- Animation starts when Button is clicked (`IsAnimationWorking` is set to `true` when Button is clicked).
  - `TextColor` property : **Black** -> **Yellow**, **1000** millisecond, **BounceIn** easing-function
  - `FontSize` property : *20* -> **50**, **2000** millisecond, *Linear* easing-function
  - `BackgroundColor` property : *Gray* -> **Red**, *1000* millisecond, **SinIn** easing-function
- After 2 seconds, another animation starts (`IsAnimationWorking` is force change to `false` after 2 seconds).
  - `TextColor` property : *Yellow* -> **Black**, *1000* milliseconds, *Linear* easing-function
  - `FontSize` property : *50* -> **20**, *1000* milliseconds, *Linear* easing-function
  - `BackgroundColor` property : *Red* -> **Gray**, *1000* milliseconds, *Linear* easing-function

Note : **(Bold Property)** is explicitly specified property. *(Italic property)* is unspecified and apply to [default-value](#common-property) property

# Dependencies
Xamarin.Forms : 3.2.0.871581

# Common Property
~~~C#
public T From { get; set; } = default(T); // Animation starting value
public T To { get; set; } = default(T); // Animation ending value
public uint Length { get; set; } = 1000; // Animation Length (milliseconds)
public string Easing { get; set; } = "Linear"; // Animation EasingFunction name
~~~

- From : Optional
  - If From do not set, then use current property value
- To : **Required**
- Length : Optional
- Easing : Optional
  - https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.easing?view=xamarin-forms

# Animation List
<table>
<tr>
  <th>Property Owner</th>
  <th>Property</th>
  <th>Animation Class Name</th>
  <th>T</th>
  <th>Implemented</th>
</tr>
<tr>
  <td rowspan=6>VisualElement</td>
  <td>BackgroundColor</td>
  <td>BackgroundColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>Opacity</td>
  <td>OpacityDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>HeightRequest</td>
  <td>HeightRequestDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>WidthRequest</td>
  <td>WidthRequestDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>Rotation</td>
  <td>(RotationTo)</td>
  <td align=center>double</td>
  <td align=center>-</td>
</tr>
<tr>
  <td>Scale</td>
  <td>(ScaleTo)</td>
  <td align=center>double</td>
  <td align=center>-</td>
</tr>
<tr>
  <td>View</td>
  <td>Margin</td>
  <td>MarginThicknessAnimation</td>
  <td align=center>Thickness</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td rowspan=3>Label</td>
  <td>FontSize</td>
  <td>LabelFontSizeDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>TextColor</td>
  <td>LabelTextColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>LineHeight</td>
  <td>LabelLineHeightDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>ActivityIndicator</td>
  <td>Color</td>
  <td>ActivityIndicatorColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#9651;</td>
</tr>
<tr>
  <td rowspan=2>BoxView</td>
  <td>Color</td>
  <td>BoxViewColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>CornerRadius</td>
  <td>BoxViewCornerRadiusAnimation</td>
  <td align=center>CornerRadius</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td rowspan=6>Button</td>
  <td>BorderColor</td>
  <td>ButtonBorderColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>BorderWidth</td>
  <td>ButtonBorderWidthDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>CornerRadius</td>
  <td>ButtonCornerRadiusAnimation</td>
  <td align=center>CornerRadius</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>FontSize</td>
  <td>ButtonFontSizeDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>Padding</td>
  <td>ButtonPaddingThicknessAnimation</td>
  <td align=center>Thickness</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>TextColor</td>
  <td>ButtonTextColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td rowspan=2>DatePicker</td>
  <td>FontSize</td>
  <td>DatePickerFontSizeDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>TextColor</td>
  <td>DatePickerTextColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>Layout</td>
  <td>Padding</td>
  <td>LayoutPaddingThicknessAnimation</td>
  <td align=center>Thickness</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>AbsoluteLayout</td>
  <td>LayoutBounds</td>
  <td>AbsoluteLayoutBoundsRectangleAnimation</td>
  <td align=center>Rectangle</td>
  <td align=center>?</td>
</tr>
<tr>
  <td rowspan=2>Grid</td>
  <td>ColumnSpacing</td>
  <td>GridColumnSpacingDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>RowSpacing</td>
  <td>GridRowSpacingDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>StackLayout</td>
  <td>Spacing</td>
  <td>StackLayoutSpacingDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td rowspan=2>Picker</td>
  <td>TextColor</td>
  <td>PickerTextColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>FontSize</td>
  <td>PickerFontSizeDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>ProgressBar</td>
  <td>ProgressColor</td>
  <td>ProgressBarColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td rowspan=3>Slider</td>
  <td>MaximumTrackColor</td>
  <td>SliderMaximumTrackColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>MinimumTrackColor</td>
  <td>SliderMinimumTrackColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>ThumbColor</td>
  <td>SliderThumbColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>Switch</td>
  <td>OnColor</td>
  <td>SwitchOnColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>TableView</td>
  <td>RowHeight</td>
  <td>TableViewRowHeightIntAnimation</td>
  <td align=center>int</td>
  <td align=center>&#10005;</td>
</tr>
<tr>
  <td rowspan=2>TimePicker</td>
  <td>FontSize</td>
  <td>TimePickerFontSizeDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>TextColor</td>
  <td>TimePickerTextColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td rowspan=3>Editor</td>
  <td>FontSize</td>
  <td>EditorFontSizeDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>PlaceholderColor</td>
  <td>EditorPlaceholderColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>TextColor</td>
  <td>EditorTextColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td rowspan=3>Entry</td>
  <td>FontSize</td>
  <td>EntryFontSizeDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>PlaceholderColor</td>
  <td>EntryPlaceholderColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>TextColor</td>
  <td>EntryTextColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td rowspan=2>ListView</td>
  <td>RowHeight</td>
  <td>ListViewRowHeightDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>&#10005;</td>
</tr>
<tr>
  <td>SeparatorColor</td>
  <td>ListViewSeparatorColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td rowspan=3>Frame</td>
  <td>BorderColor</td>
  <td>FrameBorderColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>CornerRadius</td>
  <td>FrameCornerRadiusAnimation</td>
  <td align=center>CornerRadius</td>
  <td align=center>&#10003;</td>
</tr>
<tr>
  <td>OutlineColor(Obsolete)</td>
  <td>FrameOutlineColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>&#10003;</td>
</tr>
</table>

# Xamarin.Forms namespace Class Diagram
<https://drive.google.com/file/d/1cYChmthboGXX__Rg5pFC1O2pTNE7vWGy/view?usp=sharing>