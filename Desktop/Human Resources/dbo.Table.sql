CREATE TABLE [dbo].[Table]
(
	[Name] NVARCHAR(50) NOT NULL, 
    [Phone Number] NCHAR(11) NOT NULL,	
    [Hours of Duty] TINYINT NOT NULL CHECK ([Hours of Duty] IN (4, 5, 6, 8)),
	[Position] NVARCHAR(20) NOT NULL CHECK ([Position] IN ('Doctor', 'Nurse', 'Medical Staff', 'Others')),
	[Status] NVARCHAR(10) NOT NULL CHECK ([Status] IN ('Online', 'Offline', 'Suspended', 'Fired')),
)
