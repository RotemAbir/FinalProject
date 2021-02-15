create table Neighbors (
ID varchar (9) primary key,
firstName varchar(20) not null,
lastName varchar(25) not null,
phone varchar (10) not null,
email varchar (25),
apt_number tinyint unique not null,
floorNumber tinyint not null,
numOfRooms tinyint not null,
isOwner varchar (1) check (isOwner in ('Y','N')) not null, 
typeOfUser varchar(15) check (typeOfUser in ('neighbor','manager','buildingWorker')) references Permission(typeOfUser) not null ,
buildingIdentifier int not null foreign key references Buildings(buildingIdentifier),
);

create table Buildings(
buildingIdentifier int primary key,
city varchar (20) not null,
street varchar (30) not null,
buildingNumber tinyint not null, 
postalCode tinyint not null,
numberOfApt tinyint not null,
typeOfBuilding varchar (15) check (typeOfBuilding in ('regular', 'complex')) not null,
managerID varchar (9) references Managers (ManagerID) not null,

);

create table Managers (
ManagerID varchar (9) primary key,
firstName varchar(20) not null,
lastName varchar(25) not null,
phone varchar (10) not null,
email varchar (25),
isTenant varchar(1) check (isTenant in ('Y','N')) not null,
typeOfUser varchar(15) check (typeOfUser in ('neighbor','manager','buildingWorker')) references Permission(typeOfUser) not null,

);

create table Permission(
typeOfUser varchar (15) primary key check (typeOfUser in ('neighbor','manager','buildingWorker')) ,
permissionType varchar (15) check (permissionType in ('read_and_write','read')),
creationDate datetime,
expirationDate datetime,
);

create table BuildingServices(
typeOfService varchar (20) not null primary key,
serviceDescription varchar(max),
price money,
buildingIndentfier s
);

create table buildingWorkers(
workerNumber varchar primary key,
workerID varchar (9),
firstName varchar(20) not null,
lastName varchar(25) not null,
phone varchar (10) not null,
typeOfWork varchar,
typeOfUser varchar (15)check (typeOfUser in ('neighbor','manager','buildingWorker')) not null,
);

create table IssuesAndRequests(
issueID int primary key,
issueType varchar check (issueType in('security','cleaning','pool','gym','other')) not null,
dateOfOpen datetime,
dateOfClose datetime,
issueDescription varchar(max),
typeOfUser varchar (15)check (typeOfUser in ('neighbor','manager','buildingWorker')) not null,
issueStatus varchar (10) check (issueStatus in ('received', 'in_progress', 'done')) not null,
);

create table IssueHistory(
issueID int primary key references IssuesAndRequests(issueID),
issueDate datetime,
summary varchar (max),
);

create table ServiceProviders(
ID varchar (9) primary key,
firstName varchar(20) not null,
lastName varchar(25) not null,
phone varchar (10) not null,
email varchar (25),
typeOfService varchar not null,
linkToWebsite varchar (max),
);

create table Users(
ID varchar(9) primary key,
currentPassword varchar(20) check (currentPassword>8 and currentPassword<>previoudPassword),
previoudPassword varchar(20),
typeOfUser varchar (15)check (typeOfUser in ('neighbor','manager','buildingWorker')) not null,
);

create table PaymentPerApt(
numberOfRooms tinyint,
monthlyPayment money,
);

create table Policies (
policyName varchar (20) primary key,
policyDescription varchar(max),
lastModified datetime,
buildingIdentifier int references Buildings (buildingIdentifier) not null,
);

create table PoliciesAuditHistory(
policyName varchar(20) primary key references Policies(policyName),
reasonOfAudit varchar (max),
dateOfAudit datetime,
auditor varchar (40),
);

create table AuthorziedPersonnel(
visitorID varchar(9) primary key,
firstName varchar(20) not null,
lastName varchar(25) not null,
phone varchar (10) not null,
aptNumber tinyint references Neighbors(apt_number),
visitDate datetime,
purposeOfVisit varchar (max),
);

create table VisitsHistory(
visitorID varchar(9) primary key references AuthorziedPersonnel(visitorID),
visitDate datetime,
visitCause varchar (max),
aptNumber tinyint references Neighbors(apt_number),
);

create table messagesAndReports(
messageNumber int primary key,
messageDescription varchar(max),
messageDate datetime,
buildingIdentifier int references Buildings (buildingIdentifier) not null,
);

create table TenantPayment(
tenantID varchar(9) references Neighbors(ID),
paymentID int primary key,
paymentReason varchar,
amount money not null,
paymentDate datetime,
paymentStatus varchar (15) check (paymentStatus in ('paid','not_paid')),
--primary key (tenantID,paymentID),
);

create table PaymentHistory (
paymentID int references TenantPayment(paymentID),
paymentType varchar check (paymentType in ('cash','check','credit','bank_transfer')),
amount money,
);



insert into Neighbors (ID ,firstName,lastName,phone ,email ,apt_number ,floorNumber ,numOfRooms ,isOwner ,typeOfUser ,buildingIdentifier)
values('313234189','rotem','abir','0523417031','rotemabir25@gmail.com',10,4,4,'N','neighbor',1);
insert into Neighbors (ID ,firstName,lastName,phone ,email ,apt_number ,floorNumber ,numOfRooms ,isOwner ,typeOfUser ,buildingIdentifier)
values('308098177','batell','mamo','0522327855','batellmampo@gmail.com',8,4,5,'N','neighbor',2);
insert into Neighbors (ID ,firstName,lastName,phone ,email ,apt_number ,floorNumber ,numOfRooms ,isOwner ,typeOfUser ,buildingIdentifier)
values('301757480','Gal','Shamir','0544558066','galshamir18@gmail.com',33,8,5,'N','neighbor',3);