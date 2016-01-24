import unittest
import os

bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

    
class SmokeTests(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    

    def test_001_SearchForTelerikInGoogle(self):
       RunBrowserToUrl("chrome","https://www.google.com")
       wait(TAP.Google,10)
       type(TAP.Google,"Telerik academy" )
       type(Key.ENTER)
       assert (TAP.Telerik,10)
       type("r", KEY_WIN); sleep(1)
       type("taskkill /F /IM chrome.exe /T"); sleep(1)
       type(Key.ENTER)

    def test_002_DragAndDrop(self):
        RunBrowserToUrl("chrome","http://www.dhtmlgoodies.com/scripts/drag-drop-custom/demo-drag-drop-3.html")
        wait(TAP.Copenhagen,5)
        dragDrop(TAP.Copenhagen,TAP.Denmark)
        wait(TAP.Rome,5)
        dragDrop(TAP.Rome,TAP.Italy)
        wait(TAP.Oslo,5)
        dragDrop(TAP.Oslo,TAP.Norway)
        wait(TAP.Madrid,5)
        dragDrop(TAP.Madrid,TAP.Spain)
        dragDrop(TAP.Stockholm,TAP.Sweden)
        wait(TAP.Seul,5)
        dragDrop(TAP.Seul,TAP.South_Korea)
        wait(TAP.Washington,5)
        dragDrop(TAP.Washington,TAP.Usa)
        wait(TAP.lable_result,5)
        assert(TAP.lable_result)

    def test_003_MinimizedAllActiveWindows(self):
        path = "c:\Program Files (x86)\Mozilla Firefox\Firefox.exe"
        myBrowser = App(path)
        for i in range(3):
            myBrowser.open()
            wait(2)
        type("m", KEY_WIN)
        wait(5)
        for i in range(3):
             myBrowser.close()
        wait(1)


    def test_004_Skype(self):

        type('m', KEY_WIN)
        wait(TAP.icon_skype,2)
        doubleClick(TAP.icon_skype)
        wait(5)
        wait(TAP.label_friend,1)
        click(TAP.label_friend)
        wait(TAP.lable_skype,3)
        click(TAP.lable_skype)
        type("Hello from Sikuli")
        type(Key.ENTER)
        wait(5)

    def test_005_Calculator(self):
        type(Key.WIN); sleep(1)
        type("calculator")
        wait (2)
        type(Key.ENTER)

        result = Calculate("7+5=")
        assert (result=="12")

        result = Calculate("7-5=")
        assert (result=="2")

        result = Calculate("7*5=")
        assert (result=="35")

        result = Calculate("15/5=")
        assert (result=="3")

        result = Calculate("7/0=")
        assert (result=="Cannot divide by zero")



    def test_006_Contecr_Menu(self ):
        RunBrowserToUrl("chrome","https://www.google.bg")
        wait(1)
        wait(TAP.Google,3)
        type(TAP.Google,"telerik academy" )
        type(Key.ENTER)
        wait(TAP.label_image,3)
        click(TAP.label_image)
        wait(TAP.label_logo,5)
        rightClick(TAP.label_logo)
        wait(1)
        click(TAP.label_link)
        type("l", KEY_CTRL)
        type("v", KEY_CTRL)
        type(Key.ENTER)

if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(SmokeTests)

    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='SmokeTests Report' )
    runner.run(suite)
    outfile.close()


