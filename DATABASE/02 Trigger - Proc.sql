USE DATABASE_QUANLYTIEMGIATUI
GO
-- Check Login 

CREATE PROCEDURE spCheckLogin
(
		@Username		VARCHAR(30),
		@Password		NVARCHAR(MAX)
)
	AS
	BEGIN
				SELECT	* FROM Users lg
				WHERE		lg.Username= @Username
				AND			lg.Password=@Password
	END
GO

-- Check trạng thái tài khoản

CREATE PROCEDURE spCheckStatus
(
		@Username		VARCHAR(30),
		@Password		NVARCHAR(MAX)
)
	AS
	BEGIN
				SELECT	* FROM Users lg
				WHERE		lg.Username= @Username
				AND			lg.Password=@Password
				AND			lg.Status = 1
	END
GO

-- ĐỔI MẬT KHẨU

CREATE PROCEDURE spChangePass
	@UserName VARCHAR(30),
	@Password NVARCHAR(MAX)

  AS
UPDATE Users
	SET Password = @Password WHERE UserName = @UserName
GO




-- BACKUP DATABASE
CREATE PROC spBackup
(
	@path VARCHAR(255),
	@fileName VARCHAR(255)
)
AS
BEGIN
	DECLARE @str VARCHAR(255)
	SET @str = @path +'\' +  @fileName + '.BAK'

	BACKUP DATABASE DATABASE_QUANLYTIEMGIATUI TO DISK = @str
END
GO

-- RESTORE DATABASE




-- THÊM ĐƠN VỊ TÍNH
CREATE PROCEDURE spInsertUnit
(
	@ID VARCHAR(15),
	@Unit NVARCHAR(50),
	@Note NTEXT
)
AS
BEGIN
	INSERT INTO dbo.Units(ID, Unit, Note)
	VALUES (@ID, @Unit, @Note)
END
GO



-- THÊM DỊCH VỤ
CREATE PROCEDURE spInsertService
(
	@ID VARCHAR(15),
	@ServiceName NVARCHAR(50),
	@UnitID NVARCHAR(15),
	@Price MONEY,
	@Note NTEXT
)
AS
BEGIN
	INSERT INTO dbo.Services(ID, ServiceName, UnitID, Price, Note)
	VALUES (@ID, @ServiceName, @UnitID, @Price, @Note)
END
GO



-- CẬP NHẬT DỊCH VỤ
CREATE PROCEDURE spUpdateService
(
	@ID VARCHAR(15),
	@ServiceName NVARCHAR(50),
	@UnitID NVARCHAR(15),
	@Price MONEY,
	@Note NTEXT
)
AS
BEGIN
	UPDATE dbo.Services SET ServiceName = @ServiceName, UnitID = @UnitID, Price = @Price, Note = @Note WHERE ID = @ID;
END
GO



-- XOÁ DỊCH VỤ

CREATE PROCEDURE spDeleteService
(
	@ID VARCHAR (15)
)
AS
BEGIN
	DELETE FROM dbo.Services WHERE ID=@ID
END
GO

