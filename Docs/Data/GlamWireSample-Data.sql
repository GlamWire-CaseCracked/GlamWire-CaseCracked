USE GlamWireDb;
GO
/* NPC relationships need to go on a scale from 
-100 to 100, 
-100 meaning that you can a terrible relationship with this NPC and that 
can affect how they would talk to you. Relationships can/ need to improve 
with prompts.. */
INSERT INTO NPC (NPCFirstName, NPCLastName, NPCUsername, NPCRelationship, 
		PersonalityType, Criminalhistory, Role, isLocked, isGuilty, CaseId) 
VALUES

-- Female "Clients"
('Cassia', 'Bloom', 'GLITTER-BL00M', 50, 
'Mean-Girl, Childish', 'Shoplifting - Stole three pair of Boo-Boo Kitty Slippers', 
'Client', 0, 0, 1),

-- Male "Clients"

('Elmer', 'Felmer', 'melMER5merMEL', 50, 'Shy, Anxious, Alien-Enthusiast',
'Vandalism - Covered the post office with UFO flyers', 
'Client', 1, 0, 2),

-- Female "Suspects"
('Trixie', 'Glitch', 'WitchGlitch', 10, 'Cyber-Bully, Manipulator, Queen Bee', NULL, 
'Suspect', 0, 0, 1),

('Poppy', 'Blink', '^-^poppy-seed^-^', 75, 'Charismatic, Driven', 
'Stalking - Has a tendancy to stalk those who communicate with her...',
'Suspect', 1, 1, 2),

('Lolly', 'Bean', 'candied3y3land', 25, 'Genius, Snob, Rude',
'Impersonation - She convinced a small group of space lovers in
Wisconsin she was the youngest president of NASA', 
'Suspect', 0, 0, 1),

-- Witnesses/ Others
('Dotty', 'Kravitz', 'dotdotdot123', 40, 'Nice, Friendly', NULL, 
'Witness', 1, 0, 2),

-- Peter complicates things 
('Peter', 'Bloop', 'p_b1oopers', 40, 'Talkitive, Friendly, Compulsive Liar',
'Obstruction of Justice - He lied to the police. His names not even Peter...',
'Witness', 0, 0, 1),

('Kit', 'Kiddington', '225No_Kidding', 0, 'Know-it-All, Logical, Manipulator', NULL, 
'Witness', 0, 1, 1),

-- this user is here for us to test things as well as creating just a
-- mystery users. This user is locked 
('Anonymous', 'User', 'AnonymousUser01', 0, NULL , NULL, 
'Other', 1, 0, 1);