-- CREATE DATABASE GlamWireDb; 
USE GlamWireDb;

/* 
Save File Table - This program/game doesn't need register and
login pages. It's more like a gameboy cartridge, that's where the save
file table comes into play. it will help us keep track of everything 
per save
*/
CREATE TABLE SaveFile (
	SaveId INT PRIMARY KEY IDENTITY (1,1),
	PlayerName nvarchar(75), 
	Wallet INT, 
	LastPlayed DATETIME, 
	SolvedCases INT
);

-- This snippet sorts the save files by most recently played to latest
SELECT TOP 1 SaveId, PlayerName, LastPlayed
FROM SaveFile
ORDER BY LastPlayed DESC;

/* 
Cases Table - This helps us keep track of each case. Active, inactive, locked
unlocked. But mostly the status of active cases 
*/
CREATE TABLE Cases ( -- sample data needed 
	CaseId INT PRIMARY KEY IDENTITY (1,1), -- auto- increments
	CaseTitle nvarchar(100), 
	CaseSummary nvarchar(MAX), -- case description
	Difficulty INT CHECK (Difficulty BETWEEN 1 AND 5) , -- 1-5 on difficulty scale
	Reward INT, -- the amount of coins the user will recieve
	--once they solve the case
	IsSolved BIT DEFAULT 0, --default = false
	SaveId INT,

	FOREIGN KEY (SaveId) REFERENCES SaveFile(SaveId)
); 

/* 
NPC Table - ( NPC = non-playable character)
represents the clients, suspects or whoever 
the user would need to talk to in order to progress the game, 
case or finding clues. 

You can use the NPC role column to tag NPC's as
suspects, witnesses, clients. 
*/
CREATE TABLE NPC( -- sample data needed
	NPCId INT PRIMARY KEY IDENTITY (1,1),
	NPCFirstName nvarchar(50), 
	NPCLastName nvarchar(55), 
	NPCUsername nvarchar(75), 
	NPCRelationship INT DEFAULT 50 CHECK (NPCRelationship BETWEEN 0 AND 100),
	PersonalityType nvarchar(50), 
	CriminalHistory nvarchar(150) NULL, -- default is NULL and optional 
	-- with Role we can dynamically change the NPC role later if needed 
	-- ex: if client is actually the suspicious one we can change 'Role'
	Role NVARCHAR(20) CHECK (Role IN ('Client', 'Suspect', 'Witness', 'Other')) DEFAULT 'Other',
	
	AvatarURL nvarchar(255), -- this should allow us to give them pfp
	IsLocked BIT DEFAULT 0, -- default = false
	IsGuilty BIT DEFAULT 0, -- default = false
	CaseId INT, 	
	SaveId INT,

	FOREIGN KEY (SaveId) REFERENCES SaveFile(SaveId),
	FOREIGN KEY (CaseId) REFERENCES Cases(CaseId)
);


/* 
Clues Table - This tracks the clues gathered for each case
*/
CREATE TABLE Clues ( -- sample data needed
    ClueId INT PRIMARY KEY IDENTITY(1,1),
    ClueName NVARCHAR(100), -- short name like "Champagne Vial"
    ClueDescription NVARCHAR(MAX), -- what the clue reveals
    IsCritical BIT, -- does this clue help solve the case?
    IsUnlocked BIT DEFAULT 0, -- has the player found it yet?
    CaseId INT, -- which case this clue belongs to
	SaveId INT,

    FOREIGN KEY (CaseId) REFERENCES Cases(CaseId),
    FOREIGN KEY (SaveId) REFERENCES SaveFile(SaveId)
);

/* 
Prompts Table - This helps us keep track of the prompts for the clients, 
suspects and the prompts that the users can select to further their storyline. 
*/
CREATE TABLE Prompts(-- sample data needed
	PromptId INT PRIMARY KEY IDENTITY(1,1), 
	PromptTag nvarchar(60), -- is the client anxious, suspicious, calm?
	MessageText nvarchar(MAX),  
	TimeStamp DATETIME DEFAULT GETDATE(),
	SenderType nvarchar(35), -- is it the player or NPC who sent the message
	CaseId INT, 
	NPCId INT, 
	SaveId INT,

	FOREIGN KEY (SaveId) REFERENCES SaveFile(SaveId),
	FOREIGN KEY (NPCId) REFERENCES NPC(NPCId),
	FOREIGN KEY (CaseId) REFERENCES Cases(CaseId)
);


/*
Inbox Messages Table - Maybe the client can email the user documents 
*/
CREATE TABLE InboxMessages(
	MessageId INT PRIMARY KEY IDENTITY (1,1),
	NPCId INT,
	CaseId INT, 
	SaveId INT,
	MessageText nvarchar(MAX), 
	TimeStamp DATETIME,
	IsRead BIT DEFAULT 0, -- did the user read it? default = false

	FOREIGN KEY (NPCId) REFERENCES NPC(NPCId), 
	FOREIGN KEY (CaseId) REFERENCES Cases(CaseId), 
	FOREIGN KEY (SaveId) REFERENCES SaveFile(SaveId)
);

/* 
Upgrades Table - Things that can help the user solve the case. 
This contains ALL the upgrades the user COULD get but does not 
own specifically. Like a store.
*/
CREATE TABLE Upgrades ( -- sample data needed
    UpgradeId INT PRIMARY KEY IDENTITY(1,1),
    UpgradeName NVARCHAR(100),
    UpgradeDescription NVARCHAR(MAX),
    Cost INT,
    UpgradeEffect NVARCHAR(100), 
	IsLocked BIT DEFAULT 0, -- does the user have to complete 
					-- a case before they can get the upgrade? default = false
	SaveId INT,

	FOREIGN KEY (SaveId) REFERENCES SaveFile(SaveId),
);

/* 
User Upgrades - extends Upgrades, it will keep track 
of user specific upgrades. Inventory
*/
CREATE TABLE UserUpgrades (
    UserUpgradeId INT PRIMARY KEY IDENTITY(1,1),
    SaveId INT,
    UpgradeId INT,
    DatePurchased DATETIME,

    FOREIGN KEY (SaveId) REFERENCES SaveFile(SaveId),
    FOREIGN KEY (UpgradeId) REFERENCES Upgrades(UpgradeId)
);

-- Mock "Real- time" chats with the client, suspect 
CREATE TABLE ChatLogs (
	ChatId INT PRIMARY KEY IDENTITY (1,1), 
	SaveId INT,
	NPCId INT, 
	MessageText nvarchar(450),
	TimeStamp DATETIME DEFAULT GETDATE(), -- retrieves the current time/date
	MessageTag nvarchar(50), -- is this a clue, suspicious, strange?
	PromptId INT, 

	FOREIGN KEY (PromptId) REFERENCES Prompts(PromptId),
	FOREIGN KEY (SaveId) REFERENCES SaveFile(SaveId),
    FOREIGN KEY (NPCId) REFERENCES NPC(NPCId)
); 

