Public Class MyPaneControl
    Implements Manifold.Interop.Scripts.IEventsConnection

    Dim ManifoldApplication As Manifold.Interop.Application

    Private Sub Button1_Click(
      ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles Button1.Click
        If Not (ManifoldApplication Is Nothing) Then
            ManifoldApplication.MessageBox("The document contains " +
              ManifoldApplication.ActiveDocument.ComponentSet.Count.ToString() +
              " component(s).")
        End If
    End Sub

    Public Sub ConnectEvents(
      ByVal ev As Manifold.Interop.Scripts.Events) _
      Implements Manifold.Interop.Scripts.IEventsConnection.ConnectEvents
        AddHandler ev.DocumentClosed, AddressOf Document_Changed
        AddHandler ev.DocumentCreated, AddressOf Document_Changed
        AddHandler ev.DocumentOpened, AddressOf Document_Changed
        AddHandler ev.DocumentSaved, AddressOf Document_Changed
        AddHandler ev.AddinLoaded, AddressOf Document_Changed
        AddHandler ev.ComponentsAdded, AddressOf Document_Changed
        AddHandler ev.ComponentsRemoved, AddressOf Document_Changed
        AddHandler ev.ComponentStateChanged, AddressOf Document_Changed
        AddHandler ev.ComponentNameChanged, AddressOf Document_Changed
        AddHandler ev.ComponentsRemoved, AddressOf Document_Changed


    End Sub

    Private Sub Document_Changed(
      ByVal sender As System.Object,
      ByVal args As Manifold.Interop.Scripts.DocumentEventArgs)
        ManifoldApplication = args.Document.Application
        Label1.Text = ManifoldApplication.ActiveDocument.Path
    End Sub

    Private Sub Document_Changed(
      ByVal sender As System.Object,
      ByVal args As Manifold.Interop.Scripts.ComponentEventArgs)
        ManifoldApplication = args.Component.Application
    End Sub

End Class