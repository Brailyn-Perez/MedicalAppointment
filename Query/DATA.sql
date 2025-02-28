--1
INSERT INTO Insurance.NetworkType (Name , Description , CreatedAt , UpdatedAt , IsActive) VALUES
('name example', 'Description Example', GETDATE(),null,1)
GO
--2
INSERT INTO [Insurance].[InsuranceProviders] 
( [Name], [ContactNumber], [Email], [Website], [Address], [City], [State], [Country], [ZipCode], [CoverageDetails], [LogoUrl], [IsPreferred], [NetworkTypeId], [CustomerSupportContact], [AcceptedRegions], [MaxCoverageAmount], [CreatedAt], [UpdatedAt], [IsActive])
VALUES
( N'HealthPlus', '555-1111', 'contact@healthplus.com', 'www.healthplus.com', '123 Health St', 'City', 'State', 'Country', '12345', 'Full coverage for heart conditions and general health', NULL, 1, 1, '555-4444', 'USA, Canada', 50000.00, CAST(N'2024-09-08T19:27:48.583' AS DateTime), NULL, 1),
( N'LifeCare', '555-2222', 'support@lifecare.com', 'www.lifecare.com', '456 Care Blvd', 'City', 'State', 'Country', '67890', 'Coverage for major diseases and treatments', NULL, 0, 2, '555-5555', 'USA, Mexico', 100000.00, CAST(N'2024-09-08T19:27:48.583' AS DateTime), NULL, 1)
GO

--3
INSERT INTO [system].[Roles] ([RoleName], [CreatedAt], [UpdatedAt], [IsActive]) 
VALUES
( N'Admin', CAST(N'2024-09-15T18:41:53.063' AS DateTime), NULL, 1),
( N'Doctor', CAST(N'2024-09-15T18:41:53.063' AS DateTime), NULL, 1),
( N'Patient', CAST(N'2024-09-15T18:41:53.063' AS DateTime), NULL, 1)
GO

--4
INSERT INTO [users].[Users] (FirstName,LastName,Email,Password,RoleID,CreatedAt,UpdatedAt,IsActive) VALUES
('Brailyn','Perez','Brailyn@gmail.com','607012520',1,GETDATE(),null,1)

--5
INSERT INTO [users].[Patients] 
([PatientID], [DateOfBirth], [Gender], [PhoneNumber], [Address], [EmergencyContactName], [EmergencyContactPhone], [BloodType], [Allergies], [InsuranceProviderID], [CreatedAt], [UpdatedAt], [IsActive])
VALUES
(1,'1990-04-10', 'M', '555-9999', '789 Main St, City', 'Jane Doe', '555-2222', 'O+', 'None', 1, CAST(N'2024-09-08T19:27:48.583' AS DateTime), NULL, 1)
GO


--6
INSERT INTO [system].[Status] (StatusName) VALUES 
('Scheduled'), ('Completed'), ('Cancelled'), ('Rescheduled');

--7
INSERT INTO [medical].[Specialties] ( [SpecialtyName], [CreatedAt], [UpdatedAt], [IsActive]) 
VALUES
( N'Cardiología', CAST(N'2024-09-08T19:27:48.583' AS DateTime), CAST(N'2024-09-08T19:27:48.583' AS DateTime), 1),
( N'Dermatología', CAST(N'2024-09-08T19:27:48.583' AS DateTime), CAST(N'2024-09-08T19:27:48.583' AS DateTime), 1),
( N'Gastroenterología', CAST(N'2024-09-08T19:27:48.583' AS DateTime), CAST(N'2024-09-08T19:27:48.583' AS DateTime), 1),
( N'Neurología', CAST(N'2024-09-08T19:27:48.583' AS DateTime), CAST(N'2024-09-08T19:27:48.583' AS DateTime), 1),
( N'Pediatría', CAST(N'2024-09-08T19:27:48.583' AS DateTime), CAST(N'2024-09-08T19:27:48.583' AS DateTime), 1),
( N'Psiquiatría', CAST(N'2024-09-08T19:27:48.583' AS DateTime), CAST(N'2024-09-08T19:27:48.583' AS DateTime), 1),
( N'Ortopedia', CAST(N'2024-09-08T19:27:48.583' AS DateTime), CAST(N'2024-09-08T19:27:48.583' AS DateTime), 1),
( N'Ginecología', CAST(N'2024-09-08T19:27:48.583' AS DateTime), CAST(N'2024-09-08T19:27:48.583' AS DateTime), 1)
GO

--8
INSERT INTO [medical].[AvailabilityModes] (AvailabilityMode, CreatedAt, IsActive) VALUES 
('In-Person', GETDATE(), 1),
('Online', GETDATE(), 1);

--9
INSERT INTO [users].[Doctors] (DoctorID, SpecialtyID, LicenseNumber, PhoneNumber, YearsOfExperience, Education, Bio, ConsultationFee, ClinicAddress, AvailabilityModeId, LicenseExpirationDate, CreatedAt, IsActive)
VALUES 
(1, 1, 'MD12345', '809-123-4567', 10, 'Harvard Medical School', 'Cardiologist with 10 years of experience.', 100.00, 'Av. Médica #123', 1, '2030-12-31', GETDATE(), 1)
GO

--10
INSERT INTO [appointments].[Appointments] (PatientID, DoctorID, AppointmentDate, StatusID, CreatedAt)
VALUES 
(1, 1, '2025-03-10 10:00:00', 1, GETDATE())
GO
