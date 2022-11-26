namespace Your.App;

public partial class ProjectItemTemplate : Frame {
	public ProjectItemTemplate() {
		InitializeComponent();
	}

    protected override void OnBindingContextChanged() {
		base.OnBindingContextChanged();
		if (BindingContext is ProjectItem project) {
			container.Clear();
			foreach (var user in project.Contributors) {
				container.Add(new UserItemTemplate { BindingContext = user });
			}
		}
    }
}
