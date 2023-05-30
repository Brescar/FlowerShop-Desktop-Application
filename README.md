# FlowerShop C# Desktop Application with .NET Framework
This is an application that manages a shop that sells flowers. It manages products, orders to be received that consist of products and deliveries to be sent to customers. It was made for learning purposes. Limited functionality, but still viable while not very optimal.

## List of functionalities in the order that an user might meet them : 
* Login menu at the start of the application, which connextion to a database that stores the viable credentials.
* MenuStrip and ContextMenuStrip for 3 listViews that allow add, edit and delete though a second form. Validation is made for all of them.
* Supported 'Saving as' and 'Open' as binary files and XML for all 3 listViews.
* Drag and Drop control that allows for a selected product to drag the color into a textBox, and as long as the color has a name that can be found in the .NET Framework, the color appears in the above pictureBox.
* Generating a Graph of total values for each product.
* Supporting Print Document in the Grapth menu. 
* Some shortcuts.

## Problems / small bugs :  
* When logging in, double left click is required. Why? Probably the way I implemented the method of enabling the controls after loggging in correctly, because the workaround I found was through DialogResult.
* Printing document in the Chart menu doesn't fit the graph adequatly to the page.
* Drag and Drop requires first that the product is selected, then the actual drag needs to be initiated only from the column with Color of the selected product. After dropping a kind of selection tries to take place in the listView.
* The order and delivery class are standalone, they are not connected to the Flower class (which is the entry for listViewProducts). Ideally, order and delivery should have had a list of the chosen products. 

## Notes

