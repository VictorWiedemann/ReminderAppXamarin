# ReminderAppXamarin
Reminder App as a way to try Xamarin

timeline:
April 24, 2020
I started with using the Youtube series Xamarin from the youtube Channel dotNET that is made from Microsoft. 
Link: https://www.youtube.com/watch?v=JH8ekYJrFHs&list=PLdo4fOcmZ0oU10SXt2W58pu2L0v2dOW-1
Videos 1-4 got my environment up and running.

After getting the basics running, I noticed a note came up about getting Hyper-V started. Hyper-V is a setting that helps with vertualization on your dev machine. 
To coomplete the setup, I used the documentation on the Microsoft website to get started. https://docs.microsoft.com/en-us/virtualization/hyper-v-on-windows/about/

Getting Hyper-V set-up was much more work than I expected. Luckily I had access to a Windows 10 Education OS which has Hyper-V capability. 
The issue that could have happened is Hyper-V is not an option for Windows 10 Home. With Hyper-V setup now, I can get the phone VM running.
It looks like the phone VM is a fully functioning phone which is pretty cool. I will see how it functions compared to my Onplus 5t

Next that I wanted to get started was starting a repo through my github account. If you can read this it worked! I am trying out the built-in
functioanlity within Visual Studio. It is a bit differerent than I would have expected, but after some trial and error, I think I have it.

Took 3 hours and I think I have the whole dev environment up, I will start a real hello world and hopefully get the basics down. Starting video 5.
I plan to do this project, try my own app going in blind. After I get a basic app running, I plan to start from scratch with proper design patterns.

Doing manual editing of the xaml file. Seems counter intuitive because I know that C# has form GUI editing posibilities. 
One good note is <RowDefinition Height="*"/> where * makes it be even parts between all definitions.

Video 6:
XAML - I higher functionality version of XML with GUI keywords.
MVVM - Model, View, View Model (The design pattern I wanted to learn!)
Model = Data and backend
View = UI
View Models = "Brains" or Application logic, Automatic updating of properties, Automatic firing of commands.

