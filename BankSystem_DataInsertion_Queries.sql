/*
SELECT Code from Bank order by Code
select * from bank
select * from branch
select * from loan
select * from account 
select * from loan_person
select * from person
truncate table bank
*/

/* ----------------------------------------------------- */
INSERT INTO Bank (Name, Address)
VALUES ('Bank of America', '100 North Tryon Street, Charlotte, NC 28202');

INSERT INTO Bank (Name, Address)
VALUES ('JPMorgan Chase Bank', '270 Park Avenue, New York, NY 10017');

INSERT INTO Bank (Name, Address)
VALUES ('Wells Fargo Bank', '420 Montgomery Street, San Francisco, CA 94104');

INSERT INTO Bank (Name, Address)
VALUES ('Citibank', '399 Park Avenue, New York, NY 10043');

INSERT INTO Bank (Name, Address)
VALUES ('HSBC Bank', '8 Canada Square, London E14 5HQ, United Kingdom');

INSERT INTO Bank (Name, Address)
VALUES ('Bank of China', '1 Fuxingmen Nei Dajie, Xicheng District, Beijing, China');

INSERT INTO Bank (Name, Address)
VALUES ('Barclays Bank', '1 Churchill Place, London E14 5HP, United Kingdom');

INSERT INTO Bank (Name, Address)
VALUES ('Royal Bank of Canada', '200 Bay Street, Toronto, ON M5J 2J5, Canada');

INSERT INTO Bank (Name, Address)
VALUES ('Santander Bank', '75 State Street, Boston, MA 02109');

INSERT INTO Bank (Name, Address)
VALUES ('UBS Group', 'Bahnhofstrasse 45, 8001 Zurich, Switzerland');

INSERT INTO Bank (Name, Address) VALUES ('Bank of America', '123 Main St');
INSERT INTO Bank (Name, Address) VALUES ('JPMorgan Chase', '456 Elm St');
INSERT INTO Bank (Name, Address) VALUES ('Wells Fargo', '789 Oak St');
INSERT INTO Bank (Name, Address) VALUES ('Citibank', '321 Pine St');
INSERT INTO Bank (Name, Address) VALUES ('HSBC', '654 Cedar St');
INSERT INTO Bank (Name, Address) VALUES ('Barclays', '987 Maple St');
INSERT INTO Bank (Name, Address) VALUES ('Royal Bank of Canada', '135 Oak St');
INSERT INTO Bank (Name, Address) VALUES ('Santander Bank', '246 Elm St');
INSERT INTO Bank (Name, Address) VALUES ('UBS', '579 Pine St');
INSERT INTO Bank (Name, Address) VALUES ('Credit Suisse', '802 Cedar St');
INSERT INTO Bank (Name, Address) VALUES ('Bank of China', '954 Maple St');
INSERT INTO Bank (Name, Address) VALUES ('Mitsubishi UFJ Financial Group', '267 Oak St');
INSERT INTO Bank (Name, Address) VALUES ('Banco Santander', '380 Elm St');
INSERT INTO Bank (Name, Address) VALUES ('Banco Itaú', '593 Pine St');
INSERT INTO Bank (Name, Address) VALUES ('BNP Paribas', '706 Cedar St');
INSERT INTO Bank (Name, Address) VALUES ('Deutsche Bank', '819 Maple St');
INSERT INTO Bank (Name, Address) VALUES ('Standard Chartered', '932 Oak St');
INSERT INTO Bank (Name, Address) VALUES ('ING Group', '145 Elm St');
INSERT INTO Bank (Name, Address) VALUES ('Bank of Montreal', '258 Pine St');
INSERT INTO Bank (Name, Address) VALUES ('Toronto-Dominion Bank', '361 Cedar St');
INSERT INTO Bank (Name, Address) VALUES ('Bank of New York Mellon', '474 Maple St');
INSERT INTO Bank (Name, Address) VALUES ('Morgan Stanley', '587 Oak St');
INSERT INTO Bank (Name, Address) VALUES ('Goldman Sachs', '690 Elm St');
INSERT INTO Bank (Name, Address) VALUES ('Merrill Lynch', '703 Pine St');
INSERT INTO Bank (Name, Address) VALUES ('Credit Agricole', '816 Cedar St');
INSERT INTO Bank (Name, Address) VALUES ('Societe Generale', '929 Maple St');
INSERT INTO Bank (Name, Address) VALUES ('Industrial and Commercial Bank of China', '142 Oak St');
INSERT INTO Bank (Name, Address) VALUES ('Bank of Communications', '255 Elm St');
INSERT INTO Bank (Name, Address) VALUES ('Sumitomo Mitsui Financial Group', '368 Pine St');
INSERT INTO Bank (Name, Address) VALUES ('Mizuho Financial Group', '471 Cedar St');
INSERT INTO Bank (Name, Address) VALUES ('Bank of Nova Scotia', '584 Oak St');
INSERT INTO Bank (Name, Address) VALUES ('Banco do Brasil', '697 Elm St');
INSERT INTO Bank (Name, Address) VALUES ('Intesa Sanpaolo', '710 Pine St');
INSERT INTO Bank (Name, Address) VALUES ('UniCredit', '823 Cedar St');
INSERT INTO Bank (Name, Address) VALUES ('BBVA', '936 Maple St');
INSERT INTO Bank (Name, Address) VALUES ('Reserve Bank of India', '149 Oak St');
INSERT INTO Bank (Name, Address) VALUES ('Commonwealth Bank of Australia', '262 Elm St');
INSERT INTO Bank (Name, Address) VALUES ('Westpac Banking Corporation', '375 Pine St');
INSERT INTO Bank (Name, Address) VALUES ('National Australia Bank', '488 Cedar St');
INSERT INTO Bank (Name, Address) VALUES ('ANZ Banking Group', '591 Maple St');

/* ----------------------------------------------------- */


Select * From Branch Order By BranchNumber
INSERT INTO Branch (BranchNumber, BankCode, Address)
VALUES (1, 4, '123 Main Street, New York, NY 10001');

INSERT INTO Branch (BranchNumber, BankCode, Address)
VALUES (2, 5, '456 Elm Avenue, Los Angeles, CA 90001');

INSERT INTO Branch (BranchNumber, BankCode, Address)
VALUES (3, 6, '789 Oak Road, Chicago, IL 60001');

INSERT INTO Branch (BranchNumber, BankCode, Address)
VALUES (4, 7, '321 Pine Street, San Francisco, CA 94101');

INSERT INTO Branch (BranchNumber, BankCode, Address)
VALUES (5, 8, '654 Maple Avenue, Houston, TX 77001');

INSERT INTO Branch (BranchNumber, BankCode, Address)
VALUES (6, 9, '987 Cedar Road, Miami, FL 33001');

INSERT INTO Branch (BranchNumber, BankCode, Address)
VALUES (7, 10, '210 Walnut Boulevard, London E14 6HQ, United Kingdom');

INSERT INTO Branch (BranchNumber, BankCode, Address)
VALUES (8, 11, '543 Willow Lane, Sydney NSW 2000, Australia');

INSERT INTO Branch (BranchNumber, BankCode, Address)
VALUES (9, 12, '876 Oakwood Drive, Toronto, ON M4B 1M1, Canada');

INSERT INTO Branch (BranchNumber, BankCode, Address)
VALUES (10, 13, '109 Pinecrest Avenue, Tokyo 100-0001, Japan');

INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (1, 6, '123 Main St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (2, 30, '456 Elm St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (3, 19, '789 Oak St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (4, 48, '321 Pine St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (5, 12, '654 Cedar St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (6, 40, '987 Maple St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (7, 26, '135 Oak St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (8, 8, '246 Elm St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (9, 50, '579 Pine St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (10, 16, '802 Cedar St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (11, 41, '954 Maple St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (12, 21, '267 Oak St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (13, 46, '380 Elm St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (14, 33, '593 Pine St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (15, 9, '706 Cedar St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (16, 51, '819 Maple St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (17, 13, '932 Oak St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (18, 37, '145 Elm St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (19, 7, '258 Pine St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (20, 23, '361 Cedar St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (21, 43, '474 Maple St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (22, 28, '587 Oak St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (23, 38, '690 Elm St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (24, 52, '703 Pine St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (25, 17, '816 Cedar St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (26, 49, '929 Maple St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (27, 5, '142 Oak St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (28, 32, '255 Elm St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (29, 44, '368 Pine St');
INSERT INTO Branch (BranchNumber, BankCode, Address) VALUES (30, 14, '471 Cedar St');


/* ----------------------------------------------------- */

INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Personal', 1, 6);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Business', 2, 30);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Home', 3, 19);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Auto', 4, 48);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Student', 5, 12);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Mortgage', 6, 40);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Personal', 7, 26);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Business', 8, 8);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Home', 9, 50);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Auto', 10, 16);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Student', 11, 41);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Mortgage', 12, 21);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Personal', 13, 46);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Business', 14, 33);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Home', 15, 9);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Auto', 16, 51);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Student', 17, 13);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Mortgage', 18, 37);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Personal', 19, 7);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Business', 20, 23);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Home', 21, 43);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Auto', 22, 28);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Student', 23, 38);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Mortgage', 24, 52);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Personal', 25, 17);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Business', 26, 49);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Home', 27, 5);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Auto', 28, 32);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Student', 29, 44);
INSERT INTO Loan (Type, BranchBranchNumber, BranchBankCode) VALUES ('Mortgage', 30, 14);

/*-------------------------------------------------------*/
Alter Table person Alter Column Phone nvarchar(255)
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('111111111', 'John Doe', 'password123', 'Customer', '123-456-7890', '123 Main St', 1, 6);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('222222222', 'Jane Smith', 'securepass', 'Employee', '987-654-3210', '456 Elm St', 2, 30);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('333333333', 'Michael Johnson', '123456', 'Customer', '555-555-5555', '789 Oak St', 3, 19);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('444444444', 'Emily Williams', 'pass123', 'Employee', '111-222-3333', '321 Pine St', 4, 48);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('555555555', 'Daniel Brown', 'daniel123', 'Customer', '444-444-4444', '654 Cedar St', 5, 12);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('666666666', 'Olivia Davis', 'olivia456', 'Employee', '777-777-7777', '987 Maple St', 6, 40);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('777777777', 'James Wilson', 'pass123', 'Customer', '222-333-4444', '135 Oak St', 7, 26);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('888888888', 'Sophia Taylor', 'sophia123', 'Employee', '666-666-6666', '246 Elm St', 8, 8);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('999999999', 'Benjamin Anderson', 'pass456', 'Customer', '999-999-9999', '579 Pine St', 9, 50);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('123456789', 'Isabella Martinez', 'isabella123', 'Employee', '888-888-8888', '802 Cedar St', 10, 16);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('987654321', 'Alexander Garcia', 'pass789', 'Customer', '777-777-7777', '954 Maple St', 11, 41);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('456789123', 'Mia Rodriguez', 'mia123', 'Employee', '555-555-5555', '267 Oak St', 12, 21);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('321654987', 'William Hernandez', 'pass123', 'Customer', '444-444-4444', '380 Elm St', 13, 46);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('159753852', 'Sofia Lopez', 'sofia123', 'Employee', '222-333-4444', '593 Pine St', 14, 33);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('852963741', 'Charlotte Gonzalez', 'pass456', 'Customer', '111-222-3333', '706 Cedar St', 15, 9);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('741852963', 'Sebastian Perez', 'sebastian123', 'Employee', '777-777-7777', '819 Maple St', 16, 51);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('951753852', 'Ava Torres', 'pass789', 'Customer', '666-666-6666', '932 Oak St', 17, 13);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('369852147', 'Joseph Adams', 'joseph123', 'Employee', '555-555-5555', '145 Elm St', 18, 37);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('258147369', 'Scarlett Ramirez', 'pass123', 'Customer', '444-444-4444', '258 Pine St', 19, 7);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('741369258', 'Henry Cook', 'henry123', 'Employee', '222-333-4444', '361 Cedar St', 20, 23);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('123987456', 'Victoria Scott', 'pass456', 'Customer', '111-222-3333', '474 Maple St', 21, 43);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('456789123', 'Josephine Green', 'josephine123', 'Employee', '777-777-7777', '587 Oak St', 22, 28);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('789123456', 'David Baker', 'pass789', 'Customer', '666-666-6666', '690 Elm St', 23, 38);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('369258147', 'Natalie Lewis', 'natalie123', 'Employee', '555-555-5555', '703 Pine St', 24, 52);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('852741963', 'Christopher Young', 'pass123', 'Customer', '444-444-4444', '816 Cedar St', 25, 17);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('123654789', 'Penelope Hall', 'penelope123', 'Employee', '222-333-4444', '929 Maple St', 26, 49);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('789456123', 'Liam Allen', 'pass456', 'Customer', '111-222-3333', '042 Oak St', 27, 5);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('456123789', 'Stella Hill', 'stella123', 'Employee', '777-777-7777', '155 Elm St', 28, 32);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('987321654', 'Lucas Martinez', 'pass789', 'Customer', '666-666-6666', '268 Pine St', 29, 44);
INSERT INTO Person (SSN, Name, Password, Type, Phone, Address, BranchBranchNumber, BranchBankCode) VALUES ('741852963', 'Aria Clark', 'aria123', 'Employee', '555-555-5555', '371 Cedar St', 30, 14);

/*---------------------------------------------------------*/

INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (1, '111111111', 5000, 'Accepted');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (2, '222222222', 10000, 'Pending');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (3, '333333333', 7500, 'Rejected');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (4, '444444444', 3000, 'Accepted');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (5, '555555555', 6000, 'Pending');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (6, '666666666', 4000, 'Accepted');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (7, '777777777', 8000, 'Pending');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (8, '888888888', 2000, 'Accepted');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (9, '999999999', 5500, 'Rejected');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (10, '123456789', 9000, 'Pending');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (11, '987654321', 3500, 'Accepted');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (12, '456789123', 7000, 'Rejected');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (13, '321654987', 2500, 'Accepted');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (14, '159753852', 5500, 'Pending');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (15, '852963741', 4500, 'Accepted');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (16, '741852963', 3500, 'Rejected');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (17, '951753852', 6000, 'Accepted');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (18, '369852147', 4000, 'Pending');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (19, '258147369', 3000, 'Accepted');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (20, '741369258', 7000, 'Rejected');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (21, '123987456', 5000, 'Pending');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (22, '456789123', 2000, 'Accepted');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (23, '789123456', 4500, 'Rejected');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (24, '369258147', 6000, 'Accepted');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (25, '852741963', 4000, 'Pending');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (26, '123654789', 2500, 'Accepted');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (27, '789456123', 5500, 'Rejected');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (28, '456123789', 3500, 'Accepted');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (29, '987321654', 7000, 'Pending');
INSERT INTO Loan_Person (LoanLoanNumber, PersonSSN, Amount, Status) VALUES (30, '741852963', 5000, 'Accepted');


/*---------------------------------------------------------*/

INSERT INTO Account (Balance, Type, PersonSSN) VALUES (5000, 'Checking', '111111111');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (10000, 'Savings', '222222222');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (7500, 'Checking', '333333333');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (3000, 'Savings', '444444444');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (6000, 'Checking', '555555555');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (4000, 'Savings', '666666666');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (8000, 'Checking', '777777777');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (2000, 'Savings', '888888888');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (5500, 'Checking', '999999999');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (9000, 'Savings', '123456789');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (3500, 'Checking', '987654321');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (7000, 'Savings', '456789123');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (2500, 'Checking', '321654987');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (5500, 'Savings', '159753852');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (4500, 'Checking', '852963741');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (3500, 'Savings', '741852963');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (6000, 'Checking', '951753852');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (4000, 'Savings', '369852147');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (3000, 'Checking', '258147369');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (7000, 'Savings', '741369258');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (5000, 'Checking', '123987456');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (2000, 'Savings', '456789123');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (4500, 'Checking', '789123456');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (6000, 'Savings', '369258147');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (4000, 'Checking', '852741963');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (2500, 'Savings', '123654789');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (5500, 'Checking', '789456123');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (3500, 'Savings', '456123789');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (7000, 'Checking', '987321654');
INSERT INTO Account (Balance, Type, PersonSSN) VALUES (5000, 'Savings', '741852963');


/*---------------------------------------------------------*/
/*
Select * from Person 
DELETE FROM Person
select * from loan_person
select * from loan

update loan set status = 'Pending'
select * from person where BranchBankCode IN(
select BranchbankCode from Person where ssn = globalssn
)
and
BranchBranchNumber IN
(
select BranchBranchNumber from Person where ssn = globlassn
)
and 
ssn != global ssn
and type = 'Customer'

Select type from Account inner join Person on Account.ssn = person.ssn
where person.branch = globalbranch and person.bank = global bank group by type 

select * from Account
select * from bank

drop table loan 
drop  table loan_person
CREATE TABLE Loan (
  LoanNumber         int IDENTITY NOT NULL, 
  Type               nvarchar(255) NOT NULL, 
  BranchBranchNumber int NOT NULL, 
  BranchBankCode     int NOT NULL, 
  PRIMARY KEY (LoanNumber));


  CREATE TABLE Loan_Person (
  LoanPersonID int IDENTITY NOT NULL, 
  LoanLoanNumber int NOT NULL, 
  PersonSSN    nvarchar(255) NOT NULL, 
  Amount         money NOT NULL, 
  Status         nvarchar(255) DEFAULT 'Pending' NOT NULL, 
  PRIMARY KEY (LoanPersonID,LoanLoanNumber, 
  PersonSSN));

  ALTER TABLE Loan ADD CONSTRAINT Offers FOREIGN KEY (BranchBranchNumber, BranchBankCode) REFERENCES Branch (BranchNumber, BankCode) ON UPDATE Cascade ON DELETE Cascade;
  ALTER TABLE Loan_Person ADD CONSTRAINT FKLoan_Custo987898 FOREIGN KEY (LoanLoanNumber) REFERENCES Loan (LoanNumber);
	ALTER TABLE Loan_Person ADD CONSTRAINT FKLoan_Custo717970 FOREIGN KEY (PersonSSN) REFERENCES Person (SSN);

	*/


	/*Total number of customers, employees, and admins*/
Select Type, count(*) as TotalCount FROM Person Group by Type;

	/*Max Balance from all accounts of each person*/
Select Name, max(Balance) as Max_Balance from person as per
inner join account as Acc on per.SSN = Acc.PersonSSN GROUP BY Name;

	/*Max Balance from each account type*/
SELECT Type, MAX(Balance)as Max_Balance from account GROUP BY type;

	/*Avg Balance from each account type*/
SELECT Type, AVG(Balance)as AVG_Balance from account GROUP BY type;
	
	/*Sum of all balances in each bank*/
SELECT Bank.Name,SUM(balance) AS TotalBalance FROM account INNER JOIN
(person INNER JOIN Bank ON branchBankCode = Code)
ON Account.PersonSSN = Person.SSN
Group By Bank.Name ORDER BY Bank.Name;

	/*Max of all balances in each bank*/
SELECT Bank.Name,MAX(balance) AS TotalBalance FROM account INNER JOIN
(person INNER JOIN Bank ON branchBankCode = Code)
ON Account.PersonSSN = Person.SSN
Group By Bank.Name ORDER BY Bank.Name;


	/*Min of all balances in each bank*/
SELECT Bank.Name,MIN(balance) AS TotalBalance FROM account INNER JOIN
(person INNER JOIN Bank ON branchBankCode = Code)
ON Account.PersonSSN = Person.SSN
Group By Bank.Name ORDER BY Bank.Name;


	/*number of all persons in each bank*/
SELECT Bank.Name,COUNT(PersonSSN) AS TotalPersons FROM account INNER JOIN
(person INNER JOIN Bank ON branchBankCode = Code)
ON Account.PersonSSN = Person.SSN
Group By Bank.Name ORDER BY Bank.Name;

	/*Count number of loans that accepted, rejected or waited in pending*/
SELECT Status, COUNT(*) FROM Loan_Person GROUP BY Status;

	/*Total Amount of Loan for each Person*/
SELECT Name, SUM(Amount) as TotalAmount FROM Person INNER JOIN
Loan_Person ON PersonSSN = SSN GROUP BY Name;


	/*Highest Amount of Loan for each Person*/
SELECT Name, Max(Amount) as MaxAmount FROM Person INNER JOIN
Loan_Person ON PersonSSN = SSN GROUP BY Name;

	/*Total Amount of Loan for each Bank*/
SELECT Name, SUM(Amount) as TotalLoansAmount FROM
(Loan_Person INNER JOIN
(Loan INNER JOIN Bank ON BranchBankCode = Code)
on LoanLoanNumber = LoanNumber)
GROUP BY Name;

/*Number of Branches in each Bank*/
SELECT Name, COUNT(*) BranchesNumber FROM Bank
INNER JOIN Branch ON Code = BankCode GROUP BY Name;

/*Number of People in each Branch*/
SELECT Bank.Name, COUNT(BranchNumber)BranchesNumber, COUNT(*)PersonsNumber FROM
(Bank INNER JOIN (Branch INNER JOIN Person ON BranchNumber = BranchBranchNumber)
ON Code = BankCode) GROUP BY  Bank.Name;