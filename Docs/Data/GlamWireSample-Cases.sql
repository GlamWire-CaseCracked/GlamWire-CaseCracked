/* CASES SAMPLE DATA */

USE GlamWireDb; 
GO
/* CASE TITLE, CASE SUMMARY, DIFFICULTY, REWARD, ISSOLVED, SaveId */
INSERT INTO Cases
VALUES 
-- Case #1 (Client = Cassia Bloom, Suspects = Lolly Bean & Trixie Glitch, 
--Witnesses = Peter Bloop & Kit Kiddington)

--Truly Guilty = Kit Kiddington 
-- Characters needed ^^ 
('Stolen Kittens', 
'Cassia Bloom’s Boo-Boo Kitty Slippers have mysteriously vanished—-again.
\nIt happened during her sleepover, just hours after she
\nbragged about keeping them post-shoplifting. 
\nShe’s convinced it was an inside job and points fingers at Trixie Glitch
\nand Lolly Bean. Trixie caused a scene over spilled cupcake sprinkles, which
\nCassia claims was a distraction. Lolly says she missed everything—something
about lactose intolerance and bathroom math homework... 
\n
\n
\nKit Kiddington was there too, calmly helping clean up and
offering “rational solutions” to diffuse the situation. 
\nPeter Bloop while walking his fleas, claims he saw 
“Kit arguing with a sock puppet,”
\nbut he’s a compulsive liar and might not even be named Peter. 
\nThe slippers are gone, the vibes are off, and someone at
\nthat sleepover is definitely hiding something',
1, 500, 0, 1),


-- Case #2 (Client = Elemer Felmer, Suspects = Lolly Bean? & ???, 
--Witnesses = Peter Bloop?)

-- Truly Guilty = Poppy Blink 
-- Characters needed ^^
('Heart Shaped UFO',
'Elmer Felmer has been plastering the town with flyers that say things like:
\n“THEY’RE COMING—MEET GLORP BEFORE IT’S TOO LATE” and “EMOTIONAL FREQUENCIES ARE BEING HARVESTED.” 
\nHe’s convinced aliens are trying to make contact, and someone’s been messaging him about it—someone
\nclaiming to be Lolly Bean. She’s smart, mysterious, and seems to understand his theories.
\n
\nBut when Elmer tried to perform the ceremonious Galactian Dance of Passion, 
\nLolly laughed and denied everything.
\nElmer’s confused, heartbroken, and starting to wonder if the aliens 
aren’t the only ones playing with his mind. 
\nIs this a prank, a glitch in the emotional matrix, or something more personal?
\nHelp Elmer figure out who has been communicating with him.', 
3, 1000, 0, 1);

--- Let's just start here ^^^ Other cases coming soon :) 