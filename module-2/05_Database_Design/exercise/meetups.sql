DROP TABLE IF EXISTS group_member;
DROP TABLE IF EXISTS event_member;
DROP TABLE IF EXISTS member;
DROP TABLE IF EXISTS event;
DROP TABLE IF EXISTS interest_group;



CREATE TABLE member(
MemberId INT IDENTITY (1, 1),
LastName NVARCHAR(100) NOT NULL,
FirstName NVARCHAR(100) NOT NULL,
EmailAddress VARCHAR(100) NULL,
PhoneNumber VARCHAR(20) NULL,
DateOfBirth DATE NULL,
WantsReminderEmails BIT NULL,
CONSTRAINT PK_member PRIMARY KEY (MemberId)
);



CREATE TABLE interest_group(
GroupId INT IDENTITY (1, 1),
GroupName NVARCHAR(100) NOT NULL,
CONSTRAINT PK_interest_group PRIMARY KEY (GroupID)
);



CREATE TABLE event(
EventId INT IDENTITY (1, 1), 
EventName NVARCHAR(100) NOT NULL,
Description NVARCHAR(200) NULL,
StartDateAndTime DATE NOT NULL,
Duration INT NOT NULL,
GroupRunningEvent INT NOT NULL,
CONSTRAINT PK_event PRIMARY KEY (EventId),
CONSTRAINT FK_event_interest_group FOREIGN KEY (GroupRunningEvent) REFERENCES interest_group (GroupId)
);



CREATE TABLE group_member(
GroupId INT,
MemberId INT,
CONSTRAINT FK_group_member_interest_group FOREIGN KEY (GroupId) REFERENCES interest_group (GroupId),
CONSTRAINT FK_group_member_member FOREIGN KEY (MemberId) REFERENCES member (MemberId),
PRIMARY KEY (GroupId, MemberId)
);



CREATE TABLE event_member(
EventId INT,
MemberId INT,
CONSTRAINT FK_event_member_event FOREIGN KEY (EventId) REFERENCES event (EventId),
CONSTRAINT FK_event_member_member FOREIGN KEY (MemberId) REFERENCES member (MemberId),
PRIMARY KEY (EventId, MemberId)
);



ALTER TABLE event 
ADD CONSTRAINT CHK_duration CHECK (duration >= 30);
-----------------------------------------------------------------------------------------------------------------------------------------

INSERT INTO member(LastName, FirstName)
VALUES 
('Vang', 'Victor'),
('Fulton', 'John'),
('Schlegel', 'YoungerDan'),
('Sanfillipo', 'Vinny'),
('Carmichael', 'Steve'),
('Rauh', 'Rachelle'),
('Eland', 'Matt'),
('Watkins', 'Kate'),
('Pilbeam', 'Connor'),
('Lauvray', 'Brian');

SELECT * FROM member;



INSERT INTO interest_group(GroupName)
VALUES
('Students'),
('Instructors'),
('Foundation');

SELECT * FROM interest_group;



INSERT INTO event(EventName, StartDateAndTime, Duration, GroupRunningEvent)
VALUES
('Data Access and DAO', '2/22/2022', 180, (SELECT GroupId FROM interest_group WHERE GroupName = 'Instructors')),    
('Needs Assistance on Exercises', '2/25/2022', 30, (SELECT GroupId FROM interest_group WHERE GroupName = 'Students')),
('Career Strategy 1x1', '2/24/2022', 30, (SELECT GroupId FROM interest_group WHERE GroupName = 'Foundation')),
('DAO Testing', '2/23/2022', 180, (SELECT GroupId FROM interest_group WHERE GroupName = 'Instructors'));

SELECT * FROM event;



INSERT INTO group_member(GroupId, MemberId)
VALUES
((SELECT GroupId FROM interest_group WHERE GroupName = 'Students'), (SELECT MemberId FROM member WHERE FirstName = 'Victor')),   
((SELECT GroupId FROM interest_group WHERE GroupName = 'Students'), (SELECT MemberId FROM member WHERE FirstName = 'YoungerDan')),
((SELECT GroupId FROM interest_group WHERE GroupName = 'Instructors'), (SELECT MemberId FROM member WHERE FirstName = 'John')),
((SELECT GroupId FROM interest_group WHERE GroupName = 'Instructors'), (SELECT MemberId FROM member WHERE FirstName = 'Steve')),
((SELECT GroupId FROM interest_group WHERE GroupName = 'Foundation'), (SELECT MemberId FROM member WHERE FirstName = 'Vinny')),
((SELECT GroupId FROM interest_group WHERE GroupName = 'Foundation'), (SELECT MemberId FROM member WHERE FirstName = 'Connor'));

SELECT * FROM group_member;



INSERT INTO event_member(EventId, MemberId)
VALUES
((SELECT EventId FROM event WHERE EventName LIKE 'Data%'), (SELECT MemberId FROM member WHERE FirstName = 'Victor')),  
((SELECT EventId FROM event WHERE EventName LIKE 'Needs%'), (SELECT MemberId FROM member WHERE FirstName = 'Victor')),
((SELECT EventId FROM event WHERE EventName LIKE 'Career%'), (SELECT MemberId FROM member WHERE FirstName = 'Vinny')),
((SELECT EventId FROM event WHERE EventName LIKE 'DAO%'), (SELECT MemberId FROM member WHERE FirstName = 'John')),
((SELECT EventId FROM event WHERE EventName LIKE 'Data%'), (SELECT MemberId FROM member WHERE FirstName = 'Steve')), 
((SELECT EventId FROM event WHERE EventName LIKE 'Needs%'), (SELECT MemberId FROM member WHERE FirstName = 'Rachelle')),
((SELECT EventId FROM event WHERE EventName LIKE 'Career%'), (SELECT MemberId FROM member WHERE FirstName = 'Kate')),
((SELECT EventId FROM event WHERE EventName LIKE 'DAO%'), (SELECT MemberId FROM member WHERE FirstName = 'Brian'));

SELECT * FROM event_member;
