CREATE DATABASE [MedicalAppointment]
GO
USE [MedicalAppointment]
GO
/****** Object:  Schema [appointments]    Script Date: 9/20/2024 9:13:26 PM ******/
CREATE SCHEMA [appointments]
GO
/****** Object:  Schema [Insurance]    Script Date: 9/20/2024 9:13:26 PM ******/
CREATE SCHEMA [Insurance]
GO
/****** Object:  Schema [medical]    Script Date: 9/20/2024 9:13:26 PM ******/
CREATE SCHEMA [medical]
GO
/****** Object:  Schema [system]    Script Date: 9/20/2024 9:13:26 PM ******/
CREATE SCHEMA [system]
GO
/****** Object:  Schema [users]    Script Date: 9/20/2024 9:13:26 PM ******/
CREATE SCHEMA [users]
GO
/****** Object:  Table [appointments].[Appointments]    Script Date: 9/20/2024 9:13:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [appointments].[Appointments](
	[AppointmentID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NOT NULL,
	[DoctorID] [int] NOT NULL,
	[AppointmentDate] [datetime] NOT NULL,
	[StatusID] [int] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NULL,
 CONSTRAINT [PK__Appointm__8ECDFCA291B4E736] PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [appointments].[DoctorAvailability]    Script Date: 9/20/2024 9:13:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [appointments].[DoctorAvailability](
	[AvailabilityID] [int] IDENTITY(1,1) NOT NULL,
	[DoctorID] [int] NOT NULL,
	[AvailableDate] [date] NOT NULL,
	[StartTime] [time](7) NOT NULL,
	[EndTime] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AvailabilityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Insurance].[InsuranceProviders]    Script Date: 9/20/2024 9:13:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Insurance].[InsuranceProviders](
	[InsuranceProviderID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[ContactNumber] [varchar](15) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Website] [varchar](255) NULL,
	[Address] [varchar](255) NOT NULL,
	[City] [varchar](100) NULL,
	[State] [varchar](100) NULL,
	[Country] [varchar](100) NULL,
	[ZipCode] [varchar](10) NULL,
	[CoverageDetails] [varchar](max) NOT NULL,
	[LogoUrl] [varchar](255) NULL,
	[IsPreferred] [bit] NOT NULL,
	[NetworkTypeId] [int] NOT NULL,
	[CustomerSupportContact] [varchar](15) NULL,
	[AcceptedRegions] [varchar](255) NULL,
	[MaxCoverageAmount] [decimal](10, 2) NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_InsuranceProviders] PRIMARY KEY CLUSTERED 
(
	[InsuranceProviderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Insurance].[NetworkType]    Script Date: 9/20/2024 9:13:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Insurance].[NetworkType](
	[NetworkTypeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](255) NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK__NetworkT__C09029EE538D704E] PRIMARY KEY CLUSTERED 
(
	[NetworkTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [medical].[AvailabilityModes]    Script Date: 9/20/2024 9:13:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [medical].[AvailabilityModes](
	[SAvailabilityModeID] [smallint] IDENTITY(1,1) NOT NULL,
	[AvailabilityMode] [varchar](100) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SAvailabilityModeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [medical].[MedicalRecords]    Script Date: 9/20/2024 9:13:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [medical].[MedicalRecords](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NOT NULL,
	[DoctorID] [int] NOT NULL,
	[Diagnosis] [text] NOT NULL,
	[Treatment] [text] NOT NULL,
	[DateOfVisit] [datetime] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NULL,
 CONSTRAINT [PK__MedicalR__FBDF78C96E650FFC] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [medical].[Specialties]    Script Date: 9/20/2024 9:13:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [medical].[Specialties](
	[SpecialtyID] [smallint] IDENTITY(1,1) NOT NULL,
	[SpecialtyName] [varchar](100) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SpecialtyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [system].[Notifications]    Script Date: 9/20/2024 9:13:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [system].[Notifications](
	[NotificationID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Message] [text] NOT NULL,
	[SentAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[NotificationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [system].[Roles]    Script Date: 9/20/2024 9:13:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [system].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](50) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [system].[Status]    Script Date: 9/20/2024 9:13:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [system].[Status](
	[StatusID] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [users].[Doctors]    Script Date: 9/20/2024 9:13:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [users].[Doctors](
	[DoctorID] [int] NOT NULL,
	[SpecialtyID] [smallint] NOT NULL,
	[LicenseNumber] [varchar](50) NOT NULL,
	[PhoneNumber] [varchar](15) NOT NULL,
	[YearsOfExperience] [int] NOT NULL,
	[Education] [nvarchar](max) NOT NULL,
	[Bio] [nvarchar](max) NULL,
	[ConsultationFee] [decimal](10, 2) NULL,
	[ClinicAddress] [varchar](255) NULL,
	[AvailabilityModeId] [smallint] NULL,
	[LicenseExpirationDate] [date] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK__Doctors__2DC00EDFCF31D9E9] PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [users].[Patients]    Script Date: 9/20/2024 9:13:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [users].[Patients](
	[PatientID] [int] NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Gender] [char](1) NOT NULL,
	[PhoneNumber] [varchar](15) NOT NULL,
	[Address] [varchar](255) NOT NULL,
	[EmergencyContactName] [varchar](100) NOT NULL,
	[EmergencyContactPhone] [varchar](15) NOT NULL,
	[BloodType] [char](2) NOT NULL,
	[Allergies] [nvarchar](max) NOT NULL,
	[InsuranceProviderID] [int] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK__Patients__970EC346B158B7FB] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [users].[Users]    Script Date: 9/20/2024 9:13:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [users].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[Password] [varchar](255) NOT NULL,
	[RoleID] [int] NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK__Users__1788CCACD6E62048] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [medical].[Specialties] ON 
GO
INSERT [medical].[Specialties] ([SpecialtyID], [SpecialtyName], [CreatedAt], [UpdatedAt], [IsActive]) VALUES (1, N'Cardiología', CAST(N'2024-09-08T19:27:48.583' AS DateTime), CAST(N'2024-09-08T19:27:48.583' AS DateTime), 1)
GO
INSERT [medical].[Specialties] ([SpecialtyID], [SpecialtyName], [CreatedAt], [UpdatedAt], [IsActive]) VALUES (2, N'Dermatología', CAST(N'2024-09-08T19:27:48.583' AS DateTime), CAST(N'2024-09-08T19:27:48.583' AS DateTime), 1)
GO
INSERT [medical].[Specialties] ([SpecialtyID], [SpecialtyName], [CreatedAt], [UpdatedAt], [IsActive]) VALUES (3, N'Gastroenterología', CAST(N'2024-09-08T19:27:48.583' AS DateTime), CAST(N'2024-09-08T19:27:48.583' AS DateTime), 1)
GO
INSERT [medical].[Specialties] ([SpecialtyID], [SpecialtyName], [CreatedAt], [UpdatedAt], [IsActive]) VALUES (4, N'Neurología', CAST(N'2024-09-08T19:27:48.583' AS DateTime), CAST(N'2024-09-08T19:27:48.583' AS DateTime), 1)
GO
INSERT [medical].[Specialties] ([SpecialtyID], [SpecialtyName], [CreatedAt], [UpdatedAt], [IsActive]) VALUES (5, N'Pediatría', CAST(N'2024-09-08T19:27:48.583' AS DateTime), CAST(N'2024-09-08T19:27:48.583' AS DateTime), 1)
GO
INSERT [medical].[Specialties] ([SpecialtyID], [SpecialtyName], [CreatedAt], [UpdatedAt], [IsActive]) VALUES (6, N'Psiquiatría', CAST(N'2024-09-08T19:27:48.583' AS DateTime), CAST(N'2024-09-08T19:27:48.583' AS DateTime), 1)
GO
INSERT [medical].[Specialties] ([SpecialtyID], [SpecialtyName], [CreatedAt], [UpdatedAt], [IsActive]) VALUES (7, N'Ortopedia', CAST(N'2024-09-08T19:27:48.583' AS DateTime), CAST(N'2024-09-08T19:27:48.583' AS DateTime), 1)
GO
INSERT [medical].[Specialties] ([SpecialtyID], [SpecialtyName], [CreatedAt], [UpdatedAt], [IsActive]) VALUES (8, N'Ginecología', CAST(N'2024-09-08T19:27:48.583' AS DateTime), CAST(N'2024-09-08T19:27:48.583' AS DateTime), 1)
GO
SET IDENTITY_INSERT [medical].[Specialties] OFF
GO
SET IDENTITY_INSERT [system].[Roles] ON 
GO
INSERT [system].[Roles] ([RoleID], [RoleName], [CreatedAt], [UpdatedAt], [IsActive]) VALUES (1, N'Admin', CAST(N'2024-09-15T18:41:53.063' AS DateTime), NULL, 0)
GO
INSERT [system].[Roles] ([RoleID], [RoleName], [CreatedAt], [UpdatedAt], [IsActive]) VALUES (2, N'Doctor', CAST(N'2024-09-15T18:41:53.063' AS DateTime), NULL, 0)
GO
INSERT [system].[Roles] ([RoleID], [RoleName], [CreatedAt], [UpdatedAt], [IsActive]) VALUES (3, N'Patient', CAST(N'2024-09-15T18:41:53.063' AS DateTime), NULL, 0)
GO
SET IDENTITY_INSERT [system].[Roles] OFF
GO
SET IDENTITY_INSERT [system].[Status] ON 
GO
INSERT [system].[Status] ([StatusID], [StatusName]) VALUES (2, N'Cancelled')
GO
INSERT [system].[Status] ([StatusID], [StatusName]) VALUES (3, N'Completed')
GO
INSERT [system].[Status] ([StatusID], [StatusName]) VALUES (1, N'Scheduled')
GO
SET IDENTITY_INSERT [system].[Status] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Availabi__8598C850C8668528]    Script Date: 9/20/2024 9:13:26 PM ******/
ALTER TABLE [medical].[AvailabilityModes] ADD UNIQUE NONCLUSTERED 
(
	[AvailabilityMode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Specialt__7DCA574819B86867]    Script Date: 9/20/2024 9:13:26 PM ******/
ALTER TABLE [medical].[Specialties] ADD UNIQUE NONCLUSTERED 
(
	[SpecialtyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Roles__8A2B616031A17511]    Script Date: 9/20/2024 9:13:26 PM ******/
ALTER TABLE [system].[Roles] ADD UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Status__05E7698A8F4FA226]    Script Date: 9/20/2024 9:13:26 PM ******/
ALTER TABLE [system].[Status] ADD UNIQUE NONCLUSTERED 
(
	[StatusName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__A9D10534B973B1BC]    Script Date: 9/20/2024 9:13:26 PM ******/
ALTER TABLE [users].[Users] ADD  CONSTRAINT [UQ__Users__A9D10534B973B1BC] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [appointments].[Appointments] ADD  CONSTRAINT [DF__Appointme__Creat__5165187F]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [appointments].[Appointments] ADD  CONSTRAINT [DF__Appointme__Updat__52593CB8]  DEFAULT (getdate()) FOR [UpdatedAt]
GO
ALTER TABLE [Insurance].[InsuranceProviders] ADD  CONSTRAINT [DF__Insurance__IsPre__2BFE89A6]  DEFAULT ((0)) FOR [IsPreferred]
GO
ALTER TABLE [Insurance].[InsuranceProviders] ADD  CONSTRAINT [DF__Insurance__Creat__2CF2ADDF]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [Insurance].[InsuranceProviders] ADD  CONSTRAINT [DF__Insurance__IsAct__2DE6D218]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [Insurance].[NetworkType] ADD  CONSTRAINT [DF__NetworkTy__Creat__29221CFB]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [Insurance].[NetworkType] ADD  CONSTRAINT [DF__NetworkTy__IsAct__2A164134]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [medical].[AvailabilityModes] ADD  CONSTRAINT [DF_AvailabilityModes_CreatedAt]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [medical].[AvailabilityModes] ADD  CONSTRAINT [DF_AvailabilityModes_UpdatedAt]  DEFAULT (getdate()) FOR [UpdatedAt]
GO
ALTER TABLE [medical].[AvailabilityModes] ADD  CONSTRAINT [DF_AvailabilityModes_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [medical].[MedicalRecords] ADD  CONSTRAINT [DF__MedicalRe__Creat__5CD6CB2B]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [medical].[MedicalRecords] ADD  CONSTRAINT [DF__MedicalRe__Updat__5DCAEF64]  DEFAULT (getdate()) FOR [UpdatedAt]
GO
ALTER TABLE [medical].[Specialties] ADD  CONSTRAINT [DF_Specialties_CreatedAt]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [medical].[Specialties] ADD  CONSTRAINT [DF_Specialties_UpdatedAt]  DEFAULT (getdate()) FOR [UpdatedAt]
GO
ALTER TABLE [medical].[Specialties] ADD  CONSTRAINT [DF_Specialties_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [system].[Notifications] ADD  DEFAULT (getdate()) FOR [SentAt]
GO
ALTER TABLE [system].[Roles] ADD  CONSTRAINT [DF_Roles_CreatedAt]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [system].[Roles] ADD  CONSTRAINT [DF_Roles_UpdatedAt]  DEFAULT (getdate()) FOR [UpdatedAt]
GO
ALTER TABLE [system].[Roles] ADD  CONSTRAINT [DF_Roles_IsActive]  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [users].[Doctors] ADD  CONSTRAINT [DF_Doctors_CreatedAt]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [users].[Doctors] ADD  CONSTRAINT [DF_Doctors_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [users].[Patients] ADD  CONSTRAINT [DF_Patients_CreatedAt]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [users].[Patients] ADD  CONSTRAINT [DF_Patients_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [users].[Users] ADD  CONSTRAINT [DF__Users__CreatedAt__412EB0B6]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [users].[Users] ADD  CONSTRAINT [DF__Users__UpdatedAt__4222D4EF]  DEFAULT (getdate()) FOR [UpdatedAt]
GO
ALTER TABLE [users].[Users] ADD  CONSTRAINT [DF_Users_IsActive]  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [appointments].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Doctor] FOREIGN KEY([DoctorID])
REFERENCES [users].[Doctors] ([DoctorID])
GO
ALTER TABLE [appointments].[Appointments] CHECK CONSTRAINT [FK_Appointments_Doctor]
GO
ALTER TABLE [appointments].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Patient] FOREIGN KEY([PatientID])
REFERENCES [users].[Patients] ([PatientID])
GO
ALTER TABLE [appointments].[Appointments] CHECK CONSTRAINT [FK_Appointments_Patient]
GO
ALTER TABLE [appointments].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Status] FOREIGN KEY([StatusID])
REFERENCES [system].[Status] ([StatusID])
GO
ALTER TABLE [appointments].[Appointments] CHECK CONSTRAINT [FK_Appointments_Status]
GO
ALTER TABLE [appointments].[DoctorAvailability]  WITH CHECK ADD  CONSTRAINT [FK__DoctorAva__Docto__5535A963] FOREIGN KEY([DoctorID])
REFERENCES [users].[Doctors] ([DoctorID])
ON DELETE CASCADE
GO
ALTER TABLE [appointments].[DoctorAvailability] CHECK CONSTRAINT [FK__DoctorAva__Docto__5535A963]
GO
ALTER TABLE [Insurance].[InsuranceProviders]  WITH CHECK ADD  CONSTRAINT [FK_InsuranceProviders_NetworkType] FOREIGN KEY([NetworkTypeId])
REFERENCES [Insurance].[NetworkType] ([NetworkTypeId])
GO
ALTER TABLE [Insurance].[InsuranceProviders] CHECK CONSTRAINT [FK_InsuranceProviders_NetworkType]
GO
ALTER TABLE [medical].[MedicalRecords]  WITH CHECK ADD  CONSTRAINT [FK_MedicalRecords_Doctor] FOREIGN KEY([DoctorID])
REFERENCES [users].[Doctors] ([DoctorID])
GO
ALTER TABLE [medical].[MedicalRecords] CHECK CONSTRAINT [FK_MedicalRecords_Doctor]
GO
ALTER TABLE [medical].[MedicalRecords]  WITH CHECK ADD  CONSTRAINT [FK_MedicalRecords_Patient] FOREIGN KEY([PatientID])
REFERENCES [users].[Patients] ([PatientID])
GO
ALTER TABLE [medical].[MedicalRecords] CHECK CONSTRAINT [FK_MedicalRecords_Patient]
GO
ALTER TABLE [system].[Notifications]  WITH CHECK ADD  CONSTRAINT [FK__Notificat__UserI__619B8048] FOREIGN KEY([UserID])
REFERENCES [users].[Users] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [system].[Notifications] CHECK CONSTRAINT [FK__Notificat__UserI__619B8048]
GO
ALTER TABLE [users].[Doctors]  WITH CHECK ADD  CONSTRAINT [FK__Doctors__DoctorI__45F365D3] FOREIGN KEY([DoctorID])
REFERENCES [users].[Users] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [users].[Doctors] CHECK CONSTRAINT [FK__Doctors__DoctorI__45F365D3]
GO
ALTER TABLE [users].[Doctors]  WITH CHECK ADD  CONSTRAINT [FK_Doctors_AvailabilityMode] FOREIGN KEY([AvailabilityModeId])
REFERENCES [medical].[AvailabilityModes] ([SAvailabilityModeID])
GO
ALTER TABLE [users].[Doctors] CHECK CONSTRAINT [FK_Doctors_AvailabilityMode]
GO
ALTER TABLE [users].[Doctors]  WITH CHECK ADD  CONSTRAINT [FK_Doctors_Speciality] FOREIGN KEY([SpecialtyID])
REFERENCES [medical].[Specialties] ([SpecialtyID])
GO
ALTER TABLE [users].[Doctors] CHECK CONSTRAINT [FK_Doctors_Speciality]
GO
ALTER TABLE [users].[Patients]  WITH CHECK ADD  CONSTRAINT [FK__Patients__Patien__48CFD27E] FOREIGN KEY([PatientID])
REFERENCES [users].[Users] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [users].[Patients] CHECK CONSTRAINT [FK__Patients__Patien__48CFD27E]
GO
ALTER TABLE [users].[Patients]  WITH CHECK ADD  CONSTRAINT [FK_Patients_InsuranceProvider] FOREIGN KEY([InsuranceProviderID])
REFERENCES [Insurance].[InsuranceProviders] ([InsuranceProviderID])
GO
ALTER TABLE [users].[Patients] CHECK CONSTRAINT [FK_Patients_InsuranceProvider]
GO
ALTER TABLE [users].[Users]  WITH CHECK ADD  CONSTRAINT [FK__Users__RoleID__4316F928] FOREIGN KEY([RoleID])
REFERENCES [system].[Roles] ([RoleID])
GO
ALTER TABLE [users].[Users] CHECK CONSTRAINT [FK__Users__RoleID__4316F928]
GO