using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using ThoughtWorks.CruiseControl.WebDashboard.MVC.Cruise;

namespace ThoughtWorks.CruiseControl.WebDashboard.MVC.View
{
	public class DefaultHtmlBuilder : IHtmlBuilder
	{
		public HtmlTable CreateTable(params HtmlTableRow[] rows)
		{
			HtmlTable table = new HtmlTable();
			foreach (HtmlTableRow row in rows)
			{
				table.Rows.Add(row);
			}
			return table;
		}

		public HtmlTableRow CreateRow(params HtmlTableCell[] cells)
		{
			HtmlTableRow row = new HtmlTableRow();
			foreach (HtmlTableCell cell in cells)
			{
				row.Cells.Add(cell);
			}
			return row;
		}

		public HtmlTableCell CreateCell()
		{
			return new HtmlTableCell();
		}

		public HtmlTableCell CreateCell(string content)
		{
			HtmlTableCell cell = new HtmlTableCell();
			cell.InnerHtml = content;
			return cell;
		}

		public HtmlTableCell CreateCell(Control control)
		{
			HtmlTableCell cell = new HtmlTableCell();
			cell.Controls.Add(control);
			return cell;
		}

		public HtmlTableCell CreateCell(string content, int colspan)
		{
			HtmlTableCell cell = CreateCell(content);
			cell.ColSpan = colspan;
			return cell;
		}

		public HtmlTableCell CreateCell(Control control, int colspan)
		{
			HtmlTableCell cell = CreateCell(control);
			cell.ColSpan = colspan;
			return cell;
		}

		public TextBox CreateTextBox(string id, string text)
		{
			return CreateTextBox(id, text, TextBoxMode.SingleLine);
		}

		public TextBox CreateMultiLineTextBox(string id, string text)
		{
			return CreateTextBox(id, text, TextBoxMode.MultiLine);
		}

		public HtmlAnchor CreateAnchor(string text, string url)
		{
			HtmlAnchor anchor = new HtmlAnchor();
			anchor.HRef = url;
			anchor.InnerHtml = text;
			return anchor;
		}

		public HtmlAnchor CreateAnchor(string text, string url, string cssclass)
		{
			HtmlAnchor anchor = CreateAnchor(text, url);
			anchor.Attributes["class"] = cssclass;
			return anchor;
		}

		private TextBox CreateTextBox(string id, string text, TextBoxMode mode)
		{
			TextBox textBox = new TextBox();
			textBox.ID = id;
			textBox.Text = text;
			textBox.TextMode = mode;
			return textBox;
		}

		public CheckBox CreateBooleanCheckBox(string id, bool isChecked)
		{
			CheckBox checkBox = new CheckBox();
			checkBox.ID = id;
			checkBox.Checked = isChecked;
			return checkBox;
		}

		public Button CreateButton(string id, string text)
		{
			Button button = new Button();
			button.ID = CruiseActionFactory.ACTION_PARAMETER_PREFIX + id;
			button.Text = text;
			return button;
		}

		public DropDownList CreateDropDownList(string id, string[] entries, string selectedEntry)
		{
			DropDownList dropDownList = new DropDownList();
			dropDownList.ID = id;
			foreach (string entry in entries)
			{
				ListItem listItem = new ListItem(entry);
				listItem.Selected = (entry == selectedEntry);
				dropDownList.Items.Add(listItem);
			}
			return dropDownList;
		}
	}
}
