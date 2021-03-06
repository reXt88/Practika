USE [master]
GO
/****** Object:  Database [Sample]    Script Date: 13.04.2022 7:25:15 ******/
CREATE DATABASE [Sample]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sample', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Sample.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Sample_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Sample_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Sample] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sample].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sample] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sample] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sample] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sample] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sample] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sample] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Sample] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sample] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sample] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sample] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sample] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sample] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sample] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sample] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sample] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Sample] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sample] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sample] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sample] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sample] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sample] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sample] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sample] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Sample] SET  MULTI_USER 
GO
ALTER DATABASE [Sample] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sample] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sample] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sample] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Sample] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Sample] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Sample] SET QUERY_STORE = OFF
GO
USE [Sample]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 13.04.2022 7:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Фамилия] [nvarchar](50) NULL,
	[Имя] [nvarchar](50) NULL,
	[Отчество] [nvarchar](50) NULL,
	[Номер телефона] [nvarchar](50) NULL,
	[Возраст] [int] NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductNew]    Script Date: 13.04.2022 7:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductNew](
	[ID] [nvarchar](50) NOT NULL,
	[Тип] [nvarchar](50) NULL,
	[Артикул] [nvarchar](50) NULL,
	[Название] [nvarchar](50) NULL,
	[Цена] [int] NULL,
 CONSTRAINT [PK_ProductNew] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 13.04.2022 7:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Login] [nvarchar](50) NOT NULL,
	[Psw] [nvarchar](50) NULL,
	[Role] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ID], [Фамилия], [Имя], [Отчество], [Номер телефона], [Возраст]) VALUES (9, N'Мартынов', N'Всеволод', N'Валерьевич', N'+7(917)544-95-76', 17)
INSERT [dbo].[Clients] ([ID], [Фамилия], [Имя], [Отчество], [Номер телефона], [Возраст]) VALUES (10, N'Шеховцов', N'Иван', N'Александрович', N'+7(396)342-77-42', 17)
INSERT [dbo].[Clients] ([ID], [Фамилия], [Имя], [Отчество], [Номер телефона], [Возраст]) VALUES (1007, N'Поминов', N'Даниил', N'Викторович', N'+7(980)960-09-60', 17)
INSERT [dbo].[Clients] ([ID], [Фамилия], [Имя], [Отчество], [Номер телефона], [Возраст]) VALUES (1008, N'Антипов', N'Алексей', N'Сергеевич', N'+7(798)421-97-42', 29)
INSERT [dbo].[Clients] ([ID], [Фамилия], [Имя], [Отчество], [Номер телефона], [Возраст]) VALUES (1009, N'Трофимова', N'Александра', N'Николаевна', N'+7(971)379-84-92', 34)
INSERT [dbo].[Clients] ([ID], [Фамилия], [Имя], [Отчество], [Номер телефона], [Возраст]) VALUES (1010, N'Андраникова', N'Светлана', N'Викторовна', N'+7(918)651-32-19', 44)
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'1', N'Мыльные пузыри, слаймы', N'SF02-B', N'Cream Slime, Банан, 250 г.', 217)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'10', N'Карнавальная косметика', N'К3220', N'Аквагрим Зеленый, карандаш 15 г', 94)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'100', N'Бенгальские огни и фонтаны', N'ТР157', N'Бенгальский огонь Экстра, 30 сек, 17 см, 6 шт.', 35)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'102', N'Пиньяты', N'6012316', N'Бита для пиньяты 4*43 см, 1 шт.', 192)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'103', N'Пиньяты', N'6012317', N'Бита для пиньяты Ассорти, 2,5*50 см, 1 шт.', 180)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'104', N'Грамоты, дипломы и приглашения', N'044089', N'Благодарность (красная лента), 21*29 см, 10 шт.', 108)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'105', N'Газовое оборудование', N'12904', N'Блок с манометром БМ-1, 1 шт.', 1604)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'106', N'Одноразовая посуда', N'6225025', N'Вилки, Золото, металлик, 19 см, 10 шт.', 194)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'107', N'Одноразовая посуда', N'6225088', N'Вилки, Красный, 15 см, 10 шт.', 48)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'108', N'Одноразовая посуда', N'6225092', N'Вилки, Прозрачный, 15 см, 10 шт.', 48)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'109', N'Одноразовая посуда', N'6225023', N'Вилки, Розовое Золото, 17 см, 10 шт.', 100)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'11', N'Карнавальная косметика', N'К3206', N'Аквагрим Золото, карандаш 15 г', 110)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'110', N'Одноразовая посуда', N'6225086', N'Вилки, Розовый, 15 см, 10 шт.', 48)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'111', N'Одноразовая посуда', N'6225027', N'Вилки, Серебро, 19 см, 10 шт.', 100)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'112', N'Одноразовая посуда', N'6225090', N'Вилки, Черный, 15 см, 10 шт.', 48)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'113', N'Маркеры и наклейки', N'1968-NZW', N'Виниловые наклейки Звезда, Белый, 250 шт.', 260)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'114', N'Маркеры и наклейки', N'1968-NZG', N'Виниловые наклейки Звезда, Золото, 250 шт.', 260)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'115', N'Маркеры и наклейки', N'1968-NZR', N'Виниловые наклейки Звезда, Красный, 250 шт.', 260)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'116', N'Маркеры и наклейки', N'1968-NZB', N'Виниловые наклейки Звезда, Черный, 250 шт.', 368)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'117', N'Маркеры и наклейки', N'1968-NSR', N'Виниловые наклейки Сердце, Красный, 250 шт.', 368)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'118', N'Шляпы, пилотки, платки', N'01-139', N'Волшебная шляпа на Хэллоуин Фиолетовый, 1 шт.', 196)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'119', N'Шляпы, пилотки, платки', N'01-140', N'Волшебная шляпа на Хэллоуин Черный, 1 шт.', 196)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'12', N'Карнавальная косметика', N'К3237', N'Аквагрим Изумруд, карандаш 15 г', 110)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'120', N'Конфетти, пенопласт, серпантин, глиттер', N'MS-14', N'Волшебный снег, 3 литра снега, Белый, 100 г.', 475)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'121', N'Конфетти, пенопласт, серпантин, глиттер', N'MS-4', N'Волшебный снег, Белый, 10 г.', 125)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'122', N'Гелий и баллоны', N'75401', N'Гелий в портативном баллоне, на 18-30 шаров, 1 шт.', 2249)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'123', N'Гелий и баллоны', N'75402', N'Гелий в портативном баллоне, на 28-50 шаров, 1 шт.', 3300)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'13', N'Карнавальная косметика', N'К3211', N'Аквагрим Краснокожий Вождь, карандаши, 3 цвета', 191)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'14', N'Карнавальная косметика', N'К3217', N'Аквагрим Красный, карандаш 15 г', 102)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'15', N'Карнавальная косметика', N'К3223', N'Аквагрим Оранжевый, карандаш 15 г', 81)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'18', N'Карнавальная косметика', N'К3222', N'Аквагрим Розовый, карандаш 15 г', 92)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'19', N'Карнавальная косметика', N'К3236', N'Аквагрим Сапфир, карандаш 15 г', 108)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'2', N'Мыльные пузыри, слаймы', N'SF02-S', N'Cream Slime, Клубника, 250 г.', 217)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'20', N'Карнавальная косметика', N'К3213', N'Аквагрим Фантазия, карандаши, 3 цвета', 227)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'21', N'Карнавальная косметика', N'К3241', N'Аквагрим Фиолетовый, карандаш 15 г', 94)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'22', N'Оформительское оборудование', N'CD-110', N'Аксессуар для завязывания воздушных шаров, 1 шт.', 17)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'23', N'Мыльные пузыри, слаймы', N'SSS1-15', N'Активатор для слайма, 100 мл.', 144)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'24', N'Мыльные пузыри, слаймы', N'S300-39', N'Базовый слайм, Slimer, Прозрачный, 500 мл.', 286)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'25', N'Аксессуары для шаров', N'БАНКА', N'Банка Джойка, 2 л, 1 шт.', 100)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'26', N'Банты', N'5112119', N'Бант Атласная лента, Голубой, 21 см, 1 шт.', 369)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'27', N'Банты', N'5112124', N'Бант Атласная лента, Золото, 21 см, 1 шт.', 369)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'28', N'Банты', N'5112120', N'Бант Атласная лента, Красный, 21 см, 1 шт.', 369)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'29', N'Банты', N'5112131', N'Бант Атласная лента, Малиновый, 21 см, 1 шт.', 369)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'3', N'Мыльные пузыри, слаймы', N'SF02-I', N'Cream Slime, Мороженое, 250 г.', 217)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'31', N'Банты', N'5112121', N'Бант Атласная лента, Розовый, 21 см, 1 шт.', 369)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'32', N'Банты', N'5112126', N'Бант Атласная лента, Светло-синий, 21 см, 1 шт.', 369)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'33', N'Банты', N'5112127', N'Бант Атласная лента, Серебро, 21 см, 1 шт.', 369)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'34', N'Банты', N'5112130', N'Бант Атласная лента, Фуксия, 21 см, 1 шт.', 369)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'35', N'Банты', N'17817', N'Бант Звезда, Ассорти, Перламутр, 5 см, 25 шт.', 102)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'36', N'Банты', N'17810', N'Бант Звезда, Голубой микс, 5 см, 25 шт.', 102)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'37', N'Банты', N'17802', N'Бант Звезда, Голубой микс, 7 см, 12 шт.', 128)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'38', N'Банты', N'17824', N'Бант Звезда, Золото, Металлик, 4 см, 10 шт.', 50)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'39', N'Банты', N'17815', N'Бант Звезда, Золото, Металлик, 7 см, 12 шт.', 136)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'4', N'Мыльные пузыри, слаймы', N'SF02-J', N'Cream Slime, Черничный йогурт, 250 г.', 217)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'40', N'Банты', N'17822', N'Бант Звезда, Золотой микс, Голография, 7 см, 8 шт.', 70)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'41', N'Банты', N'17809', N'Бант Звезда, Красный микс, 5 см, 25 шт.', 102)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'42', N'Банты', N'17806', N'Бант Звезда, Красный микс, 5 см, 8 шт.', 84)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'43', N'Банты', N'17812', N'Бант Звезда, Летний микс, 5 см, 25 шт.', 102)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'47', N'Банты', N'17808', N'Бант Звезда, Розовый микс, 5 см, 8 шт.', 84)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'48', N'Банты', N'17801', N'Бант Звезда, Розовый микс, 7 см, 12 шт.', 128)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'5', N'Мыльные пузыри, слаймы', N'S500-20188', N'Crystal Slime, Голубой, 250 г.', 275)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'50', N'Банты', N'17825', N'Бант Звезда, Серебро, Металлик, 4 см, 10 шт.', 50)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'51', N'Банты', N'17814', N'Бант Звезда, Серебро, Металлик, 7 см, 12 шт.', 136)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'52', N'Банты', N'17803', N'Бант Звезда, Серебро/Черный, 7 см, 12 шт.', 128)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'54', N'Банты', N'17805', N'Бант Звезда, Синий микс, 5 см, 8 шт.', 84)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'55', N'Банты', N'17811', N'Бант Звезда, Сиреневый микс, 5 см, 25 шт.', 102)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'56', N'Банты', N'17823', N'Бант Звезда, Сиреневый, Металлик, 4 см, 10 шт.', 50)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'57', N'Банты', N'17807', N'Бант Звезда, Солнечный микс, 5 см, 8 шт.', 84)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'6', N'Мыльные пузыри, слаймы', N'S500-20181', N'Crystal Slime, Розовый, 250 г.', 275)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'60', N'Банты', N'092Б', N'Бант Органза, Микс дизайнов, Ассорти, 10 см, 1 шт.', 82)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'61', N'Банты', N'БР-01', N'Бант Роза, Ассорти, 3 см, 200 шт.', 963)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'65', N'Банты', N'661027', N'Бант Шар, Золото, Голография, 21 см, 1 шт.', 76)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'66', N'Банты', N'661029', N'Бант Шар, Золото, Голография, 36 см, 1 шт.', 302)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'67', N'Банты', N'661015', N'Бант Шар, Золото, Металлик, 21 см, 1 шт.', 58)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'68', N'Банты', N'661011', N'Бант Шар, Золото, Металлик, 36 см, 1 шт.', 852)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'69', N'Банты', N'661021', N'Бант Шар, Золото, Металлик, 36 см, 1 шт.', 252)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'70', N'Банты', N'661018', N'Бант Шар, Красный, Металлик, 21 см, 1 шт.', 58)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'71', N'Банты', N'661024', N'Бант Шар, Красный, Металлик, 36 см, 1 шт.', 252)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'72', N'Банты', N'661019', N'Бант Шар, Розовый, Металлик, 21 см, 1 шт.', 58)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'73', N'Банты', N'661025', N'Бант Шар, Розовый, Металлик, 36 см, 1 шт.', 252)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'74', N'Банты', N'661026', N'Бант Шар, Серебро, Голография, 21 см, 1 шт.', 76)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'75', N'Банты', N'661028', N'Бант Шар, Серебро, Голография, 36 см, 1 шт.', 302)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'76', N'Банты', N'661014', N'Бант Шар, Серебро, Металлик, 21 см, 1 шт.', 58)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'77', N'Банты', N'661012', N'Бант Шар, Серебро, Металлик, 36 см, 1 шт.', 852)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'78', N'Банты', N'661020', N'Бант Шар, Серебро, Металлик, 36 см, 1 шт.', 252)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'79', N'Банты', N'661016', N'Бант Шар, Синий, Металлик, 21 см, 1 шт.', 58)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'8', N'Карнавальная косметика', N'К3238', N'Аквагрим Гранат, карандаш 15 г', 110)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'80', N'Банты', N'661022', N'Бант Шар, Синий, Металлик, 36 см, 1 шт.', 252)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'81', N'Банты', N'661017', N'Бант Шар, Фуше, Металлик, 21 см, 1 шт.', 58)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'82', N'Банты', N'661023', N'Бант Шар, Фуше, Металлик, 36 см, 1 шт.', 252)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'83', N'Оформительское оборудование', N'KOCR6', N'Батарейки Космос AA 1.5V, 4 шт', 62)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'84', N'Бенгальские огни и фонтаны', N'ТР151', N'Бенгальский огонь 180 сек, 40 см, 3 шт.', 208)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'85', N'Бенгальские огни и фонтаны', N'ТР154', N'Бенгальский огонь 240 сек, 60 см, 3 шт.', 301)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'86', N'Бенгальские огни и фонтаны', N'0977', N'Бенгальский огонь 30 сек, 16 см, 10 шт.', 29)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'87', N'Бенгальские огни и фонтаны', N'ТР165', N'Бенгальский огонь 30 сек, 16 см, 6 шт.', 44)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'88', N'Бенгальские огни и фонтаны', N'ТР155', N'Бенгальский огонь 30 сек, 17 см, 6 шт.', 29)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'89', N'Бенгальские огни и фонтаны', N'ТР160', N'Бенгальский огонь 30 сек, Ассорти, 21 см, 6 шт.', 58)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'9', N'Карнавальная косметика', N'К3221', N'Аквагрим Желтый, карандаш 15 г', 94)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'90', N'Бенгальские огни и фонтаны', N'ПР007010', N'Бенгальский огонь 40 сек, 17 см, 10 шт.', 49)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'91', N'Бенгальские огни и фонтаны', N'0978', N'Бенгальский огонь 60 сек, 25 см, 8 шт.', 48)
GO
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'92', N'Бенгальские огни и фонтаны', N'0784S', N'Бенгальский огонь Звезда, 30 сек, 16 см, 2 шт.', 98)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'93', N'Бенгальские огни и фонтаны', N'ТР161', N'Бенгальский огонь Звезда, 30 сек, 18 см, 2 шт.', 84)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'95', N'Бенгальские огни и фонтаны', N'0784E', N'Бенгальский огонь Сердце, 30 сек, 16 см, 2 шт.', 98)
INSERT [dbo].[ProductNew] ([ID], [Тип], [Артикул], [Название], [Цена]) VALUES (N'96', N'Бенгальские огни и фонтаны', N'ТР162', N'Бенгальский огонь Сердце, 30 сек, 18 см, 2 шт.', 91)
GO
INSERT [dbo].[Users] ([Login], [Psw], [Role], [Name]) VALUES (N'admin', N'admin', N'admin', N'admin')
INSERT [dbo].[Users] ([Login], [Psw], [Role], [Name]) VALUES (N'ewq', N'ewqewqew', N'Директор', N'ewq')
INSERT [dbo].[Users] ([Login], [Psw], [Role], [Name]) VALUES (N'qwe', N'22222222', N'Менеджер', N'qwe')
INSERT [dbo].[Users] ([Login], [Psw], [Role], [Name]) VALUES (N'User', N'w9pw8shc', N'Пользователь', N'Кабаргин Иван Алексеевич')
INSERT [dbo].[Users] ([Login], [Psw], [Role], [Name]) VALUES (N'User2', N'w9pw8shc', N'Пользователь', N'Антипов Алексей Сергеевич')
INSERT [dbo].[Users] ([Login], [Psw], [Role], [Name]) VALUES (N'User3', N'w9pw8shc', N'Пользователь', N'Трофимова Александра Николаевна')
INSERT [dbo].[Users] ([Login], [Psw], [Role], [Name]) VALUES (N'Андраникова Светлана Викторовна', N'00000000', N'Пользователь', N'Андраникова Светлана Викторовна')
GO
USE [master]
GO
ALTER DATABASE [Sample] SET  READ_WRITE 
GO
