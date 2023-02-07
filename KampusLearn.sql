create database KampusLearn;
use KampusLearn;

--Admin Table
Create table Admin(
admin_id int primary key identity(1,1),
name varchar(50) not null,
password varchar(50) not null,
contact varchar(10) not null,
email varchar(50) not null,
address varchar(100),
IsActive bit,
created_at date,
updated_at date
);

--Candidate Table
Create table Candidate(
candidate_id int primary key identity(1,1),
name varchar(50)  not null,
password varchar(50)  not null,
contact varchar(10)  not null,
email varchar(50)  not null,
address varchar(100),
IsActive bit,
created_at date,
updated_at date
);

--Trainer Table
Create table Trainer(
trainer_id int primary key identity(1,1),
name varchar(50)  not null,
password varchar(50)  not null,
contact varchar(10)  not null,
email varchar(50)  not null,
address varchar(100),
IsActive bit,
created_at date,
updated_at date
);

alter table Trainer add admin_id int foreign key references Admin(admin_id);

--Course Table
Create table Course(
course_id int primary key identity(1,1),
course_name varchar(50)  not null,
course_category varchar(50)  not null,
fees int  not null,
IsActive bit,
admin_id int foreign key references Admin(admin_id),
created_at date,
updated_at date
);

--Payment Table
Create table Payment(
payment_id int primary key identity(1,1),
candidate_id int foreign key references Candidate(candidate_id),
course_id int foreign key references Course(course_id),
created_at date,
updated_at date,
); 

--Student Available Time
Create table Candidate_Avail_Time(
id int primary key identity(1,1),
candidate_id int foreign key references Candidate(candidate_id),
date_avail date not null,
time_avail time not null,
IsActive bit
 );

--Trainer Available Time
Create table Trainer_Avail_Time(
id int primary key identity(1,1),
trainer_id int foreign key references Trainer(trainer_id),
date_avail date not null,
time_avail time not null,
IsActive bit
 );

--Scheduling Table
Create Table Scheduling(
id int primary key identity(1,1),
admin_id int foreign key references Admin(admin_id),
candidate_id int foreign key references Candidate(candidate_id),
trainer_id int foreign key references Trainer(trainer_id),
course_id int foreign key references Course(course_id),
date_scheduled date not null,
time_scheduled time not null
 );

 --Candidate to Course
Create table Candidate_Course(
id int primary key identity(1,1),
candidate_id int foreign key references Candidate(candidate_id),
course_id int foreign key references Course(course_id),
course_name varchar(100)  not null,
IsPaymentDone bit  not null,
IsActive bit not null,
created_at date,
updated_at date
);

 --Trainer_Course
Create Table Trainer_Course(
id int primary key identity(1,1),
trainer_id int foreign key references Trainer(trainer_id),
course_id int foreign key references Course(course_id)
);


