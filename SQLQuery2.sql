/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [Id]
      ,[message]
      ,[Date]
  FROM [notificationHubDB].[dbo].[notification_tbl]