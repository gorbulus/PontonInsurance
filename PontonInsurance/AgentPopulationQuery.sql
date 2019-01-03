
CREATE TABLE Locations
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL , 
    [LastName] NVARCHAR(50) NOT NULL , 
    [Certifications] NVARCHAR(255) NULL, 
    [Agency] NVARCHAR(255) NOT NULL , 
    [Address] NVARCHAR(255) NOT NULL , 
    [Suite] NVARCHAR(50) NULL, 
    [City] NVARCHAR(255) NOT NULL , 
    [State] NVARCHAR(50) NOT NULL , 
    [Zip] NVARCHAR(50) NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [Licenses] NVARCHAR(255) NULL
)

INSERT INTO Locations ( Id,FirstName, LastName, Certifications,
						 Agency, Address, Suite, City, State,
						 Zip, Phone, Licenses) 
VALUES
( 1,'Wellington', 'Hawkins', '', 'Wellington Hawkins Ins Agy Inc', '2801 Saint Johns Bluff Rd S', 'Suite 3', 'Jacksonville', 'FL', '32246-3743', '904-646-0107', '' ), 
( 2,'Sam', 'Maimone', '', 'Sam Maimone Ins Agcy Inc', '12620 Beach Blvd', 'Suite 8', 'Jacksonville', 'FL', '32246-7130', '904-641-6844', '' ), 

( 3,'Bill', 'Doyle', '', '', '11555 Central Parkway', 'Suite 904', 'Jacksonville', 'FL', '32224-2701', '904-642-4000', 'FL-A071731' ), 
( 4,'Vonnie', 'Wiggins', '', '', '3546 St. Johns Bluff Road S', 'Unit 112', 'Jacksonville', 'FL', '32224', '904-641-0090', 'FL-E090978' ), 
( 5,'Michael', 'Tauzel', 'CPCU®, CLU®', 'Michael Tauzel Ins Agcy Inc', '13170 Atlantic Boulevard', 'Suite 58', 'Jacksonville', 'FL', '32225', '904-425-4100', '' ), 
( 6,'Parvez', 'Sahotra', 'ChFC®, CASL®, CLU®', 'Parvez B Sahotra Ins Agcy Inc', '3267 Hodges Blvd', 'Suite 14', 'Jacksonville', 'FL', '32224', '904-221-1161', '' ), 
( 7,'Therese', 'Quinn', '', 'Therese Quinn Ins Agcy Inc', '1944 Southside Blvd', '', 'Jacksonville', 'FL', '32216-1930', '904-724-6040', '' ), 
( 8, 'Randy', 'Taylor', 'ChFC®, CASL®, CLU®', 'NA', '3041-1 Monument Road', '', 'Jacksonville', 'FL', '32225-5711', '904-642-2400', 'FL-D027220' ), 
( 9,'Margie', 'Harner', '', 'Margie Harner Ins Agcy Inc', '4540 Southside Blvd', 'Suite 1102', 'Jacksonville', 'FL', '32216', '904-296-2500', '' ), 
( 10,'Connie', 'Doyle', '', '', '14158 Marsh Woods Ct', '', 'Jacksonville', 'FL', '32224', '904-223-0035', 'FL-A071646' ), 
( 11,'Homer', 'St Clair', '', '', '7305 Merrill Rd', '', 'Jacksonville', 'FL', '32277-3726', '904-743-7422', 'FL-A251571' ), 
( 12,'Denny', 'Doyle', '', '', '7807 Baymeadows Road E', 'Suite 100', 'Jacksonville', 'FL', '32256-9664', '904-737-3777', 'FL-A071632' ), 
( 13,'Theo', 'Mitchelson', '', '', '1822 University Blvd South', '', 'Jacksonville', 'FL', '32216-8931', '904-724-5401', 'FL-A181337' ), 
( 14,'Michael', 'Nickas', 'ChFC®, CLU®', 'Michael Nickas Ins Agcy Inc', '10920 Baymeadows Road', 'Suite 7', 'Jacksonville', 'FL', '32256-4571', '904-777-6888', '' ), 
( 15,'Beth', 'Arnold', '', 'Beth Arnold Ins Agcy Inc', '8130 Baymeadows Circle W.', 'Suite 106', 'Jacksonville', 'FL', '32256-1812', '904-733-0253', '' ), 
( 16,'Bob', 'Gibbs', '', '', '5495 Ft Caroline Road', '', 'Jacksonville', 'FL', '32277-1777', '904-744-2702', 'FL-A096369' ), 
( 17,'Yuleen', 'Broome', '', 'Yuleen Broome Ins Agcy Inc', '3120 Atlantic Blvd', '', 'Jacksonville', 'FL', '32207-8814', '904-398-0401', '' ), 
( 18,'Debra', 'Braddock', 'CLU®, LUTCF', 'Braddock Insurance Agcy Inc', '9310 Old Kings Rd S', 'Suite 1901', 'Jacksonville', 'FL', '32257-8101', '904-727-0829', '' ), 
( 19,'Chris', 'Frank', '', '', '9475 Philips Highway', 'Suite 15', 'Jacksonville', 'FL', '32256-1346', '904-900-1727', 'FL-P071445' ), 
( 20,'Matt', 'Carlucci', '', 'Matthew F Carlucci Ins Agy Inc', '3707 Hendricks Avenue', '', 'Jacksonville', 'FL', '32207-5311', '904-399-5544', '' ), 
( 21,'Kathy', 'Scott', 'CLU®', 'Kathy Scott Insurance Agcy Inc', '6018 San Jose Blvd', '', 'Jacksonville', 'FL', '32217-2325', '904-730-3665', '' ), 
( 22,'Chris', 'Bedford', '', '', '3943 Baymeadows Road', 'Suite 1', 'Jacksonville', 'FL', '32217-4636', '904-730-4300', 'FL-A017578' ), 
( 23,'Lance', 'Atwood', '', '', '11035 Philips Highway', 'Suite 6', 'Jacksonville', 'FL', '32256-1596', '904-240-4958', 'FL-P218284' ), 
( 24,'Edie', 'Williams', 'CPCU®', 'Edie Williams Ins Agcy Inc', '2325 Park St', '', 'Jacksonville', 'FL', '32204', '904-425-4054', '' ), 
( 25,'David', 'Beam', '', '', '10400 San Jose Blvd', 'Suite 2', 'Jacksonville', 'FL', '32257-6360', '904-379-4156', 'FL-W041913' ) 

