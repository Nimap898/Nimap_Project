select *  from customers
where customer_id In
 (
 select o.customer_id from orders o
 join order_items oi on 
    o.order_id  = oi.order_id
	where product_id = 3
)