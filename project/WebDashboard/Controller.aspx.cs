using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using ThoughtWorks.CruiseControl.WebDashboard.Dashboard;

namespace ThoughtWorks.CruiseControl.WebDashboard
{
	public class Controller : Page
	{
		protected HtmlGenericControl ParentControl;

		private void Page_Load(object sender, EventArgs e)
		{
			DashboardComponentFactory dcFactory = new DashboardComponentFactory(Request, Context, this);
			dcFactory.RequestController.Do(ParentControl,dcFactory.AggregatedRequest);
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			InitializeComponent();
			base.OnInit(e);
		}
		
		private void InitializeComponent()
		{    
			this.Load += new EventHandler(this.Page_Load);
		}
		#endregion
	}
}
