insert Event(Name,RegistrationDeadlineDate,EventDate,EventStartTime,EventEndTime,TimeSlotLength) values('Speed Dating 1','9/1/2019','9/15/2019','5:00','7:30',30)

insert EventTable(EventId, Name) Values(2,'Table 1')
insert EventTable(EventId, Name) Values(2,'Table 2')

insert Corp(Name) Values('Corporate 1')
insert Corp(Name) Values('Corporate 2')
insert Corp(Name) Values('Corporate 3')
insert Corp(Name) Values('Corporate 4')

insert Investor(Name) Values('Investor A')
insert Investor(Name) Values('Investor B')
insert Investor(Name) Values('Investor C')
insert Investor(Name) Values('Investor D')

select * from Corp
select * from Investor


insert EventCorp(EventId,CorpId) values(2,1)
insert EventCorp(EventId,CorpId) values(2,2)
insert EventCorp(EventId,CorpId) values(2,3)
insert EventCorp(EventId,CorpId) values(2,4)

insert EventInvestor(EventId,InvestorId) values(2,1)
insert EventInvestor(EventId,InvestorId) values(2,2)
insert EventInvestor(EventId,InvestorId) values(2,3)
insert EventInvestor(EventId,InvestorId) values(2,4)


insert EventCorpPref(EventCorpId,EventInvestorId,PrefOrder) values(1,3,1)
insert EventCorpPref(EventCorpId,EventInvestorId,PrefOrder) values(2,3,1)
insert EventCorpPref(EventCorpId,EventInvestorId,PrefOrder) values(3,2,1)
insert EventCorpPref(EventCorpId,EventInvestorId,PrefOrder) values(4,1,1)


insert EventInvestorPref(EventInvestorId, EventCorpId, PrefOrder) values(1,4,1)
insert EventInvestorPref(EventInvestorId, EventCorpId, PrefOrder) values(2,1,1)
insert EventInvestorPref(EventInvestorId, EventCorpId, PrefOrder) values(3,1,1)
insert EventInvestorPref(EventInvestorId, EventCorpId, PrefOrder) values(4,3,1)










