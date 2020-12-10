# AmbuMate - Technical Documentation

## About
AmbuMate is an Ambulance Crew Companion App. Essentially a mobile application designed to be used on a    
smartphone by an Ambulance Crew Member throughout their shift to assist the crew and ambulance service with   
data entry and storage. The mobile application will be accompanied by a web application that allows the   
Ambulance Service's Operations staff to view and manage the data entered by crews.   

## Instructions for use - Basic Shift Outline
1. Log in using your Staff ID and password.  
2. On the HomePage press the respective Shift button to navigate to the Shift Page.  
3. Create a new Shift by entering your shift starting details and press the save button.  
4. Return to the HomePage then press the Vehicle button to navigate to the Vehicle Page.  
5. When checking your Ambulance/Vehicle fill in the Vehicle Form.   
   Enter values and toggle switches on for present/functioning or leave off for missing/broken.  
6. Return to the HomePage then press the Kit button to navigate to the Kit Page.    
7. When checking your Kit fill in the kit form.    
   Enter values and toggle switches on for present/functioning or leave off for missing/broken.   
8. Return to the HomePage then press the Patients button to navigate to the Patients Page.    
9. The patient's page contains 3 Tabs: Inactive, Active, Complete.  
   Inactive: Shows a list of patients entered by the crew or operations that are currently inactive.  
   Active: Shows a list of active patients currently being processed by the crew.  
   Completed: Shows a list of patients previously completed durign this shift.  
10. On the top right hand corner of the patients screen you can find the Add Patient button.  
   Press this to navigate to the Add Patient Page.  
11. Enter the patient you want to add's details and press the save button to add them to the shift.  
12. From the Inactive Page you can select a patient and view/update their details,   
   from this view you can also choose to make this patient an active patient.  
13. From the Active Page you can view an Active patient's details and also input the   
   Arrival and Departure times for this patient along with adding any notes you have for this patient.  
14. Once you have added your Arrivals, Departures and notes then you can press the complete patient button.  
15. Once a ptient is completed they will be moved from Active to Complete.  
16. You can now choose to activate an inactive patient or add a new one until you have completed all of    
   your patients for this shift.   
17. Upon completion of your patients and returing to base, you can input the kit used during this shift on   
   the Kit Page and input final mileage and Vehicle Notes on the Vehicle Page.  
18. When your Patients, Kit and Vehicle Pages are complete, you can enter your shift end time and any  
   final notes you have for your shift in the Shift Page and press the complete Shift Button.  

## Instructions for use - Extra Features
* The options button can be found at the top right of the HomePage.  
* You can log out of the application by pressing the log out button in the Options Page.  
* You can cancel your current shift by pressing the cancel shift button in the Options Page.  
* You can manually sync the app with the database by pressing the sync button in the Options Page.  
* You can cancel a patient by pressing the cancel patient button when viewing an Active or Inactive patient's details.  

## Software Used - Mobile Application
I have been developing the Mobile Application in Visual Studio 2019 using Xamarin Forms.  
The AmbuMate project is a Cross-Platform Mobile Application coded in C# and XAML.  
C# for functionality and XAML for layout.  

   