# Maui Progress Bar Test App(Maui 9.0.81)
Example repository to test creating a simple progress bar in .Net Maui 

How to Test
1) Build and Run App
2) Tap Open Progress Bar Test Page on an Android device
3) Progress bar in collection view does not render like on iOS. Putting a progress bar at the page level seems to work.
4) Tapping the Update Pct button will update the percentages which triggers a property change on each item which seems to trigger a rerender however the progress bars still render incorrectly when you scroll.
