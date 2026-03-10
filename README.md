
**02/13/2026**

# What Does the DocxViewer2 Do?

The DocxViewer2 is a simple windows application primarily designed to display Microsoft Word documents. The application is designed to be called by a parent program to display the word document to be examined. In addition, DocxViewer2 can be used in a standalone mode by the inclusion of a File Open menu item giving the user the ability to independently open and display a document file.

# Why Was This Utility Developed?

During genealogical research conducted over the internet, genealogical source records viewed on archive websites were saved to the local computer. Many times the source records were in different formats from text, xml, docx, pdf, png, jpg, or jpeg. During development of a utility to rename the previously saved files in a standardized manner, it required the user to view the saved document and enter data into the application’s form, data that would be saved in an xml file. Therefore, a number of different file viewers were developed to support the file rename utility, including this one.

# What files can be displayed with the viewer?

The following types can be displayed with the image viewer: \*.docx, \*.html, \*.htm, \*.xml, \*.xps, \*.jpg, \*.jpeg, and \*.bmp files.

The Microsoft Word document (\*.docx) is converted to an html file and displayed in the WebView2 control. Two ancillary packages, OpenXml and OpenXmlPowerTools, are used to convert the docx file to an html file to display in the WebView2 control.

# DocxViewer2 Utility Design

DocxViewer2 is basically a simple windows form with a menu strip, status strip, and the WebView2 control to display images or the contents of files opened. The menu strip provides a means of displaying a File menu. The status strip provides a means for displaying the file name. The WebView2 control also includes scrollbars in order to scroll the file image into view.

## DocxViewer2 Properties

The DocxViewer2 includes a public property that allows a calling program to set the file name using the get-set mechanism. When the DocxViewer2 form is loaded and the file name has been set, then the file will be opened and displayed. In addition, the calling program can close the program.

## Menu Strip

The menu strip has one menu, the File Menu.

### File Menu

The File Menu provides the option of the user to open or close a file and to Exit the viewer.

#### File Open Menu Item.

The File Open Menu Item opens the Open File Dialog allowing the user to select and open a file from the file system.

#### File Close Menu Item

The File Close Menu item closes the file and clears the file in the Web Browser control.

#### File Exit Menu Item

The File Exit Menu Item will close the Image Viewer.

### Status Strip

The Status Strip shows the file name of the file being displayed.