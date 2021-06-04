MainPage.xaml  
5:		Method that gets called if the page appears on screen  
7-9:	Define your ViewModel/BindingContext  
11-15:	Your resources (in this case a demo Converter)  
19-31:	The main content of this page. (Alist of items) => inside you see the use of a converter to prevent you from create unnessecary properties  
33-39:	A overlay shown when the viewmodel says its busy (while loading data)  
  
MainPage.xaml.cs  
14-17:	We "fire and forget" a loading task on our viewmodel (prevent async void methods since it can swallow exceptions and if not may present unuseable stacktraces)  
  
BaseViewModel.cs  
8-21:	A Flag where each viewmodel can indicate that its doing work  
24-28:	INotifyPropertyChanged implementation that is used by us (raiser) and all bindings (subsciber) to keep the properties up to date  
  
MainPageViewModel.cs  
12:		Our List of items  
20-40:	Our Full Data loading consisting of 2 major steps  
			-Loading the data (23)  
			-Updading our properties(29-38) (we want to do this on our ui thread hence the "Device.BeginInvokeOnMainThread")  
			  
StringLongerThenToVisibleConverter.cs  
- A simple converter. that returns true if the bound string is longer than the parameter provided  
  
ApiClient:  
- just a dummy for an api that returns items asynchronusly  
