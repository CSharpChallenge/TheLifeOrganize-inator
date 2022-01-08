# TheLifeOrganize-inator App
This application aggregates your agenda, to-do lists, basic personal finances, password manager, with a future companion mobile app to give it all in your hand.

With high modularity in mind, this project is conceptualized to be tackled by anyone, no matter how little or big your contribution may be, there's certainly something you can do to make this app the best it can be.

Inside the project, there will be a special file, where you can leave your name and what you did to help this program to grow.


## Roadmap for API

### Agenda API
* Add/Remove Events in a specific range of time, for the whole day or even the whole week or month.
* Add endpoints for external consultation (per year, month or day)
* At some point in the future, develop a syntax to quickly add an event from the landing page agenda overview of the main site/mobile app.
* Ability to integrate with other services (Google Calendar/Microsoft Outlook My Day function).
* Integrate some sort of 'export/import' feature.
* Implement endpoints to feed the main site/mobile app.

### To-do List API
* Add endpoints to Add/Remove tasks.
* Add endpoint to retrieve existing tasks.
* Implement the ability to create multiple to-do lists ( i.e. for different projects).
* Create the possibility to add a task or whole list to the agenda.
* Implement endpoints to feed the main site/mobile app.


### Basic Personal Finances API
* Implement balance. 
* Add/Remove income and expenses.
* Add/Remove recurring income (salary) or expenses (rent, water, electricity, internet, mobile phone bills).
* Implement endpoints to feed the main site/mobile app. (maybe graphs?).
* Ability to export to a .xlsx file.
* Basic balance calculations based on income, expenses and recurring bills.

### Password Manager API
* Endpoints to add/remove passwords with origin site/service + password.
* Securely store passwords.
* Ability to set an alert to change the password for a given site/service after a user-defined time.
* Maybe a password generator.



## Roadmap for Site

### Landing page
* Application overview with a short description of each main feature.
* Registration/Login links.
* GitHub link for the project repository and/or Issues page.
* Link for a "Credits" page, where all the people that contributed in some way to the project can be seen.

### User Area
* 'Overview' area, with a very simplified and basic version of each functionality.
* Each functionality contains a link to it's proper page.
* Account management links.

### Agenda Page
* Calendar visualization, where the user can go back and forth between year, month or day scopes.
* 'Event'creation button, where a 'Event builder' dialog appears.
* Ability to color-code existing events with user-defined and/or pre-selected colors.

### To-do List Page
* Create/Delete lists button wich opens up a 'To-do builder' dialog.
* Visualize existing lists.
* Add/Remove tasks to a specific list.

### Personal Finances Page
* View current balance.
* Add/remove income.
* Add/remove expense.
* Add/remove recurring income or expense.
* Export to .xlsx file button.

### Password Manager Page
* Add/Remove password.
* Ability to copy password to clipboard.
* Add/remove change password alarm, wich opens a dialog where the user puts a future time to be remembered to change a specific password. This may be a recurrent alarm. (every month, for exemple).


## Companion Mobile App

This will be added to the roadmap once the API and site are both in a 'usable' state.



This project is bigger than what Tim Corey recommended, but its modularity and variety of topics and functionality make it perfect for a lot of small contributions made by a lot of people. It is designed with that in mind. The project structure will reflect that modularity idea.

Feel free to leave suggestions and to make pull requests, if you think there's something you can contribute to this, no matter how big or small, that contribution won't go unnoticed. There will be a special file, in the root of the project for you to leave your name and what you made inside this project.

I'm sure that together we will build an amazing App!
