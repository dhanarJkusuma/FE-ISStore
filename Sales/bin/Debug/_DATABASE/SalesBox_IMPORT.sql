BULK INSERT box_provinces
    FROM 'D:\Tugas Akhir\IMPORT\provinces.csv'
    WITH
    (
    FIRSTROW = 0,
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next 
    TABLOCK
    )
	
go

BULK INSERT box_regencies
    FROM 'D:\Tugas Akhir\IMPORT\regencies.csv'
    WITH
    (
    FIRSTROW = 0,
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next 
    TABLOCK
    )

go

BULK INSERT box_districts
    FROM 'D:\Tugas Akhir\IMPORT\districts.csv'
    WITH
    (
    FIRSTROW = 0,
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next 
    TABLOCK
    )
