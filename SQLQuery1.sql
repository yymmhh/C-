create database footballschedulemanager
go
use footballschedulemanager
go

create table scheduleinfo(
id int identity(1,1) primary key not null,
count int not null,
hostteamid int not null,
awayteamid int  not null,
competitiontime datetime not null,
competitionposition varchar(50) not null,
score varchar(50) null,
entryperson varchar(20) null,
entrytime datetime  


)
go


create table teaminfo(
id int  identity(1,1) primary key not null ,
teamname varchar(50) not null

)
go

alter table scheduleinfo
add constraint FK_ZHU foreign key(hostteamid) references teaminfo(id)
go

alter table scheduleinfo
add constraint FK_KE foreign key(awayteamid) references teaminfo(id)
go


  select getDate()
  go
  
alter table scheduleinfo
add constraint DF_TIME default (getdate()) for entrytime
go
insert into teaminfo values('��������'),('������Ф'),('ɽ������'),('�����˺�')
go
insert into teaminfo values('���̩��')
go
select * from teaminfo

go
INSERT INTO scheduleinfo
           (count
           ,hostteamid
           ,awayteamid
           ,competitiontime
           ,competitionposition
           ,score
           ,entryperson
           )
     VALUES
           (1
           ,4
           ,3
           ,'2019-9-9'
           ,'����������'
           ,'2��3'
           ,'����'
           )
GO

INSERT INTO scheduleinfo
           (count
           ,hostteamid
           ,awayteamid
           ,competitiontime
           ,competitionposition
           ,score
           ,entryperson
           )
     VALUES
           (2
           ,1
           ,2
           ,'2019-9-9'
           ,'�Ͼ�������'
           ,'2��3'
           ,'����'
           )
select * from scheduleinfo
go
select count,n2.teamname as zhu,n1.teamname as ke,competitiontime,competitionposition,score,entryperson
 from scheduleinfo inner join teaminfo n2
on  scheduleinfo.hostteamid=n2.id
inner join teaminfo n1  on scheduleinfo.awayteamid=n1.id
where 1=1
go

create view view_cha
as

select count,n2.teamname as zhu,n1.teamname as ke,competitiontime,competitionposition,score,entryperson
 from scheduleinfo inner join teaminfo n2
on  scheduleinfo.hostteamid=n2.id
inner join teaminfo n1  on scheduleinfo.awayteamid=n1.id

go







