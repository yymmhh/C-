SELECT COUNT,n2.teamname AS zhu,n1.teamname AS ke,competitiontime,competitionposition,score,entryperson
 FROM scheduleinfo INNER JOIN teaminfo n2
ON  scheduleinfo.hostteamid=n2.id
INNER JOIN teaminfo n1  ON scheduleinfo.awayteamid=n1.id

 WHERE 1=1
 
 
 CREATE VIEW
view_cha

AS 
SELECT COUNT,n2.teamname AS zhu,n1.teamname AS ke,competitiontime,competitionposition,score,entryperson
 FROM scheduleinfo INNER JOIN teaminfo n2
ON  scheduleinfo.hostteamid=n2.id
INNER JOIN teaminfo n1  ON scheduleinfo.awayteamid=n1.id

 WHERE 1=1
 

SELECT * FROM view_cha WHERE zhu ='北京国安'

SELECT * FROM view_cha WHERE 1=1    AND zhu ='北京国安'

INSERT INTO `op`.`scheduleinfo`
            (
             `count`,
             `hostteamid`,
             `awayteamid`,
             `competitiontime`,
             `competitionposition`,
             `score`,
             `entryperson`,
             `entrytime`)
VALUES (
        1,
        1,
        3,
        '1999-11-1',
        'competitionposition',
        'score',
        'entryperson',
        'entrytime');
        
        SELECT * FROM teaminfo
        