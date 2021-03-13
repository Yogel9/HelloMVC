SET IDENTITY_INSERT [dbo].[Movie] ON
INSERT INTO [dbo].[Movie] ([Id], [Title], [ReleaseDate], [Genre], [Price]) VALUES (1, N'Hot Go', N'2021-03-03 00:00:00', N'Action', CAST(23.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Movie] ([Id], [Title], [ReleaseDate], [Genre], [Price]) VALUES (2, N'Hot Go2', N'2021-03-24 00:00:00', N'Super Action', CAST(46.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Movie] ([Id], [Title], [ReleaseDate], [Genre], [Price]) VALUES (3, N'сАША 2', N'2021-03-28 00:00:00', N'Action', CAST(46.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Movie] OFF
