using Microsoft.EntityFrameworkCore;
using QuoteApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteApp.DataContext
{
    public class QuoteDbContext : DbContext
    {
        public QuoteDbContext(DbContextOptions options) : base(options)
        {
        }

        protected QuoteDbContext()
        {
        }
        public DbSet<Quote> Quotes{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quote>().HasData
                (
                new Quote()
                {
                    Id = 4,
                    Text = "Всё сбудется, стоит только расхотеть.",
                    Author = "Фаина Раневская",
                    InsertDate = DateTime.Now.Date,
                },

                new Quote()
                {
                    Id = 5,
                    Text = "Без многого может обходиться человек, но только не без человека.",
                    Author = "Людвиг Бёрне",
                    InsertDate = DateTime.Now.Date,
                },

                new Quote()
                {
                    Id = 6,
                    Text = "Жизнь, как красивая мелодия, только песни перепутались.",
                    Author = "Ганс Христиан Андерсен.",
                    InsertDate = DateTime.Now.Date,
                },

                new Quote()
                {
                    Id = 7,
                    Text = "Они улыбаются, когда ты звонишь им, но у них нет времени позвонить тебе.",
                    Author = "Люси Скетч",
                    InsertDate = DateTime.Now.Date,
                },

                new Quote()
                {
                    Id = 8,
                    Text = "Желание добиться успеха без упорного труда, схоже с желанием снять урожай там, где вы не садили семена.",
                    Author ="Nich James",
                    InsertDate = DateTime.Now.Date,
                },
                new Quote()
                {
                    Id = 9,
                    Text = "Каждую минуту, когда вы злитесь на кого-то, вы теряете 60 секунд счастья, которые никогда не вернете.",
                    Author = "Olga Komichkina.",
                    InsertDate = DateTime.Now.Date,
                }
                );
        }

    }
}
