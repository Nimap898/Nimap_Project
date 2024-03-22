use store;

--using Subquery
select * from order_items
where product_id =
(
select product_id from products
where product_id = 3
);

--using Joins
select * from order_items o
join products p On 
 o.product_id = p.product_id
 where o.product_id =3;