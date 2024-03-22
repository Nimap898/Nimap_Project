use sql_hr;

select AVG(salary)as avg_salary from employees;

Select employee_id,Concat(first_name,' ',last_name)as fullname,salary 
from employees 
where salary >(select AVG(salary)as avg_salary from employees);


