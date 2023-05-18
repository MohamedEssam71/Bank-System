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
CREATE TABLE Person (
  SSN                nvarchar(255) NOT NULL, 
  Name               nvarchar(255) NOT NULL, 
  Password           nvarchar(255) NOT NULL, 
  Type               nvarchar(255) NOT NULL, 
  Phone              nvarchar(11) NULL, 
  Address            nvarchar(255) NULL, 
  BranchBranchNumber int NULL, 
  BranchBankCode     int NULL, 
  PRIMARY KEY (SSN));
CREATE TABLE Loan (
  LoanNumber         int IDENTITY NOT NULL, 
  Type               nvarchar(255) NOT NULL, 
  Amount             money NOT NULL, 
  Status             nvarchar(255) DEFAULT 'Pending' NOT NULL, 
  BranchBranchNumber int NOT NULL, 
  BranchBankCode     int NOT NULL, 
  PRIMARY KEY (LoanNumber));
CREATE TABLE Account (
  AccountNumber int IDENTITY NOT NULL, 
  Balance       money NOT NULL, 
  Type          nvarchar(255) NOT NULL, 
  PersonSSN   nvarchar(255) NOT NULL,
  PRIMARY KEY (AccountNumber));
CREATE TABLE Loan_Person (
  LoanLoanNumber int NOT NULL, 
  PersonSSN    nvarchar(255) NOT NULL, 
  PRIMARY KEY (LoanLoanNumber, 
  PersonSSN));
ALTER TABLE Branch ADD CONSTRAINT has FOREIGN KEY (BankCode) REFERENCES Bank (Code) ON UPDATE Cascade ON DELETE Cascade;
ALTER TABLE Account ADD CONSTRAINT Owns FOREIGN KEY (PersonSSN) REFERENCES Person (SSN) ON UPDATE Cascade ON DELETE Cascade;
ALTER TABLE Loan ADD CONSTRAINT Offers FOREIGN KEY (BranchBranchNumber, BranchBankCode) REFERENCES Branch (BranchNumber, BankCode) ON UPDATE Cascade ON DELETE Cascade;
ALTER TABLE Person ADD CONSTRAINT Registered FOREIGN KEY (BranchBranchNumber, BranchBankCode) REFERENCES Branch (BranchNumber, BankCode) ON UPDATE Cascade ON DELETE Set null;
ALTER TABLE Loan_Person ADD CONSTRAINT FKLoan_Custo987898 FOREIGN KEY (LoanLoanNumber) REFERENCES Loan (LoanNumber);
ALTER TABLE Loan_Person ADD CONSTRAINT FKLoan_Custo717970 FOREIGN KEY (PersonSSN) REFERENCES Person (SSN);

