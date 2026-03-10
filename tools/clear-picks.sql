use DraftApp
go

update TourneyTeams set PlayerID = null


select * from TourneyTeams where PlayerID is not null

select count(*) from TourneyTeams

select * from PickTrackers

select * from Picks
