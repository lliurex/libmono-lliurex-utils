
using System;

namespace lliurex
{

	namespace utils
	{
			
		namespace IO
		{
		
			public class CopyFiles
			{
		
				private int file_number;
				private int copied_files=0;
				private double percentage=0;
				private string file;
				
				private Gtk.Window dialog2;
		
				// DIALOG WIDGETS //		
		
		        private Gtk.VBox vbox1;
		        
		        private Gtk.Frame frame1;
		        
		        private Gtk.Alignment GtkAlignment;
		        
		        private Gtk.VBox vbox2;
		        
		        private Gtk.HBox hbox1;
		        
		        private Gtk.Label copyLabel;
		        
		        private Gtk.ProgressBar progressbar1;
		        
		        private Gtk.Label frameLabel;
				
				// *************** //
		
				private string damnwarning;
				
				public CopyFiles ()
				{
					file_number=0;
					
					Build(); // build dialog window
		
				}
				
				protected virtual void Build() {
		            dialog2= new Gtk.Window("Copying files...");
		            // Widget copy.CopyWidget
		            dialog2.Name = "copy.CopyWidget";
		            dialog2.Title = Mono.Unix.Catalog.GetString("CopyWidget");
		            dialog2.WindowPosition = ((Gtk.WindowPosition)(3));
		            // Container child copy.CopyWidget.Gtk.Container+ContainerChild
		            this.vbox1 = new Gtk.VBox();
		            this.vbox1.Name = "vbox1";
		            this.vbox1.Spacing = 6;
		            // Container child vbox1.Gtk.Box+BoxChild
		            this.frame1 = new Gtk.Frame();
		            this.frame1.Name = "frame1";
		            this.frame1.ShadowType = ((Gtk.ShadowType)(2));
		            this.frame1.LabelXalign = 1F;
		            this.frame1.BorderWidth = ((uint)(6));
		            // Container child frame1.Gtk.Container+ContainerChild
		            this.GtkAlignment = new Gtk.Alignment(0F, 0F, 1F, 1F);
		            this.GtkAlignment.Name = "GtkAlignment";
		            this.GtkAlignment.LeftPadding = ((uint)(12));
		            this.GtkAlignment.TopPadding = ((uint)(6));
		            this.GtkAlignment.RightPadding = ((uint)(10));
		            this.GtkAlignment.BottomPadding = ((uint)(10));
		            // Container child GtkAlignment.Gtk.Container+ContainerChild
		            this.vbox2 = new Gtk.VBox();
		            this.vbox2.Name = "vbox2";
		            this.vbox2.Spacing = 6;
		            // Container child vbox2.Gtk.Box+BoxChild
		            this.hbox1 = new Gtk.HBox();
		            this.hbox1.Name = "hbox1";
		            this.hbox1.Spacing = 6;
		            // Container child hbox1.Gtk.Box+BoxChild
		            this.copyLabel = new Gtk.Label();
		            this.copyLabel.Name = "copyLabel";
		            this.copyLabel.LabelProp = Mono.Unix.Catalog.GetString("label2");
		            this.hbox1.Add(this.copyLabel);
		            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.hbox1[this.copyLabel]));
		            w1.Position = 0;
		            w1.Expand = false;
		            w1.Fill = false;
		            this.vbox2.Add(this.hbox1);
		            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
		            w2.Position = 0;
		            w2.Expand = false;
		            w2.Fill = false;
		            // Container child vbox2.Gtk.Box+BoxChild
		            this.progressbar1 = new Gtk.ProgressBar();
		            this.progressbar1.Name = "progressbar1";
		            this.vbox2.Add(this.progressbar1);
		            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox2[this.progressbar1]));
		            w3.Position = 1;
		            w3.Expand = false;
		            w3.Fill = false;
		            this.GtkAlignment.Add(this.vbox2);
		            this.frame1.Add(this.GtkAlignment);
		            this.frameLabel = new Gtk.Label();
		            this.frameLabel.Name = "frameLabel";
		            this.frameLabel.Xpad = 8;
		            this.frameLabel.LabelProp = Mono.Unix.Catalog.GetString("<b>GtkFrame</b>");
		            this.frameLabel.UseMarkup = true;
		            this.frame1.LabelWidget = this.frameLabel;
		            this.vbox1.Add(this.frame1);
		            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox1[this.frame1]));
		            w6.Position = 0;
		            w6.Expand = false;
		            w6.Fill = false;
		            dialog2.Add(this.vbox1);
		            if ((dialog2.Child != null)) {
		                dialog2.Child.ShowAll();
		            }
		            dialog2.DefaultWidth = 400;
		            dialog2.DefaultHeight = 100;
		         //   dialog2.Show();
		        }
				
		
				
				private void updateProgressBar()
				{
					progressbar1.Text=System.Convert.ToString(percentage) + "%";
					progressbar1.Fraction=percentage/100;				
					copyLabel.Text=file;
					
					if (copied_files==file_number)
					{
						file_number=0;
						copied_files=0;
						percentage=0;
						dialog2.Destroy();
						Build();
						
					}
				}		
				
				private void countFiles(string path)
				{
					
					System.IO.DirectoryInfo dinfo=new System.IO.DirectoryInfo(path);
					
					System.IO.DirectoryInfo[] dlist=dinfo.GetDirectories();
					System.IO.FileInfo[] flist=dinfo.GetFiles();
					
					foreach(System.IO.DirectoryInfo info in dlist)
					{
						countFiles(info.FullName);	
					}
					foreach(System.IO.FileInfo info in flist)
					{
						damnwarning=info.FullName;
						file_number++;	
					}
					
					
				}
				
				public void copyDirectory(string source, string destiny)
				{
					/*
					dialog=new CopyWidget();
					dialog.Title="Copying files...";
					dialog.frameLabelText="<b>Copying " + source + " to " + destiny + "</b>";
					dialog.Show();
					
					
					int index=source.LastIndexOf("/");
					string tmp_destiny=destiny + "/" + source.Substring(index+1);
					System.IO.Directory.CreateDirectory(tmp_destiny);
						
					countFiles(source);
				
					System.Threading.ThreadStart tStart;
					System.Threading.Thread tThread;
				
				
				
					tStart = delegate { 
							copy_directory("/home/hector/Téléchargement","/tmp/Téléchargement"); 
					};
					tThread= new System.Threading.Thread(tStart);
					tThread.Start();			
					*/
					
					countFiles(source);
					
					dialog2.Title="Copying files...";
					frameLabel.Markup="<b>Copying " + source + " to " + destiny + "</b>";
					dialog2.Show();
					
					// CREATING BASE DIRECTORY
					
					int index=source.LastIndexOf("/");
					string tmp_destiny=destiny + "/" + source.Substring(index+1);
					System.IO.Directory.CreateDirectory(tmp_destiny);			
					
					// ************************
					
					
					
					System.Threading.ThreadStart tStart;
					System.Threading.Thread tThread;
					tStart = delegate { 
							copy_directory(source,tmp_destiny); 
					};
					tThread= new System.Threading.Thread(tStart);
					tThread.Start();			
					
		
					
				}
		
				
				private void copy_directory(string source, string destiny)
				{
					try 
					{
		
						System.IO.DirectoryInfo dinfo=new System.IO.DirectoryInfo(source);
						
						System.IO.DirectoryInfo[] dlist=dinfo.GetDirectories();
						System.IO.FileInfo[] flist=dinfo.GetFiles();
						
						foreach(System.IO.DirectoryInfo info in dlist)
						{
							string tmp_destiny=destiny + "/" + info.Name;
							Console.WriteLine("Creating directory {0}",tmp_destiny);
							System.IO.Directory.CreateDirectory(tmp_destiny);
							copy_directory(info.FullName,tmp_destiny);
						}
						foreach(System.IO.FileInfo info in flist)
						{
							string tmp_destiny=destiny + "/" + info.Name;
						
							Console.WriteLine("\tCopying {0} in {1}",info.FullName,tmp_destiny);
							
							System.IO.File.Copy(info.FullName,tmp_destiny);
							copied_files++;
							
							percentage=100*copied_files/file_number;
							
							file=tmp_destiny;
							
							Gtk.Application.Invoke(delegate 
							{
								updateProgressBar();
								
							});
								
							
						}
						Gtk.Application.Invoke(delegate 
							{
								updateProgressBar();
								
							});
					
					}
					catch
					{
						Console.WriteLine("TO DO");	
					}
					
					
				}		
				
				
				
				
				
				
			}
		}
	}
}