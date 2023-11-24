
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading;
using static System.Net.WebRequestMethods;

class EntryPoint
{   /*Handle Special Elements*/
    static IWebDriver driver = new ChromeDriver();
    /*for the Alert box*/
    static IAlert alert;
    static void Main()
    {
        /*try catch statement for element that cant be found*/
        /* string url = "https://testing.todorvachev.com/css-path/"; 
         string cssPath = "#post-108 > div > figure > img";
         IWebElement element;
         IWebDriver driver = new ChromeDriver();
         driver.Navigate().GoToUrl(url);
         Thread.Sleep(3000);
         try 
         {
             element = driver.FindElement(By.CssSelector(cssPath));
             if (element.Displayed)
             {
                 GreenMessage("Element is display");
             }
         }
         catch (NoSuchElementException)
         {
             RedMessage("Element does not displayed");
         } */

        /*Input text inside field & Delete text from a fiels practice*/
        /*string url = "https://testing.todorvachev.com/text-input-field/";
         driver.Navigate().GoToUrl(url);
         IWebElement textBox;
         textBox = driver.FindElement(By.Name("username"));
         textBox.SendKeys("Text test");
         Thread.Sleep(3000);
         /*Past the text inside the text field inside the console*/
        /*Console.WriteLine(textBox.GetAttribute("value"));
        Thread.Sleep(3000);*?
        /*Past the maxLength of the text field in the console*/
        /*Console.WriteLine(textBox.GetAttribute("maxlength"));
        Thread.Sleep(3000);
        textBox.Clear();
        Thread.Sleep(3000);*/

        /*CheckBox button*/
        /* string url = "https://testing.todorvachev.com/check-button-test-3/";
         IWebElement checkBox;
         driver.Navigate().GoToUrl(url);
         string option = "1";
         checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child("+option+")"));
         */
        /*cheking if the checkbox is checked or not*/
        /* if ( checkBox.GetAttribute("checked") == "true")
         {
             Console.WriteLine("The checkbox is checked !");
         }
         else
         {
             Console.WriteLine("The checkbox is NOT  checked !");
         } */
        /*Past the checkbox value inside the console*/
        /*  Console.WriteLine(checkBox.GetAttribute("value"));
         option = "3";
         checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(" + option + ")"));
         Console.WriteLine(checkBox.GetAttribute("value"));*/
        /*Click the checkbox elenment inside the page*/
        /*Thread.Sleep(3000);
        checkBox.Click();
        Thread.Sleep(3000);*/

        /*Radio Button*/
        /*  string url = "https://testing.todorvachev.com/radio-button-test/";
          driver.Navigate().GoToUrl(url);
          IWebElement radioButton;
          string option = "3";
          string[] options = { "1", "3", "5" };
          for(int i=0;i<options.Length;i++)
          {
             radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(" + options[i] + ")"));
              if (radioButton.GetAttribute("checked") == "true")
              { Console.WriteLine("The "+radioButton.GetAttribute("value")+" button is chacked!"); }
              else
              { Console.WriteLine("The "+radioButton.GetAttribute("value")+" button unchacked!"); }
          }*/

        /*Drop Down Menu*/
        /* string url = "https://testing.todorvachev.com/drop-down-menu-test/";
         driver.Navigate().GoToUrl(url);
         IWebElement dropDownMenue = driver.FindElement(By.Name("DropDownTest"));
         IWebElement elementFromTheDropDwonMenue = driver.FindElement(By.CssSelector("#post-6 > div > p:nth-child(6) > select > option:nth-child(3)"));

         for(int i =1;i<=4;i++)
         {
             elementFromTheDropDwonMenue = driver.FindElement(By.CssSelector("#post-6 > div > p:nth-child(6) > select > option:nth-child("+i+")"));
             elementFromTheDropDwonMenue.Click();
             Console.WriteLine("The selected value is : " + dropDownMenue.GetAttribute("value"));
         }*/

        /*Alert box*/
        /* string url = "https://testing.todorvachev.com/alert-box/";
         IWebElement image;
         driver.Navigate().GoToUrl(url);
         alert = driver.SwitchTo().Alert();
         Thread.Sleep(3000);
         Console.WriteLine(alert.Text);
         alert.Accept();
         Thread.Sleep(3000);
         image= driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));
         try 
         {  
             if(image.Displayed)
             {
                 Console.WriteLine("The alert was successfully accepted and i can see the image !");
             }
         }
         catch(NoSuchElementException)
         {
             Console.WriteLine("something went wrong");
         }*/


        string url = "http://google.com";
        string screeshotdirectory = Directory.GetCurrentDirectory();/*The path of the corrent directory*/
        driver.Navigate().GoToUrl(url);
        /*The line below will paste on the console the location of the current directory*/
        System.Console.WriteLine(Directory.GetCurrentDirectory());
       Screenshot googleScreenshot = ((ITakesScreenshot)driver).GetScreenshot();
        /*Create directory in the current project location + give it a name "screenshot" */
        if(Directory.Exists(screeshotdirectory))/*If the directory existe dont create anotherone , if it dont then yes*/
        {   /*Creating new directory*/
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\screenshot");
        }
       
         googleScreenshot.SaveAsFile(Directory.GetCurrentDirectory()+ @"\screenshot\googlescreenshot.png", ScreenshotImageFormat.Png);




        driver.Quit();
    }
    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

