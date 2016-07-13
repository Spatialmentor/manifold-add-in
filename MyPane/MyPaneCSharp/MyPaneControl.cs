using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manifold.Interop;

namespace MyPaneCSharp
{
    public partial class MyPaneControl : UserControl, Manifold.Interop.Scripts.IEventsConnection
    {
        public static Manifold.Interop.Application ManifoldApplication;

        public MyPaneControl()
        {
            InitializeComponent();
        }

        public void ConnectEvents(Manifold.Interop.Scripts.Events ev)
        {
            ev.DocumentClosed += new Manifold.Interop.Scripts.Events.DocumentClosedEventHandler(DocumentChanged);
            ev.DocumentCreated += new Manifold.Interop.Scripts.Events.DocumentCreatedEventHandler(DocumentChanged);
            ev.DocumentOpened += new Manifold.Interop.Scripts.Events.DocumentOpenedEventHandler(DocumentChanged);
            ev.DocumentSaved += new Manifold.Interop.Scripts.Events.DocumentSavedEventHandler(DocumentChanged);
            ev.AddinLoaded += new Manifold.Interop.Scripts.Events.AddinLoadedEventHandler(DocumentChanged);
            ev.ComponentsRemoved += new Manifold.Interop.Scripts.Events.ComponentsRemovedEventHandler(DocumentChanged);
            ev.ComponentStateChanged += new Manifold.Interop.Scripts.Events.ComponentStateChangedEventHandler(DocumentChanged);
            ev.ComponentNameChanged += new Manifold.Interop.Scripts.Events.ComponentNameChangedEventHandler(DocumentChanged);
            ev.ComponentsRemoved += new Manifold.Interop.Scripts.Events.ComponentsRemovedEventHandler(DocumentChanged);

        }

        private void DocumentChanged(System.Object sender, Manifold.Interop.Scripts.DocumentEventArgs args)
        {
            ManifoldApplication = args.Document.Application;
            Label1.Text = args.Document.Path;
        }
        private void DocumentChanged(System.Object sender, Manifold.Interop.Scripts.ComponentEventArgs args)
        {
            ManifoldApplication = args.Component.Application;
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            if (ManifoldApplication != null)
            {
                ManifoldApplication.MessageBox("The document contains " +
                  ManifoldApplication.ActiveDocument.ComponentSet.Count.ToString() +
                  " component(s).");
            }
        }
    }
}
