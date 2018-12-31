using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using BrowserLib;

namespace EOBrowser_ML
{
	public partial class FormBrowser : Form, BrowserLib.IBrowser
	{
		public FormBrowser()
		{
			InitializeComponent();
			InitializeChromium();
		}

		public ChromiumWebBrowser cefBrowser;
		private string cefPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"EOBrowser-ML\cef");

		private void InitializeChromium()
		{
			CefSettings settings = new CefSettings();
			settings.CachePath = Path.Combine(cefPath, @"cache");
			settings.UserDataPath = Path.Combine(cefPath, @"userdata");
			settings.ResourcesDirPath = Path.Combine(cefPath, @"bin");
			settings.LocalesDirPath = Path.Combine(cefPath, @"bin\locales");
			settings.BrowserSubprocessPath = Path.Combine(cefPath, @"bin\CefSharp.BrowserSubprocess.exe");
			settings.LogSeverity = LogSeverity.Disable;
			Cef.Initialize(settings);
			cefBrowser = new ChromiumWebBrowser("https://github.com/cefsharp/CefSharp");
			Controls.Add(cefBrowser);
			cefBrowser.Dock = DockStyle.Fill;
		}

		public void ConfigurationChanged(BrowserConfiguration conf)
		{
			throw new NotImplementedException();
		}

		public void InitialAPIReceived()
		{
			throw new NotImplementedException();
		}

		public Task SaveScreenShot()
		{
			throw new NotImplementedException();
		}

		public void RefreshBrowser()
		{
			throw new NotImplementedException();
		}

		public void ApplyZoom()
		{
			throw new NotImplementedException();
		}

		public void Navigate(string url)
		{
			throw new NotImplementedException();
		}

		public void SetProxy(string proxy)
		{
			throw new NotImplementedException();
		}

		public void ApplyStyleSheet()
		{
			throw new NotImplementedException();
		}

		public void DestroyDMMreloadDialog()
		{
			throw new NotImplementedException();
		}

		public void CloseBrowser()
		{
			throw new NotImplementedException();
		}

		public void SetIconResource(byte[] canvas)
		{
			throw new NotImplementedException();
		}
	}
}
