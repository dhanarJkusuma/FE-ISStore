EXEC SP_NEW_GROUP 'Administrator'

go

INSERT INTO box_user (user_name,user_password,user_group) VALUES ('admin','TCqG3CmejUs=',1);

go

UPDATE box_role SET is_actived=1 WHERE group_id=1

go

INSERT INTO box_store (store_name,store_address,store_phone,increment_point) VALUES ('STORE NAME','STORE ADDRESS','+628','0');
INSERT INTO box_category (category_code,category_name) VALUES ('CTGOTHER','OTHER');
INSERT INTO box_unit (unit_code,unit_name) VALUES ('OTHER','OTHER')