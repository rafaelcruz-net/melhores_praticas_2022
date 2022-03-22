using CarGallery.Models;
using Microsoft.EntityFrameworkCore;

namespace CarGallery.Repository.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 1,
                Name = "Porsche 911 Turbo",
                ShortDescription = "Porsche 911 Turbo S",
                LongDescription = "Sempre que um carro apresenta um comportamento irrepreensível, é difícil não nos perguntarmos como será possível fazer algo melhor em uma futura geração. Desde a primeira edição do 911 Turbo, em 1975, porém, os engenheiros da Porsche vêm conseguindo essa insuspeita superação e desta vez não foi diferente.",
                ImageUrl = "/images/porsche/porsche_911_Turbo.jpg",
                ImageThumbnailUrl = "/images/porsche/porsche_911_Turbo_small.jpg",
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 2,
                Name = "Porsche Cayenne",
                ShortDescription = "O equilibrio entre desempenho e conforto",
                LongDescription = "Cayenne é um case de sucesso na indústria automobilística. Graças a ele, a Porsche se reinventou, passou a ganhar dinheiro como nunca e hoje é ainda mais forte do que era quando se fala em automóveis esportivos. Com mais de 800 mil unidades vendidas no mundo e 5,2 mil no Brasil, o Cayenne se dá ao luxo de cobrar a mais pelo logotipo que carrega",
                ImageUrl = "/images/porsche/porsche-cayenne-coupe.jpg",
                ImageThumbnailUrl = "/images/porsche/porsche-cayenne-coupe_small.jpg",
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 3,
                Name = "Ferrari F8 Tributo",
                ShortDescription = "F8 Tributo - A lenda",
                LongDescription = "F8 Tributo é uma homenagem ao premiado motor V8 da marca italiana. Trata-se de um 3.9 biturbo, que entrega 720 cavalos e 78,5 kgfm de torque",
                ImageUrl = "/images/ferrari/ferrari-F8.jpg",
                ImageThumbnailUrl = "/images/ferrari/ferrari-F8_small.jpg",
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 4,
                Name = "Ferrari 458 Spider",
                ShortDescription = "O V8 mais poderoso já feito pela marca",
                LongDescription = "O coração do novo 458 Spider é o vencedor do Prêmio Motor Internacional do Ano de 2018, um V8 twin-turbo de 3,9 litros com 720 cavalos de potência e 78,52 kgfm de torque",
                ImageUrl = "/images/ferrari/ferrarri_spider.jpg",
                ImageThumbnailUrl = "/images/ferrari/ferrarri_spider_small.jpg",
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                CarId = 5,
                Name = "Ford Mustang",
                ShortDescription = "O melhor pony car",
                LongDescription = "O Mustang GT é absolutamente a melhor forma de começar o dia, já que seu motor é uma joia. O V8 ainda mantém o nome de Coyote, mas não é quieto como o anterior. O motor esbraveja como o melhor muscle car de todos os tempos.",
                ImageUrl = "/images/ford/ford_mustang.jpg",
                ImageThumbnailUrl = "/images/ford/ford_mustang_small.jpg",
            });

        }
    }
}