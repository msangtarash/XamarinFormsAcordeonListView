# Xamarin Forms Acordeon
For **iOS** , **Android** and **UWP**
## Prerequisites
Syncfucion [SFListView](https://help.syncfusion.com/xamarin/sflistview/getting-started)

How does it work?

1- Create group for every item in items source. [Here](https://github.com/msangtarash/XamarinFormsAcordeonListView/blob/master/src/XamarinFormsAcordeonListView/AcordeonListView.xaml.cs#L14)

2- Use ItemTemplate as acordeon's detail template and its GroupHeaderTemplate as master item header of acordeon.

3- Use [ExapantionIndicatorConverter](https://github.com/msangtarash/XamarinFormsAcordeonListView/blob/master/src/XamarinFormsAcordeonListView/AcordeonListView.xaml.cs#L18) to manage ▲ ▼ indicators.
