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

-- Check user
CREATE PROCEDURE spCheckUser
(
	@Username VARCHAR(30)
)
AS
BEGIN
	SELECT * FROM dbo.Users u
	WHERE u.UserName = @Username
END
GO


-- ĐĂNG KÝ
CREATE PROCEDURE spSignUp
(
	@Username VARCHAR(30),
	@Password NVARCHAR(MAX),
	@FullName NVARCHAR(50),
	@Address NVARCHAR(50),
	@BirthDay DATE,
	@IDCard VARCHAR(15),
	@Phone VARCHAR(15),
	@Status BIT
)
AS
BEGIN
	INSERT INTO dbo.Users
	(
	    UserName,
	    Password,
	    FullName,
	    Address,
	    BirthDay,
	    IDCardNumber,
	    Mobile,
	    Status
	)
	VALUES
	(   
		@Username, @Password, @FullName, @Address, @BirthDay, @IDCard, @Phone, @Status
	    )
END
GO

-- UPDATE USER
CREATE PROC spUpdateUser
(
	@Username VARCHAR(30),
	@FullName NVARCHAR(50),
	@Address NVARCHAR(50),
	@BirthDay DATE,
	@IDCard VARCHAR(15),
	@Phone VARCHAR(15),
	@Status BIT
)
AS
BEGIN
	UPDATE dbo.Users SET FullName = @FullName, Address = @Address, BirthDay = @BirthDay, IDCardNumber = @IDCard, Mobile = @Phone, Status = @Status WHERE UserName = @Username
END
GO


-- Check trạng thái tài khoản được kích hoạt chưa
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

-- XOÁ USER
CREATE PROC spDeleteUser
(
	@Username VARCHAR(30)
)
AS
BEGIN
	DELETE FROM dbo.Users WHERE UserName= @Username
END


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
CREATE PROC spRestore
(
	@path VARCHAR(255)
)
AS
BEGIN
	RESTORE DATABASE DATABASE_QUANLYTIEMGIATUI FROM DISK = @path WITH REPLACE
END
GO

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

CREATE PROC spgetBills
AS
BEGIN
	SELECT BillCode, BillDate, Name, AppointmentDate, Phone, Address, Status, Total FROM dbo.Customers , dbo.Bills WHERE dbo.Customers.ID = dbo.Bills.CusID
END

-- Thêm khách hàng
CREATE PROC spInsertCustomer
(
	@Name NVARCHAR(255),
	@Address NVARCHAR(255),
	@Phone VARCHAR(11),
	@TotalBill MONEY
)
AS
BEGIN
	INSERT INTO dbo.Customers
	(
	    Name,
	    Address,
	    Phone,
	    TotalBill
	)
	VALUES
	( @Name, @Address, @Phone, @TotalBill )
END

-- INSERT BILL

CREATE PROC spInsertBill
(

	@BillCode VARCHAR(15),
	@CusID INT,
	@UserID INT,
	@BillDate DATETIME,
	@AppointmentDate DATETIME,
	@Discount MONEY,
	@Surcharge MONEY,
	@Note NVARCHAR(20),
	@Total MONEY
)
AS
BEGIN
	INSERT INTO dbo.Bills
	(
		BillCode,
		CusID,
		UserID,
		BillDate,
		AppointmentDate,
		Total,
		Discount,
		Surcharge,
		Note,
		Status
	)
	VALUES
	(   
		@BillCode,
		@CusID,
		@UserID,
		@BillDate,
		@AppointmentDate,
		@Total,
		@Discount,
		@Surcharge,
		@Note,
		N'Chưa giặt'

	    )
END


-- INSERT BILL DETAILS

CREATE PROC spInsertBillDetails
(
	@BillCode VARCHAR(15),
	@ServID VARCHAR(15),
	@Quantity INT,
	@Price MONEY,
	@Total MONEY
)
AS
BEGIN
	INSERT INTO dbo.BillDetails
	(
	    BillCode,
	    ServID,
	    Quantity,
	    Price,
	    Total
	)
	VALUES
	(  @BillCode, @ServID, @Quantity, @Price, @Total )
END
GO

-- DELETE BillDetails
CREATE PROC spDeleteBillDetails
(
	@BillCode VARCHAR(15),
	@ServID VARCHAR(15)
)
AS
BEGIN
	DELETE FROM dbo.BillDetails WHERE BillCode = @BillCode AND ServID = @ServID
END
GO

-- Show BILL DETAILS (UPDATE BILL) gvCart 
CREATE PROC spShowBillDetails
(
	@BillCode VARCHAR(15)
)
AS
BEGIN
	SELECT BillCode, ServID ,ServiceName, Quantity, Total FROM dbo.BillDetails, dbo.Services WHERE BillCode = @BillCode AND ServID = Services.ID
END
GO

-- UPDATE STATUS ( TRẠNG THÁI BILL )
CREATE PROC spUpdateStatus
(
	@BillCode VARCHAR(15),
	@Status NVARCHAR(20)
)
AS
BEGIN
	UPDATE dbo.Bills SET Status = @Status WHERE BillCode = @BillCode;
END


-- Payment  ( Thanh toán hoá đơn - Tiền nhận - Tiền trả lại khách )

CREATE PROC spPayment
(
	@BillCode VARCHAR(15),
	@Paid MONEY,
	@MustBePaid MONEY
)
AS
BEGIN
	UPDATE dbo.Bills SET Paid = @Paid, MustBePaid = @MustBePaid, RecieveDate = GETDATE() WHERE BillCode = @BillCode;
END


-- DELETE BILL

CREATE PROC spDeleteBill
(
	@BillCode VARCHAR(15)
)
AS
BEGIN
	-- XOÁ CHI TIẾT HOÁ ĐƠN -- BillDetails
	-- XOÁ HOÁ ĐƠN - BILLS
	DELETE FROM dbo.BillDetails WHERE BillCode=@BillCode
	DELETE FROM dbo.Bills WHERE BillCode = @BillCode
END


-- INSERT CASHBOOK

CREATE PROC spInsertCashBook
(
	@ID VARCHAR(15),
	@UserID INT,
	@BillType NVARCHAR(50),
	@BillDate DATETIME,
	@Payer NVARCHAR(100),
	@Amount MONEY,
	@Reason NVARCHAR(255),
	@Explain NVARCHAR(255)
)
AS
BEGIN
	INSERT INTO dbo.CashBook
	(
		ID,
		UserID,
		BillType,
		BillDate,
		Payer,
		Amount,
		Reason,
		Explain,
		ReadAmount
	)
	VALUES
	(   @ID,   -- ID - varchar(15)
		@UserID,    -- UserID - int
		@BillType,  -- BillType - nvarchar(50)
		@BillDate, -- BillDate - datetime
		@Payer, -- Payer - nvarchar(100)
		@Amount, -- Amount - money
		@Reason, -- Reason - nvarchar(255)
		@Explain, -- Explain - nvarchar(255)
		NULL  -- ReadAmount - nvarchar(150)
		)
END

-- DELETE CASHBOOK
CREATE PROC spDeleteCashBook
(
	@ID VARCHAR(15)
)
AS
BEGIN
	DELETE FROM dbo.CashBook WHERE ID = @ID
END
GO

-- UPDATE CASHBOOK
CREATE PROC spUpdateCashBook
(
	@ID VARCHAR(15),
	@UserID INT,
	@BillType NVARCHAR(50),
	@BillDate DATETIME,
	@Payer NVARCHAR(100),
	@Amount MONEY,
	@Reason NVARCHAR(255),
	@Explain NVARCHAR(255)
)
AS
BEGIN
	UPDATE dbo.CashBook SET UserID = @UserID, BillType = @BillType,  BillDate = @BillDate, Payer = @Payer, Amount = @Amount, Reason = @Reason, Explain = @Explain WHERE ID = @ID
END
GO

-- GET INFO BILL
CREATE PROC spgetInfoBill
(
	@BillCode VARCHAR(15)
)
AS
BEGIN
	SELECT Status, BillDate, AppointmentDate, Name, Phone, Discount, Total, Surcharge, Address, NOTE FROM dbo.Bills, dbo.Customers WHERE CusID = ID AND BillCode = @BillCode
END

SELECT ID FROM dbo.Customers, dbo.Bills WHERE ID = CusID

-- Update CUSTOMER
CREATE PROC spUpdateCustomer
(
	@CusID INT,
	@Name NVARCHAR(255),
	@Address NVARCHAR(255),
	@Phone VARCHAR(11),
	@TotalBill MONEY
)
AS
BEGIN
	UPDATE dbo.Customers SET Name = @Name, Address = @Address, Phone = @Phone, TotalBill = @TotalBill WHERE ID = @CusID
END
GO

-- UPDATE BILL
CREATE PROC spUpdateBill
(
	
	@BillCode VARCHAR(15),
	@UserID INT,
	@BillDate DATETIME,
	@AppointmentDate DATETIME,
	@Discount MONEY,
	@Surcharge MONEY,
	@Note NVARCHAR(20),
	@Total MONEY,
	@Status NVARCHAR(20)
)
AS
BEGIN
	UPDATE dbo.Bills SET UserID = @UserID, BillDate = @BillDate, AppointmentDate = @AppointmentDate, Discount = @Discount, Surcharge = @Surcharge, NOTE = @Note, Total = @Total, Status = @Status WHERE BillCode = @BillCode
END
GO

-- UPDATE BillDetails
CREATE PROC spUpdateBillDetails
(
	@BillCode VARCHAR(15),
	@ServID VARCHAR(15),
	@Quantity INT,
	@Price MONEY,
	@Total MONEY
)
AS
BEGIN
	UPDATE dbo.BillDetails SET ServID = @ServID, Quantity = @Quantity, Price = @Price, Total = @Total WHERE BillCode = @BillCode AND ServID = @ServID
END
GO
