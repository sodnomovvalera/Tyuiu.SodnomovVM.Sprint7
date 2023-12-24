﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectV4.Lib;

namespace ProjectV4
{
    public partial class FormData : System.Windows.Forms.Form
    {
        BindingSource GenreBindingSource = new BindingSource();



        public FormData()
        {
            InitializeComponent();
        }

        private void buttonLoadGenre_Click(object sender, EventArgs e)
        {
            LibraryGenreDAO libraryGenreDAO = new LibraryGenreDAO();

            LibraryGenre Fantasy = new LibraryGenre
            {
                Жанр = "Фентези",
                Количество_Книг = 8,
                Описание = "Фэ́нтези (англ. fantasy[1] — «фантазия») — жанр современного искусства, разновидность фантастики. Произведения жанра фэнтези основываются на мифологических и сказочных мотивах, переосмысленных или переработанных авторами. Первые произведения современного фэнтези начали появляться в начале XX века. В середине XX века наиболее значительное влияние на формирование современного облика классического фэнтези оказали английские писатели Джон Рональд Руэл Толкин, автор романа «Властелин колец», и Клайв Стейплз Льюис, автор «Хроник Нарнии»."


            };

            LibraryGenre Detective = new LibraryGenre
            {
                Жанр = "Детектив",
                Количество_Книг = 8,
                Описание = "Детекти́вные произведения, также уголо́вный рассказ[1] (от лат. detectio «раскрытие», англ. detect «открывать, обнаруживать»; detective «сыщик») — преимущественно литературный и кинематографический жанр, описывающий процесс исследования загадочного происшествия с целью выяснения его обстоятельств и раскрытия загадки. Обычно в качестве такого происшествия выступает преступление. Детектив описывает его расследование и определение виновных, в таком случае конфликт строится на столкновении справедливости с беззаконием, завершающийся победой справедливости. Детективы считаются одним из видов криминальной прозы."
            };

            LibraryGenre HistoryProsa = new LibraryGenre
            {
                Жанр = "Исторический роман",
                Количество_Книг = 8,
                Описание = "Историческая проза — условное обозначение для разнородных по структуре и композиции романов, повестей, рассказов, в которых повествуется об исторических событиях более или менее отдалённого времени, а действующими лицами (главными или второстепенными) могут выступать исторические личности."
            };

            LibraryGenre LoveProsa = new LibraryGenre
            {
                Жанр = "Любовный роман",
                Количество_Книг = 8,
                Описание = "Любовный роман — литературный жанр. В центре произведений этого жанра находятся отношения и романтическая любовь между двумя людьми, также предполагается «эмоционально удовлетворительный и оптимистичный финал»[1]. У любовного романа множество поджанров: фэнтези, исторический роман, научная фантастика, мистика."
            };


            LibraryGenre AventureProsa = new LibraryGenre
            {
                Жанр = "Приключенческий роман",
                Количество_Книг = 8,
                Описание = "Приключенческий роман (также авантюрный роман, от фр. aventure) — жанр романа, сформировавшийся в середине XIX века на волне романтизма и неоромантизма с характерным для них стремлением бежать от мещанской повседневности в мир экзотики и героизма. В более широком смысле можно говорить о существовании особого авантюрного жанра, или приключенческой литературы, которую отличают резкое деление персонажей на героев и злодеев, «стремительность развития действия, переменчивость и острота сюжетных ситуаций, преувеличенность переживаний, мотивы похищения и преследования, тайны и загадки»[1]. Задача приключенческой литературы — не столько поучать, анализировать или описывать реальность, сколько развлекать читателя[1]."

            };

            libraryGenreDAO.Genre.Add(Fantasy);
            libraryGenreDAO.Genre.Add(HistoryProsa);
            libraryGenreDAO.Genre.Add(Detective);
            libraryGenreDAO.Genre.Add(LoveProsa);
            libraryGenreDAO.Genre.Add(AventureProsa);

            GenreBindingSource.DataSource = libraryGenreDAO.Genre;

            dataGridViewLibGenre.DataSource = GenreBindingSource;

        }
    }

}