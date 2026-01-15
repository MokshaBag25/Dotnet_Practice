use mokshini13012026;

-- Add the new column
ALTER TABLE Students
ADD Marks DECIMAL(5, 2); 
GO
 
-- Populate the data with random marks between 50 and 100 for existing students
UPDATE Students
SET Marks = ABS(CHECKSUM(NEWID()) % 50) + 51;

select * from Students;