using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZombieParty.Models;

namespace ZombieParty.Data
{
    public static class ModelBuilderDataGenerator
    {
        public static void GenerateData(this ModelBuilder builder)
        {

            #region Zombie
            builder.Entity<Zombie>().HasData(
                new Zombie { Id = 1, Point = 5, ShortDesc = "Pirate des Caraibes", Name = "LeChuck", ZombieTypeId = 1 },
                new Zombie { Id = 2, Point = 4, ShortDesc = "Cute Little Dead Girl", Name = "Lenore", ZombieTypeId = 2 },
                new Zombie { Id = 3, Point = 8, ShortDesc = "En costume de soirée, avec un chapeau haut de forme blanc et des lunettes soleil", Name = "Baron Samedi", ZombieTypeId = 2 },
                new Zombie { Id = 4, Point = 2, ShortDesc = "Vivant dans sa tombe grandant son trésor", Name = "Draugr", ZombieTypeId = 3 },
                new Zombie { Id = 5, Point = 5, ShortDesc = "Ancien vampire transformé en poupée de chiffon, ami de Lenore", Name = "Ragamuffin ", ZombieTypeId = 2 },
                new Zombie { Id = 6, Point = 6, ShortDesc = "Tête de sac avec yeux en boutons, amoureux de Lenore", Name = "Mr Gosh", ZombieTypeId = 1 },
                new Zombie { Id = 7, Point = 1, ShortDesc = "Tête de cerf empaillé, voisin de Lenore", Name = "Taxidermy ", ZombieTypeId = 3 },
                new Zombie { Id = 8, Point = 3, ShortDesc = "Chat mort de Lenore", Name = "Kitty", ZombieTypeId = 1 },
                new Zombie { Id = 9, Point = 2, ShortDesc = "Voleur très rapide", Name = "Singe zombie", ZombieTypeId = 3 },
                new Zombie { Id = 10, Point = 7, ShortDesc = "chien très rapide, pouvant être enflammé", Name = "chien de l'enfer", ZombieTypeId = 3 },
                new Zombie { Id = 11, Point = 9, ShortDesc = "Attaque avec des éclairs suite à un orage", Name = "Avogadro", ZombieTypeId = 3 },
                new Zombie { Id = 12, Point = 6, ShortDesc = "", Name = "Lady Rose", ZombieTypeId = 3 },
                new Zombie { Id = 13, Point = 2, ShortDesc = "Jeune étudiante qui cherche son professeur pour se venger", Name = "Matbeth", ZombieTypeId = 2 },
                new Zombie { Id = 14, Point = 5, ShortDesc = "Le clown malheureux qui court après les enfants", Name = "The Clown", ZombieTypeId = 3 },
                new Zombie { Id = 15, Point = 4, ShortDesc = "Le comptable mécontent qui cherche les failles", Name = "Clicker", ZombieTypeId = 2 },
                new Zombie { Id = 16, Point = 10, ShortDesc = "L'étudiant happé par Teams. Trop d'heures de vidéos ont transformé cet étudiant en zombie", Name = "TeamsZombie", ZombieTypeId = 3 },
                new Zombie { Id = 17, Point = 4, ShortDesc = "La fêtarde du samedi soir qui cherche les fêtes et les bars en vogue", Name = "Mathilde", ZombieTypeId = 3 }
            );
            #endregion

            #region ZombieType
            builder.Entity<ZombieType>().HasData(
                new ZombieType { Id = 1, TypeName = "Contact", Point = 2 },
                new ZombieType { Id = 2, TypeName = "Virus", Point = 3 },
                new ZombieType { Id = 3, TypeName = "Chimique", Point = 4 },
                new ZombieType { Id = 4, TypeName = "Morsure", Point = 2 },
                new ZombieType { Id = 5, TypeName = "vampzombie", Point = 5 }
            );
            #endregion

            #region Weapon
            builder.Entity<Weapon>().HasData(
                new Weapon() { WeaponId = 1, Name = "Leopold", Description = "This is to cut your friendly zombies", Force = 200, Image = "https://i.ibb.co/y5nCnXT/dagger-gfce31e967-1920.png", Price = 421, Qty = 21, QtyBought = 3, CreatedDate = new DateTime(1999, 01, 1) },
                new Weapon() { WeaponId = 2, Name = "Master Shield", Description = "An awesome Stainless Steel Shield", Force = 10, Image = "https://publicdomainvectors.org/photos/Shield-ClassicMedieval1.png", Price = 500, Qty = 30, QtyBought = 1, CreatedDate = new DateTime(1999, 01, 1) },
                new Weapon() { WeaponId = 3, Name = "Frostmourne", Description = "The sword used by the Lich king", Force = 300, Image = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/c78f1949-5e75-4eab-9541-770f5214a2b7/dhe20pb-202b5835-44a7-4a7e-9a25-f1a06aaf0002.png/v1/fit/w_828,h_1412/frostmourne_by_gortime_dhe20pb-414w-2x.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9MjE2MCIsInBhdGgiOiIvZi9jNzhmMTk0OS01ZTc1LTRlYWItOTU0MS03NzBmNTIxNGEyYjcvZGhlMjBwYi0yMDJiNTgzNS00NGE3LTRhN2UtOWEyNS1mMWEwNmFhZjAwMDIucG5nIiwid2lkdGgiOiI8PTEyNjcifV1dLCJhdWQiOlsidXJuOnNlcnZpY2U6aW1hZ2Uub3BlcmF0aW9ucyJdfQ.Si10jV5IEsUOJg9AppnfQQlXN2K-1HY8PJ1pPPCbzNU", Price = 1000, Qty = 1, QtyBought = 0, CreatedDate = new DateTime(1999, 01, 1) }
            );
            #endregion
        }
    }
}
