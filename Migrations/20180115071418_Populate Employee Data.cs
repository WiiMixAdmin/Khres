using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Khres.Migrations
{
    public partial class PopulateEmployeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Positions Table
            migrationBuilder.Sql("INSERT INTO Positions(Title) VALUES('Graphic Designer')");
            migrationBuilder.Sql("INSERT INTO Positions(Title) VALUES('Software Engineer')");
            migrationBuilder.Sql("INSERT INTO Positions(Title) VALUES('Database Administrator')");
            migrationBuilder.Sql("INSERT INTO Positions(Title) VALUES('Software Consultant')");
            migrationBuilder.Sql("INSERT INTO Positions(Title) VALUES('Senior Developer')");
            migrationBuilder.Sql("INSERT INTO Positions(Title) VALUES('Information Systems Manager')");
            migrationBuilder.Sql("INSERT INTO Positions(Title) VALUES('Chief Design Engineer')");
            migrationBuilder.Sql("INSERT INTO Positions(Title) VALUES('Senior Sales Associate')");
            migrationBuilder.Sql("INSERT INTO Positions(Title) VALUES('Web Designer')");
            migrationBuilder.Sql("INSERT INTO Positions(Title) VALUES('Business Systems Development Analyst')");

            // Employees Table
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Ula', 'Rustedge', 'urustedge0@wiley.com', 'Female', (SELECT Id FROM Positions WHERE Title='Graphic Designer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Clerkclaude', 'Gammidge', 'cgammidge1@va.gov', 'Male', (SELECT Id FROM Positions WHERE Title='Graphic Designer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Nickolas', 'Lewtey', 'nlewtey2@blogs.com', 'Male', (SELECT Id FROM Positions WHERE Title='Graphic Designer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Sven', 'McNeil', 'smcneil3@icq.com', 'Male', (SELECT Id FROM Positions WHERE Title='Graphic Designer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Adrienne', 'Hynson', 'ahynson4@globo.com', 'Female', (SELECT Id FROM Positions WHERE Title='Graphic Designer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Gerome', 'Gulberg', 'ggulberg5@economist.com', 'Female', (SELECT Id FROM Positions WHERE Title='Graphic Designer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Murry', 'Haggleton', 'mhaggleton6@baidu.com', 'Female', (SELECT Id FROM Positions WHERE Title='Graphic Designer'))");

            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Kimberli', 'Waterman', 'kwaterman7@ning.com', 'Female', (SELECT Id FROM Positions WHERE Title='Software Engineer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Shepperd', 'Trymme', 'strymme8@google.nl', 'Male', (SELECT Id FROM Positions WHERE Title='Software Engineer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Sigismundo', 'MacTrusty', 'smactrusty9@google.co.uk', 'Male', (SELECT Id FROM Positions WHERE Title='Software Engineer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Marja', 'Donaghie', 'mdonaghiea@liveinternet.ru', 'Male', (SELECT Id FROM Positions WHERE Title='Software Engineer'))");

            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Moll', 'Boutell', 'mboutellb@printfriendly.com', 'Female', (SELECT Id FROM Positions WHERE Title='Database Administrator'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Archibold', 'Szymonwicz', 'aszymonwiczc@mashable.com', 'Male', (SELECT Id FROM Positions WHERE Title='Database Administrator'))");

            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Vic', 'Fillimore', 'vfillimored@europa.eu', 'Male', (SELECT Id FROM Positions WHERE Title='Software Consultant'))");

            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Audy', 'Scherer', 'ascherere@mediafire.com', 'Male', (SELECT Id FROM Positions WHERE Title='Senior Developer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Calvin', 'Fraschetti', 'cfraschettif@constantcontact.com', 'Female', (SELECT Id FROM Positions WHERE Title='Senior Developer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Kaye', 'Norman', 'knormang@youku.com', 'Female', (SELECT Id FROM Positions WHERE Title='Senior Developer'))");

            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Gaylord', 'Hrishchenko', 'ghrishchenkoh@nba.com', 'Female', (SELECT Id FROM Positions WHERE Title='Information Systems Manager'))");

            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Sansone', 'Steljes', 'ssteljesi@apache.org', 'Male', (SELECT Id FROM Positions WHERE Title='Chief Design Engineer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Rosene', 'Jelphs', 'rjelphsj@google.cn', 'Female', (SELECT Id FROM Positions WHERE Title='Chief Design Engineer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Julie', 'Licas', 'jlicask@webs.com', 'Female', (SELECT Id FROM Positions WHERE Title='Chief Design Engineer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Kennith', 'Neesam', 'kneesaml@prnewswire.com', 'Female', (SELECT Id FROM Positions WHERE Title='Chief Design Engineer'))");

            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Vernon', 'Brugden', 'vbrugdenm@mapquest.com', 'Male', (SELECT Id FROM Positions WHERE Title='Senior Sales Associate'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Pippo', 'Sully', 'psullyn@cyberchimps.com', 'Male', (SELECT Id FROM Positions WHERE Title='Senior Sales Associate'))");

            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Coralyn', 'Speek', 'cspeeko@hugedomains.com', 'Female', (SELECT Id FROM Positions WHERE Title='Web Designer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Jeffy', 'Roose', 'jroosep@symantec.com', 'Male', (SELECT Id FROM Positions WHERE Title='Web Designer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Abeu', 'Shitliffe', 'ashitliffeq@cyberchimps.com', 'Male', (SELECT Id FROM Positions WHERE Title='Web Designer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Wanda', 'Lankester', 'wlankesterr@naver.com', 'Male', (SELECT Id FROM Positions WHERE Title='Web Designer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Craggie', 'Ledwitch', 'cledwitchs@digg.com', 'Female', (SELECT Id FROM Positions WHERE Title='Web Designer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Arnie', 'Bernath', 'abernatht@bluehost.com', 'Female', (SELECT Id FROM Positions WHERE Title='Web Designer'))");
            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Tandy', 'Mennithorp', 'tmennithorpu@msn.com', 'Female', (SELECT Id FROM Positions WHERE Title='Web Designer'))");

            migrationBuilder.Sql("INSERT INTO Employees(FirstName, LastName, Email, Gender, PositionId) VALUES('Morena', 'Yanson', 'myansonv@dyndns.org', 'Female', (SELECT Id FROM Positions WHERE Title='Business Systems Development Analyst'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {      
            migrationBuilder.Sql("DELETE FROM Employees WHERE Email IN ('urustedge0@wiley.com', 'cgammidge1@va.gov', 'nlewtey2@blogs.com', 'smcneil3@icq.com', 'ahynson4@globo.com', 'ggulberg5@economist.com', 'mhaggleton6@baidu.com')");
            migrationBuilder.Sql("DELETE FROM Employees WHERE Email IN ('kwaterman7@ning.com', 'strymme8@google.nl', 'smactrusty9@google.co.uk', 'mdonaghiea@liveinternet.ru')");
            migrationBuilder.Sql("DELETE FROM Employees WHERE Email IN ('mboutellb@printfriendly.com', 'aszymonwiczc@mashable.com')");
            migrationBuilder.Sql("DELETE FROM Employees WHERE Email IN ('vfillimored@europa.eu')");
            migrationBuilder.Sql("DELETE FROM Employees WHERE Email IN ('ascherere@mediafire.com', 'cfraschettif@constantcontact.com', 'knormang@youku.com')");
            migrationBuilder.Sql("DELETE FROM Employees WHERE Email IN ('ghrishchenkoh@nba.com')");
            migrationBuilder.Sql("DELETE FROM Employees WHERE Email IN ('ssteljesi@apache.org', 'rjelphsj@google.cn', 'jlicask@webs.com', 'kneesaml@prnewswire.com')");
            migrationBuilder.Sql("DELETE FROM Employees WHERE Email IN ('vbrugdenm@mapquest.com', 'psullyn@cyberchimps.com')");
            migrationBuilder.Sql("DELETE FROM Employees WHERE Email IN ('cspeeko@hugedomains.com', 'jroosep@symantec.com', 'ashitliffeq@cyberchimps.com', 'wlankesterr@naver.com', 'cledwitchs@digg.com', 'abernatht@bluehost.com', 'tmennithorpu@msn.com')");
            migrationBuilder.Sql("DELETE FROM Employees WHERE Email IN ('myansonv@dyndns.org')");

            migrationBuilder.Sql("DELETE FROM Positions WHERE Title IN ('Graphic Designer', 'Software Engineer', 'Database Administrator', 'Software Consultant', 'Senior Developer')");
            migrationBuilder.Sql("DELETE FROM Positions WHERE Title IN ('Information Systems Manager', 'Chief Design Engineer', 'Senior Sales Associate', 'Web Designer', 'Business Systems Development Analyst')");
        }
    }
}
