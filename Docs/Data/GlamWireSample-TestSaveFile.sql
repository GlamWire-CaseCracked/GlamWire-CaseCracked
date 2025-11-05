/* SAVE FILE SAMPLE DATA */

USE GlamWireDb; 
GO

/* PLAYER NAME, WALLET, LAST PLAYED, SOLVED CASES*/
INSERT INTO SaveFile
VALUES 
--  This is a test save file to avoid crashes, I couldn't leave savefile 
-- reference blank in some areas. 
('TestPlayer', 9999, GETDATE(), 0);