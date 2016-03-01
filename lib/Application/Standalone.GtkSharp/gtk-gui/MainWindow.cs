
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action FileAction;
	
	private global::Gtk.Action ConnectionAction;
	
	private global::Gtk.Action HelpAction;
	
	private global::Gtk.Action openAction;
	
	private global::Gtk.Action saveAction;
	
	private global::Gtk.Action ExportAction;
	
	private global::Gtk.Action ExitAction;
	
	private global::Gtk.Action AboutAction;
	
	private global::Gtk.Table table2;
	
	private global::Gtk.HPaned hpaned1;
	
	private global::Gtk.Table table3;
	
	private global::Gtk.Notebook notebookParameters;
	
	private global::Gtk.ScrolledWindow scrolledPreset;
	
	private global::Gtk.Label lblNotebookSearch;
	
	private global::Gtk.Label lblNotebookStandard;
	
	private global::Gtk.Label lblNotebookAdvanced;
	
	private global::Gtk.Label lblNotebookOutput;
	
	private global::Gtk.Table table4;
	
	private global::Gtk.Button btnRefine;
	
	private global::Gtk.Button btnReset;
	
	private global::Gtk.Button btnSearch;
	
	private global::Gtk.ComboBox cboSearchFor;
	
	private global::Gtk.Notebook notebookResults;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.NodeView nodeviewResults;
	
	private global::Gtk.Label lblNotebookResults;
	
	private global::Gtk.Label lblNotebookSql;
	
	private global::Gtk.MenuBar menuMain;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("_File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_File");
		w1.Add (this.FileAction, null);
		this.ConnectionAction = new global::Gtk.Action ("ConnectionAction", global::Mono.Unix.Catalog.GetString ("_Connection"), null, null);
		this.ConnectionAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Connection");
		w1.Add (this.ConnectionAction, null);
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("_Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Help");
		w1.Add (this.HelpAction, null);
		this.openAction = new global::Gtk.Action ("openAction", global::Mono.Unix.Catalog.GetString ("_Open..."), null, "gtk-open");
		this.openAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Open...");
		w1.Add (this.openAction, null);
		this.saveAction = new global::Gtk.Action ("saveAction", global::Mono.Unix.Catalog.GetString ("_Save As..."), null, "gtk-save");
		this.saveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Save As...");
		w1.Add (this.saveAction, null);
		this.ExportAction = new global::Gtk.Action ("ExportAction", global::Mono.Unix.Catalog.GetString ("_Export..."), null, null);
		this.ExportAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Export...");
		w1.Add (this.ExportAction, null);
		this.ExitAction = new global::Gtk.Action ("ExitAction", global::Mono.Unix.Catalog.GetString ("E_xit"), null, null);
		this.ExitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("E_xit");
		w1.Add (this.ExitAction, null);
		this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("_About..."), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_About...");
		w1.Add (this.AboutAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Database Query Framework");
		this.Icon = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, ".\\dbqf-logo.png"));
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.table2 = new global::Gtk.Table (((uint)(2)), ((uint)(1)), false);
		this.table2.Name = "table2";
		// Container child table2.Gtk.Table+TableChild
		this.hpaned1 = new global::Gtk.HPaned ();
		this.hpaned1.CanFocus = true;
		this.hpaned1.Name = "hpaned1";
		this.hpaned1.Position = 273;
		this.hpaned1.BorderWidth = ((uint)(6));
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.table3 = new global::Gtk.Table (((uint)(2)), ((uint)(1)), false);
		this.table3.Name = "table3";
		// Container child table3.Gtk.Table+TableChild
		this.notebookParameters = new global::Gtk.Notebook ();
		this.notebookParameters.CanFocus = true;
		this.notebookParameters.Name = "notebookParameters";
		this.notebookParameters.CurrentPage = 0;
		// Container child notebookParameters.Gtk.Notebook+NotebookChild
		this.scrolledPreset = new global::Gtk.ScrolledWindow ();
		this.scrolledPreset.CanFocus = true;
		this.scrolledPreset.Name = "scrolledPreset";
		this.scrolledPreset.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
		this.notebookParameters.Add (this.scrolledPreset);
		// Notebook tab
		this.lblNotebookSearch = new global::Gtk.Label ();
		this.lblNotebookSearch.Name = "lblNotebookSearch";
		this.lblNotebookSearch.LabelProp = global::Mono.Unix.Catalog.GetString ("Preset");
		this.notebookParameters.SetTabLabel (this.scrolledPreset, this.lblNotebookSearch);
		this.lblNotebookSearch.ShowAll ();
		// Notebook tab
		global::Gtk.Label w3 = new global::Gtk.Label ();
		w3.Visible = true;
		this.notebookParameters.Add (w3);
		this.lblNotebookStandard = new global::Gtk.Label ();
		this.lblNotebookStandard.Name = "lblNotebookStandard";
		this.lblNotebookStandard.LabelProp = global::Mono.Unix.Catalog.GetString ("Standard");
		this.notebookParameters.SetTabLabel (w3, this.lblNotebookStandard);
		this.lblNotebookStandard.ShowAll ();
		// Notebook tab
		global::Gtk.Label w4 = new global::Gtk.Label ();
		w4.Visible = true;
		this.notebookParameters.Add (w4);
		this.lblNotebookAdvanced = new global::Gtk.Label ();
		this.lblNotebookAdvanced.Name = "lblNotebookAdvanced";
		this.lblNotebookAdvanced.LabelProp = global::Mono.Unix.Catalog.GetString ("Advanced");
		this.notebookParameters.SetTabLabel (w4, this.lblNotebookAdvanced);
		this.lblNotebookAdvanced.ShowAll ();
		// Notebook tab
		global::Gtk.Label w5 = new global::Gtk.Label ();
		w5.Visible = true;
		this.notebookParameters.Add (w5);
		this.lblNotebookOutput = new global::Gtk.Label ();
		this.lblNotebookOutput.Name = "lblNotebookOutput";
		this.lblNotebookOutput.LabelProp = global::Mono.Unix.Catalog.GetString ("Output");
		this.notebookParameters.SetTabLabel (w5, this.lblNotebookOutput);
		this.lblNotebookOutput.ShowAll ();
		this.table3.Add (this.notebookParameters);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table3 [this.notebookParameters]));
		w6.TopAttach = ((uint)(1));
		w6.BottomAttach = ((uint)(2));
		w6.YPadding = ((uint)(3));
		w6.XOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table3.Gtk.Table+TableChild
		this.table4 = new global::Gtk.Table (((uint)(1)), ((uint)(4)), false);
		this.table4.Name = "table4";
		this.table4.RowSpacing = ((uint)(3));
		this.table4.ColumnSpacing = ((uint)(3));
		// Container child table4.Gtk.Table+TableChild
		this.btnRefine = new global::Gtk.Button ();
		this.btnRefine.CanFocus = true;
		this.btnRefine.Name = "btnRefine";
		this.btnRefine.UseUnderline = true;
		this.btnRefine.Label = global::Mono.Unix.Catalog.GetString ("Refine");
		this.table4.Add (this.btnRefine);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table4 [this.btnRefine]));
		w7.LeftAttach = ((uint)(3));
		w7.RightAttach = ((uint)(4));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.btnReset = new global::Gtk.Button ();
		this.btnReset.CanFocus = true;
		this.btnReset.Name = "btnReset";
		this.btnReset.UseUnderline = true;
		this.btnReset.Label = global::Mono.Unix.Catalog.GetString ("Reset");
		this.table4.Add (this.btnReset);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table4 [this.btnReset]));
		w8.LeftAttach = ((uint)(2));
		w8.RightAttach = ((uint)(3));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.btnSearch = new global::Gtk.Button ();
		this.btnSearch.CanFocus = true;
		this.btnSearch.Name = "btnSearch";
		this.btnSearch.UseUnderline = true;
		this.btnSearch.Label = global::Mono.Unix.Catalog.GetString ("Search");
		this.table4.Add (this.btnSearch);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table4 [this.btnSearch]));
		w9.LeftAttach = ((uint)(1));
		w9.RightAttach = ((uint)(2));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table4.Gtk.Table+TableChild
		this.cboSearchFor = global::Gtk.ComboBox.NewText ();
		this.cboSearchFor.Name = "cboSearchFor";
		this.table4.Add (this.cboSearchFor);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table4 [this.cboSearchFor]));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		this.table3.Add (this.table4);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table3 [this.table4]));
		w11.XOptions = ((global::Gtk.AttachOptions)(7));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		this.hpaned1.Add (this.table3);
		global::Gtk.Paned.PanedChild w12 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.table3]));
		w12.Resize = false;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.notebookResults = new global::Gtk.Notebook ();
		this.notebookResults.CanFocus = true;
		this.notebookResults.Name = "notebookResults";
		this.notebookResults.CurrentPage = 0;
		// Container child notebookResults.Gtk.Notebook+NotebookChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.nodeviewResults = new global::Gtk.NodeView ();
		this.nodeviewResults.CanFocus = true;
		this.nodeviewResults.Name = "nodeviewResults";
		this.nodeviewResults.EnableSearch = false;
		this.GtkScrolledWindow.Add (this.nodeviewResults);
		this.notebookResults.Add (this.GtkScrolledWindow);
		// Notebook tab
		this.lblNotebookResults = new global::Gtk.Label ();
		this.lblNotebookResults.Name = "lblNotebookResults";
		this.lblNotebookResults.LabelProp = global::Mono.Unix.Catalog.GetString ("Results");
		this.notebookResults.SetTabLabel (this.GtkScrolledWindow, this.lblNotebookResults);
		this.lblNotebookResults.ShowAll ();
		// Notebook tab
		global::Gtk.Label w15 = new global::Gtk.Label ();
		w15.Visible = true;
		this.notebookResults.Add (w15);
		this.lblNotebookSql = new global::Gtk.Label ();
		this.lblNotebookSql.Name = "lblNotebookSql";
		this.lblNotebookSql.LabelProp = global::Mono.Unix.Catalog.GetString ("SQL");
		this.notebookResults.SetTabLabel (w15, this.lblNotebookSql);
		this.lblNotebookSql.ShowAll ();
		this.hpaned1.Add (this.notebookResults);
		this.table2.Add (this.hpaned1);
		global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2 [this.hpaned1]));
		w17.TopAttach = ((uint)(1));
		w17.BottomAttach = ((uint)(2));
		// Container child table2.Gtk.Table+TableChild
		this.UIManager.AddUiFromString (@"<ui><menubar name='menuMain'><menu name='FileAction' action='FileAction'><menuitem name='openAction' action='openAction'/><menuitem name='saveAction' action='saveAction'/><menuitem name='ExportAction' action='ExportAction'/><menuitem name='ExitAction' action='ExitAction'/></menu><menu name='ConnectionAction' action='ConnectionAction'/><menu name='HelpAction' action='HelpAction'><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
		this.menuMain = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menuMain")));
		this.menuMain.Name = "menuMain";
		this.table2.Add (this.menuMain);
		global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table2 [this.menuMain]));
		w18.XOptions = ((global::Gtk.AttachOptions)(4));
		w18.YOptions = ((global::Gtk.AttachOptions)(4));
		this.Add (this.table2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 1070;
		this.DefaultHeight = 709;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
