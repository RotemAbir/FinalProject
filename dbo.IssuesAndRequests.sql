CREATE TABLE [dbo].[IssuesAndRequests] (
    [ID]               INT           NOT NULL,
    [issueType]        VARCHAR (30)   NOT NULL,
    [dateOfOpen]       DATETIME      NULL,
    [dateOfClose]      DATETIME      NULL,
    [issueDescription] VARCHAR (MAX) NULL,
    [typeOfUser]       VARCHAR (15)  NOT NULL,
    [issueStatus]      VARCHAR (10)  NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CHECK ([issueType]='other' OR [issueType]='gym' OR [issueType]='pool' OR [issueType]='cleaning' OR [issueType]='security'),
    CHECK ([typeOfUser]='buildingWorker' OR [typeOfUser]='manager' OR [typeOfUser]='neighbor'),
    CHECK ([issueStatus]='done' OR [issueStatus]='in_progress' OR [issueStatus]='received')
);

