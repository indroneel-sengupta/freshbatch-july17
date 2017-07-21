db.emp.insert(  
    {_id:7369,ename:'SMITH',job:'CLERK',mgr:7902 ,hiredate: '17-DEC-00',sal:800, comm:null,deptno:20})
db.emp.insert(    {_id:7499, ename:'ALLEN', job:'SALESMAN', mgr:7698,hiredate:'20-FEB-01',sal:1600,comm:300, deptno:30})
db.emp.insert(    {_id:7521, ename:'WARD', job:'SALESMAN', mgr:7698, hiredate:'22-FEB-01', sal:1250, comm:500, deptno:30})
db.emp.insert(    {_id:7566, ename:'JONES', job:'MANAGER', mgr:7839, hiredate:'02-APR-01', sal:2975, comm:null, deptno:20})
db.emp.insert(    {_id:7654, ename:'MARTIN', job:'SALESMAN',mgr:7698, hiredate:'28-SEP-01', sal:1250, comm:1400, deptno:30})
db.emp.insert(    {_id:7782, ename:'CLARK', job:'MANAGER', mgr:7839, hiredate:'09-JUN-01', sal:2450, comm:null, deptno:10})
db.emp.insert(    {_id:7788, ename:'SCOTT', job:'ANALYST', mgr:7566, hiredate:'19-APR-07', sal:3000, comm:null, deptno:20})
db.emp.insert(    {_id:7839, ename:'KING', job:'PRESIDENT', mgr:null, hiredate:'17-NOV-01', sal:5000, comm:null, deptno:10})
db.emp.insert(    {_id:7844, ename:'TURNER', job:'SALESMAN',mgr:7698, hiredate:'08-SEP-01', sal:1500, comm:0, deptno:30})
db.emp.insert(    {_id:7876, ename:'ADAMS', job:'CLERK', mgr:7788, hiredate:'23-MAY-07', sal:1100, comm:null, deptno:20})
db.emp.insert(    {_id:7900, ename:'JAMES', job:'CLERK', mgr:7698, hiredate:'03-DEC-01', sal:950, comm:null, deptno:30})
db.emp.insert(    {_id:7902, ename:'FORD', job:'ANALYST', mgr:7566, hiredate:'03-DEC-01', sal:3000, comm:null,deptno:20})
db.emp.insert(    {_id:7934, ename:'MILLER', job:'CLERK', mgr:7782, hiredate:'23-JAN-02', sal:1300, comm:null, deptno:10})

db.emp.find()

db.emp.find( { "deptno":30 } )

db.emp.find({"job":'CLERK'},{"ename":1,"deptno":1});

db.emp.find({"deptno":{$lt:21}},{"ename":1,"deptno":1});

db.emp.find("this.comm>this.sal*0.5",{"ename":1,"deptno":1,"job":1});

db.emp.find({$and: [
         {"sal":{$gte:2000}} , {"job":{$ne:'CLERK'}},{"job":{$ne:'MANAGER'}}
      ]},{"ename":1,"deptno":1,"sal":1 , "job":1});

db.emp.find({$and: [
         {"sal":{$gte:2000}} , {"job":{$ne:'CLERK'}},{"job":{$ne:'MANAGER'}}
      ]},{"ename":1,"deptno":1,"sal":1 , "job":1});
  
db.emp.find({$and: [
         {"sal":{$gte:1200}} , {"sal":{$lte:1400}}
      ]},{"ename":1,"deptno":1,"sal":1 , "job":1});
      
db.emp.find({$and: [
          {"job":{$ne:'CLERK'}},{"job":{$ne:'ANALYST'}},{"job":{$ne:'SALESMAN'}}
      ]},{"ename":1,"deptno":1,"sal":1 , "job":1});     
      
db.emp.find({$or: [
          {"comm":null}, {"comm":0} 
      ]},
      {"ename":1,"deptno":1,"sal":1 , "job":1,"comm":1}); 
      
db.emp.find(
           {"comm":{$gt:0}},
      {"ename":1,"deptno":1,"sal":1 , "job":1,"comm":1});
      
      
db.emp.find({$or: [
          {"comm":null}, {"comm":0} , {"comm":{$lt:100}} 
      ]},
      {"ename":1,"deptno":1,"sal":1 , "job":1,"comm":1}); 
 
 db.emp.find(
           {"ename":{$regex:/^.{2}R/}},
      {"ename":1,"deptno":1,"sal":1 , "job":1,"comm":1});
    