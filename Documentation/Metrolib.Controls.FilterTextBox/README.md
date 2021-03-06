# FilterTextBox  

A textbox meant to input queries used for filtering.

**Namespace**: Metrolib.Controls  
**Assembly**: Metrolib (in Metrolib.dll)  

### Unfocused

```xaml
<Metrolib:FilterTextBox Watermark="Enter filter..." />
```
![Image of FilterTextBox, Unfocused](Unfocused.png)

### Focused

```xaml
<Metrolib:FilterTextBox Watermark="Enter filter..." />
```
![Image of FilterTextBox, Focused](Focused.png)

### FilterText, Focused

```xaml
<Metrolib:FilterTextBox FilterText="[0-9]+" Watermark="Enter filter..." />
```
![Image of FilterTextBox, FilterText, Focused](FilterText__Focused.png)

### FilterText, Unfocused

```xaml
<Metrolib:FilterTextBox FilterText="[0-9]+" Watermark="Enter filter..." />
```
![Image of FilterTextBox, FilterText, Unfocused](FilterText__Unfocused.png)

### Invalid FilterText

```xaml
<Metrolib:FilterTextBox FilterText="[0-9]+" Watermark="Enter filter..." IsValid="False" />
```
![Image of FilterTextBox, Invalid FilterText](Invalid_FilterText.png)

### Disabled

```xaml
<Metrolib:FilterTextBox FilterText="[0-9]+" Watermark="Enter filter..." IsEnabled="False" />
```
![Image of FilterTextBox, Disabled](Disabled.png)

# Properties  

**RemoveFilterTextButton**: System.Windows.Controls.Button  
The button that appears to remove entered text.

**HasFilterText**: System.Boolean  
Whether or not any FilterText has been entered.

**IsValid**: System.Boolean  
Whether or not the entered FilterText is valid.

**Watermark**: System.String  
The watermark text that shall be displayed when the user hasn't entered any FilterText (yet).

**FilterText**: System.String  
The filter text input by the user.

