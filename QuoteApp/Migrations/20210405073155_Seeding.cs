using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuoteApp.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[,]
                {
                    { 1, "Фаина Раневская", new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), "Всё сбудется, стоит только расхотеть." },
                    { 2, "Людвиг Бёрне", new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), "Без многого может обходиться человек, но только не без человека." },
                    { 3, "Ганс Христиан Андерсен.", new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), "Жизнь, как красивая мелодия, только песни перепутались." },
                    { 4, "Люси Скетч", new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), "Они улыбаются, когда ты звонишь им, но у них нет времени позвонить тебе." },
                    { 5, "Nich James", new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), "Желание добиться успеха без упорного труда, схоже с желанием снять урожай там, где вы не садили семена." },
                    { 6, "Olga Komichkina.", new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Local), "Каждую минуту, когда вы злитесь на кого-то, вы теряете 60 секунд счастья, которые никогда не вернете." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
