# Homework
## Incident Management

1.We have a painting program like Paint.NET and we have the following bugs
*	Set Priority and Severity

| Bug description        | Severity           | Priority  |
| ------------- |:-------------:| -----:|
|Tool for selection doesn’t select exactly the same that it’s marking (crops 10 pixels to the left)      |Critical  |Immediate  |
| When selecting a color with the color picker it replaces the first color from the palette, not the chosen one     | Critical   |Immediate  |
| Shortcut for “Create New Image” (Ctrl+N) doesn’t work | Medium  |On Occasion   |
| Spelling mistake in menu Select “Transperent selection” instead of “Transparent selection”| Low  | Immediate  |
| While holding Ctrl+Z and drawing with the pencil the second color is used instead of the first one, and that’s not a feature| Low  | Open  |
| When using “Magic Wand” tool the tolerance value is changing on every mouse click| Medium  | Next Release  |
| While clicking “Rotate 90 Clockwise” the image is rotating in counterclockwise direction| Medium  |Next Release   |
| The button for increasing the Brush size doesn’t work. It can be increased only from the drop down | Medium | On Occasion |
| Program crash on clicking the OK button while resizing an image.| Blocking  |   Immediate

2.Imagine you have the following bug, mentioned by a customer and you have to describe it and log it in the bug tracking tool you use
*	Report the following bugs

|BUG REPORT |   #1   |
| ------------------------------------------------------------- |:-------------:| 
|Description  |When there’s a page break in the page and you try to set dashed border on the page, the bottom border line doesn’t show|
|Steps to reproduce  |1. Open application|
			|2. Create new document|
			|3. Enter some text on the first page |
			|4. Insert a page break|
			|5. Set a dashed border on the page|
||			
|Actual behavior: |The bottom dashed border line doesn’t show|
|Expected behavior: |The bottom dashed border line to be visible |
|Acceptance criteria  |All borders should be visible|
|Priority |Next Release|
|Severity  |Low|

|BUG REPORT |   #2   |
| ------------- |:-------------:| 
|Description  |Application crash on clicking the Save button while creating a new user, hence unable to create a new user in the application.|
|Steps to reproduce  |1. Open application|
					 |2. Click on 'New user' button|
					 |3. Enter valid user data in required fields|
					 |4. Click on 'Save' button|
|||
 |Actual behavior:|Application craches and it is not known if new user is created in data base|
 |Expected behavior:|Create new user , and display a confirmation message "User "Usermane" was createt succefully"|
|Acceptance criteria  |A new user to be created and saved to data base |
|Priority |Blocking|
|Severity  |Immediate|

* Prepare another bug report
	* for the bug shown in this [video] (http://www.youtube.com/watch?v=xJg7k8QOGtM&feature=related)
	* for this sample defect: After logging into Gmail, it navigates to Google.com
	
BUG REPORT |  #3 Exel 2010 - Latin Letters are changed to Creek|
| ------------- |:-------------:| 
|Description  | Coping an unodered list from Word 2010 and pasing to Exel 2010 sheet. Bullets are also pasted. Using "Fing and Repalace" to replace bullets with empty string - text is displayed in Greek|
|Steps to reproduce  |1. Open new Word 2010  document|
					 |2. Create an unorder list and enter some text with Lattin letters, font is Calibri(body)|
					 |3. Select whole list (bulets are not selected)|
					 |4. Copy selection|
					 |5. Open new Exel 2010 sheet|
					 |6. Paste list in empty sheet|
					 |7. The list is shown with bullets and spaces before text, font is changed to Symbol|
					 |8. Entre in first cell with text and select bullet and spaces|
					 |9. Copy selected items|
					 |9. Click "Ctrl" and "H" to open "Find and Replace" dialog box|
					 |10. Paste in "Find what" input field the coppied items (bullet and spaces)
					 |11. Leave "Releace with" empty
					 |12. Press "Replace All" button
|||					 
					 |Actual behavior:|The text in cells is displayed in Greek letters|
					 |Expected behavour:|The bullet and spaces do disappear and text font to reamin in Lattin letters.|
|||
					 |Remark:|Same bug can be reproduced with Word 2007, 2016 and Exel 2007, 2016 :)|
|Acceptance criteria  |When replacing the bullet and the empty space with an empty character, the font should not be changed |
|Priority |Open|
|Severity  |Low|

BUG REPORT |   #4  After logging into Gmail, it navigates to Google.com |
| ------------- |:-------------:| 
|Description  |Application crash on clicking the Save button while creating a new user, hence unable to create a new user in the application.|
|Steps to reproduce  |1. Open browser|
					 |2. Go to www.gmail.com page|
					 |3. Enter your credential |
					 |4. Click on 'Sihnin' button|
|||				
					 | Actual behavior:|  www.google.com is opened|
					 |Expected behavior:| The Gmail Inbox page to be opened |
|Acceptance criteria  |The user to have access to his/her Gmail inbox |
|Priority |Blocking|
|Severity  |Immediate|	
	

