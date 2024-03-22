use store;

select * from products
where product_id In(
Select product_id from order_items
where quantity = 1)


