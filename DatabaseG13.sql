/* =======================================================
   DatabaseG13.sql
   Group 13 - Wellmeadows Hospital Database
   ======================================================= */


-- =============================================
-- Source File: สร้างฐานข้อมูล.sql
-- =============================================

USE master;
GO
CREATE DATABASE [DataDictionary]
ON PRIMARY
(
  NAME = DataDictionary_Data,
  FILENAME = 'C:\B6601218.71\DataDictionary.mdf',
  SIZE = 20MB, FILEGROWTH = 10MB
)
LOG ON
(
  NAME = DataDictionary_Log,
  FILENAME = 'C:\B6601218.71\DataDictionary_log.ldf',
  SIZE = 10MB, FILEGROWTH = 10MB
);
GO

USE DataDictionary;
GO
GO


-- =============================================
-- Source File: สร้างตารางแม่+ข้อมูล.sql
-- =============================================

﻿USE DataDictionary;
GO

-- 1) Staff
CREATE TABLE dbo.Staff (
  S_ID             INT           NOT NULL PRIMARY KEY,
  S_Address        NVARCHAR(200) NOT NULL,
  Sex              CHAR(1)       NOT NULL,
  S_Position       NVARCHAR(50)  NOT NULL,
  S_Qualification  NVARCHAR(100) NOT NULL,
  ChargeNurse      CHAR(1)       NOT NULL,
  S_WorkExperience INT           NOT NULL,
  S_Surname        NVARCHAR(50)  NOT NULL,
  S_Name           NVARCHAR(50)  NOT NULL,
  S_Birth          DATE          NOT NULL,
  NIN              VARCHAR(20)   NOT NULL,
  S_Tel            VARCHAR(15)   NOT NULL,
  S_ContractType   NVARCHAR(30)  NOT NULL
);

-- 2) Supplier
CREATE TABLE dbo.Supplier (
  SU_ID      INT            NOT NULL PRIMARY KEY,
  SP_Address NVARCHAR(200)  NOT NULL,
  SP_Name    NVARCHAR(100)  NOT NULL,
  SU_Name    NVARCHAR(100)  NOT NULL,
  SU_Tel     VARCHAR(15)    NOT NULL
);

-- 3) Patient
CREATE TABLE dbo.Patient (
  P_ID             INT           NOT NULL PRIMARY KEY,
  P_Name           NVARCHAR(50)  NOT NULL,
  P_Surname        NVARCHAR(50)  NOT NULL,
  P_Birth          DATE          NOT NULL,
  Sex              CHAR(1)       NOT NULL,
  E_ContractID     INT           NULL,
  RegistrationDate DATE          NOT NULL,
  P_Address        NVARCHAR(200) NOT NULL,
  P_ZipCode        VARCHAR(10)   NOT NULL,
  P_Tel            VARCHAR(15)   NOT NULL,
  P_Status         NVARCHAR(20)  NOT NULL
);

-- 4) Ward
CREATE TABLE dbo.Ward (
  W_ID      INT           NOT NULL PRIMARY KEY,
  W_Tel     VARCHAR(15)   NOT NULL,
  Bed_Count INT           NOT NULL,
  W_Name    NVARCHAR(50)  NOT NULL,
  S_ID      INT           NOT NULL,
  B_ID      INT           NULL,
  CONSTRAINT FK_Ward_Staff FOREIGN KEY (S_ID) REFERENCES dbo.Staff(S_ID)
);

-- 5) Bed
CREATE TABLE dbo.Bed (
  B_ID        INT           NOT NULL PRIMARY KEY,
  B_Status    NVARCHAR(20)  NOT NULL,
  Bed_Number  NVARCHAR(10)  NOT NULL,
  Room_Number NVARCHAR(10)  NOT NULL,
  W_ID        INT           NOT NULL,
  CONSTRAINT FK_Bed_Ward FOREIGN KEY (W_ID) REFERENCES dbo.Ward(W_ID)
);
GO

-- 1. Staff
INSERT INTO dbo.Staff VALUES
(1001, N'1/1 โคราช', 'M', N'แพทย์ทั่วไป', N'เวชศาสตร์', '0', 5, N'ใจดี', N'เกรียงไกร', '1980-01-01', '900000000001', '0890000001', N'Full-time'),
(1002, N'2/2 ขอนแก่น', 'F', N'พยาบาล', N'พยาบาลศาสตร์', '1', 4, N'สวยดี', N'รัตนา', '1985-02-02', '900000000002', '0890000002', N'Contract'),
(1003, N'3/3 อุดร', 'M', N'เภสัชกร', N'เภสัชศาสตร์', '0', 3, N'ดีใจ', N'สมพงษ์', '1988-03-03', '900000000003', '0890000003', N'Full-time'),
(1004, N'4/4 อุบล', 'F', N'ผู้ช่วยแพทย์', N'อนุปริญญาแพทย์', '0', 2, N'ทองคำ', N'วิภา', '1992-04-04', '900000000004', '0890000004', N'Part-time'),
(1005, N'5/5 สงขลา', 'M', N'ธุรการ', N'บริหารธุรกิจ', '0', 1, N'บุญมาก', N'ไชยา', '1990-05-05', '900000000005', '0890000005', N'Contract'),
(1006, N'6/6 ระยอง', 'F', N'นักกายภาพ', N'กายภาพบำบัด', '0', 4, N'งามเลิศ', N'ณัฐธิดา', '1989-06-06', '900000000006', '0890000006', N'Full-time'),
(1007, N'7/7 แพร่', 'M', N'รังสีเทคนิค', N'รังสีเทคนิค', '0', 3, N'วัฒนสุข', N'เดชา', '1987-07-07', '900000000007', '0890000007', N'Full-time'),
(1008, N'8/8 ตรัง', 'F', N'พยาบาล', N'พยาบาลศาสตร์', '1', 2, N'รุ่งเรือง', N'สุชาดา', '1983-08-08', '900000000008', '0890000008', N'Contract'),
(1009, N'9/9 ลำปาง', 'M', N'หมอเฉพาะทาง', N'อายุรศาสตร์', '0', 5, N'ใจดี', N'อนันต์', '1975-09-09', '900000000009', '0890000009', N'Full-time'),
(1010, N'10/10 เชียงใหม่', 'F', N'พยาบาล', N'พยาบาลศาสตร์', '1', 4, N'สุขดี', N'พิมพ์ใจ', '1991-10-10', '900000000010', '0890000010', N'Contract');

-- 2. Ward
INSERT INTO dbo.Ward VALUES
(2001, '0442001', 10, N'Ward A', 1001, NULL),
(2002, '0442002', 12, N'Ward B', 1002, NULL),
(2003, '0442003', 8,  N'Ward C', 1003, NULL),
(2004, '0442004', 15, N'Ward D', 1004, NULL),
(2005, '0442005', 20, N'Ward E', 1005, NULL),
(2006, '0442006', 18, N'Ward F', 1006, NULL),
(2007, '0442007', 14, N'Ward G', 1007, NULL),
(2008, '0442008', 16, N'Ward H', 1008, NULL),
(2009, '0442009', 9,  N'Ward I', 1009, NULL),
(2010, '0442010', 11, N'Ward J', 1010, NULL);

-- Update B_ID for Ward
UPDATE dbo.Ward SET B_ID = 3001 WHERE W_ID = 2001;
UPDATE dbo.Ward SET B_ID = 3002 WHERE W_ID = 2002;
UPDATE dbo.Ward SET B_ID = 3003 WHERE W_ID = 2003;
UPDATE dbo.Ward SET B_ID = 3004 WHERE W_ID = 2004;
UPDATE dbo.Ward SET B_ID = 3005 WHERE W_ID = 2005;
UPDATE dbo.Ward SET B_ID = 3006 WHERE W_ID = 2006;
UPDATE dbo.Ward SET B_ID = 3007 WHERE W_ID = 2007;
UPDATE dbo.Ward SET B_ID = 3008 WHERE W_ID = 2008;
UPDATE dbo.Ward SET B_ID = 3009 WHERE W_ID = 2009;
UPDATE dbo.Ward SET B_ID = 3010 WHERE W_ID = 2010;

-- 3. Bed
INSERT INTO dbo.Bed VALUES
(3001, N'Available', 'A01', '101', 2001),
(3002, N'Occupied',  'A02', '102', 2002),
(3003, N'Available', 'A03', '103', 2003),
(3004, N'Maintenance','A04','104', 2004),
(3005, N'Available', 'A05', '105', 2005),
(3006, N'Occupied',  'A06', '106', 2006),
(3007, N'Available', 'A07', '107', 2007),
(3008, N'Available', 'A08', '108', 2008),
(3009, N'Occupied',  'A09', '109', 2009),
(3010, N'Available', 'A10', '110', 2010);

-- 4. Patient
INSERT INTO dbo.Patient VALUES
(4001, N'พิมพ์ใจ', N'สุขดี', '1990-01-01', 'F', 5001, '2025-09-17', N'โคราช', '30000', '0812345601', N'In-Patient'),
(4002, N'ดารา', N'สวยงาม', '1991-02-02', 'F', 5002, '2025-09-17', N'ขอนแก่น', '40000', '0812345602', N'Out-Patient'),
(4003, N'อนันต์', N'ใจดี', '1975-03-03', 'M', 5003, '2025-09-17', N'อุดร', '50000', '0812345603', N'In-Patient'),
(4004, N'มาลี', N'ทองแท้', '1985-04-04', 'F', 5004, '2025-09-17', N'อุบล', '60000', '0812345604', N'Out-Patient'),
(4005, N'ชูชาติ', N'บุญสุข', '1993-05-05', 'M', 5005, '2025-09-17', N'สงขลา', '70000', '0812345605', N'In-Patient'),
(4006, N'พรทิพย์', N'งามดี', '1999-06-06', 'F', 5006, '2025-09-17', N'ระยอง', '80000', '0812345606', N'Out-Patient'),
(4007, N'สุชาติ', N'ทองมี', '1978-07-07', 'M', 5007, '2025-09-17', N'แพร่', '90000', '0812345607', N'In-Patient'),
(4008, N'พิมพ์ใจ', N'สุขดี', '1988-08-08', 'F', 5008, '2025-09-17', N'ตรัง', '100000', '0812345608', N'Out-Patient'),
(4009, N'เกรียงไกร', N'ใจดี', '1980-09-09', 'M', 5009, '2025-09-17', N'ลำปาง', '110000', '0812345609', N'In-Patient'),
(4010, N'รัตนา', N'สวยดี', '1992-10-10', 'F', 5010, '2025-09-17', N'เชียงใหม่', '120000', '0812345610', N'Out-Patient');

-- 5. EmergencyContact
INSERT INTO dbo.EmergencyContact VALUES
(5001, N'สมชาย', N'ใจดี', N'พ่อ', N'โคราช', '0811111111', '30000', 4001),
(5002, N'สมหญิง', N'สวยงาม', N'แม่', N'ขอนแก่น', '0822222222', '40000', 4002),
(5003, N'อนันต์', N'ดีใจ', N'พ่อ', N'อุดร', '0833333333', '50000', 4003),
(5004, N'มาลี', N'ทองแท้', N'แม่', N'อุบล', '0844444444', '60000', 4004),
(5005, N'ชูชาติ', N'บุญสุข', N'พ่อ', N'สงขลา', '0855555555', '70000', 4005),
(5006, N'พรทิพย์', N'งามดี', N'แม่', 'ระยอง', '0866666666', '80000', 4006),
(5007, N'สุชาติ', N'ทองมี', N'พ่อ', N'แพร่', '0877777777', '90000', 4007),
(5008, N'พิมพ์ใจ', N'สุขดี', N'แม่', N'ตรัง', '0888888888', '10000', 4008),
(5009, N'เกรียงไกร', N'ใจดี', N'พ่อ', N'ลำปาง', '0899999999', '11000', 4009),
(5010, N'รัตนา', N'สวยดี', N'แม่', N'เชียงใหม่', '0800000000', '12000', 4010);

-- 6. Supplies
INSERT INTO dbo.Supplies VALUES
(6001, N'Paracetamol', 500, N'ยาลดไข้', N'ยา', 7001),
(6002, N'Amoxicillin', 300, N'ยาฆ่าเชื้อ', N'ยา', 7002),
(6003, N'Face Shield', 200, N'หน้ากากพลาสติก', N'อุปกรณ์', 7003),
(6004, N'Gloves', 1000, N'ถุงมือยาง', N'อุปกรณ์', 7004),
(6005, N'Oxygen Tank', 50, N'ถังออกซิเจน', N'อุปกรณ์', 7005),
(6006, N'Metformin', 150, N'ยาลดน้ำตาล', N'ยา', 7006),
(6007, N'Atorvastatin', 120, N'ยาลดไขมัน', N'ยา', 7007),
(6008, N'Omeprazole', 180, N'ยาลดกรด', N'ยา', 7008),
(6009, N'Cotton', 2000, N'สำลี', N'เวชภัณฑ์', 7009),
(6010, N'Insulin', 100, N'ยาฉีดลดน้ำตาล', N'ยา', 7010);

-- 7. Supplier
INSERT INTO dbo.Supplier VALUES
(6001, N'123 ถ.สุขภาพ กรุงเทพฯ', N'ThaiMed Co.', N'Paracetamol', '021234567'),
(6002, N'456 ถ.รักษา ขอนแก่น', N'HealthPlus Ltd.', N'Amoxicillin', '043123456'),
(6003, N'789 ถ.ปลอดภัย อุดร', N'SafetyGear Inc.', N'Face Shield', '042345678'),
(6004, N'101 ถ.สะอาด อุบล', N'CleanCare Co.', N'Gloves', '045678901'),
(6005, N'202 ถ.หายใจ สงขลา', N'OxyLife Ltd.', N'Oxygen Tank', '074567890'),
(6006, N'303 ถ.เบาหวาน ระยอง', N'SugarFree Co.', N'Metformin', '038123456'),
(6007, N'404 ถ.ไขมัน แพร่', N'HeartCare Inc.', N'Atorvastatin', '054123456'),
(6008, N'505 ถ.กระเพาะ ตรัง', N'AcidAway Ltd.', N'Omeprazole', '075123456'),
(6009, N'606 ถ.แผล ลำปาง', N'CottonSoft Co.', N'Cotton', '054987654'),
(6010, N'707 ถ.อินซูลิน เชียงใหม่', N'InsuMed Co.', N'Insulin', '053123456');
GO


-- =============================================
-- Source File: สร้างตารางลูก+ข้อมูล.sql
-- =============================================

﻿USE DataDictionary;
SET NOCOUNT ON;
SET XACT_ABORT ON;
SET DATEFORMAT ymd;

BEGIN TRAN;


------------------------------------------------------------
-- 2) CREATE CHILD TABLES
------------------------------------------------------------

-- Work_Experience (ลูกของ Staff)
CREATE TABLE dbo.Work_Experience (
    Finish_Date       DATE          NULL,
    Start_Date        DATE          NOT NULL,
    S_Position        NVARCHAR(50)  NULL,
    OrganizationName  NVARCHAR(100) NULL,
    S_ID              INT           NOT NULL,
    CONSTRAINT PK_Work_Experience PRIMARY KEY (S_ID, Start_Date),
    CONSTRAINT FK_WorkExp_Staff FOREIGN KEY (S_ID) REFERENCES dbo.Staff(S_ID)
);

-- Waiting_List (ลูกของ Patient + Ward)
CREATE TABLE dbo.Waiting_List (
    Waiting_que  INT           NOT NULL PRIMARY KEY,
    Appt_Time    TIME(0)       NULL,
    Exam_Rm      NVARCHAR(20)  NULL,
    P_Surname    NVARCHAR(50)  NULL,
    Appt_Date    DATE          NULL,
    Status       NVARCHAR(20)  NULL,
    P_Name       NVARCHAR(50)  NULL,
    P_ID         INT           NOT NULL,
    W_ID         INT           NOT NULL,
    CONSTRAINT FK_Wait_Patient FOREIGN KEY (P_ID) REFERENCES dbo.Patient(P_ID),
    CONSTRAINT FK_Wait_Ward    FOREIGN KEY (W_ID) REFERENCES dbo.Ward(W_ID)
);

-- Staff_Contract (ลูกของ Staff) — แบบ B (Term = เดือน, มี Start/End)
CREATE TABLE dbo.Staff_Contract (
    Contract_Id   INT           NOT NULL PRIMARY KEY,
    Term          INT           NULL,            -- จำนวนเดือน
    Contract_type NVARCHAR(50)  NULL,
    S_ID          INT           NOT NULL,
    Start_Date    DATE          NULL,
    End_Date      DATE          NULL,
    CONSTRAINT FK_Contract_Staff  FOREIGN KEY (S_ID) REFERENCES dbo.Staff(S_ID),
    CONSTRAINT CK_StaffContract_DateRange CHECK (
      Start_Date IS NULL OR End_Date IS NULL OR End_Date >= Start_Date
    )
);

-- Shift (ลูกของ Staff + Ward)
CREATE TABLE dbo.Shift (
    SH_ID       INT           NOT NULL PRIMARY KEY,
    S_Position  NVARCHAR(50)  NULL,
    EndTime     TIME(0)       NULL,
    StartTime   TIME(0)       NULL,
    W_ID        INT           NOT NULL,
    S_ID        INT           NOT NULL,
    CONSTRAINT FK_Shift_Ward  FOREIGN KEY (W_ID) REFERENCES dbo.Ward(W_ID),
    CONSTRAINT FK_Shift_Staff FOREIGN KEY (S_ID) REFERENCES dbo.Staff(S_ID)
);

-- Requestion (ลูกของ Ward + Supplies)
CREATE TABLE dbo.Requestion (
    RQ_ID          INT           NOT NULL PRIMARY KEY,
    SU_ID          INT           NOT NULL,
    SU_name        NVARCHAR(50)  NULL,
    W_ID           INT           NOT NULL,
    SU_Description NVARCHAR(100) NULL,
    SU_Type        NVARCHAR(50)  NULL,
    Amount         INT           NULL,
    CONSTRAINT FK_Req_Ward   FOREIGN KEY (W_ID) REFERENCES dbo.Ward(W_ID),
    CONSTRAINT FK_Req_Supply FOREIGN KEY (SU_ID) REFERENCES dbo.Supplies(SU_ID)
);

-- Pharma_Supplies (ลูกของ Staff + Patient + Supplies)
CREATE TABLE dbo.Pharma_Supplies (
    Pharma_ID     INT           NOT NULL PRIMARY KEY,
    Start_Date    DATE          NULL,
    Finish_Date   DATE          NULL,
    Units_Per_Day INT           NULL,
    S_ID          INT           NOT NULL,
    SU_ID         INT           NOT NULL,
    P_ID          INT           NOT NULL,
    CONSTRAINT FK_Pharma_Staff   FOREIGN KEY (S_ID) REFERENCES dbo.Staff(S_ID),
    CONSTRAINT FK_Pharma_Supply  FOREIGN KEY (SU_ID) REFERENCES dbo.Supplies(SU_ID),
    CONSTRAINT FK_Pharma_Patient FOREIGN KEY (P_ID) REFERENCES dbo.Patient(P_ID)
);

-- Payroll (ลูกของ Staff)
CREATE TABLE dbo.Payroll (
    Pay_Method  NVARCHAR(30)  NULL,
    Pay_Date    DATE          NULL,
    Base_Salary DECIMAL(12,2) NULL,
    Overtime    DECIMAL(12,2) NULL,
    Bank_Number NVARCHAR(20)  NULL,
    Bank_Name   NVARCHAR(50)  NULL,
    S_ID        INT           NOT NULL,
    CONSTRAINT FK_Payroll_Staff FOREIGN KEY (S_ID) REFERENCES dbo.Staff(S_ID)
);

-- Patient_Medication (ลูกของ Staff + Patient + Supplies)
CREATE TABLE dbo.Patient_Medication (
    PM_ID      INT           NOT NULL PRIMARY KEY,
    Status     NVARCHAR(20)  NULL,
    Dosage     NVARCHAR(50)  NULL,
    Start_Date DATE          NULL,
    P_ID       INT           NOT NULL,
    S_ID       INT           NOT NULL,
    SU_ID      INT           NOT NULL,
    CONSTRAINT FK_PM_Patient FOREIGN KEY (P_ID) REFERENCES dbo.Patient(P_ID),
    CONSTRAINT FK_PM_Staff   FOREIGN KEY (S_ID) REFERENCES dbo.Staff(S_ID),
    CONSTRAINT FK_PM_Supply  FOREIGN KEY (SU_ID) REFERENCES dbo.Supplies(SU_ID)
);

-- Out_Patient (ลูกของ Patient)
CREATE TABLE dbo.Out_Patient (
    Out_ID     INT IDENTITY(1,1) PRIMARY KEY,
    Appt_Time  TIME(0)       NULL,
    Diagnosis  NVARCHAR(100) NULL,
    Appt_Date  DATE          NULL,
    P_ID       INT           NOT NULL,
    CONSTRAINT FK_Out_Patient FOREIGN KEY (P_ID) REFERENCES dbo.Patient(P_ID)
);

-- In_Patient (ลูกของ Patient + Ward)  (Bed_Number เก็บโค้ด ไม่ทำ FK)
CREATE TABLE dbo.In_Patient (
    In_ID          INT IDENTITY(1,1) PRIMARY KEY,
    waitlist_date  DATE          NULL,
    Room_Number    NVARCHAR(20)  NULL,
    Discharge_Date DATE          NULL,
    Expected_Stay  INT           NULL,
    Bed_Number     NVARCHAR(20)  NULL,
    Exp_Discharge  DATE          NULL,
    Admit_Date     DATE          NULL,
    W_ID           INT           NOT NULL,
    P_ID           INT           NOT NULL,
    CONSTRAINT FK_In_Ward    FOREIGN KEY (W_ID) REFERENCES dbo.Ward(W_ID),
    CONSTRAINT FK_In_Patient FOREIGN KEY (P_ID) REFERENCES dbo.Patient(P_ID)
);

-- Edu_Qual (ลูกของ Staff)
CREATE TABLE dbo.Edu_Qual (
    Qualification_Id INT           NOT NULL PRIMARY KEY,
    Institution      NVARCHAR(100) NULL,
    Date_Qual        DATE          NULL,
    Type_Qual        NVARCHAR(50)  NULL,
    S_ID             INT           NOT NULL,
    CONSTRAINT FK_Edu_Staff FOREIGN KEY (S_ID) REFERENCES dbo.Staff(S_ID)
);

------------------------------------------------------------
-- 3) INSERT SAMPLE DATA — 10 แถว/ตาราง
------------------------------------------------------------

-- 3.1 Work_Experience
INSERT INTO dbo.Work_Experience (Finish_Date, Start_Date, S_Position, OrganizationName, S_ID) VALUES
('2015-12-31','2010-01-01',N'Doctor',          N'Hospital A', 1001),
('2018-06-30','2012-01-01',N'Nurse',           N'Clinic B',   1002),
('2019-12-31','2011-03-01',N'Pharmacist',      N'Pharmacy C', 1003),
('2020-12-31','2013-05-01',N'Assistant',       N'Hospital D', 1004),
('2021-12-31','2014-01-01',N'Admin',           N'Office E',   1005),
('2022-12-31','2015-02-01',N'Physiotherapist', N'Clinic F',   1006),
('2023-12-31','2016-03-01',N'Radiology Tech',  N'Hospital G', 1007),
('2020-12-31','2012-01-01',N'Nurse',           N'Clinic H',   1008),
('2019-06-30','2010-01-01',N'Specialist',      N'Hospital I', 1009),
('2021-12-31','2015-01-01',N'Nurse',           N'Hospital J', 1010);

-- 3.2 Waiting_List
INSERT INTO dbo.Waiting_List (Waiting_que, Appt_Time, Exam_Rm, P_Surname, Appt_Date, Status, P_Name, P_ID, W_ID) VALUES
(1 ,'09:00',N'101',N'สุขดี','2025-09-17',N'Pending',N'พิมพ์ใจ',4001,2001),
(2 ,'09:30',N'102',N'สวยงาม','2025-09-17',N'Pending',N'ดารา',  4002,2002),
(3 ,'10:00',N'103',N'ใจดี','2025-09-17',N'Pending',N'อนันต์',  4003,2003),
(4 ,'10:30',N'104',N'ทองแท้','2025-09-17',N'Pending',N'มาลี',   4004,2004),
(5 ,'11:00',N'105',N'บุญสุข','2025-09-17',N'Pending',N'ชูชาติ', 4005,2005),
(6 ,'11:30',N'106',N'งามดี','2025-09-17',N'Pending',N'พรทิพย์', 4006,2006),
(7 ,'12:00',N'107',N'ทองมี','2025-09-17',N'Pending',N'สุชาติ',  4007,2007),
(8 ,'12:30',N'108',N'สุขดี','2025-09-17',N'Pending',N'พิมพ์ใจ',4008,2008),
(9 ,'13:00',N'109',N'ใจดี','2025-09-17',N'Pending',N'เกรียงไกร',4009,2009),
(10,'13:30',N'110',N'สวยดี','2025-09-17',N'Pending',N'รัตนา',  4010,2010);

-- 3.3 Staff_Contract (แบบ B)
INSERT INTO dbo.Staff_Contract (Contract_Id, Term, Contract_type, S_ID, Start_Date, End_Date) VALUES
(10001, 12, N'Contract Doctor',     1001, '2025-01-01', '2025-12-31'),
(10002, 12, N'Contract Nurse',      1002, '2025-01-01', '2025-12-31'),
(10003, 12, N'Contract Pharmacist', 1003, '2025-01-01', '2025-12-31'),
(10004, 12, N'Contract Assistant',  1004, '2025-01-01', '2025-12-31'),
(10005, 12, N'Contract Admin',      1005, '2025-01-01', '2025-12-31'),
(10006, 12, N'Contract Therapist',  1006, '2025-01-01', '2025-12-31'),
(10007, 12, N'Contract Tech',       1007, '2025-01-01', '2025-12-31'),
(10008, 12, N'Contract Nurse',      1008, '2025-01-01', '2025-12-31'),
(10009, 12, N'Contract Specialist', 1009, '2025-01-01', '2025-12-31'),
(10010, 12, N'Contract Nurse',      1010, '2025-01-01', '2025-12-31');

-- 3.4 Shift
INSERT INTO dbo.Shift (SH_ID, S_Position, EndTime, StartTime, W_ID, S_ID) VALUES
(14001,N'Doctor',          '16:00','08:00',2001,1001),
(14002,N'Nurse',           '00:00','16:00',2002,1002),
(14003,N'Pharmacist',      '16:00','08:00',2003,1003),
(14004,N'Assistant',       '00:00','16:00',2004,1004),
(14005,N'Admin',           '16:00','08:00',2005,1005),
(14006,N'Physiotherapist', '00:00','16:00',2006,1006),
(14007,N'Radiology Tech',  '16:00','08:00',2007,1007),
(14008,N'Nurse',           '00:00','16:00',2008,1008),
(14009,N'Specialist',      '16:00','08:00',2009,1009),
(14010,N'Nurse',           '00:00','16:00',2010,1010);

-- 3.5 Requestion
INSERT INTO dbo.Requestion (RQ_ID, SU_ID, SU_name, W_ID, SU_Description, SU_Type, Amount) VALUES
(9001,6001,N'Paracetamol', 2001, N'ยาลดไข้',        N'ยา',       20),
(9002,6002,N'Amoxicillin', 2002, N'ยาฆ่าเชื้อ',     N'ยา',       30),
(9003,6003,N'Face Shield', 2003, N'หน้ากากพลาสติก', N'อุปกรณ์', 10),
(9004,6004,N'Gloves',      2004, N'ถุงมือยาง',       N'อุปกรณ์', 50),
(9005,6005,N'Oxygen Tank', 2005, N'ถังออกซิเจน',     N'อุปกรณ์', 5),
(9006,6006,N'Metformin',   2006, N'ยาลดน้ำตาล',     N'ยา',       15),
(9007,6007,N'Atorvastatin',2007, N'ยาลดไขมัน',      N'ยา',       12),
(9008,6008,N'Omeprazole',  2008, N'ยาลดกรด',        N'ยา',       25),
(9009,6009,N'Cotton',      2009, N'สำลี',            N'เวชภัณฑ์',100),
(9010,6010,N'Insulin',     2010, N'ยาฉีดลดน้ำตาล',  N'ยา',       10);

-- 3.6 Pharma_Supplies
INSERT INTO dbo.Pharma_Supplies (Pharma_ID, Start_Date, Finish_Date, Units_Per_Day, S_ID, SU_ID, P_ID) VALUES
(7001,'2025-09-01','2025-09-07',2,1001,6001,4001),
(7002,'2025-09-01','2025-09-05',1,1002,6002,4002),
(7003,'2025-09-02','2025-09-06',1,1003,6003,4003),
(7004,'2025-09-03','2025-09-07',2,1004,6004,4004),
(7005,'2025-09-04','2025-09-08',1,1005,6005,4005),
(7006,'2025-09-05','2025-09-09',1,1006,6006,4006),
(7007,'2025-09-06','2025-09-10',1,1007,6007,4007),
(7008,'2025-09-07','2025-09-11',1,1008,6008,4008),
(7009,'2025-09-08','2025-09-12',1,1009,6009,4009),
(7010,'2025-09-09','2025-09-13',1,1010,6010,4010);

-- 3.7 Payroll
INSERT INTO dbo.Payroll (Pay_Method, Pay_Date, Base_Salary, Overtime, Bank_Number, Bank_Name, S_ID) VALUES
(N'Bank Transfer','2025-09-30',90000,5000,N'123456',N'Bank A',1001),
(N'Cash','2025-09-30',40000,2000,N'234567',N'Bank B',1002),
(N'Bank Transfer','2025-09-30',50000,3000,N'345678',N'Bank C',1003),
(N'Cash','2025-09-30',30000,1000,N'456789',N'Bank D',1004),
(N'Bank Transfer','2025-09-30',35000,1500,N'567890',N'Bank E',1005),
(N'Cash','2025-09-30',45000,2500,N'678901',N'Bank F',1006),
(N'Bank Transfer','2025-09-30',60000,4000,N'789012',N'Bank G',1007),
(N'Cash','2025-09-30',42000,1800,N'890123',N'Bank H',1008),
(N'Bank Transfer','2025-09-30',80000,5000,N'901234',N'Bank I',1009),
(N'Cash','2025-09-30',38000,1700,N'012345',N'Bank J',1010);

-- 3.8 Patient_Medication
INSERT INTO dbo.Patient_Medication (PM_ID, Status, Dosage, Start_Date, P_ID, S_ID, SU_ID) VALUES
(8001,N'Ongoing',N'2 tablets','2025-09-17',4001,1001,6001),
(8002,N'Ongoing',N'1 capsule','2025-09-17',4002,1002,6002),
(8003,N'Ongoing',N'1 piece','2025-09-17',4003,1003,6003),
(8004,N'Ongoing',N'2 pairs','2025-09-17',4004,1004,6004),
(8005,N'Ongoing',N'1 tank','2025-09-17',4005,1005,6005),
(8006,N'Ongoing',N'1 tablet','2025-09-17',4006,1006,6006),
(8007,N'Ongoing',N'1 tablet','2025-09-17',4007,1007,6007),
(8008,N'Ongoing',N'1 capsule','2025-09-17',4008,1008,6008),
(8009,N'Ongoing',N'5 g','2025-09-17',4009,1009,6009),
(8010,N'Ongoing',N'1 injection','2025-09-17',4010,1010,6010);

-- 3.9 Out_Patient
INSERT INTO dbo.Out_Patient (Appt_Time, Diagnosis, Appt_Date, P_ID) VALUES
('09:00',N'Acute pharyngitis','2025-09-17',4001),
('09:30',N'Acute gastroenteritis','2025-09-17',4002),
('10:00',N'Allergic rhinitis','2025-09-17',4003),
('10:30',N'Tension headache','2025-09-17',4004),
('11:00',N'Dyspepsia','2025-09-17',4005),
('11:30',N'Type 2 DM f/u','2025-09-17',4006),
('12:00',N'Hyperlipidemia f/u','2025-09-17',4007),
('12:30',N'GERD','2025-09-17',4008),
('13:00',N'Hypertension f/u','2025-09-17',4009),
('13:30',N'Migraine','2025-09-17',4010);

-- 3.10 In_Patient
INSERT INTO dbo.In_Patient
 (waitlist_date, Room_Number, Discharge_Date, Expected_Stay, Bed_Number, Exp_Discharge, Admit_Date, W_ID, P_ID) VALUES
('2025-09-15',N'RM201','2025-09-19',4,N'B01','2025-09-19','2025-09-15',2001,4001),
('2025-09-15',N'RM202','2025-09-20',5,N'B02','2025-09-20','2025-09-15',2002,4002),
('2025-09-16',N'RM203','2025-09-21',5,N'B03','2025-09-21','2025-09-16',2003,4003),
('2025-09-16',N'RM204','2025-09-22',6,N'B04','2025-09-22','2025-09-16',2004,4004),
('2025-09-17',N'RM205','2025-09-21',4,N'B05','2025-09-21','2025-09-17',2005,4005),
('2025-09-17',N'RM206','2025-09-22',5,N'B06','2025-09-22','2025-09-17',2006,4006),
('2025-09-18',N'RM207','2025-09-23',5,N'B07','2025-09-23','2025-09-18',2007,4007),
('2025-09-18',N'RM208','2025-09-24',6,N'B08','2025-09-24','2025-09-18',2008,4008),
('2025-09-19',N'RM209','2025-09-25',6,N'B09','2025-09-25','2025-09-19',2009,4009),
('2025-09-19',N'RM210','2025-09-26',7,N'B10','2025-09-26','2025-09-19',2010,4010);

-- 3.11 Edu_Qual
INSERT INTO dbo.Edu_Qual (Qualification_Id, Institution, Date_Qual, Type_Qual, S_ID) VALUES
(5001,N'SUT','2009-03-15',N'MD',              1001),
(5002,N'CMU','2011-07-20',N'RN',              1002),
(5003,N'KU', '2010-05-10',N'B.Pharm',         1003),
(5004,N'BUU','2012-09-01',N'Assistant Cert',  1004),
(5005,N'PSU','2013-10-05',N'Administration',  1005),
(5006,N'MU', '2014-12-12',N'Physiotherapy',   1006),
(5007,N'CU', '2015-08-08',N'Radiology Tech',  1007),
(5008,N'KMITL','2016-06-18',N'RN',            1008),
(5009,N'NU', '2017-04-20',N'Specialist',      1009),
(5010,N'SU', '2018-05-25',N'RN',              1010);

COMMIT TRAN;

------------------------------------------------------------
-- 4) VERIFY — SELECT TOP(1000) ทุกตารางลูก
------------------------------------------------------------
SELECT TOP (1000) [Finish_Date],[Start_Date],[S_Position],[OrganizationName],[S_ID]
FROM dbo.Work_Experience ORDER BY S_ID, Start_Date;

SELECT TOP (1000) [Waiting_que],[Appt_Time],[Exam_Rm],[P_Surname],[Appt_Date],[Status],[P_Name],[P_ID],[W_ID]
FROM dbo.Waiting_List ORDER BY Waiting_que;

SELECT TOP (1000) [Contract_Id],[Term],[Contract_type],[S_ID],[Start_Date],[End_Date]
FROM dbo.Staff_Contract ORDER BY Contract_Id;

SELECT TOP (1000) [SH_ID],[S_Position],[EndTime],[StartTime],[W_ID],[S_ID]
FROM dbo.Shift ORDER BY SH_ID;

SELECT TOP (1000) [RQ_ID],[SU_ID],[SU_name],[W_ID],[SU_Description],[SU_Type],[Amount]
FROM dbo.Requestion ORDER BY RQ_ID;

SELECT TOP (1000) [Pharma_ID],[Start_Date],[Finish_Date],[Units_Per_Day],[S_ID],[SU_ID],[P_ID]
FROM dbo.Pharma_Supplies ORDER BY Pharma_ID;

SELECT TOP (1000) [Pay_Method],[Pay_Date],[Base_Salary],[Overtime],[Bank_Number],[Bank_Name],[S_ID]
FROM dbo.Payroll ORDER BY S_ID;

SELECT TOP (1000) [PM_ID],[Status],[Dosage],[Start_Date],[P_ID],[S_ID],[SU_ID]
FROM dbo.Patient_Medication ORDER BY PM_ID;

SELECT TOP (1000) [Appt_Time],[Diagnosis],[Appt_Date],[P_ID], Out_ID
FROM dbo.Out_Patient ORDER BY Out_ID;

SELECT TOP (1000) [waitlist_date],[Room_Number],[Discharge_Date],[Expected_Stay],[Bed_Number],[Exp_Discharge],[Admit_Date],[W_ID],[P_ID], In_ID
FROM dbo.In_Patient ORDER BY In_ID;

SELECT TOP (1000) [Qualification_Id],[Institution],[Date_Qual],[Type_Qual],[S_ID]
FROM dbo.Edu_Qual ORDER BY Qualification_Id;

PRINT N'✅ เสร็จสิ้น: สร้างตารางลูก + ใส่ข้อมูล 10 แถว + ตรวจผลครบแล้ว';
GO
