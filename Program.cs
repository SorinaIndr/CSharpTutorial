using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
	class Program
	{
		static void Main(string[] args)
		{

		}

		[Test]
		public void FirstTest()
		{
			IWebDriver Driver = new ChromeDriver();
			Driver.Navigate().GoToUrl("https://www.codegrepper.com/code-examples/delphi/how+to+set+git+username+and+password+in+git+bash");

		}
	}
}
