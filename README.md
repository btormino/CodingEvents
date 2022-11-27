# CodingEvents

Section 1:
  The purpose of this app is to help users post and search coding events in their area/field/interest.  
  It will allow for users to populate a database with information about the events. Users can currently see all 
  events available, add events, add tags, and see more detail of each event.
  
  Section 2: 
    Currently the app is giving an error in TagController, line 73 when running the app and clicking the "Add Tag" button. 
    It's also not running the edit feature properly. Otherwise, the app runs as predicted. A user can navigate to all pages,
    can add eventCategories and events.  They are able to click on individual events to see the details. They are also able to 
    add categories and events and delete events.
    
 Section 3:
    For future improvements, first and foremost, I want to get the "add tag" function to work. I also want to get the edit
    function to work. I think it could also use a Person class in order to allow us to keep track of who is adding the events.
    For the Person class you might need: Id#, userName, UserEmail, and userPassword.  You may need methods to add a new user, 
    edit user information, add user information to each post for the backend. It would likely need to work with the Events Class to 
    be able to add data and contain the information for who added or edited it. Person would likely have a one to many relationship to events
    because it will only need to join the Id# to the Event for the "creator'.
