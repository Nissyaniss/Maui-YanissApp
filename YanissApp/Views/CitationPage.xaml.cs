using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YanissApp.Views;

public partial class CitationPage : ContentPage
{
    private readonly List<(string quote, string author)> _quotes = new()
    {
        ("La vie est ce qui arrive quand on est occupé à faire d'autres projets.", "John Lennon"),
    ("Le courage n'est pas l'absence de peur, mais la capacité de la vaincre.", "Nelson Mandela"),
    ("La simplicité est la sophistication suprême.", "Léonard de Vinci"),
    ("Chaque jour est une nouvelle chance de changer votre vie.", "Inconnu"),
    ("L'éducation est l'arme la plus puissante pour changer le monde.", "Nelson Mandela"),
    ("Le succès c'est tomber 7 fois et se relever 8.", "Proverbe japonais"),
    ("La vie est soit une aventure audacieuse, soit rien du tout.", "Helen Keller"),
    ("Crois en toi et tu seras invincible.", "Sénèque"),
    ("L'avenir appartient à ceux qui croient en la beauté de leurs rêves.", "Eleanor Roosevelt"),
    ("Le seul moyen de faire du bon travail est d'aimer ce que vous faites.", "Steve Jobs"),
    ("La créativité, c'est l'intelligence qui s'amuse.", "Albert Einstein"),
    ("Le changement commence là où se termine votre zone de confort.", "Neale Donald Walsch"),
    ("La patience est un arbre dont la racine est amère, mais les fruits très doux.", "Proverbe persan"),
    ("Visez toujours la lune, même si vous échouez, vous atterrirez parmi les étoiles.", "Oscar Wilde"),
    ("La seule limite à notre réalisation de demain sera nos doutes d'aujourd'hui.", "Franklin D. Roosevelt"),
    ("Le bonheur n'est pas quelque chose de prêt à l'emploi. Il vient de vos propres actions.", "Dalaï Lama"),
    ("La meilleure façon de prédire l'avenir est de le créer.", "Peter Drucker"),
    ("La vie est comme une bicyclette, pour garder l'équilibre, il faut avancer.", "Albert Einstein"),
    ("Les opportunités ne se présentent pas. C'est vous qui les créez.", "Chris Grosser"),
    ("La persévérance est le secret de tous les triomphes.", "Victor Hugo"),
    ("Votre temps est limité, ne le gâchez pas en menant une existence qui n'est pas la vôtre.", "Steve Jobs"),
    ("La plus grande gloire n'est pas de ne jamais tomber, mais de se relever à chaque chute.", "Confucius"),
    ("Le succès est la somme de petits efforts répétés jour après jour.", "Robert Collier"),
    ("Soyez le changement que vous voulez voir dans le monde.", "Mahatma Gandhi"),
    ("La seule personne que vous êtes destiné à devenir est celle que vous décidez d'être.", "Ralph Waldo Emerson"),
    ("La connaissance s'acquiert par l'expérience, tout le reste n'est que de l'information.", "Albert Einstein"),
    ("Les problèmes sont des opportunités déguisées.", "Albert Einstein"),
    ("La meilleure revanche, c'est le succès.", "Frank Sinatra"),
    ("Ne laissez pas le bruit des opinions des autres couvrir votre voix intérieure.", "Steve Jobs"),
    ("La vie mesure l'amour qu'on donne, pas les années qu'on vit.", "Mère Teresa"),
    ("La seule façon de faire du bon travail est d'aimer ce que vous faites.", "Steve Jobs"),
    ("Le bonheur ne dépend pas de ce que vous avez, mais de ce que vous êtes.", "Leo Tolstoy"),
    ("La plus grande découverte de ma génération est qu'un être humain peut changer sa vie en changeant son attitude.", "William James"),
    ("La sagesse commence dans l'émerveillement.", "Socrate"),
    ("Le succès n'est pas final, l'échec n'est pas fatal : c'est le courage de continuer qui compte.", "Winston Churchill"),
    ("La vie est trop courte pour être petite.", "Benjamin Disraeli"),
    ("Le secret du succès est de savoir quelque chose que personne d'autre ne sait.", "Aristote Onassis"),
    ("La meilleure façon de trouver une idée est d'en avoir beaucoup.", "Linus Pauling"),
    ("Le pessimiste voit la difficulté dans chaque opportunité. L'optimiste voit l'opportunité dans chaque difficulté.", "Winston Churchill"),
    ("La gratitude transforme ce que nous avons en suffisamment.", "Melody Beattie"),
    ("Le monde appartient à ceux qui ont soif d'apprendre.", "Proverbe chinois"),
    ("La seule limite à notre réalisation de demain sera nos doutes d'aujourd'hui.", "Franklin D. Roosevelt"),
    ("Le succès consiste à aller d'échec en échec sans perdre son enthousiasme.", "Winston Churchill"),
    ("La meilleure préparation pour demain est de faire de son mieux aujourd'hui.", "H. Jackson Brown Jr."),
    ("Le bonheur n'est pas quelque chose de prêt à l'emploi. Il vient de vos propres actions.", "Dalaï Lama"),
    ("La plus grande gloire n'est pas de ne jamais tomber, mais de se relever à chaque chute.", "Confucius"),
    ("Le succès est la somme de petits efforts répétés jour après jour.", "Robert Collier"),
    ("Soyez le changement que vous voulez voir dans le monde.", "Mahatma Gandhi"),
    ("La seule personne que vous êtes destiné à devenir est celle que vous décidez d'être.", "Ralph Waldo Emerson"),
    ("La connaissance s'acquiert par l'expérience, tout le reste n'est que de l'information.", "Albert Einstein")
    };

    private readonly Random _random = new();

    public CitationPage()
    {
        InitializeComponent();
        GenerateNewQuote();
    }

    private void OnGenerateQuote(object sender, EventArgs e)
    {
        GenerateNewQuote();
    }

    private void GenerateNewQuote()
    {
        var (quote, author) = _quotes[_random.Next(_quotes.Count)];
        QuoteLabel.Text = $"« {quote} »";
        AuthorLabel.Text = $"— {author}";
        
        QuoteLabel.Opacity = 0;
        QuoteLabel.FadeTo(1, 1000);
        AuthorLabel.Opacity = 0;
        AuthorLabel.FadeTo(1, 1000);
    }
}