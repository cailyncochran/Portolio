--A7
--Cailyn Cochran
--CIS 310-01
--DUE DATE: 10/23/2017

--65
select BOOK_TITLE, BOOK_COST, BOOK_YEAR
from   BOOK

--66
select PAT_FNAME, PAT_LNAME
from   PATRON

--67
select CHECK_NUM, CHECK_OUT_DATE, CHECK_DUE_DATE
from   CHECKOUT

--68
select BOOK_NUM, BOOK_TITLE AS TITLE, BOOK_YEAR AS 'Year Published'
from   BOOK

--69
select distinct BOOK_YEAR
from            BOOK

--70
select distinct BOOK_SUBJECT
from            BOOK

--71
select BOOK_NUM, BOOK_TITLE, BOOK_COST AS 'Replacement Cost'
from   BOOK

--72
select   CHECK_NUM, BOOK_NUM, PAT_ID, CHECK_OUT_DATE, CHECK_DUE_DATE
from     CHECKOUT
order by CHECK_OUT_DATE desc

--73
select BOOK_TITLE, BOOK_YEAR, BOOK_SUBJECT
from BOOK
order by BOOK_SUBJECT asc, BOOK_YEAR desc, BOOK_TITLE asc

--74
select BOOK_NUM, BOOK_TITLE, BOOK_YEAR
from   BOOK
where  BOOK_YEAR = 2012

--75
select BOOK_NUM, BOOK_TITLE, BOOK_YEAR
from   BOOK
where  BOOK_SUBJECT = 'DATABASE'

--76
select CHECK_NUM, BOOK_NUM, CHECK_OUT_DATE
from   CHECKOUT
where  CHECK_OUT_DATE < '04/05/2015'

--77
select BOOK_NUM, BOOK_TITLE, BOOK_YEAR
from   BOOK
where  BOOK_YEAR > 2013 AND
       BOOK_SUBJECT = 'Programming'

--78
select BOOK_NUM, BOOK_TITLE, BOOK_YEAR, BOOK_SUBJECT, BOOK_COST
from   BOOK
where (BOOK_SUBJECT = 'Middleware' OR
       BOOK_SUBJECT = 'Cloud'
	  )                            AND
	   BOOK_COST > 70

--79
select AU_ID, AU_FNAME, AU_LNAME, AU_BIRTHYEAR
from   AUTHOR
where  AU_BIRTHYEAR >= 1980 AND
       AU_BIRTHYEAR < 1990

--80
select BOOK_NUM, BOOK_TITLE, BOOK_YEAR
from   BOOK
where  BOOK_TITLE like ('%database%')

--81
select PAT_ID, PAT_FNAME, PAT_LNAME
from   PATRON
where  PAT_TYPE = 'STUDENT'

--82
select PAT_ID, PAT_FNAME, PAT_LNAME, PAT_TYPE
from   PATRON
where  PAT_LNAME like 'c%'

--83
select AU_ID, AU_FNAME, AU_LNAME
from   AUTHOR
where  AU_BIRTHYEAR is NULL

--84
select AU_ID, AU_FNAME, AU_LNAME
from   AUTHOR
where  AU_BIRTHYEAR is NOT NULL

--85
select   CHECK_NUM, BOOK_NUM, PAT_ID, CHECK_OUT_DATE, CHECK_DUE_DATE
from     CHECKOUT
where    CHECK_IN_DATE is NULL
order by BOOK_NUM

--86
select AU_ID, AU_FNAME, AU_LNAME, AU_BIRTHYEAR
from AUTHOR
order by AU_BIRTHYEAR desc, AU_LNAME asc

--87
select count(BOOK_NUM) as 'Number of Books'
from         BOOK

--88
select count(distinct BOOK_SUBJECT) as 'Number of Subjects'
from                  BOOK

--89
select count(BOOK_NUM) as 'Available Books'
from         BOOK
where        PAT_ID is NULL

--90
select MAX(BOOK_COST) as 'Most Expensive' 
from       BOOK

--91
select MIN(BOOK_COST) as 'Least Expensive'
from       BOOK

--92
select count(distinct PAT_ID) as 'Different Patrons'
from CHECKOUT

--93
select   BOOK_SUBJECT, count(BOOK_TITLE) as 'Books in Subject'
from     BOOK
group by BOOK_SUBJECT
order by 'Books in Subject' desc, BOOK_SUBJECT asc

--94
select   AU_ID, count(BOOK_NUM) as 'Books Written'
from     WRITES 
group by AU_ID
order by 'Books Written' desc, AU_ID asc

--95
select SUM(BOOK_COST) as 'Library Value'
from       BOOK
