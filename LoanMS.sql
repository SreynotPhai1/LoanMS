--------------------------------------------------------
--  File created - Saturday-April-27-2024   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table ADDRESS
--------------------------------------------------------

  CREATE TABLE "LOAN"."ADDRESS" 
   (	"ADDRESSID" NUMBER GENERATED BY DEFAULT AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"CUSTOMERID" NUMBER, 
	"ADDRESSNAME" VARCHAR2(500 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table APPUSER
--------------------------------------------------------

  CREATE TABLE "LOAN"."APPUSER" 
   (	"APPUSERID" NUMBER GENERATED BY DEFAULT AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"ISHIDDEN" NUMBER(*,0), 
	"USERNAME" VARCHAR2(50 BYTE), 
	"PASSWORD" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table APPUSERPERMISSION
--------------------------------------------------------

  CREATE TABLE "LOAN"."APPUSERPERMISSION" 
   (	"APPUSERPERMISSIONID" NUMBER GENERATED BY DEFAULT AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"APPUSERID" NUMBER, 
	"USERPERMISSION" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table COLLATERAL
--------------------------------------------------------

  CREATE TABLE "LOAN"."COLLATERAL" 
   (	"COLLATERALID" NUMBER GENERATED BY DEFAULT AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"ISHIDDEN" NUMBER(*,0), 
	"COLLATERALCODE" VARCHAR2(50 BYTE), 
	"OWNERNAME" VARCHAR2(50 BYTE), 
	"OWNERNATIONALCARDNUMBER" VARCHAR2(50 BYTE), 
	"COLLATERALTYPEID" NUMBER, 
	"COLLATERALDESCRIPTION" VARCHAR2(500 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table COLLATERALTYPE
--------------------------------------------------------

  CREATE TABLE "LOAN"."COLLATERALTYPE" 
   (	"COLLATERALTYPEID" NUMBER GENERATED BY DEFAULT AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"COLLATERALTYPENAME" VARCHAR2(50 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table CREDITOFFICER
--------------------------------------------------------

  CREATE TABLE "LOAN"."CREDITOFFICER" 
   (	"CREDITOFFICERID" NUMBER GENERATED BY DEFAULT AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"ISHIDDEN" NUMBER(*,0), 
	"CREDITOFFICERNAME" VARCHAR2(50 BYTE), 
	"SEX" VARCHAR2(1 BYTE), 
	"DOB" DATE, 
	"POB" VARCHAR2(500 BYTE), 
	"PHONE" VARCHAR2(200 BYTE), 
	"EMAIL" VARCHAR2(200 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table CUSTOMER
--------------------------------------------------------

  CREATE TABLE "LOAN"."CUSTOMER" 
   (	"CUSTOMERID" NUMBER GENERATED BY DEFAULT AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"ISHIDDEN" NUMBER(*,0), 
	"CUSTOMERNAME" VARCHAR2(50 BYTE), 
	"SEX" VARCHAR2(1 BYTE), 
	"DOB" DATE, 
	"POB" VARCHAR2(500 BYTE), 
	"PHONE" VARCHAR2(200 BYTE), 
	"EMAIL" VARCHAR2(200 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table LOAN
--------------------------------------------------------

  CREATE TABLE "LOAN"."LOAN" 
   (	"LOANID" NUMBER GENERATED BY DEFAULT AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"ISHIDDEN" NUMBER(*,0), 
	"CUSTOMERID" NUMBER, 
	"COLLATERALID" NUMBER, 
	"CREDITOFFICERID" NUMBER, 
	"LOANDATE" DATE, 
	"LOANCODE" VARCHAR2(50 BYTE), 
	"LOANAMOUNT" NUMBER, 
	"CURRENCY" VARCHAR2(1 BYTE), 
	"INTERESTRATE" NUMBER, 
	"PAYMENTFREQUENCYCODE" NUMBER, 
	"MEMO" VARCHAR2(500 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table LOANDETAIL
--------------------------------------------------------

  CREATE TABLE "LOAN"."LOANDETAIL" 
   (	"LOANDETAILID" NUMBER GENERATED BY DEFAULT AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"LOANID" NUMBER, 
	"PERIODNO" NUMBER, 
	"BEGINNINGBALANCE" NUMBER, 
	"PRICIPLE" NUMBER, 
	"INEREST" NUMBER, 
	"PAYMENT" NUMBER, 
	"ENDINGBALANCE" NUMBER, 
	"ISPAID" NUMBER(*,0), 
	"PAIDDATE" DATE, 
	"NOTE" VARCHAR2(500 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
REM INSERTING into LOAN.ADDRESS
SET DEFINE OFF;
Insert into LOAN.ADDRESS (ADDRESSID,CUSTOMERID,ADDRESSNAME) values (10,1,'Siem Reap');
Insert into LOAN.ADDRESS (ADDRESSID,CUSTOMERID,ADDRESSNAME) values (11,4,'Siem Reap');
Insert into LOAN.ADDRESS (ADDRESSID,CUSTOMERID,ADDRESSNAME) values (3,3,'Siem Reap');
Insert into LOAN.ADDRESS (ADDRESSID,CUSTOMERID,ADDRESSNAME) values (9,1,'Siem Reap');
REM INSERTING into LOAN.APPUSER
SET DEFINE OFF;
REM INSERTING into LOAN.APPUSERPERMISSION
SET DEFINE OFF;
REM INSERTING into LOAN.COLLATERAL
SET DEFINE OFF;
REM INSERTING into LOAN.COLLATERALTYPE
SET DEFINE OFF;
REM INSERTING into LOAN.CREDITOFFICER
SET DEFINE OFF;
REM INSERTING into LOAN.CUSTOMER
SET DEFINE OFF;
Insert into LOAN.CUSTOMER (CUSTOMERID,ISHIDDEN,CUSTOMERNAME,SEX,DOB,POB,PHONE,EMAIL) values (1,null,'sreynot','F',to_date('27-FEB-24','DD-MON-RR'),'Siem Reap','099865434','not@gmail.com');
Insert into LOAN.CUSTOMER (CUSTOMERID,ISHIDDEN,CUSTOMERNAME,SEX,DOB,POB,PHONE,EMAIL) values (3,null,'Hak Hai','M',to_date('21-JAN-24','DD-MON-RR'),'Siem Reap','0976554322','hai@gmail.com');
Insert into LOAN.CUSTOMER (CUSTOMERID,ISHIDDEN,CUSTOMERNAME,SEX,DOB,POB,PHONE,EMAIL) values (4,null,'savry','F',to_date('17-APR-24','DD-MON-RR'),'Siem Reap','0965332245','ry@gmail.com');
REM INSERTING into LOAN.LOAN
SET DEFINE OFF;
REM INSERTING into LOAN.LOANDETAIL
SET DEFINE OFF;
--------------------------------------------------------
--  DDL for Procedure ADDRESSADD
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "LOAN"."ADDRESSADD" 
(
    P_CustomerId    Address.CustomerId%Type,
    P_AddressName Address.AddressName%Type
)
As
Begin
    Insert Into Address(CustomerId, AddressName) 
    Values(P_CustomerId,P_AddressName);
    Commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure ADDRESSDELETE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "LOAN"."ADDRESSDELETE" 
(
    P_CustomerId    Address.CustomerId%Type Default 0
)
As
Begin
    delete from address where customerid = p_customerid;
    commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure ADDRESSGET
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "LOAN"."ADDRESSGET" 
(
    P_CustomerId    Address.CustomerId%Type Default 0
)
As
    C_Address Sys_RefCursor;
Begin
    If(P_CustomerId = 0) Then
        Open C_Address For Select * From Address;
    Else
        Open C_Address For Select * From Address Where CustomerId = P_CustomerId;
    End If;
    DBMS_SQL.return_result(C_Address);
End;

/
--------------------------------------------------------
--  DDL for Procedure CUSTOMERADD
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "LOAN"."CUSTOMERADD" (
    P_CustomerName      Customer.CustomerName%Type,
    P_Sex       Customer.Sex%Type,
    P_DOB             Customer.DOB%Type,
    P_POB             Customer.POB%Type,
    P_Phone           Customer.Phone%Type,
    P_Email        Customer.Email%Type,
    P_IsHidden   Customer.IsHidden%Type
)
As
Begin
    Insert Into Customer(CustomerName, Sex, DOB, POB, Phone,Email,IsHidden) 
    Values(P_CustomerName,P_Sex,P_DOB,P_POB,P_Phone,P_Email,P_IsHidden);
    Commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure CUSTOMERDELETE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "LOAN"."CUSTOMERDELETE" 
(
    P_CustomerId        Customer.CustomerId%Type
)
As
Begin
    Delete From Customer Where CustomerId = P_CustomerId;
    Commit;
End;

/
--------------------------------------------------------
--  DDL for Procedure CUSTOMERGET
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "LOAN"."CUSTOMERGET" 
(
    P_CustomerId    Customer.CustomerId%Type Default 0
)
As
    C_Customer Sys_RefCursor;
Begin
    If(P_CustomerId = 0) Then
        Open C_Customer For Select * From Customer;
    Else
        Open C_Customer For Select * From Customer Where CustomerId = P_CustomerId;
    End If;
    DBMS_SQL.return_result(C_Customer);
End;

/
--------------------------------------------------------
--  DDL for Procedure CUSTOMERUPDATE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE EDITIONABLE PROCEDURE "LOAN"."CUSTOMERUPDATE" (
    P_CustomerId        Customer.CustomerId%Type,
     P_CustomerName      Customer.CustomerName%Type,
    P_Sex       Customer.Sex%Type,
    P_DOB             Customer.DOB%Type,
    P_POB             Customer.POB%Type,
    P_Phone           Customer.Phone%Type,
    P_Email        Customer.Email%Type,
    P_IsHidden   Customer.IsHidden%Type
)
As
Begin
    Update Customer
        Set
        CustomerName = P_CustomerName,
        Sex = P_Sex,
        DOB = P_DOB,
        POB = P_POB,
        Phone = P_Phone,
        Email = P_Email,
        IsHidden = P_IsHidden
    Where CustomerId = P_CustomerId;
    Commit;
End;

/
--------------------------------------------------------
--  Constraints for Table APPUSER
--------------------------------------------------------

  ALTER TABLE "LOAN"."APPUSER" MODIFY ("APPUSERID" NOT NULL ENABLE);
  ALTER TABLE "LOAN"."APPUSER" ADD PRIMARY KEY ("APPUSERID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table COLLATERALTYPE
--------------------------------------------------------

  ALTER TABLE "LOAN"."COLLATERALTYPE" MODIFY ("COLLATERALTYPEID" NOT NULL ENABLE);
  ALTER TABLE "LOAN"."COLLATERALTYPE" ADD PRIMARY KEY ("COLLATERALTYPEID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table CREDITOFFICER
--------------------------------------------------------

  ALTER TABLE "LOAN"."CREDITOFFICER" MODIFY ("CREDITOFFICERID" NOT NULL ENABLE);
  ALTER TABLE "LOAN"."CREDITOFFICER" ADD PRIMARY KEY ("CREDITOFFICERID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table APPUSERPERMISSION
--------------------------------------------------------

  ALTER TABLE "LOAN"."APPUSERPERMISSION" MODIFY ("APPUSERPERMISSIONID" NOT NULL ENABLE);
  ALTER TABLE "LOAN"."APPUSERPERMISSION" ADD PRIMARY KEY ("APPUSERPERMISSIONID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table LOANDETAIL
--------------------------------------------------------

  ALTER TABLE "LOAN"."LOANDETAIL" MODIFY ("LOANDETAILID" NOT NULL ENABLE);
  ALTER TABLE "LOAN"."LOANDETAIL" ADD PRIMARY KEY ("LOANDETAILID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table CUSTOMER
--------------------------------------------------------

  ALTER TABLE "LOAN"."CUSTOMER" MODIFY ("CUSTOMERID" NOT NULL ENABLE);
  ALTER TABLE "LOAN"."CUSTOMER" ADD PRIMARY KEY ("CUSTOMERID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table ADDRESS
--------------------------------------------------------

  ALTER TABLE "LOAN"."ADDRESS" MODIFY ("ADDRESSID" NOT NULL ENABLE);
  ALTER TABLE "LOAN"."ADDRESS" ADD PRIMARY KEY ("ADDRESSID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table LOAN
--------------------------------------------------------

  ALTER TABLE "LOAN"."LOAN" MODIFY ("LOANID" NOT NULL ENABLE);
  ALTER TABLE "LOAN"."LOAN" ADD PRIMARY KEY ("LOANID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table COLLATERAL
--------------------------------------------------------

  ALTER TABLE "LOAN"."COLLATERAL" MODIFY ("COLLATERALID" NOT NULL ENABLE);
  ALTER TABLE "LOAN"."COLLATERAL" ADD PRIMARY KEY ("COLLATERALID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table ADDRESS
--------------------------------------------------------

  ALTER TABLE "LOAN"."ADDRESS" ADD FOREIGN KEY ("CUSTOMERID")
	  REFERENCES "LOAN"."CUSTOMER" ("CUSTOMERID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table APPUSERPERMISSION
--------------------------------------------------------

  ALTER TABLE "LOAN"."APPUSERPERMISSION" ADD FOREIGN KEY ("APPUSERID")
	  REFERENCES "LOAN"."APPUSER" ("APPUSERID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table COLLATERAL
--------------------------------------------------------

  ALTER TABLE "LOAN"."COLLATERAL" ADD FOREIGN KEY ("COLLATERALTYPEID")
	  REFERENCES "LOAN"."COLLATERALTYPE" ("COLLATERALTYPEID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table LOAN
--------------------------------------------------------

  ALTER TABLE "LOAN"."LOAN" ADD FOREIGN KEY ("CUSTOMERID")
	  REFERENCES "LOAN"."CUSTOMER" ("CUSTOMERID") ON DELETE CASCADE ENABLE;
  ALTER TABLE "LOAN"."LOAN" ADD FOREIGN KEY ("COLLATERALID")
	  REFERENCES "LOAN"."COLLATERAL" ("COLLATERALID") ON DELETE CASCADE ENABLE;
  ALTER TABLE "LOAN"."LOAN" ADD FOREIGN KEY ("CREDITOFFICERID")
	  REFERENCES "LOAN"."CREDITOFFICER" ("CREDITOFFICERID") ON DELETE CASCADE ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table LOANDETAIL
--------------------------------------------------------

  ALTER TABLE "LOAN"."LOANDETAIL" ADD FOREIGN KEY ("LOANID")
	  REFERENCES "LOAN"."LOAN" ("LOANID") ON DELETE CASCADE ENABLE;
