# WinForms-CKEditorControl
CKEditor Control for Windows Forms application with sample usage.

Setting Up :
-----------

After setting up a working version of CkEditor in a html page with required resources and plugins. Add the following two javascript functions in the body of the main html page.

```
function getContent(){
  return CKEDITOR.instances.editor.getData();
}

function setContent(content) {
  CKEDITOR.instances.editor.setData(content);
}
```

These functions will later be used to inject and retrieve html from the CKEditor panel.
    
    
Usage :
-------
    
```
var curDir = Directory.GetCurrentDirectory();
var ckEditorUri = new Uri($"file:///{curDir}/Resources/CkEditor/index.html");
// you can place the CkEditor resources in any other location of you choice or even use an online version.
    
var ckEditorCtrl = new CKEditorControl(ckEditorUri){
  Dock = DockStyle.Fill
};
this.Controls.Add(ckEditorCtrl);
```
    
Setting Data :
-------------

If you want to set data to the CKEditor panel on first load, you can use the DocumentCompleted event to wait for the required scripts to be executed and then call the control's SetContent function set the content.
    
```
ckEditorCtrl.DocumentCompleted += (s,e) => {
  ckEditorCtrl.SetContent("Hello World!");
};
```
    
Retrieving Data :
-----------------

After the panel has been loaded, you can call the GetContent method to retrieve the CkEditor panel's content.
```
string data = ckEditorCtrl.GetContent();
```
