Sample Maui Shell app showing an issue with Page Flow

Steps to reproduce:
1. Run app on Android (or iOS)
2. Click "Go to Page 1"
3. Click "Go to Page 2"
4. Click "Go to SubMainPage"
5. Open Flyout and click "Return to MainPage"

When "Return to MainPage" is clicked, the command is executing the following `await Shell.Current.GoToAsync($"//{nameof(MainPage)}");`.  This should return the user directly to the page based on the URL, however, OnAppearing will be triggered for `Page2`, which is unwanted and not desired.
