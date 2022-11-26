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
                Title = "Ковариантность и контравариантность. Как не наступить на наши грабли",
                Body = "Занимались как-то мы создание проекта на заказ. Была обычная работа с данными, ничего интересного, но вдруг нам приспичило заюзать в дата-контроллере in out параметры для generic типов.",
                Date = DateTime.Now,
                Languages = new List<string> { "C#" }
            },
            new Post {
                Photo = "https://sun9-63.userapi.com/impg/UP2dPE21rMkSBTH8aUMHhiuznIjbhQsxyfDhmQ/gG1z4WM1J3o.jpg?size=1620x2160&quality=95&sign=8b80b56c35172d90f4e5be5fbc57edbd&type=album",
                Creator = "Darya (aka Dasha)",
                Title = "Познаем новые архитектуры (или прощай ARMv7)",
                Body = "Доброго дня, как многие заметили, в последнем обновлении XCode14 купертиновцы убрали поддержку старых архитектур (в том числе моего любимого айфона 5). Теперь нам предстоит задача портирования кода с ассемблера на более крутой его вариант",
                Date = new DateTime(2022, 8, 11),
                Languages = new List<string> { "ASM", "AARCH64" }
            },
            new Post {
                Photo = "https://avatars.githubusercontent.com/u/79706809?v=4",
                Creator = "Макс Каманин",
                Title = "Применяем новый стандарт ES2022 на практике",
                Body = "Учение без размышления бесполезно, но и размышление без учения опасно. Не тот велик, кто никогда не падал, а тот велик — кто падал и вставал. Красота есть во всем, но не всем дано это видеть. Благородный человек предъявляет требования к себе, низкий человек предъявляет требования к другим",
                Date = new DateTime(2022, 10, 2),
                Languages = new List<string> { "JavaScript", "TypeScript" }
            }
        };
    }
}