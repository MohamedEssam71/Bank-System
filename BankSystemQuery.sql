CREATE TABLE Account (
  AccountNumber int IDENTITY NOT NULL,
  Balance       money NOT NULL,
  Type          nvarchar(255) NOT NULL,
  PersonSSN     nvarchar(255) NOT NULL,
  PRIMARY KEY (AccountNumber));
CREATE TABLE Bank (
  Code    int IDENTITY NOT NULL,
  Name    nvarchar(255) NOT NULL UNIQUE,
  Address nvarchar(255) NULL,
  PRIMARY KEY (Code));
CREATE TABLE Branch (
  BranchNumber int NOT NULL,
  BankCode     int NOT NULL,
  Address      nvarchar(255) NULL,
  PRIMARY KEY (BranchNumber,
  BankCode));
CREATE TABLE Loan (
  LoanNumber         int IDENTITY NOT NULL,
  Type               nvarchar(255) NOT NULL,
  BranchBranchNumber int NOT NULL,
  BranchBankCode     int NOT NULL,
  PRIMARY KEY (LoanNumber));
CREATE TABLE Loan_Person (
  LoanPersonID   int NOT NULL,
  LoanLoanNumber int NOT NULL,
  PersonSSN      nvarchar(255) NOT NULL,
  Amount         money NOT NULL,
  Status         nvarchar(255) NOT NULL,
  EmployeeSSN    nvarchar(255) NULL,
  CONSTRAINT LoanPersonID
    PRIMARY KEY (LoanPersonID,
  LoanLoanNumber,
  PersonSSN));
CREATE TABLE Person (
  SSN                nvarchar(255) NOT NULL,
  Name               nvarchar(255) NOT NULL,
  Password           nvarchar(255) NOT NULL,
  Type               nvarchar(255) NOT NULL,
  Phone              nvarchar(255) NULL,
  Address            nvarchar(255) NULL,
  BranchBranchNumber int NULL,
  BranchBankCode     int NOT NULL,
  PRIMARY KEY (SSN));
ALTER TABLE Loan_Person ADD CONSTRAINT FKLoan_Perso721993 FOREIGN KEY (LoanLoanNumber) REFERENCES Loan (LoanNumber);
ALTER TABLE Loan_Person ADD CONSTRAINT FKLoan_Perso671504 FOREIGN KEY (PersonSSN) REFERENCES Person (SSN);
ALTER TABLE Branch ADD CONSTRAINT has FOREIGN KEY (BankCode) REFERENCES Bank (Code) ON UPDATE Cascade ON DELETE Cascade;
ALTER TABLE Loan ADD CONSTRAINT Offers FOREIGN KEY (BranchBranchNumber, BranchBankCode) REFERENCES Branch (BranchNumber, BankCode) ON UPDATE Cascade ON DELETE Cascade;
ALTER TABLE Account ADD CONSTRAINT Owns FOREIGN KEY (PersonSSN) REFERENCES Person (SSN) ON UPDATE Cascade ON DELETE Cascade;
ALTER TABLE Person ADD CONSTRAINT Registered FOREIGN KEY (BranchBranchNumber, BranchBankCode) REFERENCES Branch (BranchNumber, BankCode) ON UPDATE Cascade ON DELETE Set null;


