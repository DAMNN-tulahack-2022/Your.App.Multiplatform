using Your.Network.Models;

namespace Your.App;

public class ProjectPageViewModel: ObservableModel {
    private List<Project> projects;
    public List<Project> Projects {
        get => this.projects;
        set => SetProperty(ref this.projects, value, nameof(Projects));
    }

    public ProjectPageViewModel() {
        this.projects = new List<Project> {
            new Project {
                Title = "Создание кроссплатформеного приложения для сети ресторанов «Вкусно и Точка»",
                Body = "К нам пришел официальный представитель бывщей сети Макдонладс, сам Роналд Макдональд, и предложил нам создать приложение для его новой сети ресторанов «Вкусно и Точка». Ну мы и согласились",
                Languages = new List<string> { "Kotlin", "Objective-C" },

                DescriptionTitle = Localization.Instance.GetString("title_common_description"),
                LanguagesTitle = Localization.Instance.GetString("title_common_stack_tech")
            }
        };
    }
}