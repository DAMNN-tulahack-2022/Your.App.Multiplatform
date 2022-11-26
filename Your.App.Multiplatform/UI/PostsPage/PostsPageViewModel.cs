using Your.Network.Models;

namespace Your.App;

public class PostsPageViewModel: ObservableModel {
    private List<Post> posts;
    public List<Post> Posts {
        get => this.posts;
        set => SetProperty(ref this.posts, value, nameof(Posts));
    }

    public PostsPageViewModel() {
        this.Posts = new List<Post> {
            new Post {
                Photo = "https://avatars.githubusercontent.com/u/48021947?v=4",
                Creator = "Nikita Romanov",
                Title = "Ковариативность, Контрвариативность. Как не наступить на наши грабли",
                Body = "Саб, двач. Сидим мы значит такие с Максом на паре, сидим, чилим, и тут он мне говорит: «Ну, а ты что, не знаешь, что такое ковариативность?» Я ему: «Ну, я знаю, что такое ковариативность, но я не знаю, что такое контрвариативность.»",
                Date = DateTime.Now,
                Languages = new List<string> { "C#" }
            },
            new Post {
                Photo = "https://avatars.githubusercontent.com/u/79706809?v=4",
                Creator = "Maxim Cumanin",
                Title = "Анекдот",
                Body = "Учение без размышления бесполезно, но и размышление без учения опасно. Не тот велик, кто никогда не падал, а тот велик — кто падал и вставал. Красота есть во всем, но не всем дано это видеть. Благородный человек предъявляет требования к себе, низкий человек предъявляет требования к другим",
                Date = new DateTime(2022, 10, 2),
                Languages = new List<string> { "Python", "Angular" }
            },
            new Post {
                Photo = "https://sun9-63.userapi.com/impg/UP2dPE21rMkSBTH8aUMHhiuznIjbhQsxyfDhmQ/gG1z4WM1J3o.jpg?size=1620x2160&quality=95&sign=8b80b56c35172d90f4e5be5fbc57edbd&type=album",
                Creator = "Darya (aka Dasha (aka Shasha))",
                Title = "В заречье снова неприятный запах",
                Body = "Доброго дня, в нашем городе снова стало не приятно пахнуть. Я уже обращалась к Путину на прямой линии, нам провели ремонт в городе, но теперь снова пвхнет. Я уже не знаю, что делать. Помогите, пожалуйста.",
                Date = new DateTime(2022, 10, 2),
                Languages = new List<string> { "Figma", "Компас 3D", "КБП❤️" }
            }
        };
    }
}