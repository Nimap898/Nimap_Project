
select * from invoices
where invoice_total > (
select invoice_total from invoices
where invoice_id =3);