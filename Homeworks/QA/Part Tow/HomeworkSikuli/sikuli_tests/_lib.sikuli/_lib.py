from sikuli import *
import HTMLTestRunner
bdLibPath = os.path.abspath(sys.argv[0] + "..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _uimap import *
from sikuli import *

def RunBrowserToUrl(browser,toUrl):
    #TestAction("Start " +browser +" "+toUrl)
    sleep(0.5)
    type("d",KEY_WIN); sleep(1)
    type("r", KEY_WIN); sleep(1)
    type(browser+" "); sleep(1)
    type(toUrl); sleep(1)
    type(Key.ENTER)

def Calculate(expression):
    wait(TAP.label_calculator,5)
    click(TAP.label_calculator)
    type(expression)
    wait(2)
    click(TAP.label_calculator)
    type("c",KEY_CTRL)
    wait(2)
    return Env.getClipboard().strip()