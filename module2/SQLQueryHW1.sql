create database HW1_socialMedia_db

CREATE TABLE Person(
PK_person_ID INT IDENTITY(1,1) PRIMARY KEY,
first_name VARCHAR(20),
last_name VARCHAR(20),
email VARCHAR(50),
city VARCHAR(50),
university VARCHAR(100),
employer VARCHAR(100),
role VARCHAR(50),
);

CREATE TABLE Group_table(
PK_group_ID INT IDENTITY(1,1) PRIMARY KEY,
title VARCHAR(50),
creator VARCHAR(50),
);

CREATE TABLE Person_Group_Relation(
person_ID INT NOT NULL,
group_ID INT NOT NULL,
FOREIGN KEY(person_ID) REFERENCES Person(PK_person_ID),
FOREIGN KEY(group_ID) REFERENCES Group_table(PK_group_ID),
UNIQUE(person_ID, group_ID)
);

CREATE TABLE Statistic(
PK_statistics_ID INT IDENTITY(1,1) PRIMARY KEY,
followers INT,
minutes_online INT,
liked_posts INT,
accounts_reached INT,
profile_views INT,
FK_person_ID INT UNIQUE FOREIGN KEY REFERENCES Person(PK_person_ID)
);


CREATE TABLE Post(
PK_post_ID INT IDENTITY(1,1) PRIMARY KEY,
content VARCHAR(200),
author VARCHAR(50),
time_created DATETIME,
FK_group_ID INT FOREIGN KEY REFERENCES Group_table(PK_group_ID)
);

CREATE TABLE Comment(
PK_comment_ID INT IDENTITY(1,1) PRIMARY KEY,
content VARCHAR(200),
author VARCHAR(50),
time_sent DATETIME,
time_edited DATETIME,
FK_post_ID INT FOREIGN KEY REFERENCES Post(PK_post_ID)
);

CREATE TABLE Message_table(
PK_message_ID INT IDENTITY(1,1) PRIMARY KEY,
receiver VARCHAR(50),
content VARCHAR(200),
attachment VARCHAR NULL,
FK_sender_ID INT FOREIGN KEY REFERENCES Person(PK_person_ID)
);

ALTER TABLE Message_table
ADD time_sent DATE DEFAULT GETDATE();

CREATE TABLE PostLike(
PK_id INT PRIMARY KEY,
time_liked DATETIME,
FK_post_ID INT FOREIGN KEY REFERENCES Post(PK_post_ID),
FK_person_ID INT FOREIGN KEY REFERENCES Person(PK_person_ID)
);