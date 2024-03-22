use store;

select * from products
where product_id not in 
(select DISTINCT product_id from order_items
);

use sql_invoicing;

select * from clients
where client_id not in(
select client_id from invoices
);