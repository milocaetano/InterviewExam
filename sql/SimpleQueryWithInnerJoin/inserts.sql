USE [InterviewExam]
GO

INSERT INTO [dbo].[Customers]
           ([FirstName]
           ,[LastName]
           ,[Age]
           ,[Occupation])
     VALUES
           ('CAMILO'
           ,'CAETANO'
           ,32
           ,'Software Engineer')
GO

INSERT INTO [dbo].[Orders]
           ([PersonID]
           ,[DateCreated]
           ,[MethodofPurchase])
     VALUES
           (1
           ,getdate()
           ,'methodx')

GO

INSERT INTO [dbo].[OrderDetails]
           ([PersonID]
           ,[OrderId]
           ,[ProductNumber]
           ,[ProductOrigin]
           ,[ProductID])
     VALUES
           (1
           ,1
           ,99
           ,'WEB'
           ,1112222333
           )