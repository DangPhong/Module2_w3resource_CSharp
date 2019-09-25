CREATE DATABASE datebaseFirst

CREATE TABLE [dbo].[tblEmployees](  
    [EmployeeID] [int] IDENTITY(1,1) NOT NULL,  
    [EmployeeName] [varchar](50) NULL,  
    [PhoneNumber] [varchar](50) NULL,  
    [SkillID] [int] null,  
    [YearsExperience] [int] null,  
PRIMARY KEY CLUSTERED   
(  
    [EmployeeID] ASC  
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  
) ON [PRIMARY] 

CREATE TABLE [dbo].[tblSkills](  
    [SkillID] [int] IDENTITY(1,1) NOT NULL,  
    [Title] [varchar](50) NULL,  
PRIMARY KEY CLUSTERED   
(  
    [SkillID] ASC  
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  
) ON [PRIMARY]  

insert into tblSkills
(Title) values('Visual Foxpro')
insert into tblSkills
(Title) values('C#')
insert into tblSkills
(Title) values('VB.NET')
insert into tblSkills
(Title) values('Delphi')
insert into tblSkills
(Title) values('Java')
insert into tblSkills
(Title) values('Power Builder')
insert into tblSkills
(Title) values('COBOL')
insert into tblSkills
(Title) values('Python')
---------------------------
Insert Into tblEmployees
(EmployeeName,PhoneNumber,SkillID,YearsExperience)
values ('Suhana Kalla','9869569634',2,'11')
Insert Into tblEmployees
(EmployeeName,PhoneNumber,SkillID,YearsExperience)
values ('Ashish Kalla','9869166077',8,'14')
Insert Into tblEmployees
(EmployeeName,PhoneNumber,SkillID,YearsExperience)
values ('Manoj Kalla','9869569634',1,'24')
Insert Into tblEmployees
(EmployeeName,PhoneNumber,SkillID,YearsExperience)
values ('Nirupama Kalla','9969359746',6,'20')
Insert Into tblEmployees
(EmployeeName,PhoneNumber,SkillID,YearsExperience)
values ('Rajesh Bohra','9869166012',7,'28')
Insert Into tblEmployees
(EmployeeName,PhoneNumber,SkillID,YearsExperience)
values ('Murli Vyas','9261166012',5,'18')